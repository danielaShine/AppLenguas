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
    public partial class frmLogin : Form
    {
        frmEntrada logeo; 
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((txtusuario.Text != "") && (txtpassword.Text != ""))
            {
                if ((txtusuario.Text == "Administrador") && (txtpassword.Text == "pass"))
                {
                    logeo = new frmEntrada();
                    logeo.ShowDialog();
                    this.Hide();
                }
            }
        }
    }
}
