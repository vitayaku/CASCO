using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASCO
{
    public partial class Form1 : Form
    {
        int price;
        double totalprice;
        string model;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9')||(e.KeyChar == (char)Keys.Back))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                price = Convert.ToInt32(textBox1.Text);
                model = Convert.ToString(comboBox1.SelectedItem);
                switch(model)
                {
                    case "Ford":
                        totalprice = price * 0.1;
                        break;
                    case "BMW":
                        totalprice = price * 0.2;
                        break;
                    case "Toyota":
                        totalprice = price * 0.3;
                        break;
                    case "Renault":
                        totalprice = price * 0.4;
                        break;
                    case "Volkswagen":
                        totalprice = price * 0.5;
                        break;
                }
                label3.Text = "Стоимость КАСКО составит " + totalprice;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Выберите марку и цену авто.", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
