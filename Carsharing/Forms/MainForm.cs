using Carsharing.Classes;
using Carsharing.UserControls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Carsharing.Forms
{
    public partial class MainForm : Form
    {
        private readonly Account _currentAccount;
        private bool back = false;

        public MainForm(Account account)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Text = "Каршеринг";

            _currentAccount = account;

            if (account.RoleId == 1)
            {
                btnManageCars.Visible = false;
                btnManageClients.Visible = false;
                btnFines2.Visible = false;
                btnRentals.Text = "Мои аренды";
            }
            else if (account.RoleId == 2)
            {
                btnManageCars.Visible = true;
                btnManageClients.Visible = true;
                btnRentCar.Visible = false;
                btnFines.Visible = false;
                btnRentals.Text = "Аренды";
            }

            // Загружаем HomeControl
            try
            {
                LoadContent(new HomeControl(_currentAccount));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка");
            }
        }

        public void OnClosed()
        {
            if (back)
            { back = false; }
            else { Application.Exit(); }
        }

        private void LoadContent(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            LoadContent(new HomeControl(_currentAccount));
        }

        private void btnRentCar_Click(object sender, EventArgs e)
        {
            LoadContent(new RentControl(_currentAccount));
        }

        private void btnMyRentals_Click(object sender, EventArgs e)
        {
            LoadContent(new RentalsControl(_currentAccount));
        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            LoadContent(new FinesControl(_currentAccount));
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadContent(new ProfileControl(_currentAccount));
        }

        private void btnManageCars_Click(object sender, EventArgs e)
        {
            LoadContent(new ManageCarsControl());
        }

        private void btnManageClients_Click(object sender, EventArgs e)
        {
            LoadContent(new ManageClientsControl());
        }

        private void btnFines2_Click(object sender, EventArgs e)
        {
            LoadContent(new ManageFinesControl());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();


            /*LoginForm loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.Show();
            }
            else
            {
                loginForm = new LoginForm();
                loginForm.Show();
            }*/
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
                Application.Exit();
            
        }
    }
}