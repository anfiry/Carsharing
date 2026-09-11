using Carsharing.Classes;
using Carsharing.Services;
using Npgsql;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Carsharing.UserControls
{
    public partial class ManageCarsControl : UserControl
    {
        private int _selectedCarId = 0;
        private bool _isAddingNew = false;

        public ManageCarsControl()
        {
            InitializeComponent();

            nudYear.Minimum = 2000;
            nudYear.Maximum = DateTime.Now.Year;
            nudYear.Value = 2000;

            nudPrice.Minimum = 1;
            nudPrice.Maximum = 1000;
            nudPrice.Value = 1;
            nudPrice.DecimalPlaces = 2;

            cmbBrand.SelectedIndexChanged += cmbBrand_SelectedIndexChanged;
            dgvCars.CellClick += dgvCars_CellClick;
            dgvCars.SelectionChanged += dgvCars_SelectionChanged;

            LoadBrands();
            LoadModels();
            LoadComboBoxes();
            ClearFields();
            LoadCars();

            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }
        
        private void EnableSaveIfEditing(object sender, EventArgs e)
        {
            if (_selectedCarId > 0 && !_isAddingNew)
                btnSave.Enabled = true;
        }

        private void LoadBrands()
        {
            try
            {
                var car = new Car();
                var brands = car.GetAllBrands();
                cmbBrand.DisplayMember = "brand";
                cmbBrand.ValueMember = "brand";
                cmbBrand.DataSource = brands;
                cmbBrand.DropDownStyle = ComboBoxStyle.DropDown;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки брендов: {ex.Message}");
            }
        }

        private void LoadModels(string brand = null)
        {
            try
            {
                var car = new Car();
                DataTable models;

                if (string.IsNullOrWhiteSpace(brand))
                {
                    models = car.GetAllModels();
                }
                else
                {
                    models = car.GetModelsByBrand(brand);
                }

                cmbModel.DisplayMember = "model";
                cmbModel.ValueMember = "model";
                cmbModel.DataSource = models;
                cmbModel.DropDownStyle = ComboBoxStyle.DropDown;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки моделей: {ex.Message}");
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                var car = new Car();

                var fuels = car.GetAllFuelTypes();
                cmbFuelType.DisplayMember = "fuel_type_name";
                cmbFuelType.ValueMember = "id_fuel_type";
                cmbFuelType.DataSource = fuels;
                cmbFuelType.DropDownStyle = ComboBoxStyle.DropDownList;

                var colors = car.GetAllColors();
                cmbColor.DisplayMember = "car_color_name";
                cmbColor.ValueMember = "id_car_color";
                cmbColor.DataSource = colors;
                cmbColor.DropDownStyle = ComboBoxStyle.DropDown;

                var parking = new Parking();
                var parkings = parking.GetAllParkings();
                cmbParking.DisplayMember = "address";
                cmbParking.ValueMember = "id_parking";
                cmbParking.DataSource = parkings;
                cmbParking.DropDownStyle = ComboBoxStyle.DropDown;

                var statuses = car.GetAllStatuses();
                cmbStatus.DisplayMember = "car_status_name";
                cmbStatus.ValueMember = "id_car_status";
                cmbStatus.DataSource = statuses;
                cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки списков: {ex.Message}");
            }
        }

        private void LoadCars()
        {
            try
            {
                var car = new Car();
                var data = car.GetAllCars();
                dgvCars.DataSource = null;
                dgvCars.DataSource = data;
                SetupCarsGrid(dgvCars);
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
                dgv.Columns["brand"].HeaderText = "Бренд";
            if (dgv.Columns.Contains("model"))
                dgv.Columns["model"].HeaderText = "Модель";
            if (dgv.Columns.Contains("car_year"))
                dgv.Columns["car_year"].HeaderText = "Год";
            if (dgv.Columns.Contains("price_per_minute"))
                dgv.Columns["price_per_minute"].HeaderText = "Цена/мин";
            if (dgv.Columns.Contains("car_status_name"))
                dgv.Columns["car_status_name"].HeaderText = "Статус";
            if (dgv.Columns.Contains("car_color_name"))
                dgv.Columns["car_color_name"].HeaderText = "Цвет";
            if (dgv.Columns.Contains("fuel_type_name"))
                dgv.Columns["fuel_type_name"].HeaderText = "Топливо";
            if (dgv.Columns.Contains("address"))
                dgv.Columns["address"].HeaderText = "Текущая парковка";
        }

        private void SelectCarById(int carId)
        {
            try
            {
                foreach (DataGridViewRow row in dgvCars.Rows)
                {
                    if (row.Cells["id_car"].Value != DBNull.Value &&
                        Convert.ToInt32(row.Cells["id_car"].Value) == carId)
                    {
                        dgvCars.ClearSelection();
                        row.Selected = true;
                        dgvCars.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
            catch { }
        }

        private void FillFields(DataGridViewRow row)
        {
            if (row == null) return;

            _selectedCarId = Convert.ToInt32(row.Cells["id_car"].Value);

            txtStateNumber.Text = row.Cells["state_number"].Value.ToString();
            cmbBrand.Text = row.Cells["brand"].Value.ToString();
            LoadModels(cmbBrand.Text);
            cmbModel.Text = row.Cells["model"].Value.ToString();
            nudYear.Value = Convert.ToDecimal(row.Cells["car_year"].Value);
            nudPrice.Value = Convert.ToDecimal(row.Cells["price_per_minute"].Value);

            cmbFuelType.Text = row.Cells["fuel_type_name"].Value.ToString();
            cmbColor.Text = row.Cells["car_color_name"].Value.ToString();
            cmbStatus.Text = row.Cells["car_status_name"].Value.ToString();

            if (row.Cells["address"].Value != DBNull.Value)
                cmbParking.Text = row.Cells["address"].Value.ToString();
            else
                cmbParking.SelectedIndex = -1;

            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
            _isAddingNew = false;
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBrand.SelectedValue != null && !string.IsNullOrWhiteSpace(cmbBrand.Text))
            {
                LoadModels(cmbBrand.Text);
            }
            else
            {
                LoadModels();
            }
        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvCars.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dgvCars_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count > 0 && !_isAddingNew)
            {
                FillFields(dgvCars.SelectedRows[0]);
            }
        }

        private bool IsValidStateNumber(string number)
        {
            number = number.Replace(" ", "").ToUpper();

            if (number.Length != 8 && number.Length != 9)
                return false;

            string allowedLetters = "АВЕКМНОРСТУХABEKMHOPCTYX";

            if (!allowedLetters.Contains(number[0]))
                return false;

            for (int i = 1; i <= 3; i++)
            {
                if (!char.IsDigit(number[i]))
                    return false;
            }

            if (!allowedLetters.Contains(number[4]) || !allowedLetters.Contains(number[5]))
                return false;

            for (int i = 6; i < number.Length; i++)
            {
                if (!char.IsDigit(number[i]))
                    return false;
            }

            return true;
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtStateNumber.Text))
            {
                MessageBox.Show("Введите госномер!", "Ошибка");
                txtStateNumber.Focus();
                return false;
            }

            string stateNumber = txtStateNumber.Text.Trim().Replace(" ", "").ToUpper();

            if (stateNumber.Length > 9)
            {
                MessageBox.Show("Госномер не может быть длиннее 9 символов!", "Ошибка");
                txtStateNumber.Focus();
                txtStateNumber.SelectAll();
                return false;
            }

            if (!IsValidStateNumber(stateNumber))
            {
                MessageBox.Show("Неверный формат госномера!\n\nПример: А777ВВ136", "Ошибка");
                txtStateNumber.Focus();
                txtStateNumber.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbBrand.Text))
            {
                MessageBox.Show("Введите или выберите бренд!", "Ошибка");
                cmbBrand.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbModel.Text))
            {
                MessageBox.Show("Введите или выберите модель!", "Ошибка");
                cmbModel.Focus();
                return false;
            }

            if (nudYear.Value < 2000 || nudYear.Value > DateTime.Now.Year)
            {
                MessageBox.Show($"Год должен быть от 2000 до {DateTime.Now.Year}!", "Ошибка");
                nudYear.Focus();
                return false;
            }

            if (nudPrice.Value < 1 || nudPrice.Value > 1000)
            {
                MessageBox.Show("Цена должна быть от 1 до 1000!", "Ошибка");
                nudPrice.Focus();
                return false;
            }

            if (cmbFuelType.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип топлива!", "Ошибка");
                cmbFuelType.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbColor.Text))
            {
                MessageBox.Show("Введите или выберите цвет!", "Ошибка");
                cmbColor.Focus();
                return false;
            }

            if (!IsOnlyLetters(cmbColor.Text))
            {
                MessageBox.Show("Цвет должен содержать только буквы, пробелы и дефисы!", "Ошибка");
                cmbColor.Focus();
                cmbColor.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbParking.Text))
            {
                MessageBox.Show("Введите или выберите парковку!", "Ошибка");
                cmbParking.Focus();
                return false;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите статус!", "Ошибка");
                cmbStatus.Focus();
                return false;
            }

            return true;
        }

        private bool IsOnlyLetters(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsLetter(c) && c != ' ' && c != '-')
                    return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _selectedCarId = 0;
            _isAddingNew = true;
            ClearFields();
            LoadModels();
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
            txtStateNumber.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                string stateNumber = txtStateNumber.Text.Trim().Replace(" ", "").ToUpper();
                if (stateNumber.Length > 9)
                {
                    stateNumber = stateNumber.Substring(0, 9);
                }

                var car = new Car();
                var parking = new Parking();

                string brand = cmbBrand.Text.Trim();
                string model = cmbModel.Text.Trim();
                int savedCarId = _selectedCarId;

                int colorId;
                if (!string.IsNullOrWhiteSpace(cmbColor.Text))
                {
                    colorId = car.GetOrAddColor(cmbColor.Text.Trim());
                }
                else
                {
                    colorId = (int)cmbColor.SelectedValue;
                }

                int? parkingId = null;
                string addressText = cmbParking.Text.Trim();
                if (!string.IsNullOrWhiteSpace(addressText))
                {
                    string[] parts = addressText.Split(',');
                    if (parts.Length >= 3)
                    {
                        string city = parts[0].Trim();
                        string street = parts[1].Trim();
                        string house = parts[2].Trim().Replace("д.", "").Replace("д", "").Trim();
                        string entrance = parts.Length >= 4 ? parts[3].Trim().Replace("подъезд", "").Trim() : null;

                        var parkings = parking.GetAllParkings();
                        bool parkingExists = false;
                        foreach (DataRow row in parkings.Rows)
                        {
                            if (row["address"].ToString() == addressText)
                            {
                                parkingExists = true;
                                parkingId = Convert.ToInt32(row["id_parking"]);
                                break;
                            }
                        }

                        if (!parkingExists)
                        {
                            parkingId = parking.AddParking(city, street, house, entrance);
                        }
                    }
                }

                int fuelTypeId = (int)cmbFuelType.SelectedValue;
                int statusId = (int)cmbStatus.SelectedValue;

                if (_selectedCarId == 0)
                {
                    car.AddCar(
                        stateNumber,
                        brand,   
                        model,   
                        (int)nudYear.Value,
                        nudPrice.Value,
                        fuelTypeId,
                        colorId,
                        parkingId
                    );
                    MessageBox.Show("Машина добавлена!", "Успех");
                    savedCarId = 0;
                }
                else
                {
                    car.UpdateCar(
                        _selectedCarId,
                        stateNumber,
                        brand,
                        model,
                        (int)nudYear.Value,
                        nudPrice.Value,
                        fuelTypeId,
                        colorId,
                        parkingId
                    );
                    MessageBox.Show("Машина обновлена!", "Успех");
                }

                ClearFields();
                LoadCars();
                LoadBrands();
                LoadModels();
                LoadComboBoxes();

                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                btnAdd.Enabled = true;
                _isAddingNew = false;

                if (savedCarId > 0)
                {
                    SelectCarById(savedCarId);
                }
                else if (dgvCars.Rows.Count > 0)
                {
                    dgvCars.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCarId == 0)
            {
                MessageBox.Show("Выберите машину!", "Ошибка");
                return;
            }

            if (MessageBox.Show("Удалить машину?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    var car = new Car();
                    car.DeleteCar(_selectedCarId);
                    MessageBox.Show("Машина удалена!", "Успех");
                    _selectedCarId = 0;
                    ClearFields();
                    LoadCars();
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _isAddingNew = false;
            _selectedCarId = 0;

            ClearFields();
            LoadCars();
            LoadBrands();
            LoadModels();
            LoadComboBoxes();

            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;

            if (dgvCars.Rows.Count > 0)
            {
                dgvCars.Rows[0].Selected = true;
            }
        }

        private void ClearFields()
        {
            txtStateNumber.Clear();
            cmbBrand.Text = "";
            cmbModel.Text = "";
            nudYear.Value = 2000;
            nudPrice.Value = 1;
            cmbFuelType.SelectedIndex = -1;
            cmbColor.Text = "";
            cmbParking.Text = "";
            cmbStatus.SelectedIndex = -1;
        }
    }
}