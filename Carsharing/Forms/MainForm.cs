using Carsharing.Classes;
using Carsharing.UserControls;
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
    public partial class MainForm : Form
    {
        private readonly Account _currentAccount;

        public MainForm(Account account)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Text = "Каршеринг - Главная";

            _currentAccount = account;

            if (account.RoleId == 1)
            {
                btnManageCars.Visible = false;
                btnManageClients.Visible = false;
                btnRentals.Text = "Мои аренды";
            }

            else if (account.RoleId == 2)
            {
                btnManageCars.Visible = true;
                btnManageClients.Visible = true;
                btnRentCar.Visible = false;
                btnRentals.Text = "Аренды";
            }
        }

        private bool back = false;
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
            LoadContent(new RentControl());
        }


        private void btnMyRentals_Click(object sender, EventArgs e)
        {
            LoadContent(new RentalsControl());

        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            LoadContent(new FinesControl());

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadContent(new ProfileControl());

        }


        private void btnManageCars_Click(object sender, EventArgs e)
        {
            LoadContent(new ManageCarsControl());

        }

        private void btnManageClients_Click(object sender, EventArgs e)
        {
            LoadContent(new ManageClientsControl());

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            back = true;
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnClosed();
        }
    }
}
