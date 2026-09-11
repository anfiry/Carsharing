using Carsharing.Classes;
using Carsharing.Services;
using System;
using System.Drawing;
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


            SetupPlaceholder(txtPhone, "Пример: +79001234567");
            SetupPlaceholder(txtPassword, "8 символов");



        }

        public void OnClosed()
        {
            if (back)
            { back = false; }
            else { Application.Exit(); }
        }
        public static void SetupPlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.PasswordChar != '\0')
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
                textBox.Tag = placeholder;
                textBox.PasswordChar = '\0';

                textBox.Enter += (s, e) =>
                {
                    if (textBox.Text == textBox.Tag?.ToString())
                    {
                        textBox.Text = "";
                        textBox.ForeColor = Color.Black;
                        textBox.PasswordChar = '*';
                    }
                };

                textBox.Leave += (s, e) =>
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.Text = placeholder;
                        textBox.ForeColor = Color.Gray;
                        textBox.PasswordChar = '\0';
                    }
                    else
                    {
                        textBox.PasswordChar = '*';
                    }
                };
            }
            else
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
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
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            

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

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int age = DateTime.Today.Year - dtpBirthDate.Value.Year;
            if (dtpBirthDate.Value.Date > DateTime.Today.AddYears(-age)) age--;

            if (age < 21)
            {
                MessageBox.Show("Возраст должен быть не менее 21 года!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime birthDate = dtpBirthDate.Value;
            DateTime licenseDate = dtpLicenseDate.Value;

            int ageAtLicense = licenseDate.Year - birthDate.Year;
            if (licenseDate.Date < birthDate.AddYears(ageAtLicense)) ageAtLicense--;

            if (ageAtLicense < 18)
            {
                MessageBox.Show("Возраст при получении водительского удостоверения должен быть не менее 18 лет!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Ошибка регистрации! Попробуйте снова.", "Ошибка");
                    return;
                }

                MessageBox.Show("Регистрация успешна!", "Успех");

                var authService = new AuthService();
                Account account = authService.GetUserByLogin(txtLogin.Text);

                if (account == null)
                {
                    MessageBox.Show("Не удалось получить данные аккаунта!", "Ошибка");
                    return;
                }

                MainForm mainForm = new MainForm(account);
                mainForm.Show();

                LoginForm loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
                if (loginForm != null)
                {
                    loginForm.Hide();
                }

                back = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
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

        
    }
}