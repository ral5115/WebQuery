using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebQuery.DAO
{
    public class SQLTransaction
    {
        public static IConfiguration Configuration { get; set; }
        public DataSet GetData()
        {

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            DataSet result = new DataSet();
            Configuration = builder.Build();
            MySqlConnection connection = new MySqlConnection(Configuration.GetConnectionString("DefaultConnection"));
            MySqlCommand command = new MySqlCommand("SELECT * FROM BD_VINCORTE.cache;", connection);
            command.CommandType = CommandType.Text;
            MySqlDataAdapter daData = new MySqlDataAdapter();


            try
            {
                daData.SelectCommand = command;
                daData.Fill(result);
                
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                command.Connection.Close();
            }



            return result;
        }
    }
}
