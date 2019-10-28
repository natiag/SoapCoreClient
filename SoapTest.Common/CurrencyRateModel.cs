using System;

namespace SoapTest.Common
{
    public class CurrencyRateModel
    {
        public string Code { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public string Name { get; set; }
        public decimal Diff { get; set; }
        public DateTime Date { get; set; }
        public DateTime ValidFromDate { get; set; }
    }
}
