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

                ManualOutput(true,"Valid ID");
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

        private void ValidationAlgorithm()
        {
            //Get user input

            //Split into char array and convert to int

            //x weight then add values

            //Devide by 12 and work remains

            //12 - remains

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
