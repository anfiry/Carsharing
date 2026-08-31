using Carsharing.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carsharing.UserControls
{
    public partial class ProfileControl : UserControl
    {

        private readonly Account _account;

        public ProfileControl(Account account)
        {
            InitializeComponent();
            _account = account;
            LoadProfile();
        }


        private void LoadProfile()
        {
            txtLogin.Text = _account.Login;
            txtLogin.ReadOnly = true;

            if (_account.RoleId == 1)
            {
                LoadClientProfile();
            }
            else if (_account.RoleId == 2)
            {
                LoadOperatorProfile();
            }
        }


        private int GetClientId()
        {
            var client = new Client();
            var clients = client.GetAllClients();

            foreach (DataRow row in clients.Rows)
            {
                if (row["login"].ToString() == _account.Login)
                {
                    return Convert.ToInt32(row["id_client"]);
                }
            }
            return 0;
        }

        private int GetOperatorId()
        {
            var op = new Operator();
            var operators = op.GetAllOperators();

            foreach (DataRow row in operators.Rows)
            {
                if (row["login"].ToString() == _account.Login)
                {
                    return Convert.ToInt32(row["id_operator"]);
                }
            }
            return 0;
        }

        private void LoadClientProfile()
        {
            int clientId = GetClientId();
            var client = new Client();
            var info = client.GetInfo(clientId);

            if (info.Rows.Count > 0)
            {
                var row = info.Rows[0];
                txtLastName.Text = row["last_name"].ToString();
                txtFirstName.Text = row["first_name"].ToString();
                txtPatronymic.Text = row["patronymic"].ToString();
                txtPhone.Text = row["phone_number"].ToString();
                txtBirthDate.Text = Convert.ToDateTime(row["birth_date"]).ToShortDateString();
                txtExperience.Text = row["driving_experience"].ToString() + " лет";

                txtBirthDate.ReadOnly = true;
                txtExperience.ReadOnly = true;
                txtBirthDate.Visible = true;
                txtExperience.Visible = true;
                lblBirthDate.Visible = true;
                lblExperience.Visible = true;
                txtBirthDate.BackColor = SystemColors.Control;
                txtExperience.BackColor = SystemColors.Control;
            }

            txtLastName.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtPatronymic.ReadOnly = false;
            txtPhone.ReadOnly = false;
        }


        private void LoadOperatorProfile()
        {
            int operatorId = GetOperatorId();
            var op = new Operator();
            var info = op.GetInfo(operatorId);

            if (info.Rows.Count > 0)
            {
                var row = info.Rows[0];
                txtLastName.Text = row["last_name"].ToString();
                txtFirstName.Text = row["first_name"].ToString();
                txtPatronymic.Text = row["patronymic"].ToString();
                txtPhone.Text = row["phone_number"].ToString();

                txtBirthDate.Visible = false;
                txtExperience.Visible = false;
                lblBirthDate.Visible = false;
                lblExperience.Visible = false;
            }

            txtLastName.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtPatronymic.ReadOnly = false;
            txtPhone.ReadOnly = false;
        }


        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Введите фамилию!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }
            if (!IsOnlyLetters(txtLastName.Text))
            {
                MessageBox.Show("Фамилия должна содержать только буквы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Введите имя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }
            if (!IsOnlyLetters(txtFirstName.Text))
            {
                MessageBox.Show("Имя должно содержать только буквы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtPatronymic.Text))
            {
                if (!IsOnlyLetters(txtPatronymic.Text))
                {
                    MessageBox.Show("Отчество должно содержать только буквы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPatronymic.Focus();
                    return false;
                }
            }

            // Телефон
            string phone = txtPhone.Text.Trim();

            if (phone.Length != 12 || !phone.StartsWith("+7"))
            {
                MessageBox.Show("Введите номер телефона в формате +7XXXXXXXXXX (12 символов)!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            // Проверка: после +7 только цифры
            for (int i = 2; i < phone.Length; i++)
            {
                if (!char.IsDigit(phone[i]))
                {
                    MessageBox.Show("Телефон должен содержать только цифры после +7!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhone.Focus();
                    return false;
                }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                if (_account.RoleId == 1)
                {
                    int clientId = GetClientId();
                    var client = new Client();
                    client.UpdateProfile(
                        clientId,
                        txtLastName.Text,
                        txtFirstName.Text,
                        txtPatronymic.Text,
                        txtPhone.Text
                    );
                    MessageBox.Show("Профиль обновлён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (_account.RoleId == 2)
                {
                    int operatorId = GetOperatorId();
                    var op = new Operator();
                    op.UpdateProfile(
                        operatorId,
                        txtLastName.Text,
                        txtFirstName.Text,
                        txtPatronymic.Text,
                        txtPhone.Text
                    );
                    MessageBox.Show("Профиль обновлён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
