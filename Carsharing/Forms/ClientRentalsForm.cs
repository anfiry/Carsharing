using Carsharing.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Carsharing.Forms
{
    public partial class ClientRentalsForm : Form
    {
        private readonly int _clientId;

        public ClientRentalsForm(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;
            LoadRentals();
        }

        private void LoadRentals()
        {
            var rental = new Rental();
            var data = rental.GetClientRentals(_clientId);

            // Создаём новую таблицу с нужными столбцами
            DataTable displayTable = new DataTable();
            displayTable.Columns.Add("Автомобиль", typeof(string));
            displayTable.Columns.Add("Госномер", typeof(string));
            displayTable.Columns.Add("Время начала", typeof(DateTime));
            displayTable.Columns.Add("Время окончания", typeof(DateTime));
            displayTable.Columns.Add("Стоимость", typeof(decimal));
            displayTable.Columns.Add("Статус", typeof(string));

            // Заполняем данными
            foreach (DataRow row in data.Rows)
            {
                string carName = $"{row["brand"]} {row["model"]}";
                displayTable.Rows.Add(
                    carName,
                    row["state_number"].ToString(),
                    row["start_time"],
                    row["end_time"] == DBNull.Value ? (object)DBNull.Value : row["end_time"],
                    row["total_cost"] == DBNull.Value ? 0 : row["total_cost"],
                    row["rental_status_name"].ToString()
                );
            }

            dgvRentals.DataSource = displayTable;
            SetupGrid(dgvRentals);

            var client = new Client();
            var info = client.GetInfo(_clientId);
            if (info.Rows.Count > 0)
            {
                Text = $"Аренды клиента: {info.Rows[0]["first_name"]} {info.Rows[0]["last_name"]}";
            }
        }

        private void SetupGrid(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Форматирование стоимости
            if (dgv.Columns.Contains("Стоимость"))
            {
                dgv.Columns["Стоимость"].DefaultCellStyle.Format = "N2";
                dgv.Columns["Стоимость"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}