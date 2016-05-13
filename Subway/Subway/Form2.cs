using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subway
{
    public partial class Form2 : Form
    {
        string s;

        public Form2(string mys)
        {
            s = mys;
           
           

            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = s;
            this.DoubleBuffered = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubwayOrder o = new SubwayOrder();
            o.notifycustomer(1);

            this.Close();
            
        }

   
    }
}
