using Carsharing.Classes;
using System;
using System.Data;
using System.Net;
using System.Windows.Forms;

namespace Carsharing.UserControls
{
    public partial class ManageFinesControl : UserControl
    {
        public ManageFinesControl()
        {
            InitializeComponent();
            LoadFines();
            LoadComboBoxes();
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClient.SelectedValue != null)
            {
                int clientId = (int)cmbClient.SelectedValue;
                LoadRentalsByClient(clientId);
            }
        }

        private void LoadFines(string filter = "Все")
        {
            var fine = new Fine();
            var allData = fine.GetAllFines();
            DataTable data;

            switch (filter)
            {
                case "Неоплаченные":
                    data = allData.Clone();
                    foreach (DataRow row in allData.Rows)
                    {
                        if (row["status"].ToString() == "Не оплачен")
                        {
                            data.ImportRow(row);
                        }
                    }
                    break;
                case "Оплаченные":
                    data = allData.Clone();
                    foreach (DataRow row in allData.Rows)
                    {
                        if (row["status"].ToString() == "Оплачен")
                        {
                            data.ImportRow(row);
                        }
                    }
                    break;
                default:
                    data = allData;
                    break;
            }

            dgvFines.DataSource = data;
            SetupFinesGrid(dgvFines);
        }

        private void LoadComboBoxes()
        {
            var client = new Client();
            var clients = client.GetAllClients();

            clients.Columns.Add("FullName", typeof(string));
            foreach (DataRow row in clients.Rows)
            {
                row["FullName"] = $"{row["last_name"]} {row["first_name"]}";
            }

            cmbClient.DisplayMember = "FullName";
            cmbClient.ValueMember = "id_client";
            cmbClient.DataSource = clients;
            cmbClient.SelectedIndex = -1;
            cmbClient.SelectedIndexChanged += cmbClient_SelectedIndexChanged; 

            var fine = new Fine();
            var types = fine.GetAllFineTypes();
            cmbFineType.DisplayMember = "fine_type_name";
            cmbFineType.ValueMember = "id_fine_type";
            cmbFineType.DataSource = types;

            cmbRental.DataSource = null;
        }

        private void LoadRentalsByClient(int clientId)
        {
            var rental = new Rental();
            var rentals = rental.GetClientRentals(clientId);

            rentals.Columns.Add("DisplayText", typeof(string));
            foreach (DataRow row in rentals.Rows)
            {
                string carInfo = row["car_info"].ToString();
                string stateNumber = row["state_number"].ToString();
                string startTime = Convert.ToDateTime(row["start_time"]).ToShortDateString();
                string status = row["rental_status_name"].ToString();

                string endTime = "";
                if (row["end_time"] != DBNull.Value)
                {
                    endTime = Convert.ToDateTime(row["end_time"]).ToShortDateString();
                }

                string displayText;
                if (status == "Активна")
                {
                    displayText = $"{carInfo} ({stateNumber}) {startTime} → Активна";
                }
                else
                {
                    displayText = $"{carInfo} ({stateNumber}) {startTime} → {endTime} [{status}]";
                }

                row["DisplayText"] = displayText;
            }

            cmbRental.DisplayMember = "DisplayText";
            cmbRental.ValueMember = "id_rental";
            cmbRental.DataSource = rentals;
            cmbRental.SelectedIndex = -1;
        }


        private void SetupFinesGrid(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgv.Columns.Contains("id_fine"))
                dgv.Columns["id_fine"].Visible = false;
            if (dgv.Columns.Contains("id_rental"))
                dgv.Columns["id_rental"].Visible = false;

            if (dgv.Columns.Contains("client_name"))
                dgv.Columns["client_name"].HeaderText = "Клиент";
            if (dgv.Columns.Contains("car_info"))
                dgv.Columns["car_info"].HeaderText = "Автомобиль";
            if (dgv.Columns.Contains("fine_type_name"))
                dgv.Columns["fine_type_name"].HeaderText = "Тип штрафа";
            if (dgv.Columns.Contains("amount"))
                dgv.Columns["amount"].HeaderText = "Сумма";
            if (dgv.Columns.Contains("description"))
                dgv.Columns["description"].HeaderText = "Описание";
            if (dgv.Columns.Contains("status"))
                dgv.Columns["status"].HeaderText = "Статус";
            if (dgv.Columns.Contains("start_time"))
                dgv.Columns["start_time"].HeaderText = "Время начала аренды";
        }


        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFines(cmbFilter.Text);
        }

        private void btnAddFine_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRental.SelectedValue == null)
                {
                    MessageBox.Show("Выберите аренду!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string amountText = txtAmount.Text.Trim();
                if (string.IsNullOrWhiteSpace(amountText))
                {
                    MessageBox.Show("Введите сумму штрафа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmount.Focus();
                    return;
                }

                amountText = amountText.Replace(",", ".");

                foreach (char c in amountText)
                {
                    if (!char.IsDigit(c) && c != '.')
                    {
                        MessageBox.Show("Сумма должна содержать только цифры и десятичную точку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAmount.Focus();
                        txtAmount.SelectAll();
                        return;
                    }
                }

                if (!decimal.TryParse(amountText, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal amount))
                {
                    MessageBox.Show("Введите корректную сумму!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmount.Focus();
                    txtAmount.SelectAll();
                    return;
                }

                if (amount <= 0)
                {
                    MessageBox.Show("Сумма должна быть больше 0!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmount.Focus();
                    txtAmount.SelectAll();
                    return;
                }

                if (amount > 1000000)
                {
                    MessageBox.Show("Сумма штрафа не может превышать 1 000 000 ₽!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmount.Focus();
                    txtAmount.SelectAll();
                    return;
                }

                int rentalId = (int)cmbRental.SelectedValue;

                var rental = new Rental();
                var rentalData = rental.GetRentalStatus(rentalId);

                if (rentalData.Rows.Count > 0)
                {
                    string status = rentalData.Rows[0]["rental_status_name"].ToString();

                    if (status == "Активна")
                    {
                        MessageBox.Show("Штраф можно выставить только после завершения аренды.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                var fine = new Fine();
                fine.AddFine(
                    rentalId,
                    (int)cmbFineType.SelectedValue,
                    amount,
                    txtDescription.Text
                );

                MessageBox.Show("Штраф успешно назначен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadFines(cmbFilter.Text);
                ClearAddFineFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadFines(cmbFilter.Text);
            LoadComboBoxes();
        }


        private void ClearAddFineFields()
        {
            txtAmount.Clear();
            txtDescription.Clear();
            cmbRental.SelectedIndex = -1;
        }
    }
}