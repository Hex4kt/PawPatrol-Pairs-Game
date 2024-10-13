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
        Label firstClicked = null;
        Label secondClicked = null;
        public Form1()
        {
            InitializeComponent();

            AssignIconsToSquares();
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
            }   
        }
    } 
}
