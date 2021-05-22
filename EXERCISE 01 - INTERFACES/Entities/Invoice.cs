using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities {
    //------------------------------- START -------------------------------//
    class Invoice {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
    //-------------------------------- CONST -------------------------------//
        public Invoice(double basicPayment, double tax) {
            BasicPayment = basicPayment;
            Tax = tax;
        }
    //-------------------------------- MET -------------------------------//
        public double TotalPayment {
            get { return BasicPayment + Tax; }
        }
        public override string ToString() {
            return "Basic payment: " + BasicPayment.ToString("F2") + "\nTax: " + Tax.ToString("F2") + "\nTotal payment: " + TotalPayment.ToString("F2");
        }
    }
    //-------------------------------- END -------------------------------//
}
