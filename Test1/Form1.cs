using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test2.Form2 f2 = new Test2.Form2();
            f2.TopLevel = false; 
            f2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Controls.Add(f2);
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.Show();

        }

    
    }
}
