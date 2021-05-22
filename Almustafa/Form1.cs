using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almustafa
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
             
            InitializeComponent();
           // w.Focus();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (w.Text == "" || k.Text == "" || p.Text == "")
                {
                    MessageBox.Show("Please Fill All Fields !");
                }
                else
                {
                    double a, b = 96, c, rt, z, x, v, n, m;
                    double d = 11.664;
                    a = Convert.ToDouble(w.Text);
                    //a = Convert.ToInt32(w.Text);
                   c = Convert.ToDouble(k.Text);
                    rt = Convert.ToDouble(p.Text);
                    z = (a / b);
                    x = z * c;
                    v = x - a;
                    n = v / d;
                    m = n * rt;
                    op.Text = m.ToString();
                    w.Clear();
                    k.Clear();
                    p.Clear();
                }
            }

            catch
            {
                MessageBox.Show("Invalid Enteries !!");
            }
        


        }
            

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            k.Text = "";
          // w.TabIndex = 0;
            //this.ActiveControl = k;
            k.Select();
            k.Focus(); */
        }

        private void w_KeyDown(object sender, KeyEventArgs e)
        { /*
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();

            } */
        }

        private void cb_Click(object sender, EventArgs e)
        {
            w.Clear();
            k.Clear();
            p.Clear();
            op.Clear();
        }
    }
}
