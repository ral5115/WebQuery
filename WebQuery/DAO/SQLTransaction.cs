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
		                                                ped.FT_0004 AS 'Cliente_Nit',
		                                                ped.FT_0005 AS 'Cliente_Suc',
                                                       cli.ft_0005 AS 'Cliente',
	                                                   ped.ft_0007 AS 'Co_Id',
	                                                   co.ft_0002 'Centro_Operacion',
		                                                 ped.ft_0008 AS 'Bodega_Id',
		                                                 bod.ft_0003 AS 'Bodega',
		                                                 ped.ft_0011 AS 'Item_Id',
		                                                 itm.ft_0003 AS 'Item',
		                                                 ped.ft_0014 AS 'Unidad_Pedida',
		                                                 ped.ft_0015 AS 'Cantidad_Ped',
		                                                 ped.ft_0038 AS 'Estado',
                                                       err.ft_0005 AS 'Error'
                                                FROM BD_VINCORTE.UNCC_00021 ped
                                                INNER JOIN BD_VINCORTE.UNCC_00001 cli ON cli.ft_0001 = ped.ft_0004 AND cli.ft_0002 = ped.ft_0005
                                                INNER JOIN BD_VINCORTE.UNCC_00002 bod ON bod.ft_0001 = ped.ft_0007 AND bod.ft_0002 = ped.ft_0008
                                                INNER JOIN BD_VINCORTE.UNCC_00007 co ON co.ft_0001 = ped.ft_0007
                                                INNER JOIN BD_VINCORTE.UNCC_00023 err ON err.ft_0001 = ped.FT_0001
                                                INNER JOIN BD_VINCORTE.UNCC_00003 itm ON itm.ft_0001 = ped.ft_0011
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
