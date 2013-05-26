using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace IQ_Test
{
    public class ImageQuestion:Question
    {
        //како гласи прашањето
        public Bitmap QuestionContent { get; set; }
        //листа од понудени одговори
        public Bitmap[] possibleAnswers { get; set; } 

        public ImageQuestion(Bitmap content, Bitmap[] possibleAns, int correct)
            : base(correct)
        {
            QuestionContent = content;
            possibleAnswers = new Bitmap[possibleAns.Length];
            for (int i = 0; i < possibleAns.Length; i++)
            {
                possibleAnswers[i] = new Bitmap(possibleAns[i]);
            }
        }

        public override void DrawQuestionObject(List<PictureBox> answerGraphics, PictureBox questionGraphics)
        {
            DrawAnswers(answerGraphics);
            DrawQuestion(questionGraphics);
        }

        //функција за исртување на еден од одговорите
        public override void DrawSingleAnswer(PictureBox answerGraphics, int i)
        {
            Pen drawingPen = new Pen(Color.RoyalBlue, 3);
            Bitmap buffered = new Bitmap(answerGraphics.Size.Width, answerGraphics.Size.Height);
            Graphics g = Graphics.FromImage(buffered);
            g.DrawImageUnscaledAndClipped(possibleAnswers[i], new Rectangle(0, 0, answerGraphics.Size.Width, answerGraphics.Size.Height));
            g.DrawRectangle(drawingPen, 2, 2, answerGraphics.Size.Width - 4, answerGraphics.Size.Height - 4);
            answerGraphics.Image = buffered;
            g.Dispose();
        }
        //мора answerGraphics.Count == possibleAnswers.Length
        public override void DrawAnswers(List<PictureBox> answerGraphics)
        {
            for (int i = 0; i < answerGraphics.Count; i++)
            {
                DrawSingleAnswer(answerGraphics[i], i);
            }
        }
        //функција за исртување на прашањето
        public override void DrawQuestion(PictureBox questionGraphics)
        {
            Pen drawingPen = new Pen(Color.RoyalBlue, 3);
            Bitmap buffered = new Bitmap(questionGraphics.Size.Width, questionGraphics.Size.Height);
            Graphics g = Graphics.FromImage(buffered);
            g.DrawImageUnscaledAndClipped(QuestionContent, new Rectangle(0,0,questionGraphics.Size.Width, questionGraphics.Size.Height));
            g.DrawRectangle(drawingPen, 2, 2, questionGraphics.Size.Width - 4, questionGraphics.Size.Height - 4);
            questionGraphics.Image = buffered;
            g.Dispose();
        }
    }
}
