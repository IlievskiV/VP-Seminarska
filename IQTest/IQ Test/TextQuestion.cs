using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace IQ_Test
{
    public class TextQuestion:Question
    {
        //како гласи прашањето
        public string QuestionContent { get; set; }
        //листа од понудени одговори
        public string[] possibleAnswers { get; set; }

        public TextQuestion(string content, string[] possibleAns, int correct)
            : base(correct)
        {
            QuestionContent = content;
            possibleAnswers = new string[possibleAns.Length];
            for (int i = 0; i < possibleAns.Length; i++)
            {
                possibleAnswers[i] = possibleAns[i];
            }
        }

        public override void DrawQuestionObject(List<PictureBox> answerGraphics, PictureBox questionGraphics)
        {
            DrawQuestion(questionGraphics);
            DrawAnswers(answerGraphics);
        }

        public override void DrawQuestion(PictureBox questionGraphics)
        {
            Pen drawingPen = new Pen(Color.RoyalBlue, 3);
            Bitmap buffered = new Bitmap(questionGraphics.Size.Width, questionGraphics.Size.Height);
            Graphics g = Graphics.FromImage(buffered);
            g.DrawString(QuestionContent, new Font("Times New Roman", 20.0f), new SolidBrush(Color.Black), 10, 10);
            g.DrawRectangle(drawingPen, 2, 2, questionGraphics.Size.Width - 4, questionGraphics.Size.Height - 4);
            questionGraphics.Image = buffered;
            g.Dispose();
        }

        public override void DrawSingleAnswer(PictureBox answerGraphics, int i)
        {
            Pen drawingPen = new Pen(Color.RoyalBlue, 3);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            Bitmap buffered = new Bitmap(answerGraphics.Size.Width, answerGraphics.Size.Height);
            Graphics g = Graphics.FromImage(buffered);
            RectangleF rectangle = new RectangleF(0, 0, answerGraphics.Width, answerGraphics.Height);
            g.DrawString(possibleAnswers[i], new Font("Times New Roman", 20.0f), new SolidBrush(Color.Black), rectangle, format);
            g.DrawRectangle(drawingPen, 2, 2, answerGraphics.Size.Width - 4, answerGraphics.Size.Height - 4);
            answerGraphics.Image = buffered;
            g.Dispose();
        }

        public override void DrawAnswers(List<PictureBox> answerGraphics)
        {
            
            for (int i = 0; i < answerGraphics.Count; i++)
            {
                DrawSingleAnswer(answerGraphics[i], i);
            }
        }
    }
}
