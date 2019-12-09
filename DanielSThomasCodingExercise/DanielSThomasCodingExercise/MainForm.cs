﻿using System;
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
                MessageBox.Show("Patient ID must be 10 digits long");
                lblManualOutput.Text = "Invalid"; lblManualOutput.ForeColor = Color.Red;
                return;
            }
            if(CheckforDuplicates(userInput) > 9)
            {
                MessageBox.Show("Patient ID has too many duplicates");
                lblManualOutput.Text = "Invalid"; lblManualOutput.ForeColor = Color.Red;
                return;
            }
            else
            {
                try
                {
                    long patientID = Int64.Parse(userInput);
                    if(patientID < 0)
                    {
                        MessageBox.Show("Invalid Characters");
                        lblManualOutput.Text = "Invalid"; lblManualOutput.ForeColor = Color.Red;
                        return;
                    }
                }
                catch(FormatException)
                {
                    MessageBox.Show("Invalid Characters");
                    lblManualOutput.Text = "Invalid"; lblManualOutput.ForeColor = Color.Red;
                    return;
                }
               
                lblManualOutput.Text = "Valid"; lblManualOutput.ForeColor = Color.Green;
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
    }
}
