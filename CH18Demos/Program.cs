﻿using ConsoleLibrary;

namespace CH18Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to LINQ demo!\n");

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumberQuery = from number in numbers
                                  where number % 2 == 0
                                  orderby number descending
                                  select number;

            string evenNumbers = "";
            foreach (var nbr in evenNumberQuery) {
                evenNumbers += nbr + " ";
            }
            MyConsole.PrintLine(evenNumbers);

            // p. 583 
            decimal[] salesTotals = { 1286.45m, 2433.49m, 2893.85m, 2094.53m };
            var salesList = from sales in salesTotals
                            select sales;
            decimal sum = 0;
            foreach (var sales in salesTotals) {
                sum += sales;
            }
            MyConsole.PrintLine("sales = " + sum.ToString("c"));

            //p 583. invoice ist
            List<Invoice> invoicesList = InvoiceDB.GetInvoices();
            // foreach (var invoice in invoicesList) {
            //     MyConsole.PrintLine(invoice.ToString());
            // }
            var invoices = from invoice in invoicesList
                           select invoice;
            foreach (var invoice in invoicesList) {
                MyConsole.PrintLine(invoice.ToString());
            }

            // p. 585
            salesList = from sales in salesTotals
                        where sales > 2000
                        select sales;
            string salesDisplay = "";
            foreach (var sales in salesList)
                salesDisplay += sales.ToString("c") + "|";
            MyConsole.PrintLine(salesDisplay);

            MyConsole.PrintLine("---- Invoices with totals over $150 ----");
            invoices = from invoice in invoicesList
                       where invoice.InvoiceTotal > 150
                       select invoice;
            string invoiceDisplay = "";
            foreach (var invoice in invoices) {
                invoiceDisplay += invoice.InvoiceTotal.ToString("c") + "|";
            }
            MyConsole.PrintLine(invoiceDisplay);

            MyConsole.PrintLine("==== join in LINQ ====");
            List<Customer>  customersList = CustomerDB.GetCustomers();

            //join
            var invoices2 = from invoice in invoicesList
                            join customer in customersList
                            on invoice.CustomerID equals customer.CustomerID
                            where invoice.InvoiceTotal > 150
                            orderby customer.Name, invoice.InvoiceTotal descending
                            select new { customer.Name, invoice.InvoiceTotal };
            invoiceDisplay = "Customer Name\t\tInvoice Amount\n";
            foreach (var invoice in invoices2) {
                invoiceDisplay += invoice.Name + "\t\t" + invoice.InvoiceTotal.ToString("C") + "\n";
            }
            MyConsole.PrintLine(invoiceDisplay);

            // p. 593 - extension methods
            // list of invoices totals > 150 ordereb by customerid, then by invoiceTotal (desc)

            var invoices3 = invoicesList.
                Where(i => i.InvoiceTotal > 150).
                OrderBy(I => I.CustomerID).
                ThenByDescending(i => i.InvoiceTotal).
                Select(i => new { i.CustomerID, i.InvoiceTotal });

            foreach (var i in invoices3) {
                MyConsole.PrintLine($"{i.CustomerID}, {i.InvoiceTotal}");
            }


            MyConsole.PrintLine("\nBye");
        }
    }
}
