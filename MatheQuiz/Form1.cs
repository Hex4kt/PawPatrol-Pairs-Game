using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatheQuiz
{
    public partial class Mathequiz : Form
    {
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
            divNumber1 = randomizer.Next(1, 20);
            divNumber2 = randomizer.Next(3, divNumber1);
            lblLeftNumber4.Text = divNumber1.ToString();
            lblRightNumber4.Text = divNumber2.ToString();
            numErgebnis4.Value = 0;
        }
        public Mathequiz()
        {
            InitializeComponent();
        }

        private void lblLeftNumber_Click(object sender, EventArgs e)
        {

        }

        private void numErgebnis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numErgebnis2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
