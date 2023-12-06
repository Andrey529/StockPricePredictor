using System;
using System.Collections.Generic;

namespace DataMining
{
    public class StockPricePredictor
    {
        private string filePath_;

        private List<Stock> data_;

        public double Intercept { get; private set; }
        public double Slope { get; private set; }

        public StockPricePredictor(string filePath, int percentFromInputData)
        {
            this.filePath_ = filePath;
        
            this.data_ = FileReader.ReadData(filePath_,percentFromInputData);
        }

        public List<Stock> Predict(int countDays)
        {
            List<Stock> predictedData = new List<Stock>(data_);

            Random random = new Random();
            for (int i = 0; i < countDays; i++)
            {
                Train(predictedData);

                DateTime futureDate = predictedData[predictedData.Count - 1].date.AddDays(i + 1);
                double predictedPrice = Intercept + Slope * futureDate.Ticks;
                predictedPrice += (random.NextDouble() - 0.5) * 10;


                Stock predictedStock = new Stock
                {
                    id = predictedData.Count + 1,
                    date = futureDate,
                    open = predictedPrice ,
                };

                predictedData.RemoveAt(0);
                predictedData.Add(predictedStock);
            }

            for (int i = 0; i < data_.Count - countDays; i++)
            {
                predictedData.RemoveAt(0);
            }

            List<Stock> result = new List<Stock>(data_);
            result.AddRange(predictedData);

            return result;
        }

        private void Train(List<Stock> stocks)
        {
            double sumX = 0, sumY = 0, sumXY = 0, sumXSquare = 0;
            int n = stocks.Count;

            for (int i = 0; i < stocks.Count; i++)
            {
                sumX += stocks[i].date.Ticks;
                sumY += stocks[i].open;
                sumXY += stocks[i].date.Ticks * stocks[i].open;
                sumXSquare += stocks[i].date.Ticks * stocks[i].date.Ticks;
            }

            double meanX = sumX / n;
            double meanY = sumY / n;

            Slope = (sumXY - (sumX * sumY) / n) / (sumXSquare - (sumX * sumX) / n);
            Intercept = meanY - Slope * meanX;
        }

        public override string ToString()
        {
            string result = "";

            foreach (var stock in data_)
            {
                result += stock.ToString() + '\n';
            }

            return result;
        }
    }
}
