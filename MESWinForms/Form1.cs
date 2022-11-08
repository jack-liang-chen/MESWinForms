using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var sig1 = formsPlot1.Plot.AddSignal(DataGen.Sin(51));
            sig1.Label = "Sin";

            var legend = formsPlot1.Plot.Legend();
            legend.FontSize = 24;

            formsPlot1.Refresh();
        }
    }
}
