using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tapsiriq___1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string emeliyyat ;
        int firstnumber;
        int secondnumber;
        private void button_ce_Click(object sender, EventArgs e)
        {
            label_ekran.Text = "0";
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            
            if (label_ekran.Text == "0")

                label_ekran.Text = "1";
            else label_ekran.Text += "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
    
            if (label_ekran.Text == "0") label_ekran.Text = "2";
            else label_ekran.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {

            if ( label_ekran.Text == "0") label_ekran.Text = "3";
            else label_ekran.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
           
            if ( label_ekran.Text == "0") label_ekran.Text = "4";
            else label_ekran.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
       
            if ( label_ekran.Text == "0") label_ekran.Text = "5";
            else label_ekran.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
    
            if ( label_ekran.Text == "0") label_ekran.Text = "6";
            else label_ekran.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if ( label_ekran.Text == "0") label_ekran.Text = "7";
            else label_ekran.Text += "7";
        }
        private void button_8_Click_1(object sender, EventArgs e)
        {

            if ( label_ekran.Text == "0") label_ekran.Text = "8";
            else label_ekran.Text += "8";
        }
        private void button_9_Click(object sender, EventArgs e)
        {
  
            if ( label_ekran.Text == "0") label_ekran.Text = "9";
            else label_ekran.Text += "9";
        }

        private void button_0_Click(object sender, EventArgs e)
        {

            if ( label_ekran.Text == "0") label_ekran.Text = "0";
            else label_ekran.Text += "0";
        }

        private void button_bolbire_Click(object sender, EventArgs e)
        {
            double number = int.Parse(label_ekran.Text);
            label_ekran.Text = (1 / number).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number = int.Parse(label_ekran.Text);
            label_ekran.Text = (Math.Sqrt(number)).ToString();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            emeliyyat = "+";
            firstnumber = int.Parse(label_ekran.Text);

            label_ekran.Text += "+";

        }

        private void button_beraber_Click(object sender, EventArgs e)
        {
            if (emeliyyat != null)
            {
                secondnumber = int.Parse(label_ekran.Text);
                if (emeliyyat == "+")
                {
                    label_ekran.Text = "0";
                    label_ekran.Text = (firstnumber + secondnumber).ToString();

                }
                else if (emeliyyat == "-")
                {
                    label_ekran.Text = "0";
                    label_ekran.Text = (firstnumber - secondnumber).ToString();

                }
                else if (emeliyyat == "*")
                {
                    label_ekran.Text = "0";
                    label_ekran.Text = (firstnumber * secondnumber).ToString();

                }
                else if (emeliyyat == "/")
                {
                    if (secondnumber == 0)
                    {
                        label_ekran.Text = "Xeta";
       
                    }
                    else
                    {
                        label_ekran.Text = "0";
                        label_ekran.Text = (firstnumber / secondnumber).ToString();
                    }
     

                }
                else if (emeliyyat == "^")
                {
                    label_ekran.Text = "0";
                 
                    label_ekran.Text = (Math.Pow(firstnumber,secondnumber)).ToString();

                }
            }
            
            emeliyyat = null;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            emeliyyat = "-";
            firstnumber = int.Parse(label_ekran.Text);

   
            label_ekran.Text = "0";

        }

        private void button_vur_Click(object sender, EventArgs e)
        {
            emeliyyat = "*";
            firstnumber = int.Parse(label_ekran.Text);

            label_ekran.Text = "0";

        }

        private void button_bolme_Click(object sender, EventArgs e)
        {
            emeliyyat = "/";
            firstnumber = int.Parse(label_ekran.Text);

            label_ekran.Text = "0";

        }

        private void button_kvadrat_Click(object sender, EventArgs e)
        {
            emeliyyat = "^";
            firstnumber = int.Parse(label_ekran.Text);

            label_ekran.Text = "0";


        }
        private void button_plusminus_Click(object sender, EventArgs e)
        {
            double number = int.Parse(label_ekran.Text);
            label_ekran.Text = (number*(-1)).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label_ekran.Text != null &&  label_ekran.Text!="0")
            {
                string number = (label_ekran.Text);
                label_ekran.Text = (number.Remove(number.Length - 1)).ToString();
            }

        }

        private void button_vergul_Click(object sender, EventArgs e)
        {
            string number = (label_ekran.Text);

            if (number[number.Length - 1]!=',') label_ekran.Text += ",";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label_ekran.Text = "0";
        }

        private void button_faiz_Click(object sender, EventArgs e)
        {
            double number = int.Parse(label_ekran.Text);
            label_ekran.Text = (number /100).ToString();
        }

    }
}
