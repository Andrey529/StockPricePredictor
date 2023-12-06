using System;
using System.Collections.Generic;
using System.Drawing;

namespace DataMining
{
    public class GraphicsMaker
    {
        public static void DrawStockGraph(List<Stock> stocks)
        {
            int width = 800;
            int height = 600;
            Bitmap plotBitmap = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(plotBitmap))
            {
                // Очистка картинки
                g.Clear(Color.White);

                // Определение максимального значения open
                double maxOpen = double.MinValue;
                foreach (var stock in stocks)
                {
                    maxOpen = Math.Max(maxOpen, stock.open);
                }

                // Рисование осей координат
                Pen axisPen = new Pen(Color.Black);
                g.DrawLine(axisPen, 50, height - 50, 50, 50); // Ось Y
                g.DrawLine(axisPen, 50, height - 50, width - 50, height - 50); // Ось X

                // Рисование значений по оси Y
                Font font = new Font("Arial", 8);
                Brush brush = new SolidBrush(Color.Black);
                int numTicks = 5;
                for (int i = 0; i <= numTicks; i++)
                {
                    double value = maxOpen / numTicks * i;
                    int y = height - 50 - (int)((value / maxOpen) * (height - 100));
                    g.DrawLine(axisPen, 45, y, 50, y);
                    g.DrawString(value.ToString("F2"), font, brush, 10, y - 7);
                }

                // Рисование графика
                Pen plotPen = new Pen(Color.Blue);
                double xStep = (double)(width - 100) / stocks.Count;
                for (int i = 0; i < stocks.Count - 1; i++)
                {
                    int x1 = 50 + (int)(xStep * i);
                    int x2 = 50 + (int)(xStep * (i + 1));
                    int y1 = height - 50 - (int)((stocks[i].open / maxOpen) * (height - 100));
                    int y2 = height - 50 - (int)((stocks[i + 1].open / maxOpen) * (height - 100));
                    g.DrawLine(plotPen, x1, y1, x2, y2);
                }
            }

            GraphicForm graphicForm = new GraphicForm(plotBitmap);
            graphicForm.Show();
        }
    }
}
