using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielSThomasCodingExercise
{
    public partial class MainForm : Form
    {
        //Variables
        private string userInput;
      

        //Components
        public MainForm()
        {
            InitializeComponent();
        }
  
        private void BtnManualInput_Click(object sender, EventArgs e)
        {
            ValidateID();
        }
      
        private void BtnAutoInput_Click(object sender, EventArgs e)
        {
                    
        }

        //Methods
        private void ValidateID()
        {
            userInput = txtManualInput.Text;

            if(userInput.Length != 10)
            {
                
                ManualOutput(false, "Patient ID must be 10 digits long");
                return;
            }
            if(CheckforDuplicates(userInput) > 9)
            {            
                ManualOutput(false, "Patient ID has too many duplicate digits");
                return;
            }
            else
            {
                try
                {
                    long patientID = Int64.Parse(userInput);
                    if(patientID < 0)
                    {                      
                        ManualOutput(false, "Invalid Characters");
                        return;
                    }
                }
                catch(FormatException)
                {
                    
                    ManualOutput(false, "Invalid Characters");
                    return;
                }

                if(ValidationAlgorithm(userInput) == true)
                {
                    ManualOutput(true, "Valid ID");
                }
                else
                {
                    ManualOutput(false, "ID Failled Advanced Validation Check");
                }
               
            }

           


        }
        private int CheckforDuplicates(string input)
        {
            int duplicateCount = 0;


            char firstChar = input[0];

            char[] charArray = input.ToCharArray();


            foreach(char ch in charArray)
            {
                if (ch == firstChar)
                {
                    duplicateCount++;
                }
            }

            return duplicateCount;
        }

        private bool ValidationAlgorithm(string input)
        {
            
            int digit1 = Int32.Parse(input[0].ToString()) * 11;           
            int digit2 = Int32.Parse(input[1].ToString()) * 10;
            int digit3 = Int32.Parse(input[2].ToString()) * 9;
            int digit4 = Int32.Parse(input[3].ToString()) * 8;
            int digit5 = Int32.Parse(input[4].ToString()) * 7;
            int digit6 = Int32.Parse(input[5].ToString()) * 6;
            int digit7 = Int32.Parse(input[6].ToString()) * 5;
            int digit8 = Int32.Parse(input[7].ToString()) * 4;
            int digit9 = Int32.Parse(input[8].ToString()) * 3;
            int digit10 = Int32.Parse(input[9].ToString());

            int sum = digit1 + digit2 + digit3 + digit4 + digit5 + digit6 + digit7 + digit8 + digit9;
            sum %= 12;
            sum = 12 - sum;
         
            if (sum == 10 || sum == 12)
            {
                return true;
            }
            if (sum == 11 && digit10 == 0)
            {
                return true;
            }
            if(sum == digit10)
            {
                return true;
            }
            else
            {
                return false;
            }
           
            
            

            //if final no = 10 or 12 return invalid
            //if final no = 11 and userinput[9] == 0 return valid
            //if final no = userinput[9] return valid
           
        }


        private void ManualOutput(bool input,string message)
        {
            if(input == true)
            {
                lblManualOutput.Text = "Valid"; lblManualOutput.ForeColor = Color.Green;            
            }
            if(input == false)
            {
                lblManualOutput.Text = "Invalid"; lblManualOutput.ForeColor = Color.Red;
                MessageBox.Show(message);
            }
        }
    }
}
