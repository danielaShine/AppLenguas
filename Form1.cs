using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLenguas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePane1.Height = button3.Height;
            firstCustomControl11.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePane1.Height = button3.Height;
            SidePane1.Top = button3.Top;
            firstCustomControl11.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePane1.Height = button4.Height;
            mySecondCustmControl1.BringToFront();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePane1.Height = button2.Height;
            myThreeCustomControl1.BringToFront();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SidePane1.Height = button4.Height;
            mySecondCustmControl1.BringToFront();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new frmLogin();
            formulario.Show();
            
        }

        private void myThreeCustomControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
