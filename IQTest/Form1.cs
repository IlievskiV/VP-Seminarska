using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IQ_Test
{
    public partial class Form1 : Form
    {
        //потребно време за правење на тестот
        private static int TIME = 1800;
        private int timeElapsed;
        //документ класата
        private QuestionDocument doc;
        //листа од PictureBox каде треба да се исцртаат можните одговори
        private List<PictureBox> answerGraphics;
        //PictureBox каде треба да се исцрта прашањето
        private PictureBox questionGraphics;
        //за селекција на одговорите
        private Pen SelectedPen;
        //помошна листа од копчиња
        private List<Button> ButtonList;
        //тековното прашање
        private int currentQuestion;
        //крајниот коефициент на на интелигенција
        public int IQCoef;
        //Име на формата
        private string Ime;

        bool hasNextQuestion = true;
        int i = 0;

        public Form1(string ime)
        {
            InitializeComponent();
            Ime = ime;
            this.BackColor = Color.Gray;
            SelectedPen = new Pen(Color.Blue, 5);
            doc = new QuestionDocument();

            answerGraphics = new List<PictureBox>();
            answerGraphics.Add(pbAnswer1);
            answerGraphics.Add(pbAnswer2);
            answerGraphics.Add(pbAnswer3);
            answerGraphics.Add(pbAnswer4);

            questionGraphics = pbQuestion;

            DrawQuestion(0);

            currentQuestion = 0;

            AddButtonsToList();
            selectButton(ButtonList[currentQuestion]); // овде се избојува стартното прашање

            timer.Start();
            timeElapsed = 0;
        }

        //Додавање на копчињата во 
        public void AddButtonsToList()
        {
            ButtonList = new List<Button>();
            ButtonList.Add(btn1);
            ButtonList.Add(btn2);
            ButtonList.Add(btn3);
            ButtonList.Add(btn4);
            ButtonList.Add(btn5);
            ButtonList.Add(btn6);
            ButtonList.Add(btn7);
            ButtonList.Add(btn8);
            ButtonList.Add(btn9);
            ButtonList.Add(btn10);
            ButtonList.Add(btn11);
            ButtonList.Add(btn12);
            ButtonList.Add(btn13);
            ButtonList.Add(btn14);
            ButtonList.Add(btn15);
            ButtonList.Add(btn16);
            ButtonList.Add(btn17);
            ButtonList.Add(btn18);
            ButtonList.Add(btn19);
            ButtonList.Add(btn20);
            ButtonList.Add(btn21);
            ButtonList.Add(btn22);
            ButtonList.Add(btn23);
            ButtonList.Add(btn24);
            ButtonList.Add(btn25);
            ButtonList.Add(btn26);
            ButtonList.Add(btn27);
            ButtonList.Add(btn28);
            ButtonList.Add(btn29);
            ButtonList.Add(btn30);
        }
        //за исцртување на прашањето
        public void DrawQuestion(int numberOfQuestion)
        {
            doc.QuestionList[numberOfQuestion].DrawQuestionObject(answerGraphics, questionGraphics);
        }
        //настан за селектирање на тековно селектираниот одговор
        private void pictureBoxMouseEnter(object sender, EventArgs e)
        {
            if (!doc.QuestionList[currentQuestion].isAnswered)
            {
                if (sender == pbAnswer1)
                {
                    Graphics g = pbAnswer1.CreateGraphics();
                    g.DrawRectangle(SelectedPen, pbAnswer1.ClientRectangle);
                    g.Dispose();
                }

                if (sender == pbAnswer2)
                {
                    Graphics g = pbAnswer2.CreateGraphics();
                    g.DrawRectangle(SelectedPen, pbAnswer2.ClientRectangle);
                    g.Dispose();
                }

                if (sender == pbAnswer3)
                {
                    Graphics g = pbAnswer3.CreateGraphics();
                    g.DrawRectangle(SelectedPen, pbAnswer3.ClientRectangle);
                    g.Dispose();
                }

                if (sender == pbAnswer4)
                {
                    Graphics g = pbAnswer4.CreateGraphics();
                    g.DrawRectangle(SelectedPen, pbAnswer4.ClientRectangle);
                    g.Dispose();
                }
            }
        }
        //настан за деселктирање на претходно селектиран одговор
        private void pictureBoxMouseLeave(object sender, EventArgs e)
        {
            if (!doc.QuestionList[currentQuestion].isAnswered)
            {
                if (sender == pbAnswer1)
                {
                    doc.QuestionList[currentQuestion].DrawSingleAnswer(pbAnswer1, 0);
                }
                if (sender == pbAnswer2)
                {
                    doc.QuestionList[currentQuestion].DrawSingleAnswer(pbAnswer2, 1);
                }
                if (sender == pbAnswer3)
                {
                    doc.QuestionList[currentQuestion].DrawSingleAnswer(pbAnswer3, 2);
                }
                if (sender == pbAnswer4)
                {
                    doc.QuestionList[currentQuestion].DrawSingleAnswer(pbAnswer4, 3);
                }
            }
        }
        //селектирај копче кога маусот е врз него
        private void selectButton(Button btn)
        {
            btn.BackColor = Color.DarkBlue;
            btn.ForeColor = Color.White;
        }
        //деселектирај копче кога маусот ќе испадне
        private void deselectButton(Button btn)
        {
            btn.BackColor = SystemColors.GradientActiveCaption;
            btn.ForeColor = SystemColors.MenuHighlight;
        }
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            selectButton(btn);
        }
        private void btnMouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            deselectButton(btn);
        }
        // овде се одбојува
        private void btnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            deselectButton(ButtonList[currentQuestion]);
            currentQuestion = getButtonIndex(btn) - 1;
            DrawQuestion(currentQuestion);
            questionNumberLbl.Text = string.Format("Избери прашање: {0}", currentQuestion + 1);
        }

        private int getButtonIndex(Button btn)
        {
            return Int16.Parse(btn.Text + "");
        }

        //Настан за одбирање на одговор и прикажување на следниот
        private void pbMouseClick(object sender, MouseEventArgs e)
        {
            doc.QuestionList[currentQuestion].isAnswered = true;

            if (sender == pbAnswer1)
            {
                if (doc.QuestionList[currentQuestion].correctAnswer == 1)
                {
                    doc.QuestionList[currentQuestion].isCorrectAnswered = true;
                }
            }

            if (sender == pbAnswer2)
            {
                if (doc.QuestionList[currentQuestion].correctAnswer == 2)
                {
                    doc.QuestionList[currentQuestion].isCorrectAnswered = true;
                }
            }

            if (sender == pbAnswer3)
            {
                if (doc.QuestionList[currentQuestion].correctAnswer == 3)
                {
                    doc.QuestionList[currentQuestion].isCorrectAnswered = true;
                }
            }

            if (sender == pbAnswer4)
            {
                if (doc.QuestionList[currentQuestion].correctAnswer == 4)
                {
                    doc.QuestionList[currentQuestion].isCorrectAnswered = true;
                }
            }

            Button btn = ButtonList[currentQuestion];

            if (currentQuestion <= 29)
            {
                currentQuestion = findNextUnanswered(currentQuestion);
            }

            if (hasNextQuestion)
            {
                DrawQuestion(currentQuestion);
                btn.Enabled = false;
                btn.BackColor = Color.RoyalBlue;
                selectButton(ButtonList[currentQuestion]);
            }
            else
            {
                timer.Stop();
                validateIQ();
                CallResultForm();
            }


            questionNumberLbl.Text = string.Format("Избери прашање: {0}", currentQuestion + 1);

        }

        /// <summary>
        /// Функција за наоѓање на следното неодговорено прашање почнувајќи од прашањето проследено како аргумент
        /// </summary>
        /// <param name="previousQuestion">Претходното прашање</param>
        /// <returns>Следното прашање што треба да се одговара</returns>
        private int findNextUnanswered(int previousQuestion)
        {
            deselectButton(ButtonList[previousQuestion]);
            int nextQuestion = previousQuestion;
            i = previousQuestion;
            for (; i < 30; i++)
            {
                if (doc.QuestionList[i].isAnswered == false)
                {
                    nextQuestion = i;
                    break;
                }
            }

            if (i == 30)
            {
                nextQuestion = findFirstUnanswered();
            }
                

            return nextQuestion;
        }
        /// <summary>
        /// Функција за наоѓање на првото неодговорено прашање почнувајќи од првото
        /// </summary>
        /// <returns></returns>
        private int findFirstUnanswered()
        {
            int firstUnanswered = currentQuestion;
            for (i = 0; i < 30; i++)
            {
                if (doc.QuestionList[i].isAnswered == false)
                {
                    firstUnanswered = i;
                    break;
                }
            }

            if (i == 30)
            {
                hasNextQuestion = false;
            }
               

            return firstUnanswered;
        }
        //го пресметува IQ коефициентот
        private void validateIQ()
        {
            int NoCorrectAnswers = 0;
            foreach (Question q in doc.QuestionList)
            {
                if (q.isCorrectAnswered == true)
                {
                    NoCorrectAnswers++;
                }
            }
            IQCoef = (NoCorrectAnswers * 3) + 55;

        }
        //ја повикува формата за резултат
        private void CallResultForm()
        {
            ResultForm resultForm = new ResultForm(IQCoef, Ime);
            this.Hide();

            if (resultForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
        //настан за предвремено завршување на тестот
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            timer.Stop();
            validateIQ();
            foreach (Button b in ButtonList)
            {
                b.Enabled = false;
            }
            CallResultForm();
        }
        //настан за клик врз копчето за избор на претходно прашање прашање
        private void btnPrevious_Click(object sender, EventArgs e)
        {

            GoToPreviousQuestion();
            selectButton(ButtonList[currentQuestion]);
        }
        //настан за клик врз копчето за избор на следно
        private void btnNext_Click(object sender, EventArgs e)
        {
            GoToNextQuestion();
            selectButton(ButtonList[currentQuestion]);
        }
        //функција која се користи за наоѓање на претходно прашање при клик врз копчето за избор на претходно прашање
        private void GoToPreviousQuestion()
        {
            deselectButton(ButtonList[currentQuestion]);
            if (currentQuestion >= 0)
            {
                do
                {
                    if (currentQuestion == 0)
                    {
                        currentQuestion = 29;
                    }
                    else currentQuestion--;
                }
                while (doc.QuestionList[currentQuestion].isAnswered == true);

                DrawQuestion(currentQuestion);
            }

            questionNumberLbl.Text = string.Format("Избери прашање: {0}", currentQuestion + 1);
        }
        //функција која се користи за наоѓање на следното прашање при клик врз копчето за избор на претходно прашање
        public void GoToNextQuestion()
        {
            deselectButton(ButtonList[currentQuestion]);
            if (currentQuestion <= 29)
            {
                do
                {
                    if (currentQuestion == 29)
                    {
                        currentQuestion = 0;
                    }
                    else currentQuestion++;

                }
                while (doc.QuestionList[currentQuestion].isAnswered == true);

                DrawQuestion(currentQuestion);
            }
            else
            {
                DrawQuestion(currentQuestion);
            }

            questionNumberLbl.Text = string.Format("Избери прашање: {0}", currentQuestion + 1);

        }

        //настан за Timer
        private void timer_Tick(object sender, EventArgs e)
        {
            selectButton(ButtonList[currentQuestion]);
            timeElapsed++;
            if (timeElapsed <= TIME)
            {
                int newTime = TIME - timeElapsed;
                int min = newTime / 60;
                int sec = newTime % 60;
                lblTime.Text = string.Format("{0:00}:{1:00}", min, sec);
            }
            else
            {
                timer.Stop();
                validateIQ();
                CallResultForm();
            }
        }

        //за затварање на формата
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        //настан за притискање на стрлеките
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            selectButton(ButtonList[currentQuestion]);
            if (e.KeyCode == Keys.Left)
            {
                GoToPreviousQuestion();
            }

            if (e.KeyCode == Keys.Right)
            {
                GoToNextQuestion();
            }
        }

    }
}