using System;
using System.Collections.Generic;
using System.Text;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Comission { get; set; }
        public decimal PaymentDue { get; set; }

        public Vendor()
        {
            Comission = .2;
        }

        public string Display
        {
            get
            {
                return string.Format("{0} - {1} - {2}", FirstName, LastName, PaymentDue.ToString("c"));
            }
        }

    }
}
