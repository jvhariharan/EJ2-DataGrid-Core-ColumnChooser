using EJ2Grid.Models;
using Syncfusion.EJ2.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2Grid.Controllers
{
    public class HomeController : Controller
    {
        public static List<Orders> order = new List<Orders>();
        public static List<DropDownData> dropdata = new List<DropDownData>();


        public ActionResult Index()
        {
            if (order.Count == 0)
                BindDataSource();
            if (dropdata.Count == 0)
                DropDownData.GetDropData();
            ViewBag.datasource = order;
            ViewBag.dropData = dropdata;
            return View();
        }
        private void BindDataSource()
        { 
            for (var i = 0; i< 100; i++)
            {
                order.Add(new Orders(10248+i, "035a", 1, 2.3, new DateTime(1991, 05, 15), "Denmark", "ALFKI"));
                order.Add(new Orders(10249+i, "035a", 2, 3.3, new DateTime(2017, 08, 11), "Brazil", "VINET"));
                order.Add(new Orders(10250+i, "035a", 3, 4.3, new DateTime(1957, 11, 30), "Germany", "TOMSP"));
                order.Add(new Orders(10251+i, "035a", 4, 5.3, new DateTime(2019, 11, 11), "Austria", "HANAR"));
                order.Add(new Orders(10252+i, "035a", 5, 6.3, new DateTime(1953, 02, 18), "Switzerland", "VICTE"));
            }
        }
        public class Orders
        {
            public Orders()
            {

            }
            public Orders(long OrderId, string Copicker, int EmployeeId, double Freight, DateTime? OrderDate, string ShipCounty, string CustomerID)
            {
                this.OrderID = OrderId;
                this.Copicker = Copicker;
                this.EmployeeID = EmployeeId;
                this.Freight = Freight;
                this.OrderDate = OrderDate;
                this.ShipCountry = ShipCounty;
                this.CustomerID = CustomerID;
            }
            public long OrderID { get; set; }
            public string Copicker { get; set; }
            public int EmployeeID { get; set; }
            public double Freight { get; set; }
            public DateTime? OrderDate { get; set; }
            public string ShipCountry { get; set; }
            public string CustomerID { get; set; }
        }
        public class DropDownData
        {
            public int ID { get; set; }
            public string ShipCountry { get; set; }
            public DropDownData()
            {

            }
            public DropDownData(int id, string shipCountry)
            {
                this.ID = id;
                this.ShipCountry = shipCountry;
            }

            public static List<DropDownData> GetDropData()
            {
                if (dropdata.Count() == 0)
                {
                    dropdata.Add(new DropDownData(1, "Denmark"));
                    dropdata.Add(new DropDownData(2, "Brazil"));
                    dropdata.Add(new DropDownData(3, "Germany"));
                    dropdata.Add(new DropDownData(4, "Austria"));
                    dropdata.Add(new DropDownData(5, "Switzerland"));
                }
                return dropdata;

            }
        }
    }
}