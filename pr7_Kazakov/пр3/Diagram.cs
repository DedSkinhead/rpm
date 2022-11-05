using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace пр3
{
    public partial class Diagram : Form
    {
        public Diagram()
        {
            Transfer.callbackEventHandler = new Transfer.callbackEvent(this.TransferDiag);
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void TransferDiag(string[] name, string[] price) //Объявление функции и получение значений
        {
            double[] num = new double[name.Length]; //Объявление массива чисел
            for (int i = 0; i < name.Length; i++)   //Цикл конвертирования значений из string в double
            {
                num[i] = Convert.ToDouble(price[i]);
            }
            chart1.Series.Add("Товар");		//Добавление названия в 1 диаграмму
            for (int i = 0; i < name.Length; i++) //Цикл внесения значений в 1 диаграмму
            {
                chart1.Series["Товар"].Points.AddXY(name[i], price[i]); //Внесение имени и цены
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)); //Создание случайного цвета
                chart1.Series["Товар"].Points[i].Color = randomColor; //Присваивание случайного цвета
            }

            chart2.Series.Add(new Series("Товар") //Изменение отображения диаграммы на круговую
            {
                ChartType = SeriesChartType.Pie
            });
            chart2.Series["Товар"].Points.DataBindXY(name, num); //Внесение значений в 2 диаграмму
        }
        private Random rnd = new Random();
    }
}
