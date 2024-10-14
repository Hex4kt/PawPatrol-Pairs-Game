using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VergleichsSpiel
{
    public partial class Form1 : Form
    {
        PictureBox firstClicked;
        PictureBox secondClicked;

        int timeUsed = 0;
        TimeSpan benutzteZeit = new TimeSpan();

        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();

            benutzteZeit = TimeSpan.FromSeconds(timeUsed);
            LabelTimer.Text = string.Format("{0:D2}:{1:D2}", benutzteZeit.Minutes, benutzteZeit.Seconds);
        }
        // Zufallszahl um später zufällige Objekte zu wählen
        Random random = new Random();

        // Erstellt eine Liste mit verschiedenen Buchstaben, die den Bidlern zugewiesen werden
        List<string> icons = new List<string>
        {
            "1", "1", "2", "2", "3", "3", "4", "4",
            "5", "5", "6", "6", "7", "7", "8", "8"
        };

        // Erstellt eine Liste, die den PictureBoxen ihre Icons zuordnet
        Dictionary<PictureBox, string> iconMapping = new Dictionary<PictureBox, string>();

        // weist jedem Quadrat ein Icon zu
        public void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            { 
                PictureBox iconBox = control as PictureBox;
                if (iconBox != null)
                { 
                    int randomNumber = random.Next(icons.Count());
                    string assignedIcon = icons[randomNumber];

                    // Speichert die zugewiesene Icon-ID in einer Zuordnungstabelle
                    iconMapping[iconBox] = assignedIcon;

                    // Entfernt das bereits benutze Icon
                    icons.RemoveAt(randomNumber);

                    // verdeckt erstmal das Bild
                    iconBox.Image = null;
                }
            }
        }
        // Gibt anhand der IconID das jeweilige Icon zurück
        private Image GetIconById(string iconId)
        {
            switch (iconId)
            {
                case "1":
                    return Image.FromFile("D:\\Repos\\Tutorials\\VergleichsSpiel\\Icons\\canine.ico");

                case "2":
                    return Image.FromFile("D:\\Repos\\Tutorials\\VergleichsSpiel\\Icons\\chase.ico");

                case "3":
                    return Image.FromFile("D:\\Repos\\Tutorials\\VergleichsSpiel\\Icons\\dad.ico");

                case "4":
                    return Image.FromFile("D:\\Repos\\Tutorials\\VergleichsSpiel\\Icons\\everest.ico");

                case "5":
                    return Image.FromFile("D:\\Repos\\Tutorials\\VergleichsSpiel\\Icons\\mom.ico");

                case "6":
                    return Image.FromFile("D:\\Repos\\Tutorials\\VergleichsSpiel\\Icons\\ryder.ico");

                case "7":
                    return Image.FromFile("D:\\Repos\\Tutorials\\VergleichsSpiel\\Icons\\zuma.ico");

                case "8":
                    return Image.FromFile("D:\\Repos\\Tutorials\\VergleichsSpiel\\Icons\\bloodrage.ico");

                default:
                    return null;
            }
        }

        // Deckt Felder durch anklicken auf
        private void PictureBoxClicked(object sender, EventArgs e)
        {
            timer2.Enabled = true;

            string iconId;
            // Wenn Timer1 läuft, wird returned
            if (timer1.Enabled)
            {
                return;
            }

            PictureBox clickedPicture = sender as PictureBox;

            if (clickedPicture != null)
            {
                if (clickedPicture.Image != null)
                    return;

                if (firstClicked == null)
                {
                    // Zeigt das versteckte Bild an
                    iconId = iconMapping[clickedPicture];
                    firstClicked = clickedPicture;
                    firstClicked.Image = GetIconById(iconId); // Zeigt das passende Icon an
                    firstClicked.SizeMode = PictureBoxSizeMode.Zoom;
                    return;
                }

                iconId = iconMapping[clickedPicture];
                secondClicked = clickedPicture;
                secondClicked.Image = GetIconById(iconId);
                secondClicked.SizeMode = PictureBoxSizeMode.Zoom;

                CheckForWin();

                if (iconMapping[firstClicked] == iconMapping[secondClicked])
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer1.Start();
            }   
        }
        // Dreht die Felder wieder um, nach Intervall Zeit
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            // Verbirgt die Icons nach der Verzögerung (Intervall)
            if (firstClicked != null && secondClicked != null)
            {
                firstClicked.Image = null;
                secondClicked.Image = null;
                firstClicked = null;
                secondClicked = null;
            }
        }

        // Die Funktion checkt ob das Spiel gewonnnen wurde
        private void CheckForWin()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                PictureBox iconLabel = control as PictureBox;

                if (iconLabel.Image == null)
                    return;
            }

            timer2.Enabled = false;
            MessageBox.Show($"Du hast gewonnen und hast {benutzteZeit.Minutes} Minuten und {benutzteZeit.Seconds} Sekunden gebraucht, herzlichsten Glühstrumpf!!!");
            Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeUsed++;
            benutzteZeit = TimeSpan.FromSeconds(timeUsed);
            LabelTimer.Text = string.Format("{0:D2}:{1:D2}", benutzteZeit.Minutes, benutzteZeit.Seconds);
        }
    } 
}
