using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.OleDb;
using ConnectRMDDb.Entities;
using Dapper;

namespace ConnectRMDDb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\RMS\RMS-RTA600-V3.45.mdb");
            List<Employee> emp = conn.Query<Employee>("Select * From p_person").ToList();
            List<DCReader> dcr = conn.Query<DCReader>("Select * From citac").ToList();
            List<ReaderCode> readerCode = conn.Query<ReaderCode>("Select * From OpisCitaci").ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}