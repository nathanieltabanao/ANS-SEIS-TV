using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace ANS_SEIS_TV
{
    public partial class TopUser : Form
    {
        public TopUser()
        {
            InitializeComponent();

            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Current",
                    Values = new ChartValues<double> { 10, 50, 39, 50 }
                }
            };

            

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Borrower",
                Labels = new[] { "Maria", "Susan", "Charles", "Frida" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Borrowed Equipments",
                LabelFormatter = value => value.ToString("N")
            });

        }
    }
}
