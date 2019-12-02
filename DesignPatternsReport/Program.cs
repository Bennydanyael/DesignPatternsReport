using DesignPatternsReport.Model;
using DesignPatternsReport.ReportProduct;
using System;
using System.Collections.Generic;

namespace DesignPatternsReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var _products = new List<Product>
            {
                new Product { ProductID = 1, ProductName = "Benny", ProductPrice = 3500}
            };

            var _builder = new ProductStockReportBuilder(_products);
            var _director = new ProductStockReportDirector(_builder);
            _director.BuildStockReport();

            var _reports = _builder.GetReport();
            Console.WriteLine(_reports);
            Console.ReadKey();
        }
    }
}
