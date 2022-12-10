using SRPRefactoredApp.BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactoredApp.ReportService
{
    internal class InvoiceConsoleReport
    {
        Invoice _invoice;
        public InvoiceConsoleReport(Invoice invoice) {
            _invoice = invoice;
        }

        public StringBuilder formattedOutput()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Decription : " + _invoice._discription);
            sb.Append("Amount : " + _invoice._amount);
            sb.Append("\nTax : " + _invoice.Tax);
            sb.Append("\nDiscount : " + _invoice.discount);
            sb.Append("\nTotal : " + _invoice.Total);

            return sb;


        }

        public void GenerateInvoice()
        {
            StringBuilder sb = formattedOutput();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(sb);
           
            Console.ResetColor();
            
        }
    }
}
