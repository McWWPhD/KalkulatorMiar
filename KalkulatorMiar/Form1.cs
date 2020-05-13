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
        Conversion conversion = new Conversion();

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
                    txtValue.Text = string.Format("{0:#.00} фунт", conversion.KgToFunt(value));
                    return;
                }
                else if (lbOptions.SelectedIndex == 1 && numInput.Value > 0)
                {                    
                    txtValue.Text = string.Format("{0:#.00} Kg", conversion.FuntToKg(value));
                    return;
                }

                else if (lbOptions.SelectedIndex == 2)
                {
                    txtValue.Text = string.Format("{0:#.00} °F", conversion.CelToFah(value));
                    return;
                }

                else if (lbOptions.SelectedIndex == 3)
                {
                    txtValue.Text = string.Format("{0:#.00} °C", conversion.FahToCel(value));
                    return;
                }

                else if (lbOptions.SelectedIndex == 4 && numInput.Value > 0)
                {
                    txtValue.Text = string.Format("{0:#.00} Kts/h", conversion.KmHToKts(value));
                    return;
                }

                else if (lbOptions.SelectedIndex == 5 && numInput.Value > 0)
                {
                    txtValue.Text = string.Format("{0:#.00} Km/h", conversion.KtsToKmH(value));
                    return;
                }

            }


            


        }
    }
}
