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
        double t = 0;
        double a = 1;
        double b = 0;
        double c = 1;
        double re;
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
            b = 0;
            c = 1;
            result = 0;
            label1.Text = t1.Text;
            label2.Text = t1.Text;
            label3.Text = t1.Text;
            t1.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string de = "";
            de = t1.Text + de;
            de = de.Remove(de.Length-1);
            t1.Text = de + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double d;
            d = result;
            t1.Text = d + "";
        }

        private void button_Click(object sender, EventArgs e)
        {
           
            
            try
            {
                Button btn = (Button)sender;

                num1 = Double.Parse(t1.Text);
                //label1.Text = t1.Text;
                num2 = Double.Parse(t1.Text);
                
      
                if (btn.Text=="+")
                {
                    option = "+";
                    label2.Text = "+";
                    label3.Text = "";
                    t1.Text = "";
                    if (result <1)
                    {
                        t = t + num1;
                        string s = "";
                        s = s + t;
                        label1.Text = s;

                    }
                   else
                   {
                        t = 0;
                        re = result;
                        label1.Text = re + "";
                    }

                }
                if (btn.Text == "×")
                {
                    option= "×";
                    label2.Text = "×";
                    t1.Text = "";
                    label3.Text = "";
                    if (result < 1)
                    {
                        a = a * num1;
                        string s = "";
                        s = s + a;
                        label1.Text = s;

                    }
                    else
                    {
                        a = 0;
                        re = result;
                        label1.Text = re + "";
                    }
                }
                if (btn.Text == "−")
                {
                    option = "−"; 
                    label2.Text = "−";
                    t1.Text = "";
                    label3.Text = "";
                    if (result < 1)
                    {
                        
                        b = num1 - b;
                        string s = "";
                        s = b + s;
                        label1.Text = s;
                       
                    }
                    else
                    {

                        b = 0;
                        re = result;
                        label1.Text = re + "";
                    }
                }
                if (btn.Text == "÷")
                {
                    option= "÷"; 
                    label2.Text = "÷";
                    t1.Text = "";
                    label3.Text = "";
                    if (result < 1)
                    {
                        c = num1 / c;
                        string s = "";
                        s = s + c;
                        label1.Text = s;
                    }
                    else
                    {
                        c = 0;
                        re = result;
                        label1.Text = re + "";
                    }
                }
                if (btn.Text == "%")
                {
                    option = "%";
                    result = num1/100;
                    t1.Text = result + "";
                }

                if (btn.Text == "=")
                {
                    label3.Text = t1.Text;

                    
                    if (option=="+")
                    {
                        if (t > 0)
                        {
                            result = t + num2;
                        }
                        else
                        {
                            result = re + num2;
                        }
                    }
                    if (option == "×")
                    {
                        
                        if (a > 1)
                        {
                            result = a * num2;
                        }
                        else
                        {
                            result = re * num2;
                        }

                    }
                    if (option == "−")
                    {
                        
                        if (b > 0)
                        {
                            result = b - num2;
                        }
                        else
                        {
                            result = re - num2;
                        }
                    }
                    if (option == "÷")
                    {
                        if (c > 1)
                        {
                            result = c / num2;
                        }
                        else
                        {
                            result = re / num2;
                        }
                    }
                    

                    t1.Text = result + "";

                }
                
                

            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Input+" + "\n" + "[C]      :Cancel");
            }
        }
        
      

        

      

            

       
    }
}
