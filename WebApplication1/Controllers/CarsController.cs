using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public CarsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]

        public JsonResult Get()
        {
            CarsRepository carsRepository = new CarsRepository(_configuration.GetConnectionString("Carsconn"));

            var table = carsRepository.GetAll();
            //string query = @"
            //            select CarModelNo,CarCompany,CarName,CarColor,CarFuelType,CarTransmission,CarBodyType from
            //              carsinfo.cars
            //";
            //DataTable table = new DataTable();
            //string sqlDataSource = _configuration.GetConnectionString("Carsconn");
            //MySqlDataReader myReader;
            //using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            //{
            //    mycon.Open();
            //    using(MySqlCommand myCommand=new MySqlCommand(query,mycon))
            //    {
            //        myReader = myCommand.ExecuteReader();
            //        table.Load(myReader);

            //        myReader.Close();
            //        mycon.Close();
            //    }
            //}
            return new JsonResult(table);
        }
        [HttpPost]

        public JsonResult Post(Carsinfo car)
        {
            CarsRepository carsRepository = new CarsRepository(_configuration.GetConnectionString("Carsconn"));

            var table = carsRepository.Add(car);
            //string query = @"
            //            insert into carsinfo.cars 
            //               (CarModelNo,CarCompany,CarName,CarColor,CarFuelType,CarTransmission,CarBodyType) Values
            //              (@CarModelNo,@CarCompany,@CarName,@CarColor,@CarFuelType,@CarTransmission,@CarBodyType)
            //";
            //DataTable table = new DataTable();
            //string sqlDataSource = _configuration.GetConnectionString("Carsconn");
            //MySqlDataReader myReader;
            //using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            //{
            //    mycon.Open();
            //    using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
            //    {

            //        myCommand.Parameters.AddWithValue("@CarModelNo", car.CarModelNo);
            //        myCommand.Parameters.AddWithValue("@CarCompany", car.CarCompany);
            //        myCommand.Parameters.AddWithValue("@CarName", car.CarName);
            //        myCommand.Parameters.AddWithValue("@CarColor", car.CarColor);
            //        myCommand.Parameters.AddWithValue("@CarFuelType", car.CarFuelType);
            //        myCommand.Parameters.AddWithValue("@CarTransmission", car.CarTransmission);
            //        myCommand.Parameters.AddWithValue("@CarBodyType", car.CarBodyType);


            //        myReader = myCommand.ExecuteReader();
            //        table.Load(myReader);

            //        myReader.Close();
            //        mycon.Close();
            //    }
            //}
            return new JsonResult("Added Successfully");
        }

        [HttpPut]
        public JsonResult Put(Carsinfo car)
        {
             CarsRepository carsRepository = new CarsRepository(_configuration.GetConnectionString("Carsconn"));

            var table = carsRepository.Update(car);
            //string query = @"
            //                update carsinfo.cars set
            //                CarCompany=@CarCompany,
            //                CarName=@CarName,
            //                CarColor=@CarColor,
            //                CarFuelType=@CarFuelType,
            //                CarTransmission=@CarTransmission,
            //                CarBodyType=@CarBodyType
            //                where CarModelNo=@CarModelNo;
            //";
            //DataTable table = new DataTable();
            //string sqlDataSource = _configuration.GetConnectionString("Carsconn");
            //MySqlDataReader myReader;
            //using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            //{
            //    mycon.Open();
            //    using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
            //    {

            //        myCommand.Parameters.AddWithValue("@CarModelNo", car.CarModelNo);
            //        myCommand.Parameters.AddWithValue("@CarCompany", car.CarCompany);
            //        myCommand.Parameters.AddWithValue("@CarName", car.CarName);
            //        myCommand.Parameters.AddWithValue("@CarColor", car.CarColor);
            //        myCommand.Parameters.AddWithValue("@CarFuelType", car.CarFuelType);
            //        myCommand.Parameters.AddWithValue("@CarTransmission", car.CarTransmission);
            //        myCommand.Parameters.AddWithValue("@CarBodyType", car.CarBodyType);
            //        myReader = myCommand.ExecuteReader();
            //        table.Load(myReader);

            //        myReader.Close();
            //        mycon.Close();
            //    }
            //}
            return new JsonResult("Updated Successfully");
        }
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            CarsRepository carsRepository = new CarsRepository(_configuration.GetConnectionString("Carsconn"));

            var table = carsRepository.Delete(id);
            //string query = @"
            //                delete from carsinfo.cars 
            //                where CarModelNo=@CarModelNo;
            //";
            //DataTable table = new DataTable();
            //string sqlDataSource = _configuration.GetConnectionString("Carsconn");
            //MySqlDataReader myReader;
            //using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            //{
            //    mycon.Open();
            //    using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
            //    {

            //        myCommand.Parameters.AddWithValue("@CarModelNo", id);

            //        myReader = myCommand.ExecuteReader();
            //        table.Load(myReader);

            //        myReader.Close();
            //        mycon.Close();
            //    }
            //}
            return new JsonResult("Deleted Successfully");
        }
    }
}
