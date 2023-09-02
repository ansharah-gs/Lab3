using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public partial class Customer
    {
       
        static Random randomNumberGenerator = new Random();

        public Customer(string first, string last)
        {
            FirstName = first;
            LastName = last;
            //to generate new  random account no
            //Random randomNumberGenerator = new Random();
            int aRandomAccountNo = randomNumberGenerator.Next(1000, 10000);
            AccountNumber = aRandomAccountNo;
            
        }
        
        public Customer(int accountno, string first, string last)
        {
            this.FirstName = first;
            LastName = last;
            AccountNumber = accountno;
        }
       
        //blank constructor
        public Customer()
        {
            FirstName = "";
            LastName = "";
            AccountNumber = 0;

        }


    }

}
