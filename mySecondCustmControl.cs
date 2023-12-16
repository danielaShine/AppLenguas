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
    public partial class mySecondCustmControl : UserControl
    {
        public mySecondCustmControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();

            //SidePane1.Height = button4.Height;
            // mySecondCustmControl1.BringToFront();
        }
    }
}
