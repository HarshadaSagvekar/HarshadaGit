
// See https://aka.ms/new-console-template for more information
using SRPViolationApp.BusinessModel;

Console.WriteLine("Hello, World!");

Invoice invoice = new Invoice(amount: 200,discription:"Book Invoice",discountPercent:20);

invoice.GenerateInvoice();

