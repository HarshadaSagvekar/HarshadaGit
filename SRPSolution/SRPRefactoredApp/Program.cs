// See https://aka.ms/new-console-template for more information
using SRPRefactoredApp.BusinessModel;
using SRPRefactoredApp.ReportService;

Console.WriteLine("Hello, World!");
Invoice invoice = new Invoice(200, "Food Invoice", 20);

InvoiceConsoleReport invoiceConsole = new InvoiceConsoleReport(invoice);

invoiceConsole.GenerateInvoice();
Console.WriteLine("End Of Project");

Console.ReadLine();