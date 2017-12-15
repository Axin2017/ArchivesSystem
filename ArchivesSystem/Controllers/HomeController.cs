using Archives.Common.Tools;
using Archives.Data;
using Archives.IData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArchivesSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DBFactory.RegisterDataBaseType(DataBaseType.Oracle,typeof(OracleOBOprator),WebConfigTools.GetConnectString("DYWMIS4"),true);
            IDBOprator db = DBFactory.GetDBOprator();
            DataSet ds = db.SelectDsBySql("select * from wfcaseinfo where caseid='BM00126947'");
            if (DataTools.DsIsNotNull(ds))
            {
                string caseid = ds.Tables[0].Rows[0]["CASEID"].ToString();
            }
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