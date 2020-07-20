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
            MySqlCommand command = new MySqlCommand(@"SELECT ped.FT_0001 AS 'Pedido',
                                                        ped.ft_0006 AS 'Fecha',
                                                        ped.FT_0004 AS 'Cliente Nit.',
                                                        ped.FT_0005 AS 'Cliente Suc.',
                                                       cli.ft_0005 AS 'Cliente',
                                                       ped.ft_0007 AS 'C.O. Id.',
                                                       co.ft_0002 'Centro Operacion',
                                                         ped.ft_0008 AS 'Bodega Id.',
                                                         bod.ft_0003 AS 'Bodega',
                                                         ped.ft_0011 AS 'Item Id.',
                                                         itm.ft_0003 AS 'Item',
                                                         ped.ft_0014 AS 'Unidad Pedida',
                                                         ped.ft_0015 AS 'Cantidad Ped.',
                                                         ped.ft_0038 AS 'Estado',
                                                       err.ft_0005 AS 'Error'
                                                FROM UNCC_00021 ped
                                                INNER JOIN UNCC_00001 cli ON cli.ft_0001 = ped.ft_0004 AND cli.ft_0002 = ped.ft_0005
                                                INNER JOIN UNCC_00002 bod ON bod.ft_0001 = ped.ft_0007 AND bod.ft_0002 = ped.ft_0008
                                                INNER JOIN UNCC_00007 co ON co.ft_0001 = ped.ft_0007
                                                INNER JOIN UNCC_00023 err ON err.ft_0001 = ped.FT_0001
                                                INNER JOIN UNCC_00003 itm ON itm.ft_0001 = ped.ft_0011
                                                WHERE FT_0038 = '2' AND ped.ft_0006 >= '20200601'", connection);
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
