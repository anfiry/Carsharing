using Carsharing.Classes;
using Carsharing.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Carsharing.Forms
{
    public partial class RegisterForm : Form
    {
        private bool back = false;

        public RegisterForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Text = "Регистрация";

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtPhone, "Пример: +79001234567");
            toolTip.SetToolTip(txtCardNumber, "Пример: 1234 5678 9012 3456");
            toolTip.SetToolTip(txtCardExpiry, "Пример: 12/25");
            toolTip.SetToolTip(txtCardCVV, "Пример: 123");
        }

        public void OnClosed()
        {
            if (back)
            { back = false; }
            else { Application.Exit(); }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLogin.Text)
                || string.IsNullOrWhiteSpace(txtPassword.Text)
                || string.IsNullOrWhiteSpace(txtLastName.Text)
                || string.IsNullOrWhiteSpace(txtFirstName.Text)
                || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text.Length != 8)
            {
                MessageBox.Show("Пароль должен содержать 8 символов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPhone.Text.Length != 12 || !txtPhone.Text.StartsWith("+7"))
            {
                MessageBox.Show("Введите корректный номер телефона! (+79...)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cardNumber = txtCardNumber.Text.Replace(" ", "");
            string expiry = txtCardExpiry.Text;
            string cvv = txtCardCVV.Text;

            if (cardNumber.Length != 16 || !long.TryParse(cardNumber, out _))
            {
                MessageBox.Show("Введите корректный номер карты (16 цифр)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCardNumber.Focus();
                return;
            }

            if (expiry.Length != 5 || !expiry.Contains("/"))
            {
                MessageBox.Show("Введите срок действия в формате ММ/ГГ!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCardExpiry.Focus();
                return;
            }

            if (cvv.Length != 3 || !int.TryParse(cvv, out _))
            {
                MessageBox.Show("Введите корректный CVV (3 цифры)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCardCVV.Focus();
                return;
            }

            int age = DateTime.Today.Year - dtpBirthDate.Value.Year;
            if (dtpBirthDate.Value.Date > DateTime.Today.AddYears(-age)) age--;

            if (age < 21)
            {
                MessageBox.Show("Возраст должен быть не менее 21 года!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int experience = DateTime.Today.Year - dtpLicenseDate.Value.Year;
            if (dtpLicenseDate.Value.Date > DateTime.Today.AddYears(-experience)) experience--;

            if (experience < 2)
            {
                MessageBox.Show("Стаж вождения должен быть не менее 2 лет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var registerService = new RegisterService();
                int clientId = registerService.Register(
                    txtLogin.Text,
                    txtPassword.Text,
                    txtLastName.Text,
                    txtFirstName.Text,
                    txtPhone.Text,
                    dtpBirthDate.Value,
                    dtpLicenseDate.Value,
                    txtPatronymic.Text
                );

                if (clientId == 0)
                {
                    MessageBox.Show("Ошибка регистрации! Попробуйте снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var card = new Card();
                card.SaveCard(clientId, cardNumber, expiry, cvv);

                MessageBox.Show("Регистрация успешна! Карта сохранена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var authService = new AuthService();
                Account account = authService.GetUserByLogin(txtLogin.Text);

                if (account == null)
                {
                    MessageBox.Show("Не удалось получить данные аккаунта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MainForm mainForm = new MainForm(account);
                mainForm.Show();

                back = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.Show();
            }
            else
            {
                loginForm = new LoginForm();
                loginForm.Show();
            }
            back = true;
            this.Close();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnClosed();
        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
            string text = txtCardNumber.Text.Replace(" ", "");
            if (text.Length > 16)
                text = text.Substring(0, 16);

            if (text.Length >= 4)
                text = text.Insert(4, " ");
            if (text.Length >= 9)
                text = text.Insert(9, " ");
            if (text.Length >= 14)
                text = text.Insert(14, " ");

            txtCardNumber.Text = text.Trim();
            txtCardNumber.SelectionStart = txtCardNumber.Text.Length;
        }
    }
}