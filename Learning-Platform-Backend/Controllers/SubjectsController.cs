using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Teaching.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public SubjectsController(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        [HttpGet]

        public JsonResult Get()
        {
            string query = @"SELECT * FROM Subjects";

            DataTable table = new DataTable();

            MySqlDataReader myReader;

            string connection = "server= localhost; Uid=root; password= 6UvPhZr1w9RxhYkX; database=teachingdb; SslMode=none";


            

            using (MySqlConnection myCon = new MySqlConnection(connection))
            {
                myCon.Open();
                using(MySqlCommand cmd = new MySqlCommand(query, myCon))
                {
                    myReader = cmd.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }


            }

            return new JsonResult(table);
        }

        [HttpGet("{id:int}")]

        public JsonResult GetSubject(int id)
        {
            string query = @"SELECT * FROM Subjects WHERE GradeId =" + id;

            DataTable table = new DataTable();

            MySqlDataReader myReader;

            string connection = "server= localhost; Uid=root; password= 6UvPhZr1w9RxhYkX; database=teachingdb; SslMode=none";




            using (MySqlConnection myCon = new MySqlConnection(connection))
            {
                myCon.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, myCon))
                {
                    myReader = cmd.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }


            }

            return new JsonResult(table);
        }
    }
}
