using Carsharing.Services;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Carsharing.Classes
{
    public class Car
    {
        public int IdCar { get; set; }
        public string StateNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal PricePerMinute { get; set; }
        public int FuelTypeId { get; set; }
        public int ColorId { get; set; }
        public int StatusId { get; set; }
        public int? CurrentParkingId { get; set; }


        public void AddCar(string stateNumber, string brand, string model, int year, decimal pricePerMinute, int fuelTypeId, int colorId, int? parkingId = null)
        {
            using(var db = new DBService())
            {
                var parameters = new NpgsqlParameter[]
                    {
                    new NpgsqlParameter("p_state_number", stateNumber),
                    new NpgsqlParameter("p_brand", brand),
                    new NpgsqlParameter("p_model", model),
                    new NpgsqlParameter("p_year", year),
                    new NpgsqlParameter("p_price_per_minute", pricePerMinute),
                    new NpgsqlParameter("p_fuel_type_id", fuelTypeId),
                    new NpgsqlParameter("p_color_id", colorId),
                    new NpgsqlParameter("p_parking_id", parkingId ?? (object)DBNull.Value),
                    };

                db.ExecuteFunction("add_car", parameters);
            }
        }


        public void UpdateCar(int idCar, string stateNumber, string brand, string model, int year, decimal pricePerMinute, int fuelTypeId, int colorId, int? parkingId = null)
        {
            using (var db = new DBService())
            {
                var parameters = new NpgsqlParameter[]
                    {
                    new NpgsqlParameter("p_car_id", idCar),
                    new NpgsqlParameter("p_state_number", stateNumber),
                    new NpgsqlParameter("p_brand", brand),
                    new NpgsqlParameter("p_model", model),
                    new NpgsqlParameter("p_year", year),
                    new NpgsqlParameter("p_price_per_minute", pricePerMinute),
                    new NpgsqlParameter("p_fuel_type_id", fuelTypeId),
                    new NpgsqlParameter("p_color_id", colorId),
                    new NpgsqlParameter("p_parking_id", parkingId ?? (object)DBNull.Value),
                    };

                db.ExecuteFunction("update_car", parameters);
            }
        }
       

        public void DeleteCar( int idCar)
        {
            using (var db = new DBService())
            {
                var parameters = new NpgsqlParameter[]
                    {
                    new NpgsqlParameter("p_car_id", idCar),
                    };

                db.ExecuteFunction("delete_car", parameters);
            }
        }


       

        public DataTable GetModelsByBrand(string brand)
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery(
                    "SELECT * FROM get_models_by_brand(@p_brand)",
                    new NpgsqlParameter("p_brand", brand));
            }
        }

        public DataTable GetAllCars()
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery("SELECT * FROM cars_info ORDER BY brand, model");
            }
        }


        public DataTable GetCarInfo(int idCar)
        {
            using (var db = new DBService())
            {

                return db.ExecuteQuery("SELECT * FROM get_car_info(@p_car_id)",
                new NpgsqlParameter("p_car_id", idCar));
            }
        }

       

        public int GetOrAddColor(string colorName)
        {
            using (var db = new DBService())
            {
                var result = db.ExecuteQuery(
                    "SELECT id_car_color FROM car_color WHERE car_color_name = @p_name",
                    new NpgsqlParameter("p_name", colorName));

                if (result.Rows.Count > 0)
                {
                    return Convert.ToInt32(result.Rows[0][0]);
                }

                var id = db.ExecuteScalar(
                    "INSERT INTO car_color (car_color_name) VALUES (@p_name) RETURNING id_car_color",
                    new NpgsqlParameter("p_name", colorName));

                return Convert.ToInt32(id);
            }
        }


        public DataTable GetAllFuelTypes()
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery("SELECT id_fuel_type, fuel_type_name FROM car_fuel_type ORDER BY fuel_type_name");
            }
        }


        public DataTable GetAllStatuses()
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery("SELECT id_car_status, car_status_name FROM Car_status ORDER BY car_status_name");
            }
        }


        public DataTable GetAllColors()
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery("SELECT id_car_color, car_color_name FROM car_color ORDER BY car_color_name");
            }
        }


        public DataTable GetAllBrands()
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery("SELECT DISTINCT brand FROM car ORDER BY brand");
            }
        }


        public DataTable GetAllModels()
        {
            using (var db = new DBService())
            {
                return db.ExecuteQuery("SELECT DISTINCT model FROM car ORDER BY model");
            }
        }
    }
}
