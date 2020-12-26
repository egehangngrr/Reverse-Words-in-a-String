using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reverse_Words_in_a_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void btnReverse_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtInput.Text))
                {
                    txtOutput.Text = reverseWords(txtInput.Text);
                }
                else
                {
                    MessageBox.Show("Input Can Not Be Empty !");
                }
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                MessageBox.Show("Warning!!! Error Message :  " + errMsg);
            }
        }

        public string reverseWords(string input)
        {
            string outPut = "";

            try
            {
                string[] wordArray = input.Split(' ');

                foreach (var word in wordArray.Reverse())
                {
                    outPut += word + " ";
                }

                txtOutput.Text = outPut.Trim();
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
                MessageBox.Show("Warning !!! " + errMsg);
            }

            return outPut.Trim();
        }
    }
}
