using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebQuery.Models
{
    public class QueryOne
    {

		public string Pedido { get; set; }
		public string Fecha { get; set; }
		public string Cliente_Nit { get; set; }
		public string Cliente_Suc { get; set; }
		public string Cliente { get; set; }		
		public string Co_Id { get; set; }
		public string Centro_Operacion { get; set; }
		public string Bodega_Id { get; set; }
		public string Bodega { get; set; }
		public int Item_Id { get; set; }
		public string Item { get; set; }
		public string Unidad_Pedida { get; set; }
		public float Cantidad_Ped { get; set; }
		public string Estado { get; set; }
		public string Error { get; set; }
		

	}
}
