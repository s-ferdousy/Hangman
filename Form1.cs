using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hangman5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string word = "";
        int chances = 0;
        int WinCounter = 0;

        List<Label> labels = new List<Label>();
        
        enum BodyParts
        {
            Head, Arm1, Arm2, Body, Leg1, Leg2
        }
        void DrawBodyPart(BodyParts bp)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.White, 2);
            if (bp == BodyParts.Head)
            {
                g.DrawEllipse(p, 40, 50, 40, 40);
            }
            else if (bp == BodyParts.Body)
            {
                g.DrawLine(p, new Point(60, 90), new Point(60, 170));
            }
            else if (bp == BodyParts.Arm2)
            {
                g.DrawLine(p, new Point(60, 100), new Point(30, 85));
            }
            else if (bp == BodyParts.Arm1)
            {
                g.DrawLine(p, new Point(60, 100), new Point(90, 85));                
            }
            else if (bp == BodyParts.Leg2)
            {
                g.DrawLine(p, new Point(60, 170), new Point(30, 190));
            }
            else if (bp == BodyParts.Leg1)
            {
                g.DrawLine(p, new Point(60, 170), new Point(90, 190));
            }
        }

        void MakeLabels()
        {
            word = GetRandomWord();
            char[] chars = word.ToCharArray();
            int between = 330 / chars.Length - 1;
            for (int i = 0; i < chars.Length; i++)
            {
                labels.Add(new Label());
                labels[i].Location = new Point((i * between) + 10, 80);
                labels[i].Text = "_";
                labels[i].Parent = groupBox2;
                labels[i].BringToFront();
                labels[i].CreateControl();
                labels[i].ForeColor = System.Drawing.Color.White;
            }
            WordLengthLabel.Text = "Guess a word with " + (chars.Length - 1).ToString() +" letters.";
        }
        string GetRandomWord() 
        {
            string wordlist = "mango orange pineapple";
            string[] words = wordlist.Split(' ');
            Random ran = new Random();
            return words[ran.Next(0, words.Length - 1)];
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.White, 10);
            g.DrawLine(p, new Point(130, 248), new Point(130, 10));
            g.DrawLine(p, new Point(135, 5), new Point(65, 5));
            g.DrawLine(p, new Point(60, 0), new Point(60, 50));
            MakeLabels();
        }

        public void SubmitLetterFromTextBox()
        {
            if (LetterBox.Text.Length >= 1)
            {
                char letter = LetterBox.Text.ToLower().ToCharArray()[0];
                if (!char.IsLetter(letter))
                {
                    MessageBox.Show("Letters only", "Wrong!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (word.Contains(letter))
                {
                    char[] letters = word.ToCharArray();
                    for (int i = 0; i < letters.Length; i++)
                    {
                        if (letters[i] == letter)
                        {
                            labels[i].Text = letter.ToString();
                            WinCounter++;
                        }
                    }

                }
                
                else
                {
                    MessageBox.Show("Wrong Guess");
                    WrongGuessCountLabel.Text += " " + letter.ToString() + ",";
                    DrawBodyPart((BodyParts)chances);
                    chances++;   
                }
                if (WinCounter == word.Length)
                {
                    MessageBox.Show("You Win!");
                    Environment.Exit(0);
                }
                if (chances == 6)
                {
                    MessageBox.Show("You lost!");
                    Environment.Exit(0);
                }
            }
            LetterBox.Text = "";
        }
        private void SubmitLetterButton_Click(object sender, EventArgs e)
        {
            SubmitLetterFromTextBox();
        }

        private void LetterBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitLetterFromTextBox();
            }
        }
    }
}
