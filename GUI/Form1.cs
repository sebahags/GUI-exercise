using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI : Form
    {
        bool bColourChange = true;
        public GUI()
        {
            InitializeComponent();
            panelCalendar.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sName = nameBox.Text;
            labelGreeting.Text = "Hello " + sName + "!";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you wan't to close this program?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelCalendar_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelCalendar.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panelCalendar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime birthday = new DateTime();
            DateTime today = new DateTime();
            
            birthday = monthCalendar1.SelectionRange.Start.Date;
            today = DateTime.Now.Date;
            int oldDays = (today - birthday).Days;

            labelAgeOutput.Text = "You are " + oldDays + " days old.";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            string sInput1 = textBoxOperand1.Text;
            string sInput2 = textBoxOperand2.Text;
            string sOperand1 = "";
            string sOperand2 = "";
            
            if (sInput1.Contains(".") || sInput2.Contains("."))
            {
                sOperand1 = sInput1.Replace(".", ",");
                sOperand2 = sInput2.Replace(".", ",");
            }
            else
            {
                sOperand1 = sInput1;
                sOperand2 = sInput2;
            }
            Double dOperand1 = Convert.ToDouble(sOperand1);
            Double dOperand2 = Convert.ToDouble(sOperand2);
            Double result = dOperand1 * dOperand2;

            labelMathOutput.Text = "The result is: " + result;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string sInput1 = textBoxOperand1.Text;
            string sInput2 = textBoxOperand2.Text;
            string sOperand1 = "";
            string sOperand2 = "";

            if (sInput1.Contains(".") || sInput2.Contains("."))
            {
                sOperand1 = sInput1.Replace(".", ",");
                sOperand2 = sInput2.Replace(".", ",");
            }
            else
            {
                sOperand1 = sInput1;
                sOperand2 = sInput2;
            }
            Double dOperand1 = Convert.ToDouble(sOperand1);
            Double dOperand2 = Convert.ToDouble(sOperand2);
            Double result = dOperand1 + dOperand2;

            labelMathOutput.Text = "The result is: " + result;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            string sInput1 = textBoxOperand1.Text;
            string sInput2 = textBoxOperand2.Text;
            string sOperand1 = "";
            string sOperand2 = "";

            if (sInput1.Contains(".") || sInput2.Contains("."))
            {
                sOperand1 = sInput1.Replace(".", ",");
                sOperand2 = sInput2.Replace(".", ",");
            }
            else
            {
                sOperand1 = sInput1;
                sOperand2 = sInput2;
            }
            Double dOperand1 = Convert.ToDouble(sOperand1);
            Double dOperand2 = Convert.ToDouble(sOperand2);
            Double result = dOperand1 - dOperand2;

            labelMathOutput.Text = "The result is: " + result;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            string sInput1 = textBoxOperand1.Text;
            string sInput2 = textBoxOperand2.Text;
            string sOperand1 = "";
            string sOperand2 = "";

            if (sInput1.Contains(".") || sInput2.Contains("."))
            {
                sOperand1 = sInput1.Replace(".", ",");
                sOperand2 = sInput2.Replace(".", ",");
            }
            else
            {
                sOperand1 = sInput1;
                sOperand2 = sInput2;
            }
            Double dOperand1 = Convert.ToDouble(sOperand1);
            Double dOperand2 = Convert.ToDouble(sOperand2);

            if (dOperand2 == 0)
            {
                labelMathOutput.Text = "Please don't try to divide by zero,\n the matrix might glitch.";
            }
            else
            {
                Double result = dOperand1 / dOperand2;
                labelMathOutput.Text = "The result is: " + result;
            }
            
        }

        private void buttonPercentage_Click(object sender, EventArgs e)
        {
            string sInput1 = textBoxOperand1.Text;
            string sInput2 = textBoxOperand2.Text;
            string sOperand1 = "";
            string sOperand2 = "";

            if (sInput1.Contains(".") || sInput2.Contains("."))
            {
                sOperand1 = sInput1.Replace(".", ",");
                sOperand2 = sInput2.Replace(".", ",");
            }
            else
            {
                sOperand1 = sInput1;
                sOperand2 = sInput2;
            }

            Double dOperand1 = Convert.ToDouble(sOperand1);
            Double dOperand2 = Convert.ToDouble(sOperand2);

            if (dOperand2 == 0)
            {
                labelMathOutput.Text = "Please don't try to divide by zero,\n the matrix might glitch.";
            }
            else
            {
                Double result = (dOperand1 / dOperand2) * 100;
                labelMathOutput.Text = "The result is: " + result + "%";
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sSentence = textBoxSentence.Text;
            int iCharacters = 0;

            foreach (char c in sSentence)
            {
                iCharacters++;

                if (c == ' ' || c == ',' || c == '.' || c == '!' || c == '?' || c == '-' || c == '_' || c == ';' || c == ':')
                {
                    iCharacters--;
                } 
            }

            labelCharsOutput.Text = "Your sentence has " + iCharacters + " characters";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bColourChange == true)
            {
                bColourChange = false;
                panelColourChange.BackColor = Color.Blue;
            }
            else
            {
                bColourChange = true;
                panelColourChange.BackColor = Color.Red;
            }
        }
    }
}
