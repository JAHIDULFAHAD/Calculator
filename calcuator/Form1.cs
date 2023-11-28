using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcuator
{
    public partial class Form1 : Form
    {
        String option;
        double num1, num2;
        double result;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnNum_click(Object sender,EventArgs e)
        {
            if(t1.Text =="0")
            {
                t1.Clear();

            }
            Button btn = (Button)sender;
            
            if (btn.Text == "." && t1.Text.Contains("."))
                return;
            t1.Text += btn.Text;

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            //int t1 = Int32.Parse(text1.Text);
          //  int t2 = Int32.Parse(text1.Text);
        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            t1.Clear();
            t = 0;
            a = 1;
            label1.Text = t1.Text;
            label2.Text = t1.Text;
            label3.Text = t1.Text;
            t1.Text = "0";
        }
        double t = 0;
        double a = 1;
        double b = 0;
        double c = 1;
        private void button_Click(object sender, EventArgs e)
        {
           
            
            try
            {
                Button btn = (Button)sender;

                if (btn.Text == "." && t1.Text.Contains("."))
                    return;
                t1.Text += btn.Text;

                num1 = Double.Parse(t1.Text);
                //label1.Text = t1.Text;
                num2 = Double.Parse(t1.Text);
                label3.Text = t1.Text;
      
                if (btn.Text=="+")
                {
                    label2.Text = "+";
                    t = t + num1;
                    string s = "";
                    s = s + t;
                    label1.Text = s;
                    t1.Text = "";
                }
                if (btn.Text == "×")
                {
                    label2.Text = "×";
                    a = a * num1;
                    string s = "";
                    s = s + a;
                    label1.Text = s;
                    t1.Text = "";
                }
                if (btn.Text == "−")
                {
                    label2.Text = "−";
                    b = num1 - b;
                    string s = "";
                    s = b + s;
                    label1.Text = s;
                    t1.Text = "";
                }
                if (btn.Text == "÷")
                {
                    label2.Text = "÷";
                    c = num1 / c;
                    string s = "";
                    s =  s +c ;
                    label1.Text = s;
                    t1.Text = "";
                }
                if (btn.Text == "=")
                {
                    result = t + num2;
                    result = a * num2;
                    result = b - num2;
                    result = c / num2;
                }
                t1.Text = result + "";

            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Input+" + "\n" + "[C]      :Cancel");
            }
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        

      

            

       
    }
}
