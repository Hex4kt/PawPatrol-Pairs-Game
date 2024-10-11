using System;
using System.Windows.Forms;

namespace MatheQuiz
{
    public partial class Mathequiz : Form
    {
        // Zufallszahl für Aufgaben
        Random randomizer = new Random();

        // Zahlen für Additionsaufgabe
        int addNumber1;
        int addNumber2;

        // Zahlen für Subtraktionsaufgabe
        int subNumber1;
        int subNumber2;

        // Zahlen für Multiplikationsaufgabe
        int multNumber1;
        int multNumber2;

        // Zahlen für Divisionsaufgabe
        int divNumber1;
        int divNumber2;

        // Verbleibene Zeit
        int timeLeft;

        public Mathequiz()
        {
            InitializeComponent();
        }
        public void StartTheQuiz()
        {
            // Additionsproblem
            addNumber1 = randomizer.Next(51);
            addNumber2 = randomizer.Next(51);
            lblLeftNumber.Text = addNumber1.ToString();
            lblRightNumber.Text = addNumber2.ToString();
            numErgebnis.Value = 0;

            // Substraktionsproblem
            subNumber1 = randomizer.Next(1, 101);
            subNumber2 = randomizer.Next(1, subNumber1);
            lblLeftNumber2.Text = subNumber1.ToString();
            lblRightNumber2.Text = subNumber2.ToString();
            numErgebnis2.Value = 0;

            // Multiplikationsproblem
            multNumber1 = randomizer.Next(1, 11);
            multNumber2 = randomizer.Next(2, multNumber1);
            lblLeftNumber3.Text = multNumber1.ToString();
            lblRightNumber3.Text = multNumber2.ToString();
            numErgebnis3.Value = 0;

            // Divisionsproblem
            divNumber2 = randomizer.Next(1, 11);
            int tempDivNumber = randomizer.Next(1, 11);
            divNumber1 = divNumber2 * tempDivNumber;
            lblLeftNumber4.Text = divNumber1.ToString();
            lblRightNumber4.Text = divNumber2.ToString();
            numErgebnis4.Value = 0;

            // Timer starten
            timeLeft = 30;
            lblTime.Text = timeLeft.ToString() + " seconds";
            timer1.Start();
        }
        private bool CheckAntworten()
        {
            if (addNumber1 + addNumber2 == numErgebnis.Value
                && subNumber1 - subNumber2 == numErgebnis2.Value
                && multNumber1 * multNumber2 == numErgebnis3.Value
                && divNumber1 / divNumber2 == numErgebnis4.Value)
                return true;
            else 
                return false;
        }
        private void startQuiz_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startQuiz.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckAntworten())
            {
                timer1.Stop();
                MessageBox.Show("Richtig!");
                startQuiz.Enabled = true;
            }
            else if (timeLeft > 0) 
            {
                timeLeft -= 1;
                lblTime.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                lblTime.Text = "Zeit abgelaufen!";
                MessageBox.Show("Die zeit ist abgelaufen, versuchs nochmal!");
                numErgebnis.Value = addNumber1 + addNumber2;
                numErgebnis2.Value = subNumber1 - subNumber2;
                numErgebnis3.Value = multNumber1 * multNumber2;
                numErgebnis4.Value = divNumber1 / divNumber2;
                startQuiz.Enabled = true;
            }
        }
    }
}
