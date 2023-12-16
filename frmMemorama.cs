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
    public partial class frmMemorama : Form
    {
        
        int cont = 0;


        // Use this Random object to choose random icons for the squares
        Random random = new Random();

      
        List<string> icons = new List<string>()
    {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
    };

        Label firstClicked, secondClicked;

        public frmMemorama()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }
        private void AssignIconsToSquares()
        {
            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    // iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel == null)
                return;
            if (clickedLabel.ForeColor == Color.Black)
                return;
            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;


            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;
            CheckForWinner();
            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
                timer1.Start();
            cont++;
        }
        private void CheckForWinner()
        {
            Label label;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;
                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }


            MessageBox.Show("Felicidades, has completado el juego", "Congratulations");
            MessageBox.Show("La cantidad de intentos fue:" + cont);

            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = firstClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMemorama_Load(object sender, EventArgs e)
        {

        }

    }
}
