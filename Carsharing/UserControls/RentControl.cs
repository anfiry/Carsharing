using Carsharing.Classes;
using Carsharing.Services;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Carsharing.UserControls
{
    public partial class RentControl : UserControl
    {
        private readonly Account _account;
        private int _selectedCarId = 0;
        private int _activeRentalId = 0;
        private int _pendingParkingId = 0;
        private DateTime _rentalStartTime;
        private decimal _pricePerMinute = 0;

        public RentControl()
        {
            InitializeComponent();
        }

        public RentControl(Account account) : this()
        {
            _account = account;

            timerProcessing.Interval = 2000;
            timerProcessing.Tick += timerProcessing_Tick;

            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Visible = false;
            labelchoose.Visible = true;

            LoadAvailableCars();
            LoadParkings();
            CheckActiveRental();
        }

        private void LoadAvailableCars()
        {
            try
            {
                using (var db = new DBService())
                {
                    var data = db.ExecuteQuery(@"
                        SELECT 
                            c.id_car,
                            c.state_number,
                            c.brand,
                            c.model,
                            cc.car_color_name AS color_name,
                            c.price_per_minute,
                            COALESCE(a.city || ', ' || a.street || ', ' || a.house, 'Парковка не указана') AS address
                        FROM Car c
                        LEFT JOIN Car_color cc ON c.car_color_id = cc.id_car_color
                        LEFT JOIN Parking p ON c.current_parking_id = p.id_parking
                        LEFT JOIN Address a ON p.address_id = a.id_address
                        WHERE c.car_status_id = 1
                        ORDER BY c.price_per_minute
                    ");

                    dgvCars.DataSource = data;
                    SetupCarsGrid(dgvCars);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки машин: {ex.Message}");
            }
        }

        private void SetupCarsGrid(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgv.Columns.Contains("id_car"))
                dgv.Columns["id_car"].Visible = false;

            if (dgv.Columns.Contains("state_number"))
                dgv.Columns["state_number"].HeaderText = "Госномер";
            if (dgv.Columns.Contains("brand"))
                dgv.Columns["brand"].HeaderText = "Марка";
            if (dgv.Columns.Contains("model"))
                dgv.Columns["model"].HeaderText = "Модель";
            if (dgv.Columns.Contains("color_name"))
                dgv.Columns["color_name"].HeaderText = "Цвет";
            if (dgv.Columns.Contains("price_per_minute"))
                dgv.Columns["price_per_minute"].HeaderText = "Цена/мин";
            if (dgv.Columns.Contains("address"))
                dgv.Columns["address"].HeaderText = "Адрес";
        }

        private void LoadParkings()
        {
            try
            {
                using (var db = new DBService())
                {
                    var parkings = db.ExecuteQuery(@"
                        SELECT p.id_parking, 
                               COALESCE(a.city || ', ' || a.street || ', ' || a.house, 'Парковка не указана') AS address
                        FROM parking p
                        JOIN address a ON p.address_id = a.id_address
                        ORDER BY address
                    ");

                    listParkings.Items.Clear();
                    foreach (DataRow row in parkings.Rows)
                    {
                        listParkings.Items.Add(row["address"].ToString());
                    }

                    DataTable dt = parkings.Clone();
                    DataRow newRow = dt.NewRow();
                    newRow["id_parking"] = -1;
                    newRow["address"] = "Нет нужной парковки";
                    dt.Rows.Add(newRow);
                    foreach (DataRow row in parkings.Rows)
                    {
                        dt.ImportRow(row);
                    }

                    cmbParking.DisplayMember = "address";
                    cmbParking.ValueMember = "id_parking";
                    cmbParking.DataSource = dt;
                    cmbParking.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки парковок: {ex.Message}");
            }
        }

        private void CheckActiveRental()
        {
            try
            {
                int clientId = GetClientId();
                var rental = new Rental();
                var activeRental = rental.GetActiveRentalByClient(clientId);

                if (activeRental != null && activeRental.Rows.Count > 0)
                {
                    var row = activeRental.Rows[0];
                    _activeRentalId = Convert.ToInt32(row["id_rental"]);
                    _rentalStartTime = Convert.ToDateTime(row["start_time"]);
                    _pricePerMinute = Convert.ToDecimal(row["price_per_minute"]);

                    string carName = row["car_info"].ToString();
                    string stateNumber = row["state_number"].ToString();

                    lblActiveRental.Text = $"Активная аренда: {carName} ({stateNumber})";
                    lblStartTime.Text = $"Начало: {_rentalStartTime:dd.MM.yyyy HH:mm}";

                    btnAction.Text = "Завершить аренду";
                    btnAction.Enabled = true;
                    dgvCars.Visible = false;
                    labelchoose.Visible = false;
                    btnAction.BackColor = System.Drawing.Color.LightCoral;

                    listParkings.Visible = true;
                    lblParkings.Visible = true;
                    cmbParking.Visible = true;
                    lblParking.Visible = true;
                    cmbParking.Enabled = true;
                    lblStartTime.Visible = true;
                    lblCurrentCost.Visible = true;

                    timerCost.Enabled = true;
                    timerCost.Interval = 60000;
                    UpdateCurrentCost();
                }
                else
                {
                    lblActiveRental.Text = "Нет активной аренды";
                    btnAction.Text = "Начать аренду";
                    btnAction.Enabled = false;
                    _activeRentalId = 0;

                    labelchoose.Visible = true;
                    dgvCars.Visible = true;
                    dgvCars.Enabled = true;
                    btnAction.BackColor = System.Drawing.Color.LightGreen;

                    listParkings.Visible = false;
                    lblParkings.Visible = false;
                    cmbParking.Visible = false;
                    lblParking.Visible = false;
                    cmbParking.Enabled = false;
                    lblStartTime.Visible = false;
                    lblCurrentCost.Visible = false;
                    timerCost.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка проверки аренды: {ex.Message}");
            }
        }

        private void UpdateCurrentCost()
        {
            if (_activeRentalId > 0)
            {
                TimeSpan elapsed = DateTime.Now - _rentalStartTime;
                int seconds = (int)elapsed.TotalSeconds;  

                decimal pricePerSecond = _pricePerMinute / 60;  
                decimal cost = seconds * pricePerSecond;    

                decimal roundedCost = Math.Round(cost, 0, MidpointRounding.AwayFromZero); 

                lblCurrentCost.Text = $"Текущая стоимость: {roundedCost:F0} ₽";
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
            catch { }
            return 0;
        }

        private void dgvCars_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count > 0 && _activeRentalId == 0)
            {
                _selectedCarId = Convert.ToInt32(dgvCars.SelectedRows[0].Cells["id_car"].Value);
                btnAction.Enabled = true;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (_activeRentalId == 0)
                StartRental();
            else
                EndRental();
        }

        private bool IsCardValid(string cardNumber, string expiry, string cvv)
        {
            string cleanNumber = cardNumber.Replace(" ", "").Replace("-", "");
            if (cleanNumber.Length != 16 || !long.TryParse(cleanNumber, out _))
                return false;

            if (expiry.Length != 5 || !expiry.Contains("/"))
                return false;

            string[] parts = expiry.Split('/');
            if (parts.Length != 2 || parts[0].Length != 2 || parts[1].Length != 2)
                return false;

            if (!int.TryParse(parts[0], out int month) || !int.TryParse(parts[1], out int year))
                return false;

            if (month < 1 || month > 12)
                return false;

            int currentYear = DateTime.Now.Year % 100;
            int currentMonth = DateTime.Now.Month;
            if (year < currentYear || (year == currentMonth && month < currentMonth))
                return false;

            if (cvv.Length != 3 || !int.TryParse(cvv, out _))
                return false;

            return true;
        }

        private void StartRental()
        {
            if (_selectedCarId == 0)
            {
                MessageBox.Show("Выберите машину!", "Ошибка");
                return;
            }

            try
            {
                int clientId = GetClientId();
                if (clientId == 0)
                {
                    MessageBox.Show("Клиент не найден!", "Ошибка");
                    return;
                }

                var blocklist = new Blocklist();
                if (blocklist.IsClientBlocked(clientId))
                {
                    MessageBox.Show("Вы заблокированы! Аренда невозможна.", "Доступ запрещён");
                    return;
                }

                var card = new Card();
                var cards = card.GetCardByClient(clientId);

                if (cards.Rows.Count == 0)
                {
                    MessageBox.Show("У вас не привязана карта!\nДобавьте карту в профиле.", "Ошибка");
                    return;
                }

                string cardNumber = cards.Rows[0]["card_number"].ToString();
                string expiry = cards.Rows[0]["expiry_date"].ToString();
                string cvv = cards.Rows[0]["cvv"].ToString();

                if (!IsCardValid(cardNumber, expiry, cvv))
                {
                    MessageBox.Show("Ваша карта недействительна!\nПроверьте данные карты в профиле.", "Ошибка");
                    return;
                }

                int parkingId = 0;
                using (var db = new DBService())
                {
                    var result = db.ExecuteQuery(
                        "SELECT current_parking_id FROM car WHERE id_car = @p_car_id",
                        new NpgsqlParameter("p_car_id", _selectedCarId)
                    );
                    if (result.Rows.Count > 0 && result.Rows[0][0] != DBNull.Value)
                        parkingId = Convert.ToInt32(result.Rows[0][0]);
                }

                if (parkingId == 0)
                {
                    MessageBox.Show("Машина не привязана к парковке!", "Ошибка");
                    return;
                }

                var rental = new Rental();
                rental.StartRental(clientId, _selectedCarId, parkingId);

                MessageBox.Show("Аренда начата!", "Успех");
                LoadAvailableCars();
                LoadParkings();
                CheckActiveRental();

                labelchoose.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void EndRental()
        {
            if (_activeRentalId == 0)
            {
                MessageBox.Show("Нет активной аренды!", "Ошибка");
                return;
            }

            if (cmbParking.SelectedItem == null)
            {
                MessageBox.Show("Выберите парковку для возврата!", "Ошибка");
                cmbParking.Focus();
                return;
            }

            if (Convert.ToInt32(cmbParking.SelectedValue) == -1)
            {
                MessageBox.Show("Встаньте на одной из разрешенных парковок!", "Ошибка");
                cmbParking.SelectedIndex = -1;
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

                int cardId = Convert.ToInt32(cards.Rows[0]["id_card"]);
                _pendingParkingId = (int)cmbParking.SelectedValue;

                btnAction.Enabled = false;
                btnAction.Text = "⏳ Обработка...";
                progressBar.Visible = true;

                timerProcessing.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                btnAction.Text = "Завершить аренду";
                btnAction.Enabled = true;
                progressBar.Visible = false;
            }
        }

        private void timerProcessing_Tick(object sender, EventArgs e)
        {
            timerProcessing.Stop();
            progressBar.Visible = false;
            btnAction.Text = "Завершить аренду";

            try
            {
                if (_activeRentalId == 0)
                {
                    btnAction.Enabled = true;
                    return;
                }

                int clientId = GetClientId();
                var card = new Card();
                var cards = card.GetCardByClient(clientId);

                if (cards.Rows.Count == 0)
                {
                    MessageBox.Show("У вас не привязана карта!\nДобавьте карту в профиле.", "Ошибка");
                    btnAction.Enabled = true;
                    return;
                }

                int cardId = Convert.ToInt32(cards.Rows[0]["id_card"]);

                var rentalService = new RentalService();
                decimal totalCost = rentalService.EndRental(_activeRentalId, _pendingParkingId, cardId);

                MessageBox.Show($"Аренда завершена!\n\nСтоимость: {totalCost:F0} ₽. Оплата прошла.", "Успех");

                _activeRentalId = 0;
                LoadAvailableCars();
                LoadParkings();
                CheckActiveRental();
                btnAction.Enabled = false;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (message.Contains("P0210") || message.Contains("не найдена") || message.Contains("уже завершена"))
                {
                    message = "Аренда уже завершена или не найдена.";
                }
                MessageBox.Show($"{message}", "Ошибка");
                btnAction.Enabled = true;
                progressBar.Visible = false;
                CheckActiveRental();
            }
        }

        private void timerCost_Tick(object sender, EventArgs e)
        {
            UpdateCurrentCost();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAvailableCars();
            LoadParkings();
            CheckActiveRental();
        }
    }
}