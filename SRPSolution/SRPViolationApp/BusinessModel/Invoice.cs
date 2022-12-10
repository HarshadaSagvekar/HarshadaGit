using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolationApp.BusinessModel
{
    internal class Invoice
    {
        private double _amount;
        private double _discountPercent;
        private string _discription;

        public Invoice(double amount,string discription,double discountPercent)
        {
            _amount = amount;
            _discription = discription;
            _discountPercent = discountPercent;
        }

        private double discount
        {
            get
            {
                return _amount * _discountPercent / 100;
            }
            
        }

        private double Tax
         {
            get
            {
                return _amount * 0.10;
            }
        }

        private double Total
        {
            get
            {
                return _amount - discount + Tax;
            }
            
        }

        public void GenerateInvoice()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Amount : " + _amount);
            sb.Append("\nTax : " + Tax);
            sb.Append("\nDiscount : " + discount);
            sb.Append("\nTotal : " + Total);

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
