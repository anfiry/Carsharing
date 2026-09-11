using Carsharing.Classes;
using Carsharing.Services;
using System;
using System.Windows.Forms;

namespace Carsharing.Forms
{
    public partial class LoginForm : Form
    {
        private bool back = false;

        public LoginForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Text = "Вход";
        }

        public void OnClosed()
        {
            if (back)
            { back = false; }
            else
            {
                if (Application.OpenForms.Count == 0)
                {
                    Application.Exit();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка");
                return;
            }

            try
            {
                var authService = new AuthService();
                Account account = authService.Login(txtLogin.Text, txtPassword.Text);

                MainForm mainForm = new MainForm(account);
                mainForm.Show();

                back = true;
                this.Hide(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка");
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnClosed();
        }
    }
}