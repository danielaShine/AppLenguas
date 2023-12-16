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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = "C:/Users/danie/Music/YO-ME-LLAMO.wav";
            Player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = "C:/Users/danie/Music/YA-ME-VOY.wav";
            Player.Play();
        }
    }
}
