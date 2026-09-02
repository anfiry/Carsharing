using Carsharing.Classes;
using Carsharing.Services;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Carsharing.UserControls
{
    public partial class HomeControl : UserControl
    {
        private readonly Account _account;
        private Timer timerCost;

        public HomeControl()
        {
            InitializeComponent();
        }

        public HomeControl(Account account) : this()
        {
            _account = account;
            LoadData();

            timerCost = new Timer();
            timerCost.Interval = 60000;
            timerCost.Tick += TimerCost_Tick;
            timerCost.Start();
        }

        private void TimerCost_Tick(object sender, EventArgs e)
        {
            if (_account.RoleId == 1)
            {
                int clientId = GetClientId();
                if (clientId > 0)
                {
                    var rental = new Rental();
                    var activeRental = rental.GetActiveRentalByClient(clientId);
                    if (activeRental.Rows.Count > 0)
                    {
                        dgvRental.DataSource = null;
                        dgvRental.DataSource = activeRental;
                        SetupRentalGrid(dgvRental);
                    }
                }
            }
        }

        private void LoadData()
        {
            lblWelcome.Text = $"Добро пожаловать, {_account.Login}";

            if (_account.RoleId == 1)
            {
                LoadClientData();
            }
            else if (_account.RoleId == 2)
            {
                LoadOperatorData();
            }
        }

        private int GetClientId()
        {
            try
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка получения client_id: {ex.Message}", "Ошибка");
            }
            return 0;
        }

        private void LoadClientData()
        {
            try
            {
                int clientId = GetClientId();
                if (clientId == 0) return;

                lblFines.Visible = true;
                lblFines.ForeColor = System.Drawing.Color.Black;
                lblFines.BringToFront();

                var rental = new Rental();
                var activeRental = rental.GetActiveRentalByClient(clientId);

                if (activeRental.Rows.Count > 0)
                {
                    lblRentalInfo.Text = "Активная аренда:";
                    dgvRental.Visible = true;
                    dgvRental.DataSource = activeRental;
                    SetupRentalGrid(dgvRental);
                }
                else
                {
                    lblRentalInfo.Text = "Нет активной аренды";
                    dgvRental.Visible = false;
                    dgvRental.DataSource = null;
                }

                var fine = new Fine();
                var unpaidFines = fine.GetUnpaidFinesByClient(clientId);

                if (unpaidFines.Rows.Count > 0)
                {
                    lblFines.Text = "Неоплаченные штрафы:";
                    lblFines.Visible = true;
                    dgvFines.Visible = true;
                    dgvFines.DataSource = unpaidFines;
                    SetupFinesGrid(dgvFines);
                }
                else
                {
                    lblFines.Text = "Нет неоплаченных штрафов";
                    lblFines.Visible = true;
                    dgvFines.Visible = false;
                    dgvFines.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных клиента: {ex.Message}", "Ошибка");
            }
        }

        private void LoadOperatorData()
        {
            try
            {
                var rental = new Rental();
                var activeRentals = rental.GetActiveRentals();

                lblFines.Visible = false;
                dgvFines.Visible = false;

                if (activeRentals.Rows.Count > 0)
                {
                    lblRentalInfo.Text = "Активные аренды:";
                    dgvRental.Visible = true;
                    dgvRental.DataSource = activeRentals;
                    SetupOperatorRentalGrid(dgvRental);
                }
                else
                {
                    lblRentalInfo.Text = "Нет активных аренд";
                    dgvRental.Visible = false;
                    dgvRental.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных оператора: {ex.Message}", "Ошибка");
            }
        }

        private void SetupFinesGrid(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;

            if (dgv.Columns.Contains("id_fine"))
                dgv.Columns["id_fine"].Visible = false;

            if (dgv.Columns.Contains("start_time"))
                dgv.Columns["start_time"].HeaderText = "Дата аренды";
            if (dgv.Columns.Contains("car_info"))
                dgv.Columns["car_info"].HeaderText = "Автомобиль";
            if (dgv.Columns.Contains("fine_type_name"))
                dgv.Columns["fine_type_name"].HeaderText = "Тип штрафа";
            if (dgv.Columns.Contains("description"))
                dgv.Columns["description"].HeaderText = "Описание";
            if (dgv.Columns.Contains("status"))
                dgv.Columns["status"].HeaderText = "Статус";
            if (dgv.Columns.Contains("amount"))
                dgv.Columns["amount"].HeaderText = "Сумма";
        }

        private void SetupRentalGrid(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgv.Columns.Contains("id_rental"))
                dgv.Columns["id_rental"].Visible = false;
            if (dgv.Columns.Contains("client_id"))
                dgv.Columns["client_id"].Visible = false;
            if (dgv.Columns.Contains("car_id"))
                dgv.Columns["car_id"].Visible = false;
            if (dgv.Columns.Contains("rental_status_id"))
                dgv.Columns["rental_status_id"].Visible = false;
            if (dgv.Columns.Contains("start_parking_id"))
                dgv.Columns["start_parking_id"].Visible = false;
            if (dgv.Columns.Contains("end_parking_id"))
                dgv.Columns["end_parking_id"].Visible = false;
            if (dgv.Columns.Contains("id_client"))
                dgv.Columns["id_client"].Visible = false;
            if (dgv.Columns.Contains("last_name"))
                dgv.Columns["last_name"].Visible = false;
            if (dgv.Columns.Contains("first_name"))
                dgv.Columns["first_name"].Visible = false;
            if (dgv.Columns.Contains("brand"))
                dgv.Columns["brand"].Visible = false;
            if (dgv.Columns.Contains("model"))
                dgv.Columns["model"].Visible = false;
            if (dgv.Columns.Contains("price_per_minute"))
                dgv.Columns["price_per_minute"].Visible = false;
            if (dgv.Columns.Contains("end_time"))
                dgv.Columns["end_time"].Visible = false;
            if (dgv.Columns.Contains("total_cost"))
                dgv.Columns["total_cost"].Visible = false;
            if (dgv.Columns.Contains("end_address"))
                dgv.Columns["end_address"].Visible = false;
            if (dgv.Columns.Contains("minutes"))
                dgv.Columns["minutes"].Visible = false;
            if (dgv.Columns.Contains("rental_status_name"))
                dgv.Columns["rental_status_name"].Visible = false;

            if (dgv.Columns.Contains("car_name"))
                dgv.Columns["car_name"].HeaderText = "Автомобиль";
            if (dgv.Columns.Contains("state_number"))
                dgv.Columns["state_number"].HeaderText = "Госномер";
            if (dgv.Columns.Contains("start_time"))
                dgv.Columns["start_time"].HeaderText = "Время начала";
            if (dgv.Columns.Contains("start_address"))
                dgv.Columns["start_address"].HeaderText = "Парковка начала";
            if (dgv.Columns.Contains("current_cost"))
            {
                dgv.Columns["current_cost"].HeaderText = "Текущая стоимость";
                dgv.Columns["current_cost"].DefaultCellStyle.Format = "F2";
                dgv.Columns["current_cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void SetupOperatorRentalGrid(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;

            if (dgv.Columns.Contains("id_rental"))
                dgv.Columns["id_rental"].Visible = false;

            if (dgv.Columns.Contains("client_name"))
                dgv.Columns["client_name"].HeaderText = "Клиент";
            if (dgv.Columns.Contains("brand"))
                dgv.Columns["brand"].HeaderText = "Марка";
            if (dgv.Columns.Contains("model"))
                dgv.Columns["model"].HeaderText = "Модель";
            if (dgv.Columns.Contains("state_number"))
                dgv.Columns["state_number"].HeaderText = "Госномер";
            if (dgv.Columns.Contains("start_time"))
                dgv.Columns["start_time"].HeaderText = "Время начала";
            if (dgv.Columns.Contains("start_address"))
                dgv.Columns["start_address"].HeaderText = "Парковка";
        }
    }
}