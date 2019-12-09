namespace DanielSThomasCodingExercise
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnManualInput = new System.Windows.Forms.Button();
            this.lblManual = new System.Windows.Forms.Label();
            this.txtManualInput = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAutoInput = new System.Windows.Forms.Button();
            this.lblManualOutput = new System.Windows.Forms.Label();
            this.lblAuto = new System.Windows.Forms.Label();
            this.lblAutoOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManualInput
            // 
            this.btnManualInput.Location = new System.Drawing.Point(26, 121);
            this.btnManualInput.Name = "btnManualInput";
            this.btnManualInput.Size = new System.Drawing.Size(131, 36);
            this.btnManualInput.TabIndex = 0;
            this.btnManualInput.Text = "Validate ID";
            this.btnManualInput.UseVisualStyleBackColor = true;
            this.btnManualInput.Click += new System.EventHandler(this.btnManualInput_Click);
            // 
            // lblManual
            // 
            this.lblManual.AutoSize = true;
            this.lblManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManual.Location = new System.Drawing.Point(114, 66);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(135, 20);
            this.lblManual.TabIndex = 1;
            this.lblManual.Text = "Manual Validation";
            // 
            // txtManualInput
            // 
            this.txtManualInput.Location = new System.Drawing.Point(26, 95);
            this.txtManualInput.Name = "txtManualInput";
            this.txtManualInput.Size = new System.Drawing.Size(312, 20);
            this.txtManualInput.TabIndex = 2;        
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(45, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(283, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Patient ID Checker";
            // 
            // btnAutoInput
            // 
            this.btnAutoInput.Location = new System.Drawing.Point(26, 215);
            this.btnAutoInput.Name = "btnAutoInput";
            this.btnAutoInput.Size = new System.Drawing.Size(131, 36);
            this.btnAutoInput.TabIndex = 4;
            this.btnAutoInput.Text = "Validate ID from file";
            this.btnAutoInput.UseVisualStyleBackColor = true;
            this.btnAutoInput.Click += new System.EventHandler(this.BtnAutoInput_Click);
            // 
            // lblManualOutput
            // 
            this.lblManualOutput.AutoSize = true;
            this.lblManualOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManualOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblManualOutput.Location = new System.Drawing.Point(271, 128);
            this.lblManualOutput.Name = "lblManualOutput";
            this.lblManualOutput.Size = new System.Drawing.Size(67, 29);
            this.lblManualOutput.TabIndex = 5;
            this.lblManualOutput.Text = "Valid";
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuto.Location = new System.Drawing.Point(105, 181);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(155, 20);
            this.lblAuto.TabIndex = 6;
            this.lblAuto.Text = "Automatic Validation";        
            // 
            // lblAutoOutput
            // 
            this.lblAutoOutput.AutoSize = true;
            this.lblAutoOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoOutput.ForeColor = System.Drawing.Color.Red;
            this.lblAutoOutput.Location = new System.Drawing.Point(191, 222);
            this.lblAutoOutput.Name = "lblAutoOutput";
            this.lblAutoOutput.Size = new System.Drawing.Size(147, 29);
            this.lblAutoOutput.TabIndex = 7;
            this.lblAutoOutput.Text = "1/5 Valid IDs";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 279);
            this.Controls.Add(this.lblAutoOutput);
            this.Controls.Add(this.lblAuto);
            this.Controls.Add(this.lblManualOutput);
            this.Controls.Add(this.btnAutoInput);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtManualInput);
            this.Controls.Add(this.lblManual);
            this.Controls.Add(this.btnManualInput);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManualInput;
        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.TextBox txtManualInput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAutoInput;
        private System.Windows.Forms.Label lblManualOutput;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.Label lblAutoOutput;
    }
}

