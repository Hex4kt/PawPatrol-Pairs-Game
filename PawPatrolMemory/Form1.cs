using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawPatrol
{
    public partial class Form1 : Form
    {
        private string _appPath = Application.StartupPath;

        PictureBox firstClicked;
        PictureBox secondClicked;

        SoundManager soundGoal = new SoundManager("Goal");
        SoundManager soundWin = new SoundManager("Win");
        SoundManager soundWrong = new SoundManager("Wrong");

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
                    return Image.FromFile(Path.Combine(_appPath, "Icons", "canine.ico"));

                case "2":
                    return Image.FromFile(Path.Combine(_appPath, "Icons", "chase.ico"));

                case "3":
                    return Image.FromFile(Path.Combine(_appPath, "Icons", "dad.ico"));

                case "4":
                    return Image.FromFile(Path.Combine(_appPath, "Icons", "everest.ico"));

                case "5":
                    return Image.FromFile(Path.Combine(_appPath, "Icons", "mom.ico"));

                case "6":
                    return Image.FromFile(Path.Combine(_appPath, "Icons", "ryder.ico"));

                case "7":
                    return Image.FromFile(Path.Combine(_appPath, "Icons", "zuma.ico"));

                case "8":
                    return Image.FromFile(Path.Combine(_appPath, "Icons", "marshall.ico"));

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
                return;

            PictureBox clickedPicture = sender as PictureBox;

            if (clickedPicture != null)
            {
                if (clickedPicture.Image != null)
                    return;

                if (firstClicked == null)
                {
                    // Zeigt das erste versteckte Bild an
                    iconId = iconMapping[clickedPicture];
                    firstClicked = clickedPicture;
                    firstClicked.Image = GetIconById(iconId); // Zeigt das passende Icon an
                    firstClicked.SizeMode = PictureBoxSizeMode.Zoom;
                    return;
                }

                // Zeigt das zweite versteckte Bild an
                iconId = iconMapping[clickedPicture];
                secondClicked = clickedPicture;
                secondClicked.Image = GetIconById(iconId);
                secondClicked.SizeMode = PictureBoxSizeMode.Zoom;

                // Überprüft ob alle Felder aufgedeckt wurden
                CheckForWin();

                // Wenn beide Felder übereinstimmen, dann wird Timer1 nicht gestartet = beide Felder bleiben aufgedeckt
                if (iconMapping[firstClicked] == iconMapping[secondClicked])
                {
                    firstClicked = null;
                    secondClicked = null;
                    soundGoal.Play();
                    return;
                }

                // Wenn Felder nicht übereinstimmten, wird timer1 gestartet
                soundWrong.Play();
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
                firstClicked.Image.Dispose();
                secondClicked.Image.Dispose();
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
            soundWin.Play();
            MessageBox.Show($"Du hast gewonnen und hast {benutzteZeit.Minutes} Minuten und {benutzteZeit.Seconds} Sekunden gebraucht, herzlichen Glückwunsch!!!");
            Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeUsed++;
            benutzteZeit = TimeSpan.FromSeconds(timeUsed);
            LabelTimer.Text = string.Format("{0:D2}:{1:D2}", benutzteZeit.Minutes, benutzteZeit.Seconds);
        }

        bool _darkMode = false;
        private void switchBackground_Click(object sender, EventArgs e)
        {
            if (_darkMode)
            {
                this.BackColor = Color.DarkSlateBlue;
                LabelTimer.ForeColor = Color.White;
                LabelVerbleibeneZeit.ForeColor = Color.White;
                lightButton.Text = "WhiteMode";
                _darkMode = false;
            }
            else
            {
                this.BackColor = Color.White;
                LabelTimer.ForeColor = Color.DarkSlateGray;
                LabelVerbleibeneZeit.ForeColor = Color.DarkSlateGray;
                this.lightButton.Text = "DarkMode";
                _darkMode = true;
            }
        }
    } 
}
