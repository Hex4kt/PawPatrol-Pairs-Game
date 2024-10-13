using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VergleichsSpiel
{
    public partial class Form1 : Form
    {
        Label firstClicked;
        Label secondClicked;

        int timeUsed = 0;
        public Form1()
        {
            InitializeComponent();

            AssignIconsToSquares();

            LabelTimer.Text = timeUsed.ToString();
        }
        // Zufallszahl um später zufällige Objekte zu wählen
        Random random = new Random();

        // erstellt eine Liste mit verschiedenen Buchstaben, die den Bidlern zugewiesen werden
        List<string> icons = new List<string>
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        public void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            { 
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count());
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void LabelClicked(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
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

                CheckForWin();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer1.Start();
            }   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Stop();

            timeUsed += 1;
            LabelTimer.Text = timeUsed.ToString();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWin()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            MessageBox.Show("Du hast gewonnen, herzlichsten Glühstrumpf!!!");
            Close();
        }
    } 
}
