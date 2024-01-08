using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBKR_Algo
{
    internal class fiveMinOHLC
    {
        public string Time { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public decimal Volume { get; set; }
        public decimal WAP { get; set; }
        public fiveMinOHLC(string time, double open, double high, double low, double close, decimal volume, decimal wap)
        {
            Time = time;
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Volume = volume;
            WAP = wap;
        }
    }
}
