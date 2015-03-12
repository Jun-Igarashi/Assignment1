using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnetCare
{
    public class Package
    {
        public string Description { get; set; }
        public string Life { get; set; }
        public int Value { get; set; }
        public string ExpirationDate { get; set; }
        public string Barcode { get; set; }
        public Status status { get; set; }
        public Boolean Association { get; set; } // If associated to a distribution center

        public enum Status
        {
            InStock,
            Discarded, 
            Lost, 
            Distributed
        }

        public void Package()
        {
            Association = false;
        }

        public void Package(string description, string life, int value, string expirationDate, 
                            string barcode, Status status)
        {
            Description = description;
            Life = life;
            Value = value;
            ExpirationDate = expirationDate;
            Barcode = barcode;
            this.status = status;
        }
    }
}