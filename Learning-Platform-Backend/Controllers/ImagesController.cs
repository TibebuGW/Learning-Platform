using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Teaching.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ImagesController(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        [HttpGet]

        public JsonResult Get()
        {
            string query = @"SELECT * FROM images";

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
