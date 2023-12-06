using System;

namespace DataMining
{
    public class Stock
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public double open { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double close { get; set; }
        public int volume { get; set; }

        public override string ToString()
        {
            return $"ID: {id}, Date: {date}, Open: {open}, High: {high}, Low: {low}, Close: {close}, Volume: {volume}";
        }
    }
}
