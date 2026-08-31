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
    public partial class RentalsControl : UserControl
    {
        private readonly Account _account;

        public RentalsControl(Account account)
        {
            InitializeComponent();
            _account = account;
            LoadRentals();
        }


        private void LoadRentals()
        {
            var rental = new Rental();

            if (_account.RoleId == 1) // Клиент
            {
                int clientId = GetClientId();
                var data = rental.GetClientRentals(clientId);
                dgvRentals.DataSource = data;
                lblTitle.Text = "Мои аренды";
                SetupClientRentalsGrid(dgvRentals);
            }
            else if (_account.RoleId == 2) // Оператор
            {
                // Используем активные аренды или создадим метод GetAllRentals
                var data = rental.GetAllRentals();
                dgvRentals.DataSource = data;
                lblTitle.Text = "Все аренды";
                SetupOperatorRentalsGrid(dgvRentals);
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

        private void SetupClientRentalsGrid(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;

            if (dgv.Columns.Contains("id_rental"))
                dgv.Columns["id_rental"].Visible = false;
            if (dgv.Columns.Contains("id_client"))
                dgv.Columns["id_client"].Visible = false;
            if (dgv.Columns.Contains("car_id"))
                dgv.Columns["car_id"].Visible = false;
            if (dgv.Columns.Contains("rental_status_id"))
                dgv.Columns["rental_status_id"].Visible = false;

            if (dgv.Columns.Contains("brand"))
                dgv.Columns["brand"].HeaderText = "Марка";
            if (dgv.Columns.Contains("model"))
                dgv.Columns["model"].HeaderText = "Модель";
            if (dgv.Columns.Contains("state_number"))
                dgv.Columns["state_number"].HeaderText = "Госномер";
            if (dgv.Columns.Contains("start_time"))
                dgv.Columns["start_time"].HeaderText = "Время начала";
            if (dgv.Columns.Contains("end_time"))
                dgv.Columns["end_time"].HeaderText = "Время окончания";
            if (dgv.Columns.Contains("total_cost"))
                dgv.Columns["total_cost"].HeaderText = "Стоимость";
            if (dgv.Columns.Contains("rental_status_name"))
                dgv.Columns["rental_status_name"].HeaderText = "Статус";
        }

        private void SetupOperatorRentalsGrid(DataGridView dgv)
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
            if (dgv.Columns.Contains("end_time"))
                dgv.Columns["end_time"].HeaderText = "Время окончания";
            if (dgv.Columns.Contains("total_cost"))
                dgv.Columns["total_cost"].HeaderText = "Стоимость";
            if (dgv.Columns.Contains("rental_status_name"))
                dgv.Columns["rental_status_name"].HeaderText = "Статус";
            if (dgv.Columns.Contains("start_address"))
                dgv.Columns["start_address"].HeaderText = "Парковка";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRentals();
        }
    }
}
