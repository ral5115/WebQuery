using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebQuery.DAO;
using WebQuery.Models;

namespace WebQuery.Controllers
{
    public class QueryController : Controller
    {
        SQLTransaction db;
        DataSet data;
        public IActionResult Index()
        {
            db = new SQLTransaction();
            data = db.GetData();
            List<QueryOne> listData = new List<QueryOne>();
            foreach (DataRow item in data.Tables[0].Rows)
            {
                listData.Add(new QueryOne
                {
                    Pedido =Convert.ToInt32(item["Pedido"]),
                    Fecha=Convert.ToDateTime(item["Fecha"]),
                    Cliente_Nit= item["Cliente_Nit"].ToString(),
                    Cliente_Suc= Convert.ToInt32(item["Cliente_Suc"]),
                    Cliente= Convert.ToInt32(item["Cliente"]),
                    Co_Id= Convert.ToInt32(item["Co_Id"]),
                    Centro_Operacion= item["Centro_Operacion"].ToString(),
                    Bodega_Id = Convert.ToInt32(item["Bodega_Id"]),
                    Bodega= item["Bodega"].ToString(),
                    Item_Id = Convert.ToInt32(item["Item_Id"]),
                    Item = item["Item"].ToString(),
                    Unidad_Pedida=item["Unidad_Pedida"].ToString(),
                    Cantidad_Ped = Convert.ToInt32(item["Cantidad_Ped"]),
                    Estado=item["Estado"].ToString(),
                    Error = item["Error"].ToString()
                }); ; ;
            }
            return View(listData);

        }
    }
}