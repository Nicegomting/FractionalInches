using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionalInches
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            teMM.Text       = "";
            teInch.Text     = "-";
            teFraction.Text = "-";
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void sbConvert_Click(object sender, EventArgs e)
        {
            teInch.Text     = "-";
            teFraction.Text = "-";
            // 790 mm (31.1024 in) = 31-1/8
            // 548 mm (21.5748 in) = 21-9/16
            // 913 mm (35.9449 in) = 35-15/16
            string mm = teMM.Text;
            
            if (String.IsNullOrEmpty(mm) || String.IsNullOrWhiteSpace(mm))
                return;

            var regex = new Regex(@"^-?[0-9][0-9,\.]+$");
            if (!regex.IsMatch(mm))
                return;

            try
            {
                double millimeter = Convert.ToDouble(mm);
                double inch = millimeter / 25.4;
                string fraction = DoubleExtension.ToInchFraction(inch, 16);
                teInch.Text = inch.ToString("0.0000");
                teFraction.Text = fraction;
            }
            catch
            {
                return;
            }
        }
    }
}
