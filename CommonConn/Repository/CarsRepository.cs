using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Models;


namespace CommonConn.Repository
{
    public class CarsRepository
    {
        private readonly string _connectionString;

        public CarsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public DataTable GetAll()
        {
            string query = @"
                        select CarModelNo,CarCompany,CarName,CarColor,CarFuelType,CarTransmission,CarBodyType,EngineCC,BootSpace from
                          carsinfo.cars
            ";
            DataTable table = new DataTable();
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(_connectionString))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }

            return table;
        }
        public DataTable Add(Carsinfo car)
        {
            string query = @"
                        insert into carsinfo.cars 
                           (CarModelNo,CarCompany,CarName,CarColor,CarFuelType,CarTransmission,CarBodyType,EngineCC,BootSpace) Values
                          (@CarModelNo,@CarCompany,@CarName,@CarColor,@CarFuelType,@CarTransmission,@CarBodyType,@EngineCC,@BootSpace)
            ";
            DataTable table = new DataTable();
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(_connectionString))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {

                    myCommand.Parameters.AddWithValue("@CarModelNo", car.CarModelNo);
                    myCommand.Parameters.AddWithValue("@CarCompany", car.CarCompany);
                    myCommand.Parameters.AddWithValue("@CarName", car.CarName);
                    myCommand.Parameters.AddWithValue("@CarColor", car.CarColor);
                    myCommand.Parameters.AddWithValue("@CarFuelType", car.CarFuelType);
                    myCommand.Parameters.AddWithValue("@CarTransmission", car.CarTransmission);
                    myCommand.Parameters.AddWithValue("@CarBodyType", car.CarBodyType);
                    myCommand.Parameters.AddWithValue("@EngineCC", car.EngineCC);
                    myCommand.Parameters.AddWithValue("@BootSpace", car.BootSpace);


                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }
            return table;
        }

        public DataTable Update(Carsinfo car)
        {
            string query = @"
                            update carsinfo.cars set
                            CarCompany=@CarCompany,
                            CarName=@CarName,
                            CarColor=@CarColor,
                            CarFuelType=@CarFuelType,
                            CarTransmission=@CarTransmission,
                            CarBodyType=@CarBodyType,
                            EngineCC=@EngineCC,
                            BootSpace=@BootSpace
                            where CarModelNo=@CarModelNo;
            ";
            DataTable table = new DataTable();
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(_connectionString))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {

                    myCommand.Parameters.AddWithValue("@CarModelNo", car.CarModelNo);
                    myCommand.Parameters.AddWithValue("@CarCompany", car.CarCompany);
                    myCommand.Parameters.AddWithValue("@CarName", car.CarName);
                    myCommand.Parameters.AddWithValue("@CarColor", car.CarColor);
                    myCommand.Parameters.AddWithValue("@CarFuelType", car.CarFuelType);
                    myCommand.Parameters.AddWithValue("@CarTransmission", car.CarTransmission);
                    myCommand.Parameters.AddWithValue("@CarBodyType", car.CarBodyType);
                    myCommand.Parameters.AddWithValue("@EngineCC", car.EngineCC);
                    myCommand.Parameters.AddWithValue("@BootSpace", car.BootSpace);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }
            return table;
        }
        public DataTable Delete(int id)
        {
            string query = @"
                            delete from carsinfo.cars 
                            where CarModelNo=@CarModelNo;
            ";
            DataTable table = new DataTable();
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(_connectionString))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {

                    myCommand.Parameters.AddWithValue("@CarModelNo", id);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }
            return table;
        }
     }
}
