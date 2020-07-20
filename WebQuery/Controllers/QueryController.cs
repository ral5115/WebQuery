using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebQuery.DAO;
using WebQuery.Models;

namespace WebQuery.Controllers
{
    public class QueryController : Controller
    {
        SQLTransaction db;
        DataSet data;
        List<QueryOne> listData;

        public QueryController()
        {
            db = new SQLTransaction();
            data = db.GetData();
            listData = new List<QueryOne>();
            foreach (DataRow item in data.Tables[0].Rows)
            {
                listData.Add(new QueryOne
                {
                    Pedido = item["Pedido"].ToString(),
                    Fecha = item["Fecha"].ToString(),
                    Cliente_Nit = item["Cliente_Nit"].ToString(),
                    Cliente_Suc = item["Cliente_Suc"].ToString(),
                    Cliente = item["Cliente"].ToString(),
                    Co_Id = item["Co_Id"].ToString(),
                    Centro_Operacion = item["Centro_Operacion"].ToString(),
                    Bodega_Id = item["Bodega_Id"].ToString(),
                    Bodega = item["Bodega"].ToString(),
                    Item_Id = Convert.ToInt32(item["Item_Id"]),
                    Item = item["Item"].ToString(),
                    Unidad_Pedida = item["Unidad_Pedida"].ToString(),
                    Cantidad_Ped = Convert.ToInt32(item["Cantidad_Ped"]),
                    Estado = item["Estado"].ToString(),
                    Error = item["Error"].ToString()
                });
            }
        }
        public  IActionResult Index(string sortOrder,string currentFilter,string searchString, int? page)
        {
            ViewData["NombreSortParm"] = String.IsNullOrEmpty(sortOrder) ? "nombre_desc" : "";
            ViewData["DescripcionSortParm"] = sortOrder == "descripcion_asc" ? "descripcion_desc" : "descripcion_asc";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;
            ViewData["CurrentSort"] = sortOrder;
            

            //db = new SQLTransaction();
            //data = db.GetData();
            //List<QueryOne> listData = new List<QueryOne>();
            //foreach (DataRow item in data.Tables[0].Rows)
            //{
            //    listData.Add(new QueryOne
            //    {
            //        Pedido =item["Pedido"].ToString(),
            //        Fecha=item["Fecha"].ToString(),
            //        Cliente_Nit= item["Cliente_Nit"].ToString(),
            //        Cliente_Suc= item["Cliente_Suc"].ToString(),
            //        Cliente= item["Cliente"].ToString(),
            //        Co_Id= item["Co_Id"].ToString(),
            //        Centro_Operacion= item["Centro_Operacion"].ToString(),
            //        Bodega_Id = item["Bodega_Id"].ToString(),
            //        Bodega= item["Bodega"].ToString(),
            //        Item_Id = Convert.ToInt32(item["Item_Id"]),
            //        Item = item["Item"].ToString(),
            //        Unidad_Pedida=item["Unidad_Pedida"].ToString(),
            //        Cantidad_Ped = Convert.ToInt32(item["Cantidad_Ped"]),
            //        Estado=item["Estado"].ToString(),
            //        Error = item["Error"].ToString()
            //    }); 
            //}

            var querys = from s in listData select s;
            ViewData["Data"] = querys;
            if (!String.IsNullOrEmpty(searchString))
            {
                querys = querys.Where(s => s.Cliente.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "nombre_desc":
                    querys = querys.OrderByDescending(s => s.Pedido);
                    break;
                default:
                    querys = querys.OrderBy(s => s.Pedido);
                    break;
            }

            var queryfinal = querys.AsQueryable();
            int pageSize = 20;
            return View( Pag<QueryOne>.CreateAsync(queryfinal, page ?? 1,pageSize));

        }

        
    }
}