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

namespace ZavrsniRad
{
    public partial class ZoomForm : Form
    {
        public ZoomForm(Chart chart)
        {
            InitializeComponent();
            chart1.Series.Clear();
            foreach (Series series in chart.Series)
                chart1.Series.Add(series);
            chart.ChartAreas[0].AxisY.IsStartedFromZero = false;
        }
    }
}
