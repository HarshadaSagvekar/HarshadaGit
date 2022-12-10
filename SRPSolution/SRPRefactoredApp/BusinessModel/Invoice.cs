using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactoredApp.BusinessModel
{
    internal class Invoice
    {
        public double _amount;
        private double _discountPercent;
        private string _discription;

        public Invoice(double amount,string discription,double discountPercent)
        {
            _amount = amount;
            _discription = discription;
            _discountPercent = discountPercent;
        }

        public double discount
        {
            get
            {
                return _amount * _discountPercent / 100;
            }
            
        }

        public double Tax
         {
            get
            {
                return _amount * 0.10;
            }
        }

        public double Total
        {
            get
            {
                return _amount - discount + Tax;
            }
            
        }
    }
}
