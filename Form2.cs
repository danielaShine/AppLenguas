using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace AppLenguas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = "C:/Users/danie/Music/HOLA.wav";
            Player.Play();

        

        }

        //private void button3_Click(object sender, EventArgs e)
        //     Versión de runtime:4.0.30319.42000
        //Q@autor mari cruz



        //}

        private void button3_Click_1(object sender, EventArgs e)
        {
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = "C:/Users/danie/Music/COMO-ESTAS.wav";
            Player.Play();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new Form4();
            formulario.Show();
        }
    }
}
