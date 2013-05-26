using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace IQ_Test
{
    public abstract class Question
    {
        //индексот во листата на точниот одговор
        public int correctAnswer { get; set; }
        //дали прашањето е точно одговорено
        public bool isCorrectAnswered { get; set; }
        //дали прашањето е одговарано некогаш
        public bool isAnswered { get; set; }

        public Question(int correct)
        {
            correctAnswer = correct;
            isAnswered = false;
        }

        //како ќе се исцртува целокупното прашање прашањето на екранот
        public abstract void DrawQuestionObject(List<PictureBox> answerGraphics, PictureBox questionGraphics);
        //како ќе се исцртуваат одговорите
        public abstract void DrawAnswers(List<PictureBox> answerGraphics);
        //како ќе се исцртува прашањето на панелата
        public abstract void DrawQuestion(PictureBox questionGraphics);
        //исцртување на само еден одговор
        public abstract void DrawSingleAnswer(PictureBox answerGraphics, int n);
    }
}
