using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public partial class Invoice
    {
        public decimal CalculateBill()
        {
            //formula 12+0.07*usedkwh
            decimal kwhRate = 0.07m;
            //usedkwh is class attribute so no need to pass as parameter
            decimal administrativeCharge = 12m;
            InvoiceTotal = administrativeCharge + kwhRate * PowerUsage;
            return InvoiceTotal;
        }
        public Invoice()
        {
        }
        public Invoice(int accno,decimal usedkwh)
        {
            this.PowerUsage = usedkwh;
            InvoiceTotal = CalculateBill();
            DateTime date = DateTime.Now;
            DateTime dateonly = date.Date;
            InvoiceDate = dateonly;
            AccountNumber = accno;
        }

        public string GetBillAmount()
        {
            return $"Your bill is: ${InvoiceTotal: 0.00}";
        }
        
        public void date()
        {
            DateTime date= DateTime.Now;
            DateTime dateonly= date.Date;
        }
    }
}
