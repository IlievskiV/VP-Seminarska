using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using IQ_Test.Properties;
using System.Reflection;
using System.Windows.Forms;

namespace IQ_Test
{
    //документ класата во проектов
    public class QuestionDocument
    {
        public List<Question> QuestionList{get; set;}

        public QuestionDocument()
        {
            QuestionList = new List<Question>();
            InitializeQuestions();
        }

        //иницијализација на сите прашања
        private void InitializeQuestions()
        {
            //1. слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion1, Resources.ImgQuestion1Answer1, 
                Resources.ImgQuestion1Answer2, Resources.ImgQuestion1Answer3, Resources.ImgQuestion1Answer4, 3));
            //2.текст
            QuestionList.Add(generateTextQuestion(Resources.TxtQuestion1,Resources.TxtQuestion1Answer1, Resources.TxtQuestion1Answer2, 
                Resources.TxtQuestion1Answer3, Resources.TxtQuestion1Answer4,1));
            //3.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion2, Resources.ImgQuestion2Answer1, Resources.ImgQuestion2Answer2,
                Resources.ImgQuestion2Answer3, Resources.ImgQuestion2Answer4, 4));
            //4.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion3, Resources.ImgQuestion3Answer1, Resources.ImgQuestion3Answer2,
                Resources.ImgQuestion3Answer3, Resources.ImgQuestion3Answer4, 2));
            //5.текст
            QuestionList.Add(generateTextQuestion(Resources.TxtQuestion2, Resources.TxtQuestion2Answer1, Resources.TxtQuestion2Answer2,
                Resources.TxtQuestion2Answer3, Resources.TxtQuestion2Answer4, 2));
            //6.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion4, Resources.ImgQuestion4Answer1, Resources.ImgQuestion4Answer2,
               Resources.ImgQuestion4Answer3, Resources.ImgQuestion4Answer4, 4));
            //7.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion5, Resources.ImgQuestion5Answer1, Resources.ImgQuestion5Answer2,
               Resources.ImgQuestion5Answer3, Resources.ImgQuestion5Answer4, 1));
            //8.текст
            QuestionList.Add(generateTextQuestion(Resources.TxtQuestion3, Resources.TxtQuestion3Answer1, Resources.TxtQuestion3Answer2,
                Resources.TxtQuestion3Answer3, Resources.TxtQuestion3Answer4, 1));
            //9.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion6, Resources.ImgQuestion6Answer1, Resources.ImgQuestion6Answer2,
               Resources.ImgQuestion6Answer3, Resources.ImgQuestion6Answer4, 3));
            //10.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion7, Resources.ImgQuestion7Answer1, Resources.ImgQuestion7Answer2,
               Resources.ImgQuestion7Answer3, Resources.ImgQuestion7Answer4, 4));
            //11.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion8, Resources.ImgQuestion8Answer1, Resources.ImgQuestion8Answer2,
               Resources.ImgQuestion8Answer3, Resources.ImgQuestion8Answer4, 2));
            //12.текст
            QuestionList.Add(generateTextQuestion(Resources.TxtQuestion4, Resources.TxtQuestion4Answer1, Resources.TxtQuestion4Answer2,
                Resources.TxtQuestion4Answer3, Resources.TxtQuestion4Answer4, 3));
            //13.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion9, Resources.ImgQuestion9Answer1, Resources.ImgQuestion9Answer2,
              Resources.ImgQuestion9Answer3, Resources.ImgQuestion9Answer4, 1));
            //14.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion10, Resources.ImgQuestion10Answer1, Resources.ImgQuestion10Answer2,
              Resources.ImgQuestion10Answer3, Resources.ImgQuestion10Answer4, 2));
            //15.текст
            QuestionList.Add(generateTextQuestion(Resources.TxtQuestion5, Resources.TxtQuestion5Answer1, Resources.TxtQuestion5Answer2,
                Resources.TxtQuestion5Answer3, Resources.TxtQuestion5Answer4, 3));
            //16.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion11, Resources.ImgQuestion11Answer1, Resources.ImgQuestion11Answer2,
              Resources.ImgQuestion11Answer3, Resources.ImgQuestion11Answer4, 4));
            //17.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion12, Resources.ImgQuestion12Answer1, Resources.ImgQuestion12Answer2,
              Resources.ImgQuestion12Answer3, Resources.ImgQuestion12Answer4, 1));
            //18.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion13, Resources.ImgQuestion13Answer1, Resources.ImgQuestion13Answer2,
              Resources.ImgQuestion13Answer3, Resources.ImgQuestion13Answer4, 2));
            //19.текст
            QuestionList.Add(generateTextQuestion(Resources.TxtQuestion6, Resources.TxtQuestion6Answer1, Resources.TxtQuestion6Answer2,
               Resources.TxtQuestion6Answer3, Resources.TxtQuestion6Answer4, 4));
            //20.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion14, Resources.ImgQuestion14Answer1, Resources.ImgQuestion14Answer2,
              Resources.ImgQuestion14Answer3, Resources.ImgQuestion14Answer4, 2));
            //21.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion15, Resources.ImgQuestion15Answer1, Resources.ImgQuestion15Answer2,
              Resources.ImgQuestion15Answer3, Resources.ImgQuestion15Answer4, 3));
            //22.текст
            QuestionList.Add(generateTextQuestion(Resources.TxtQuestion7, Resources.TxtQuestion7Answer1, Resources.TxtQuestion7Answer2,
              Resources.TxtQuestion7Answer3, Resources.TxtQuestion7Answer4, 2));
            //23.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion16, Resources.ImgQuestion16Answer1, Resources.ImgQuestion16Answer2,
              Resources.ImgQuestion16Answer3, Resources.ImgQuestion16Answer4, 4));
            //24.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion17, Resources.ImgQuestion17Answer1, Resources.ImgQuestion17Answer2,
              Resources.ImgQuestion17Answer3, Resources.ImgQuestion17Answer4, 2));
            //25.текст
            QuestionList.Add(generateTextQuestion(Resources.TxtQuestion8, Resources.TxtQuestion8Answer1, Resources.TxtQuestion8Answer2,
             Resources.TxtQuestion8Answer3, Resources.TxtQuestion8Answer4, 1));
            //26.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion18, Resources.ImgQuestion18Answer1, Resources.ImgQuestion18Answer2,
             Resources.ImgQuestion18Answer3, Resources.ImgQuestion18Answer4, 3));
            //27.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion19, Resources.ImgQuestion19Answer1, Resources.ImgQuestion19Answer2,
             Resources.ImgQuestion19Answer3, Resources.ImgQuestion19Answer4, 4));
            //28.слика
            QuestionList.Add(generateImageQuestion(Resources.ImgQuestion20, Resources.ImgQuestion20Answer1, Resources.ImgQuestion20Answer2,
             Resources.ImgQuestion20Answer3, Resources.ImgQuestion20Answer4, 2));
            //29.текст
            QuestionList.Add(generateTextQuestion(Resources.TxtQuestion9, Resources.TxtQuestion9Answer1, Resources.TxtQuestion9Answer2,
             Resources.TxtQuestion9Answer3, Resources.TxtQuestion9Answer4, 1));
            //30.текст
            QuestionList.Add(generateTextQuestion(Resources.TxtQuestion10, Resources.TxtQuestion10Answer1, Resources.TxtQuestion10Answer2,
            Resources.TxtQuestion10Answer3, Resources.TxtQuestion10Answer4, 1));
        }

        //функција за генерирање на прашање со слика
        private Question generateImageQuestion(Image question, Image answer1, Image answer2,
            Image answer3, Image answer4, int correct)
        {
            Bitmap questionContent = new Bitmap(question);

            Bitmap[] questionAnswers = new Bitmap[4];
            questionAnswers[0] = new Bitmap(answer1);
            questionAnswers[1] = new Bitmap(answer2);
            questionAnswers[2] = new Bitmap(answer3);
            questionAnswers[3] = new Bitmap(answer4);

            return new ImageQuestion(questionContent, questionAnswers, correct);
        }

        //функција за генерирање на прашање со текст
        private Question generateTextQuestion(string question, string answer1, string answer2, string answer3,
            string answer4, int correct)
        {
            string[] questionAnswers = new string[4];
            questionAnswers[0] = answer1;
            questionAnswers[1] = answer2;
            questionAnswers[2] = answer3;
            questionAnswers[3] = answer4;

            return new TextQuestion(question, questionAnswers, correct);
        }
    }
}
