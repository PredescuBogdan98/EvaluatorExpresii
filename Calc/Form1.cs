using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        string []vector = new string[51];
        int ct = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox_R.Text == "0") textBox_R.Clear();
            Button button = (Button)sender;
            textBox_R.Text = textBox_R.Text + button.Text;
            
        }

       

        private void button25_Click(object sender, EventArgs e)
        {
            textBox_R.Text = "0";
        }

       public void button6_Click(object sender, EventArgs e)
        {
         
           fp r = new fp();
           textBox4.Text = r.FP(textBox_R.Text);

         Solution p=new Solution();
         textBox6.Text = p.EvalRPN(r.transform(textBox_R.Text)).ToString();

           Transformari m = new Binar(textBox6.Text);
           if (!textBox6.Text.Contains(","))
           textBox3.Text = m.TR().ToString();

           Transformari n = new Hexa(textBox6.Text);
           if (!textBox6.Text.Contains(","))
           textBox2.Text = n.TR().ToString();
           
                vector[++ct] = textBox_R.Text + "=" + textBox6.Text;
            textBox5.Text = vector[ct];
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if(textBox_R.Text.Length>0) textBox_R.Text=textBox_R.Text.Substring(0, textBox_R.Text.Length - 1);
        }

        public void button29_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "UP")
            {
                if (ct != 0)
                {
                    ct--;
                    textBox5.Text = vector[ct];
                }
            }
            if (button.Text == "DOWN")
            {
                ct++;
                if (ct < vector.Length)
                    textBox5.Text = vector[ct];
            }
            
        }
    }
}
