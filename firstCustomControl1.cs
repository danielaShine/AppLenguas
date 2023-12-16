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
    public partial class firstCustomControl1 : UserControl
    {
        public firstCustomControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
        }

        private void btnMemorama_Click(object sender, EventArgs e)
        {
            //Form formulario = new frmMemorama();
            //formulario.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new frmMemorama();
            formulario.Show();
        }
    }
}
