using Carsharing.Classes;
using Carsharing.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carsharing.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Text = "Регистрация";
        }

        private bool back = false;
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
                MessageBox.Show("Пароли не совпадают", "Ошибка");
                return;
            }


            if (string.IsNullOrWhiteSpace(txtLogin.Text)
                || string.IsNullOrWhiteSpace(txtPassword.Text)
                || string.IsNullOrWhiteSpace(txtLastName.Text)
                || string.IsNullOrWhiteSpace(txtFirstName.Text)
                || string.IsNullOrWhiteSpace(txtPhone.Text)
                )
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка");
                return;
            }


            if (txtPassword.Text.Length != 8)
            {
                MessageBox.Show("Пароль должен содержать 8 символов!", "Ошибка");
                return;
            }


            if (txtPhone.Text.Length != 12)
            {
                MessageBox.Show("Введите корректный номер телефона! (+79...)", "Ошибка");
                return;
            }


            int age = DateTime.Today.Year - dtpBirthDate.Value.Year;
            if (dtpBirthDate.Value.Date > DateTime.Today.AddYears(-age)) age--;

            if (age < 21)
            {
                MessageBox.Show("Возраст должен быть не менее 21 года!", "Ошибка");
                return;
            }


            int experience = DateTime.Today.Year - dtpLicenseDate.Value.Year;
            if (dtpLicenseDate.Value.Date > DateTime.Today.AddYears(-experience)) experience--;

            if (experience < 2)
            {
                MessageBox.Show("Стаж вождения должен быть не менее 2 лет!", "Ошибка");
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

                MessageBox.Show("Регистрация успешна!", "Ошибка");

                AuthService authService = new AuthService();
                Account account = authService.GetUserByLogin(txtLogin.Text);

                MainForm mainForm = new MainForm(account);
                mainForm.Show();
                this.Close();

                LoginForm loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
                if (loginForm != null)
                {
                    loginForm.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
            //LoginForm loginForm = new LoginForm();
            //loginForm.Show();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnClosed();
        }
    }
}
