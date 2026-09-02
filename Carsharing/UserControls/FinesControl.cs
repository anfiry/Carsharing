using Carsharing.Classes;
using Carsharing.Services;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Carsharing.UserControls
{
    public partial class FinesControl : UserControl
    {
        private readonly Account _account;
        private int _pendingFineId = 0;
        private decimal _pendingAmount = 0;

        public FinesControl()
        {
            InitializeComponent();
        }

        public FinesControl(Account account) : this()
        {
            _account = account;

            cmbFilter.Items.Add("Все");
            cmbFilter.Items.Add("Неоплаченные");
            cmbFilter.Items.Add("Оплаченные");
            cmbFilter.SelectedIndex = 0;

            timerProcessing.Interval = 2000;
            timerProcessing.Tick += timerProcessing_Tick;

            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Visible = false;

            LoadFines();
        }

        private void LoadFines(string filter = "Все")
        {
            int clientId = GetClientId();
            var fine = new Fine();
            var data = fine.GetClientFines(clientId);

            if (filter == "Неоплаченные")
            {
                var filtered = data.Clone();
                foreach (DataRow row in data.Rows)
                {
                    if (row["status"].ToString() == "Не оплачен")
                    {
                        filtered.ImportRow(row);
                    }
                }
                data = filtered;
            }
            else if (filter == "Оплаченные")
            {
                var filtered = data.Clone();
                foreach (DataRow row in data.Rows)
                {
                    if (row["status"].ToString() == "Оплачен")
                    {
                        filtered.ImportRow(row);
                    }
                }
                data = filtered;
            }

            dgvFines.DataSource = data;
            SetupFinesGrid(dgvFines);

            btnPayFine.Enabled = false;
        }

        private int GetClientId()
        {
            using (var db = new DBService())
            {
                var result = db.ExecuteQuery(
                    "SELECT id_client FROM client WHERE account_id = @p_account_id",
                    new NpgsqlParameter("p_account_id", _account.Id)
                );
                if (result.Rows.Count > 0)
                    return Convert.ToInt32(result.Rows[0][0]);
            }
            return 0;
        }

        private void SetupFinesGrid(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgv.Columns.Contains("id_fine"))
                dgv.Columns["id_fine"].Visible = false;

            if (dgv.Columns.Contains("fine_type_name"))
                dgv.Columns["fine_type_name"].HeaderText = "Тип штрафа";
            if (dgv.Columns.Contains("amount"))
                dgv.Columns["amount"].HeaderText = "Сумма";
            if (dgv.Columns.Contains("description"))
                dgv.Columns["description"].HeaderText = "Описание";
            if (dgv.Columns.Contains("car_info"))
                dgv.Columns["car_info"].HeaderText = "Автомобиль";
            if (dgv.Columns.Contains("start_time"))
                dgv.Columns["start_time"].HeaderText = "Дата аренды";
            if (dgv.Columns.Contains("status"))
                dgv.Columns["status"].HeaderText = "Статус";

            btnPayFine.Enabled = false;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFines(cmbFilter.Text);
        }

        private void dgvFines_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFines.SelectedRows.Count > 0)
            {
                var row = dgvFines.SelectedRows[0];
                string status = row.Cells["status"].Value.ToString();

                btnPayFine.Enabled = (status == "Не оплачен");
            }
        }

        private void btnPayFine_Click(object sender, EventArgs e)
        {
            if (dgvFines.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите штраф!", "Ошибка");
                return;
            }

            var row = dgvFines.SelectedRows[0];
            _pendingFineId = Convert.ToInt32(row.Cells["id_fine"].Value);
            _pendingAmount = Convert.ToDecimal(row.Cells["amount"].Value);
            string status = row.Cells["status"].Value.ToString();

            if (status == "Оплачен")
            {
                MessageBox.Show("Штраф уже оплачен", "Информация");
                return;
            }

            try
            {
                int clientId = GetClientId();
                var card = new Card();
                var cards = card.GetCardByClient(clientId);

                if (cards.Rows.Count == 0)
                {
                    MessageBox.Show("У вас не привязана карта!\nДобавьте карту в профиле.", "Ошибка");
                    return;
                }

                btnPayFine.Enabled = false;
                btnPayFine.Text = "⏳ Обработка...";
                progressBar.Visible = true;
                timerProcessing.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Ошибка: {ex.Message}", "Ошибка");
                btnPayFine.Text = "Оплатить штраф";
                btnPayFine.Enabled = true;
                progressBar.Visible = false;
            }
        }

        private void timerProcessing_Tick(object sender, EventArgs e)
        {
            timerProcessing.Stop();
            progressBar.Visible = false;
            btnPayFine.Text = "Оплатить штраф";

            try
            {
                int clientId = GetClientId();
                var card = new Card();
                var cards = card.GetCardByClient(clientId);

                if (cards.Rows.Count == 0)
                {
                    MessageBox.Show("У вас не привязана карта!", "Ошибка");
                    btnPayFine.Enabled = true;
                    return;
                }

                int cardId = Convert.ToInt32(cards.Rows[0]["id_card"]);

                var fine = new Card();
                fine.PayFineWithCard(_pendingFineId, cardId);

                MessageBox.Show($"✅ Штраф {_pendingAmount:F2} ₽ оплачен!", "Успех");
                LoadFines(cmbFilter.Text);
                btnPayFine.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Ошибка: {ex.Message}", "Ошибка");
                btnPayFine.Enabled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadFines(cmbFilter.Text);
        }
    }
}