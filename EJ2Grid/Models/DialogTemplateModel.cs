using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EJ2Grid.Models
{
    public class DialogTemplateModel
    {
        public long OrderID { get; set; }
        public string CustomerID { get; set; }
        public string Copicker { get; set; }
        public int EmployeeID { get; set; }
        public double Freight { get; set; }
        public string ShipCity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}