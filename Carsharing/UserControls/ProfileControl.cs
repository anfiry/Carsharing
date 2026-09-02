using Carsharing.Classes;
using System;
using System.Data;
using System.Drawing;
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
            txtBirthDate.Visible = true;
            txtExperience.Visible = true;
            lblBirthDate.Visible = true;
            lblExperience.Visible = true;

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
                txtBirthDate.BackColor = SystemColors.Control;
                txtExperience.BackColor = SystemColors.Control;
            }

            LoadCardInfo(clientId);

            txtLastName.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtPatronymic.ReadOnly = false;
            txtPhone.ReadOnly = false;
        }

        private void LoadOperatorProfile()
        {
            txtBirthDate.Visible = false;
            txtExperience.Visible = false;
            lblBirthDate.Visible = false;
            lblExperience.Visible = false;

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
            }

            HideCardFields();

            txtLastName.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtPatronymic.ReadOnly = false;
            txtPhone.ReadOnly = false;
        }

        private void LoadCardInfo(int clientId)
        {
            try
            {
                var card = new Card();
                var data = card.GetCardByClient(clientId);

                if (data.Rows.Count > 0)
                {
                    txtCardNumber.Text = data.Rows[0]["card_number"].ToString();
                    txtCardExpiry.Text = data.Rows[0]["expiry_date"].ToString();
                    txtCardCVV.Text = data.Rows[0]["cvv"].ToString();
                }
                else
                {
                    txtCardNumber.Clear();
                    txtCardExpiry.Clear();
                    txtCardCVV.Clear();
                }

                ShowCardFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки карты: {ex.Message}", "Ошибка");
            }
        }

        private void ShowCardFields()
        {
            lblCardNumber.Visible = true;
            txtCardNumber.Visible = true;
            lblCardExpiry.Visible = true;
            txtCardExpiry.Visible = true;
            lblCardCVV.Visible = true;
            txtCardCVV.Visible = true;
        }

        private void HideCardFields()
        {
            lblCardNumber.Visible = false;
            txtCardNumber.Visible = false;
            lblCardExpiry.Visible = false;
            txtCardExpiry.Visible = false;
            lblCardCVV.Visible = false;
            txtCardCVV.Visible = false;
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

        private bool IsOnlyDigits(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private bool ValidateFields()
        {
            // Фамилия
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
                return false;
            }

            // Имя
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
                return false;
            }

            // Отчество (если не пустое)
            if (!string.IsNullOrWhiteSpace(txtPatronymic.Text))
            {
                if (!IsOnlyLetters(txtPatronymic.Text))
                {
                    MessageBox.Show("Отчество должно содержать только буквы, пробелы и дефисы!", "Ошибка");
                    txtPatronymic.Focus();
                    return false;
                }
            }

            // Телефон
            string phone = txtPhone.Text.Trim();
            if (phone.Length != 12 || !phone.StartsWith("+7"))
            {
                MessageBox.Show("Введите номер телефона в формате +7XXXXXXXXXX (12 символов)!", "Ошибка");
                txtPhone.Focus();
                return false;
            }
            for (int i = 2; i < phone.Length; i++)
            {
                if (!char.IsDigit(phone[i]))
                {
                    MessageBox.Show("Телефон должен содержать только цифры после +7!", "Ошибка");
                    txtPhone.Focus();
                    return false;
                }
            }

            // Карта (если заполнена)
            string cardNumber = txtCardNumber.Text.Replace(" ", "").Replace("-", "");
            string expiry = txtCardExpiry.Text;
            string cvv = txtCardCVV.Text;

            // Если хоть одно поле карты заполнено — проверяем все
            if (!string.IsNullOrWhiteSpace(cardNumber) || !string.IsNullOrWhiteSpace(expiry) || !string.IsNullOrWhiteSpace(cvv))
            {
                // Номер карты — только цифры, 16 символов
                if (cardNumber.Length != 16 || !IsOnlyDigits(cardNumber))
                {
                    MessageBox.Show("Введите корректный номер карты (16 цифр)!", "Ошибка");
                    txtCardNumber.Focus();
                    txtCardNumber.SelectAll();
                    return false;
                }

                // Срок — формат ММ/ГГ
                if (expiry.Length != 5 || !expiry.Contains("/"))
                {
                    MessageBox.Show("Введите срок действия в формате ММ/ГГ!", "Ошибка");
                    txtCardExpiry.Focus();
                    txtCardExpiry.SelectAll();
                    return false;
                }

                // Проверка, что месяц и год — цифры
                string[] parts = expiry.Split('/');
                if (parts.Length != 2 || parts[0].Length != 2 || parts[1].Length != 2 ||
                    !IsOnlyDigits(parts[0]) || !IsOnlyDigits(parts[1]))
                {
                    MessageBox.Show("Введите срок действия в формате ММ/ГГ (цифры)!", "Ошибка");
                    txtCardExpiry.Focus();
                    txtCardExpiry.SelectAll();
                    return false;
                }

                int month = int.Parse(parts[0]);
                int year = int.Parse(parts[1]);
                if (month < 1 || month > 12)
                {
                    MessageBox.Show("Введите корректный месяц (01-12)!", "Ошибка");
                    txtCardExpiry.Focus();
                    txtCardExpiry.SelectAll();
                    return false;
                }

                // CVV — только цифры, 3 символа
                if (cvv.Length != 3 || !IsOnlyDigits(cvv))
                {
                    MessageBox.Show("Введите корректный CVV (3 цифры)!", "Ошибка");
                    txtCardCVV.Focus();
                    txtCardCVV.SelectAll();
                    return false;
                }
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

                    var card = new Card();
                    var data = card.GetCardByClient(clientId);

                    string cardNumber = txtCardNumber.Text.Replace(" ", "").Replace("-", "");
                    string expiry = txtCardExpiry.Text;
                    string cvv = txtCardCVV.Text;

                    if (!string.IsNullOrWhiteSpace(cardNumber) && !string.IsNullOrWhiteSpace(expiry) && !string.IsNullOrWhiteSpace(cvv))
                    {
                        if (data.Rows.Count > 0)
                        {
                            int cardId = Convert.ToInt32(data.Rows[0]["id_card"]);
                            card.UpdateCard(cardId, cardNumber, expiry, cvv);
                        }
                        else
                        {
                            card.SaveCard(clientId, cardNumber, expiry, cvv);
                        }
                    }

                    MessageBox.Show("Профиль обновлён!", "Успех");
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
                    MessageBox.Show("Профиль обновлён!", "Успех");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }
    }
}