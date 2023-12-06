using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string filePath_ = "D:\\leti\\7sem\\Artificial intelligence\\Data mining\\DataMining\\DataMining\\Resources\\yandex_1day.csv";

        private void buttonPredict_Click(object sender, EventArgs e)
        {
            StockPricePredictor stockPricePredictor = new StockPricePredictor(filePath_, int.Parse(percentFromInputDataTextBox.Text));

            int countPredictedDays = int.Parse(countPredictedDaysTextBox.Text);

            var predictedData = stockPricePredictor.Predict(countPredictedDays);
            
            GraphicsMaker.DrawStockGraph(predictedData);
        }

        private void buttonShowAllInputData_Click(object sender, EventArgs e)
        {
            var data = FileReader.ReadData(filePath_, int.Parse(percentFromInputDataTextBox.Text));

            GraphicsMaker.DrawStockGraph(data);
        }
    }
}
