using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsReport.ReportProduct
{
    public class ProductStockReportDirector
    {
        private readonly IProductStockReportBuilder _productStockReportBuilder;

        public ProductStockReportDirector(IProductStockReportBuilder productStockReportBuilder)
        {
            _productStockReportBuilder = productStockReportBuilder;
        }

        public void BuildStockReport()
        {
            _productStockReportBuilder
                .BuildHeader()
                .BuildBody()
                .BuildFooter();
        }
    }
}
