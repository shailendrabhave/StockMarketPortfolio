using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketPortfolio.Core.Entities
{
    public class Transaction:EntityBase
    {
        public int TransactionNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public string StockName {  get; set; } = string.Empty;
        public char TransactionMode { get; set; }
        public int Quantity {  get; set; }
        public double Rate {  get; set; }
    }
}
