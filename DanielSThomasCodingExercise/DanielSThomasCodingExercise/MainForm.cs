using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            userInput = txtManualInput.Text;
            ValidateID(userInput);
        }
      
        private void BtnAutoInput_Click(object sender, EventArgs e)
        {
            LoadJsonData();
        }

        //Methods
        private void ValidateID(string input)
        {
           

            if(input.Length != 10)
            {                
                ManualOutput(false, "ID must be 10 digits long");
                return;
            }
            if(CheckforDuplicates(input) > 9)
            {            
                ManualOutput(false, "ID has too many duplicate digits");
                return;
            }
            else
            {
                try
                {
                    long patientID = Int64.Parse(input); //Convert string into numbers
                    if(patientID < 0) //Check to prevent negitive values
                    {                      
                        ManualOutput(false, "Invalid Characters");
                        return;
                    }
                }
                catch(FormatException) //String is non-numeric
                {
                    
                    ManualOutput(false, "Invalid Characters");
                    return;
                }

                if(ValidationAlgorithm(input) == true)
                {
                    ManualOutput(true, "Valid ID");
                }
                else 
                {
                    ManualOutput(false, "ID Failled Advanced Validation Check");
                }
               
            }
          
        }

        private bool AutomaticValidateID(string input)
        {

            if (input.Length != 10)
            {              
                return false;
            }
            if (CheckforDuplicates(input) > 9)
            {              
                return false;
            }
            else
            {
                try
                {
                    long patientID = Int64.Parse(input); //Convert string into numbers
                    if (patientID < 0) //Check to prevent negitive values
                    {                       
                        return false;
                    }
                }
                catch (FormatException) //String is non-numeric
                {                
                    return false;
                }

                if (ValidationAlgorithm(input) == true)
                {                    
                    return true;
                }
                else
                {                
                    return false;
                }

            }

        }

        private int CheckforDuplicates(string input)
        {
            int duplicateCount = 0;


            char firstChar = input[0];

            char[] charArray = input.ToCharArray();


            foreach(char ch in charArray) //Compare every character to the first and count duplicates
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
                      
        }

        private void ManualOutput(bool input,string message) //Visual feedback to indicate ID as valid or invalid
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

        private void LoadJsonData()
        {
            MessageBox.Show("Select the patient file to open");

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                using (StreamReader r = new StreamReader(filePath))
                {
                    string json = r.ReadToEnd();
                    List<string> patientIDs = JsonConvert.DeserializeObject<List<string>>(json);

                    int validScore = 0;
                    int inValidScore = 0;


                    foreach(string ID in patientIDs)
                    {
                       if (AutomaticValidateID(ID) == true)
                        {
                            validScore ++;
                        }
                        else
                        {
                            inValidScore++;
                        }
                       

                    }

                    int total = validScore + inValidScore;

                    if(inValidScore > 0)
                    {
                        lblAutoOutput.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblAutoOutput.ForeColor = Color.Green;
                    }

                    lblAutoOutput.Text = ( validScore + "/" + total + " Valid" );
                    //Show scores
                }


            }

            
        }
            

    }
}
