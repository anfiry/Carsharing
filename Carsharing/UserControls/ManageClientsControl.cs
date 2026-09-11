using Carsharing.Classes;
using Carsharing.Forms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Carsharing.UserControls
{
    public partial class ManageClientsControl : UserControl
    {
        private DataTable _clients;
        private int _selectedClientId;

        public ManageClientsControl()
        {
            InitializeComponent();
            LoadClients();

            SetupPlaceholder(txtPhone, "Пример: +79001234567");
        }

        private void LoadClients()
        {
            var client = new Client();
            _clients = client.GetAllClients();
            dgvClients.DataSource = _clients;
            SetupClientsGrid(dgvClients);
        }


        private void SetupPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Black;
            textBox.Tag = placeholder;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == textBox.Tag?.ToString())
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void SetupClientsGrid(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgv.Columns.Contains("id_client"))
                dgv.Columns["id_client"].Visible = false;

            if (dgv.Columns.Contains("login"))
                dgv.Columns["login"].HeaderText = "Логин";
            if (dgv.Columns.Contains("last_name"))
                dgv.Columns["last_name"].HeaderText = "Фамилия";
            if (dgv.Columns.Contains("first_name"))
                dgv.Columns["first_name"].HeaderText = "Имя";
            if (dgv.Columns.Contains("patronymic"))
                dgv.Columns["patronymic"].HeaderText = "Отчество";
            if (dgv.Columns.Contains("phone_number"))
                dgv.Columns["phone_number"].HeaderText = "Телефон";
            if (dgv.Columns.Contains("birth_date"))
                dgv.Columns["birth_date"].HeaderText = "Дата рождения";
            if (dgv.Columns.Contains("driving_experience"))
                dgv.Columns["driving_experience"].HeaderText = "Стаж (лет)";
            if (dgv.Columns.Contains("is_blocked"))
                dgv.Columns["is_blocked"].HeaderText = "Заблокирован";
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                var row = dgvClients.SelectedRows[0];
                _selectedClientId = Convert.ToInt32(row.Cells["id_client"].Value);

                txtLastName.Text = row.Cells["last_name"].Value.ToString();
                txtFirstName.Text = row.Cells["first_name"].Value.ToString();
                txtPatronymic.Text = row.Cells["patronymic"]?.Value?.ToString() ?? "";
                txtPhone.Text = row.Cells["phone_number"].Value.ToString();

                bool isBlocked = Convert.ToBoolean(row.Cells["is_blocked"].Value);

                if (isBlocked)
                {
                    btnToggleBlock.Text = "Разблокировать";
                    btnToggleBlock.BackColor = Color.LightGreen;
                }
                else
                {
                    btnToggleBlock.Text = "Заблокировать";
                    btnToggleBlock.BackColor = Color.LightCoral;
                }
            }
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

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Введите фамилию!", "Ошибка");
                txtLastName.Focus();
                return false;
            }

            if (!IsOnlyLetters(txtLastName.Text))
            {
                MessageBox.Show("Фамилия должна содержать только буквы, пробелы и дефисы!", "Ошибка");
                txtLastName.Focus();
                txtLastName.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Введите имя!", "Ошибка");
                txtFirstName.Focus();
                return false;
            }

            if (!IsOnlyLetters(txtFirstName.Text))
            {
                MessageBox.Show("Имя должно содержать только буквы, пробелы и дефисы!", "Ошибка");
                txtFirstName.Focus();
                txtFirstName.SelectAll();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtPatronymic.Text))
            {
                if (!IsOnlyLetters(txtPatronymic.Text))
                {
                    MessageBox.Show("Отчество должно содержать только буквы, пробелы и дефисы!", "Ошибка");
                    txtPatronymic.Focus();
                    txtPatronymic.SelectAll();
                    return false;
                }
            }

            string phone = txtPhone.Text.Trim();
            if (phone.Length != 12 || !phone.StartsWith("+7"))
            {
                MessageBox.Show("Введите номер телефона в формате +7XXXXXXXXXX (12 символов)!", "Ошибка");
                txtPhone.Focus();
                txtPhone.SelectAll();
                return false;
            }

            for (int i = 2; i < phone.Length; i++)
            {
                if (!char.IsDigit(phone[i]))
                {
                    MessageBox.Show("Телефон должен содержать только цифры после +7!", "Ошибка");
                    txtPhone.Focus();
                    txtPhone.SelectAll();
                    return false;
                }
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedClientId == 0)
            {
                MessageBox.Show("Выберите клиента!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateFields())
                return;

            try
            {
                var client = new Client();
                client.UpdateProfile(
                    _selectedClientId,
                    txtLastName.Text,
                    txtFirstName.Text,
                    txtPatronymic.Text,
                    txtPhone.Text
                );
                MessageBox.Show("Данные обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToggleBlock_Click(object sender, EventArgs e)
        {
            if (_selectedClientId == 0)
            {
                MessageBox.Show("Выберите клиента!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var blocklist = new Blocklist();
                bool isBlocked = blocklist.IsClientBlocked(_selectedClientId);

                if (isBlocked)
                {
                    blocklist.UnblockClient(_selectedClientId);
                    MessageBox.Show("Клиент разблокирован!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    blocklist.BlockClient(_selectedClientId, "Заблокирован оператором");
                    MessageBox.Show("Клиент заблокирован!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            if (_selectedClientId == 0)
            {
                MessageBox.Show("Выберите клиента!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rentalsForm = new ClientRentalsForm(_selectedClientId);
            rentalsForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadClients();
        }
    }
}