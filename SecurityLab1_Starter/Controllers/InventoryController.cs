using SecurityLab1_Starter.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityLab1_Starter.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index()
        {
             throw new DivideByZeroException();
            //return View();
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
 //adad
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry("Log message example", EventLogEntryType.Error, 102, 1);
            }
            filterContext.Result = RedirectToAction("Error", "ServerError");

            LogUtil log = new LogUtil();

            using (StreamWriter w = System.IO.File.AppendText("C:\\temp\\log.txt"))
            {
                log.LogToFile("Test1", w);
            }

            throw new NotImplementedException();

        }
    }
}