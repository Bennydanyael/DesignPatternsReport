using DesignPatternsReport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsReport.ReportProduct
{
    public class ProductStockReportBuilder : IProductStockReportBuilder
    {
        private ProductStockReport _productStockReport;
        private IEnumerable<Product> _products;

        public ProductStockReportBuilder(IEnumerable<Product> products)
        {
            _products = products;
            _productStockReport = new ProductStockReport();
        }

        public IProductStockReportBuilder BuildHeader()
        {
            _productStockReport.HeaderPart = $"STOCK REPORT FOR ALL THE PRODUCTS ON DATE: {DateTime.Now}\n";
            return this;
        }

        public IProductStockReportBuilder BuildBody()
        {
            _productStockReport.BodyPart = string.Join(Environment.NewLine, _products.Select(_p => $"Product Name : {_p.ProductName}, Product Price : {_p.ProductPrice}"));
            return this;
        }

        public IProductStockReportBuilder BuildFooter()
        {
            _productStockReport.FooterPart = "\nReport provide by the IT_Products Company";
            return this;
        }

        public ProductStockReport GetReport()
        {
            var _productStockReports = _productStockReport;
            Clear();
            return _productStockReports;
        }

        private void Clear() => _productStockReport = new ProductStockReport();
    }
}
