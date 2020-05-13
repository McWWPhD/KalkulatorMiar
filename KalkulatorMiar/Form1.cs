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

                switch (lbOptions.SelectedIndex)
                {
                    case 0:
                        txtValue.Text = string.Format("{0:#.00} фунт", conversion.KgToFunt(value));
                        break;

                    case 1:
                        txtValue.Text = string.Format("{0:#.00} Kg", conversion.FuntToKg(value));
                        break;

                    case 2:
                        txtValue.Text = string.Format("{0:#.00} °F", conversion.CelToFah(value));
                        break;

                    case 3:
                        txtValue.Text = string.Format("{0:#.00} °C", conversion.FahToCel(value));
                        break;

                    case 4:
                        txtValue.Text = string.Format("{0:#.00} Kts/h", conversion.KmHToKts(value));
                        break;

                    case 5:
                        txtValue.Text = string.Format("{0:#.00} Km/h", conversion.KtsToKmH(value));
                        break;

                    default:
                        break;
                }


            }


        }
    }
}
