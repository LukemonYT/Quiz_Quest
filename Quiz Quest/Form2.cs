using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Quiz_Quest
{
    public partial class Form2 : Form
    {
        //Global variables
        public new string Name { get; set; }
        public int NumOfQuest {  get; set; }
        public string Level { get; set; }
        int num1, num2, pmmin, pmmax, mmin, mmax, score, userAns, total;
        int questCounter = 1;
        string[] Symbol = { "+", "-", "×", };
        string[] ResultsList = new string[] { };
        string results;
        
        //Randomly generates interger when called
        Random rnd = new Random();

        public Form2()
        {
            InitializeComponent();
            //Sets the windows to the start postion
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            //Welcomes user, displays number of questions & level chosen
            MessageBox.Show($"Welcome to Quest Quest {Name}!\nNumber of questions chosen: {NumOfQuest}\nLevel chosen: {Level}\n");
           
            //Hides show results button
            btnShwReslts.Hide();
            ResultsList = ResultsList.Concat(new string[] { $"Thank you for playing Quiz Quest {Name}!\n\nHere are your results:" }).ToArray();

            CheckLevel();
            SetupQuiz();
        }

        private void CheckLevel()
        {
            //Sets the minimum and maximum intergers for questions based on level
            if (Level == "Easy")
            {
                pmmin = 0; pmmax = 20;
                mmin = 0; mmax = 5;
            }
            else if (Level == "Medium")
            {
                pmmin = -20; pmmax = 50;
                mmin = 0; mmax = 15;
            }
            else if (Level == "Hard")
            { 
                pmmin = -99; pmmax = 99;
                mmin = -20; mmax = 20;
            }
        }
        
        private void SetupQuiz()
        {  
            // Rnadomly selects operator
            switch (Symbol[rnd.Next(0, 3)])
            {
                //Randomly generates the first and second interger and calculates the answer based on the operator selected
                case "+":
                    lblSmbl.Text = "+";
                    num1 = rnd.Next(pmmin, pmmax); lblNum1.Text = num1.ToString();
                    num2 = rnd.Next(pmmin, pmmax); lblNum2.Text = num2.ToString();
                    total = num1 + num2;
                    break;

                case "-":
                    lblSmbl.Text = "-";
                    num1 = rnd.Next(pmmin, pmmax); lblNum1.Text = num1.ToString();
                    num2 = rnd.Next(pmmin, pmmax); lblNum2.Text = num2.ToString();
                    total = num1 - num2;
                    break;

                case "×":
                    lblSmbl.Text = "×";
                    num1 = rnd.Next(mmin, mmax); lblNum1.Text = num1.ToString();
                    num2 = rnd.Next(mmin, mmax); lblNum2.Text = num2.ToString();
                    total = num1 * num2;
                    break; 
            }
        }

        private void CheckQuestion()
        {
            //Checks if the users answer was correct or incorrect and displays the appropriate mark and colour
            //Adds the equation to the results variable and adds the correct answer if the users answer was incorrect
            if (total == userAns)
            {
                lblDispMark.ForeColor = System.Drawing.Color.Green;
                lblDispMark.Text = "Correct";
                results = ($"Question {questCounter} was correct: {num1} {lblSmbl.Text} {num2} = {userAns}.");

                //Adds a point to the score if the user gets the answer correct
                score++;
            }
            else if (total != userAns)
            {
                lblDispMark.ForeColor = System.Drawing.Color.Red;
                lblDispMark.Text = "Incorrect";
                results = ($"Question {questCounter} was incorrect: {num1} {lblSmbl.Text} {num2} = {userAns}. Correct answer: {total}.");
            }

            //Adds the results variable to the results array 
            ResultsList = ResultsList.Concat(new string[] { results }).ToArray();
        }

        private bool CheckAnswer()
        {
            try
            {
                //Converts and stores string as an interger
                userAns = Convert.ToInt32(txtAns.Text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void butNxt_Click(object sender, EventArgs e)
        {
            if (CheckAnswer())
            {
                //Checks how many questions the user has answered compared to the number of questions requested and takes the appropriate action
                if (NumOfQuest != questCounter)
                {
                    CheckQuestion();

                    //Adds a point to the amount of questions complete
                    questCounter++;

                    //Diplays the current question number
                    lblQuest.Text = $"Question {questCounter}";

                    SetupQuiz();  
                }
                else if (NumOfQuest == questCounter)
                {
                    CheckQuestion();

                    //Adds the users percentage and score to the results array
                    ResultsList = ResultsList.Concat(new string[] { $"\nYour percentage of correct questions was: {(score * 100) / NumOfQuest}%!\nYour score of correct questions was: {score}/{NumOfQuest}!" }).ToArray();

                    //Shows the results buttons and hides the equation
                    btnShwReslts.Show();
                    lblQuest.Hide();
                    lblDispMark.Hide();
                    lblNum1.Hide();
                    lblSmbl.Hide();
                    lblNum2.Hide();
                    lblEqual.Hide();
                    txtAns.Hide();
                }
                
            }
            else 
            {
                //Displays an error because the input was invalid
                MessageBox.Show("Please enter a valid interger!");
            }
            txtAns.Text = "";
        }

        private void btnPrntReslts_Click(object sender, EventArgs e)
        {
            //Displays the users results 
            MessageBox.Show(string.Join("\n", ResultsList));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Returns user to form1
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}
