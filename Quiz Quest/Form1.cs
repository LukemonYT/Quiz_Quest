using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Quiz_Quest
{

    public partial class Form1 : Form
    {
        //Global variables
        string name, level;
        int numOfQuest;
        

        public Form1()
        {
            InitializeComponent();
            //Sets the windows to the start postion
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
        
        
        public void butCont_Click(object sender, EventArgs e)
        {
            //Checks if both the name, number of questions & level are valid
            if (CheckName() && CheckNumOfQuest() && CheckLevel())
            {
                //Takes user to the form2
                //Saves name, number of questions & level on form2
                this.Hide();
                Form2 form2 = new Form2();
                form2.Name = name;
                form2.NumOfQuest = numOfQuest;
                form2.Level = level;
                form2.ShowDialog();
                this.Close();
 
            }
            else
            {
             
                //Displays an error because the input was invalid
                MessageBox.Show("Please enter a valid input!");

            }
        }

        public bool CheckName()
        {   
            name = txtName.Text;
            //Checks if name is valid
            if (!name.Equals(""))
            {
                //Capitlises name
                name = name[0].ToString().ToUpper() + txtName.Text.Substring(1);

                return true;
            }
            txtName.Text = "";
            return false; 
        }

        public bool CheckNumOfQuest()
        {
            try
            {
                //Converts and stores string as an interger
                numOfQuest = Convert.ToInt32(txtNumOfQuest.Text);

                //Checks if number is above 0
                if (numOfQuest > 0)
                {
                    return true;
                }
                txtNumOfQuest.Text = "";
                return false;

            }
            catch (Exception)
            {
                txtNumOfQuest.Text = "";
                return false;
            }
            
        }


        public bool CheckLevel()
        {
            level = cmbLvlOfQuest.Text;
            //Checks if level is valid
            if (!level.Equals(""))
            {
                return true;
            }
            cmbLvlOfQuest.Text = "";
            return false;
        }
    }
}