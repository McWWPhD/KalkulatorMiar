using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorMiar
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void lbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(numInput.Value);


            if (lbOptions.SelectedIndex > -1)
            {
                if (lbOptions.SelectedIndex == 0 && numInput.Value > 0)
                {
                    txtValue.Text = string.Format("{0:#.00} фунт", Conversion.KgToFunt(value));
                    return;
                }
                else if (lbOptions.SelectedIndex == 1 && numInput.Value > 0)
                {                    
                    txtValue.Text = string.Format("{0:#.00} Kg", Conversion.FuntToKg(value));
                    return;
                }

                else if (lbOptions.SelectedIndex == 2)
                {
                    txtValue.Text = string.Format("{0:#.00} °F", Conversion.CelToFah(value));
                    return;
                }

                else if (lbOptions.SelectedIndex == 3)
                {
                    txtValue.Text = string.Format("{0:#.00} °C", Conversion.FahToCel(value));
                    return;
                }

                else if (lbOptions.SelectedIndex == 4 && numInput.Value > 0)
                {
                    txtValue.Text = string.Format("{0:#.00} Kts/h", Conversion.KmHToKts(value));
                    return;
                }

                else if (lbOptions.SelectedIndex == 5 && numInput.Value > 0)
                {
                    txtValue.Text = string.Format("{0:#.00} Km/h", Conversion.KtsToKmH(value));
                    return;
                }

            }          


        }
    }
}
