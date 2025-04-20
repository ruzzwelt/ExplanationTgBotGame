using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplanationTgBotGame
{
    internal class ExplanationModel
    {
        public string[] Words { get; set; }
        public char[] Letters { get; set; }
        public string Hints { get; set; }
        public ExplanationModel()
        {

        }

        private void GetWords()
        {
            this.Words = new string[]
            {
                "Шаль", "Диплом", "Платок", "Палуба" , "Плоскогубцы", "Подросток", "Мухобойка", "Малина", "Чаевые", "Банка"
            };
        }

        private void GetLetters()
        {
            this.Letters = new char[]
            {
                'Д', 'З', 'К', 'П', 'Н', 'О', 'В', 'С', 'Т', 'М', 'Л', 'Р'
            };
        }



        public string GetWord() 
        {
            this.GetWords();

            Random random = new Random();
            return this.Words[random.Next(0, this.Words.Length)];
        }

        public char GetLetter()
        {
            this.GetLetters();

            Random random = new Random();
            return this.Letters[random.Next(0, this.Letters.Length)];
        }

        public string GetHints()
        {
            return this.Hints;
        }
    }
}
