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
    public partial class HomeControl : UserControl
    {

        private readonly Account _account;
        public HomeControl()
        {
            InitializeComponent();
        }

        public HomeControl(Account account) :this()
        {
            _account = account;
            LoadData();
        }

        private void LoadData()
        {
            lblWelcome.Text = $"Добро пожаловать, {_account.Login}";


            if (_account.RoleId == 1)
            {
                LoadClientData();
            }
            else if (_account.RoleId == 2)
            {
                LoadOperatorData();
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


        
        private void LoadClientData()
        {
            int clientId = GetClientId();

            var rental = new Rental();
            var activeRental = rental.GetActiveRentalByClient(clientId);

            if (activeRental.Rows.Count > 0) 
            {
                lblRentalInfo.Text = "Активная аренда:";
                dgvRental.Visible = true;
                dgvRental.DataSource = activeRental;
                SetupRentalGrid(dgvRental);
            }
            else
            {
                lblRentalInfo.Text = "Нет активной аренды";
                dgvRental.Visible = false;
                dgvRental.DataSource = null;
            }



            var fine = new Fine();
            var unpaidFines = fine.GetUnpaidFinesByClient(clientId);

            if (unpaidFines.Rows.Count > 0)
            {
                lblFines.Text = "Неоплаченные штрафы:";
                lblFines.Visible = true;
                lblFines.BringToFront();
                dgvFines.Visible = true;
                dgvFines.DataSource = unpaidFines;
                SetupFinesGrid(dgvFines);
            }
            else
            {
                lblFines.Text = "Нет неоплаченных штрафов";
                lblFines.Visible = true;
                lblFines.BringToFront();
                dgvFines.Visible = false;
                dgvFines.DataSource = null;
            }
        }



        private void LoadOperatorData()
        {
            var rental = new Rental();
            var activeRentals = rental.GetActiveRentals();

            lblFines.Visible = false;
            dgvFines.Visible = false;


            if (activeRentals.Rows.Count > 0)
            {
                lblRentalInfo.Text = "Активные аренды:";
                dgvRental.Visible = true;
                dgvRental.DataSource = activeRentals;
                SetupOperatorRentalGrid(dgvRental);

            }

            else
            {
                lblRentalInfo.Text = "Нет активных аренды";
                dgvRental.Visible = false;
                dgvRental.DataSource = null;
                
            }
        }

        private void SetupFinesGrid(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;

            if (dgv.Columns.Contains("id_fine"))
                dgv.Columns["id_fine"].Visible = false;

            if (dgv.Columns.Contains("start_time"))
                dgv.Columns["start_time"].HeaderText = "Дата аренды";
            if (dgv.Columns.Contains("car_info"))
                dgv.Columns["car_info"].HeaderText = "Автомобиль";
            if (dgv.Columns.Contains("fine_type_name"))
                dgv.Columns["fine_type_name"].HeaderText = "Тип штрафа";
            if (dgv.Columns.Contains("description"))
                dgv.Columns["description"].HeaderText = "Описание";
            if (dgv.Columns.Contains("status"))
                dgv.Columns["status"].HeaderText = "Статус";
            if (dgv.Columns.Contains("amount"))
                dgv.Columns["amount"].HeaderText = "Сумма";               
        }


        private void SetupRentalGrid(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;

            if (dgv.Columns.Contains("id_rental"))
                dgv.Columns["id_rental"].Visible = false;
            if (dgv.Columns.Contains("client_id"))
                dgv.Columns["client_id"].Visible = false;
            if (dgv.Columns.Contains("car_id"))
                dgv.Columns["car_id"].Visible = false;
            if (dgv.Columns.Contains("rental_status_id"))
                dgv.Columns["rental_status_id"].Visible = false;
            if (dgv.Columns.Contains("start_parking_id"))
                dgv.Columns["start_parking_id"].Visible = false;
            if (dgv.Columns.Contains("end_parking_id"))
                dgv.Columns["end_parking_id"].Visible = false;

            if (dgv.Columns.Contains("car_name"))
                dgv.Columns["car_name"].HeaderText = "Автомобиль";
            if (dgv.Columns.Contains("state_number"))
                dgv.Columns["state_number"].HeaderText = "Госномер";
            if (dgv.Columns.Contains("start_time"))
                dgv.Columns["start_time"].HeaderText = "Время начала";
            if (dgv.Columns.Contains("end_time"))
                dgv.Columns["end_time"].HeaderText = "Время окончания";
            if (dgv.Columns.Contains("total_cost"))
                dgv.Columns["total_cost"].HeaderText = "Стоимость";
            if (dgv.Columns.Contains("minutes"))
                dgv.Columns["minutes"].HeaderText = "Минут";
            if (dgv.Columns.Contains("current_cost"))
                dgv.Columns["current_cost"].HeaderText = "Текущая стоимость";
            if (dgv.Columns.Contains("rental_status_name"))
                dgv.Columns["rental_status_name"].HeaderText = "Статус";
        }

        private void SetupOperatorRentalGrid(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;

            if (dgv.Columns.Contains("id_rental"))
                dgv.Columns["id_rental"].Visible = false;

            if (dgv.Columns.Contains("client_name"))
                dgv.Columns["client_name"].HeaderText = "Клиент";
            if (dgv.Columns.Contains("brand"))
                dgv.Columns["brand"].HeaderText = "Марка";
            if (dgv.Columns.Contains("model"))
                dgv.Columns["model"].HeaderText = "Модель";
            if (dgv.Columns.Contains("state_number"))
                dgv.Columns["state_number"].HeaderText = "Госномер";
            if (dgv.Columns.Contains("start_time"))
                dgv.Columns["start_time"].HeaderText = "Время начала";
            if (dgv.Columns.Contains("start_address"))
                dgv.Columns["start_address"].HeaderText = "Парковка";
        }
    }
}
