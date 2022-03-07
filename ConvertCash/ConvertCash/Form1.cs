using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertCash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lbl_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /* USD
         GEL
         RUR
         JPY
         CNY*/

        private void button1_Click(object sender, EventArgs e)
        {
            int Amount = int.Parse(textBox1.Text);
            double gelTOusd = Convert.ToDouble(textBox1.Text) * 0.34;
            double gelTOrur = Convert.ToDouble(textBox1.Text) * 25.88;
            double gelTOjpy = Convert.ToDouble(textBox1.Text) * 38.53;
            double gelTOcny = Convert.ToDouble(textBox1.Text) * 2.12;

            double usdTOgel = Convert.ToDouble(textBox1.Text) * 2.95;
            double usdTOrur = Convert.ToDouble(textBox1.Text) * 77.16;
            double usdTOjpy = Convert.ToDouble(textBox1.Text) * 114.89;
            double usdTOcny = Convert.ToDouble(textBox1.Text) * 6.33;

            double rurTOusd = Convert.ToDouble(textBox1.Text) * 0.013;
            double rurTOgel = Convert.ToDouble(textBox1.Text) * 0.038;
            double rurTOjpy = Convert.ToDouble(textBox1.Text) * 1.48;
            double rurTOcny = Convert.ToDouble(textBox1.Text) * 0.082;

            double jpyTOusd = Convert.ToDouble(textBox1.Text) * 0.0087;
            double jpyTOgel = Convert.ToDouble(textBox1.Text) * 0.026;
            double jpyTOrur = Convert.ToDouble(textBox1.Text) * 0.67;
            double jpyTOcny = Convert.ToDouble(textBox1.Text) * 0.055;
            if (comboBox1.SelectedItem == "GEL")
            {
                if (comboBox2.SelectedItem == "USD")
                {
                    string message = gelTOusd + " USD";
                    MessageBox.Show(message);
                }
                if (comboBox2.SelectedItem == "RUR")
                {
                    string message = gelTOrur + " RUR";
                    MessageBox.Show(message);
                }
                if (comboBox2.SelectedItem == "JPY")
                {
                    string message = gelTOjpy + " JPY";
                    MessageBox.Show(message);
                }
                if (comboBox2.SelectedItem == "CNY")
                {
                    string message = gelTOcny + " CNY";
                    MessageBox.Show(message);
                }
            }
            if (comboBox1.SelectedItem == "USD")
            {
                if (comboBox2.SelectedItem == "GEL")
                {
                    string message = usdTOgel + " GEL";
                    MessageBox.Show(message);
                }
                if (comboBox2.SelectedItem == "RUR")
                {
                    string message = usdTOrur + " RUR";
                    MessageBox.Show(message);
                }
                if (comboBox2.SelectedItem == "JPY")
                {
                    string message = usdTOjpy + " JPY";
                    MessageBox.Show(message);
                }
                if (comboBox2.SelectedItem == "CNY")
                {
                    string message = usdTOcny + " CNY";
                    MessageBox.Show(message);
                }
            }
            if (comboBox1.SelectedItem == "RUR")
            {
                if (comboBox2.SelectedItem == "USD")
                {
                    string message = rurTOusd + " USD";
                    MessageBox.Show(message);
                }
                if (comboBox2.SelectedItem == "GEL")
                {
                    string message = rurTOgel + " GEL";
                    MessageBox.Show(message);
                }
                if (comboBox2.SelectedItem == "JPY")
                {
                    string message = rurTOjpy + " JPY";
                    MessageBox.Show(message);
                }
                if (comboBox2.SelectedItem == "CNY")
                {
                    string message = rurTOcny + " CNY";
                    MessageBox.Show(message);
                }
            }
            if (comboBox1.SelectedItem == "JPY")
            {
                if (comboBox2.SelectedItem == "USD")
                {
                    string message = jpyTOusd + " USD";
                    MessageBox.Show(message);
                }
                if (comboBox2.SelectedItem == "RUR")
                {
                    string message = jpyTOrur + " RUR";
                    MessageBox.Show(message);
                }
                if (comboBox2.SelectedItem == "GEL")
                {
                    string message = jpyTOgel + " GEL";
                    MessageBox.Show(message);

                }
                if (comboBox2.SelectedItem == "CNY")
                {
                    string message = jpyTOcny + " CNY";
                    MessageBox.Show(message);
                }
            }
        }
    }
}


