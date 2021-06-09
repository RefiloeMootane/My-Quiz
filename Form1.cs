using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Quiz
{
    public partial class Form1 : Form
    {

        // quiz game variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 6;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.questionmark;

                    lblQuestion.Text = "DO YOU WHANT TO PLAY THIS QUIZ?";

                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Text = "Maybe";
                    button4.Text = "Not sure";

                    correctAnswer = 1;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.Q1;

                    lblQuestion.Text = "Who is the first black president?";

                    button1.Text = "Thabo Mbeki";
                    button2.Text = "Nelson Madela";
                    button3.Text = "Jacob Zuma";
                    button4.Text = "Kgalema Motlanthi";

                    correctAnswer = 2;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Q2;

                    lblQuestion.Text = "Who is our curre president?";

                    button1.Text = "Thabo Mbeki";
                    button2.Text = "Nelson Madela";
                    button3.Text = "Jacob Zuma";
                    button4.Text = "Cyril Ramaphosa";

                    correctAnswer = 4;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Q3;

                    lblQuestion.Text = "In which year did  the organasation SASSA star?";

                    button1.Text = "2010";
                    button2.Text = "2009";
                    button3.Text = "2021";
                    button4.Text = "2005";

                    correctAnswer = 4;

                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.Q4;

                    lblQuestion.Text = "Who is the MEC of Health in limpopo ?";

                    button1.Text = "Dr Tintswalo Mativandlela";
                    button2.Text = "Dr Nomathemba Mokgethi ";
                    button3.Text = "Dr Phophi Ramathuba";
                    button4.Text = "Dr Refiloe Mootane";

                    correctAnswer = 3;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.Q5;

                    lblQuestion.Text = "Who is the MEC of Education in limpopo?";

                    button1.Text = "Polly Boshielo";
                    button2.Text = "Naledi Phando";
                    button3.Text = "Tswelopele Mativandlea";
                    button4.Text = "Mampa Mativandlela";

                    correctAnswer = 1;

                    break;

               

               


            }



        }

    }
}
