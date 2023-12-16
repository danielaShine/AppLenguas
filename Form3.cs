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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "C:/Users/madi_/Music/tortillaS.wav";
            Player.SoundLocation = "C:/Users/danie/Music/TORTILLA.wav";

            Player.Play();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = "C:/Users/Mari Cruz/Music/FRIJOL.wav";
            Player.Play();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = "C:/Users/danie/Music/FRIJOL.wav";
            Player.Play();
        }
    }
}
