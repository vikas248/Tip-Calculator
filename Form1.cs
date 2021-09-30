using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tip_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double charges, people, tip, tipperson, total;
            
            try
            {
                
                charges = double.Parse(textBoxCharges.Text);
                Type tp1 = textBoxCharges.Text.GetType();
                tip = double.Parse(textBoxTip.Text);
                Type tp2 = textBoxTip.Text.GetType();
                people = double.Parse(textBoxPeople.Text);
                Type tp3 = textBoxPeople.Text.GetType();
                if (people <= 0.0 )
                {
                    textBoxPeople.Text = "Enter valid number >=1";
                    textBoxPeople.ForeColor = Color.Red;
                    label7.Text = "None";
                    labelBox2.Text = "None";

                }
                else
                {
                    label8.Text = "Results are";
                    label8.ForeColor = Color.OrangeRed;
                    tipperson = (charges * tip / 100.0);
                    total = (charges + tipperson) / people;
                    label7.Text = (tipperson / people).ToString();
                    labelBox2.Text = total.ToString();
                    label7.Text = (tipperson / people).ToString();
                    labelBox2.Text = total.ToString();
                }

            }
            catch (FormatException)
            {

                //textBoxCharges.Text = "please enter only numbers";
                //textBoxCharges.ForeColor = Color.Red;
                textBoxCharges.Text = "0.0";
                    textBoxPeople.Text = "0.0";
                    textBoxTip.Text = "0.0";

                label8.Text = "Reset and Enter correct data";
                label8.ForeColor = Color.RosyBrown;


            }
            catch (Exception ex)
            {
                label7.Text = ex.GetType() + ":" + ex.Message;
            }




        }

        private void textBoxTip_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBoxCharges.Text = "";
            
            textBoxTip.Text = "";
            textBoxPeople.Text = "";
            label7.Text = "0.0";
            labelBox2.Text = "0.0";
            label8.Text= "Enter Bill,Tip and People";
            textBoxPeople.ForeColor = Color.Black;


        }

        private void textBoxCharges_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
