namespace Hangman5
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubmitLetterButton = new System.Windows.Forms.Button();
            this.LetterBox = new System.Windows.Forms.TextBox();
            this.WordLengthLabel = new System.Windows.Forms.Label();
            this.WrongGuessCountLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 259);
            this.panel1.TabIndex = 0;
            // 
            // SubmitLetterButton
            // 
            this.SubmitLetterButton.ForeColor = System.Drawing.Color.Black;
            this.SubmitLetterButton.Location = new System.Drawing.Point(58, 222);
            this.SubmitLetterButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.SubmitLetterButton.Name = "SubmitLetterButton";
            this.SubmitLetterButton.Size = new System.Drawing.Size(293, 36);
            this.SubmitLetterButton.TabIndex = 0;
            this.SubmitLetterButton.Text = "Submit Letter";
            this.SubmitLetterButton.UseVisualStyleBackColor = true;
            this.SubmitLetterButton.Click += new System.EventHandler(this.SubmitLetterButton_Click);
            // 
            // LetterBox
            // 
            this.LetterBox.Location = new System.Drawing.Point(392, 198);
            this.LetterBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LetterBox.MaxLength = 1;
            this.LetterBox.Name = "LetterBox";
            this.LetterBox.Size = new System.Drawing.Size(116, 26);
            this.LetterBox.TabIndex = 2;
            this.LetterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LetterBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LetterBox_KeyDown);
            // 
            // WordLengthLabel
            // 
            this.WordLengthLabel.AutoSize = true;
            this.WordLengthLabel.ForeColor = System.Drawing.Color.White;
            this.WordLengthLabel.Location = new System.Drawing.Point(6, 19);
            this.WordLengthLabel.Name = "WordLengthLabel";
            this.WordLengthLabel.Size = new System.Drawing.Size(94, 21);
            this.WordLengthLabel.TabIndex = 0;
            this.WordLengthLabel.Text = "Word Length:";
            // 
            // WrongGuessCountLabel
            // 
            this.WrongGuessCountLabel.AutoSize = true;
            this.WrongGuessCountLabel.ForeColor = System.Drawing.Color.White;
            this.WrongGuessCountLabel.Location = new System.Drawing.Point(6, 126);
            this.WrongGuessCountLabel.Name = "WrongGuessCountLabel";
            this.WrongGuessCountLabel.Size = new System.Drawing.Size(58, 21);
            this.WrongGuessCountLabel.TabIndex = 4;
            this.WrongGuessCountLabel.Text = "Missed:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SubmitLetterButton);
            this.groupBox2.Controls.Add(this.WrongGuessCountLabel);
            this.groupBox2.Controls.Add(this.WordLengthLabel);
            this.groupBox2.Location = new System.Drawing.Point(245, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox2.Size = new System.Drawing.Size(419, 267);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(674, 290);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LetterBox);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("MarseilleSerial-Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SubmitLetterButton;
        private System.Windows.Forms.TextBox LetterBox;
        private System.Windows.Forms.Label WordLengthLabel;
        private System.Windows.Forms.Label WrongGuessCountLabel;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

