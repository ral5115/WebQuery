using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebQuery.Models
{
    public class QueryOne
    {

		public int Pedido { get; set; }
		public DateTime Fecha { get; set; }
		public string Cliente_Nit { get; set; }
		public int Cliente_Suc { get; set; }
		public int Cliente { get; set; }		
		public int Co_Id { get; set; }
		public string Centro_Operacion { get; set; }
		public int Bodega_Id { get; set; }
		public string Bodega { get; set; }
		public int Item_Id { get; set; }
		public string Item { get; set; }
		public string Unidad_Pedida { get; set; }
		public float Cantidad_Ped { get; set; }
		public string Estado { get; set; }
		public string Error { get; set; }
		

	}
}
