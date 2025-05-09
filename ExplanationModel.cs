using System.Collections.Generic;
using ExplanationTgBotGame.Models;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;


namespace ExplanationTgBotGame
{
    internal class ExplanationModel
    {
        public List<string> Words { get; set; }
        public char[] Letters { get; set; }
        public string Hints { get; set; }
        public ExplanationModel()
        {
            this.GetWords();
            this.GetLetters();
        }

        private void GetWords()
        {
            this.Words = WordsModel.GetList();
        }

        private void GetLetters()
        {
            this.Letters = LettersModel.GetList();
        }

        private int GetRandIndex(int maxLength)
        {
            Random random = new Random();
            int index = random.Next(0, maxLength);

            return index;
        }

        public string GetWord() 
        {
            if(this.Words.Count == 0)
            {
                this.GetWords();
            }

            int index = this.GetRandIndex(this.Words.Count);
            string GotWord = this.Words[index];
            this.Words.RemoveAt(index);
            
            return GotWord;
        }
            
        public char GetLetter()
        {
            int index = this.GetRandIndex(this.Letters.Length);
            char GotLetter = this.Letters[index];

            return GotLetter;
        }

        public string GetHints()
        {
            return this.Hints;
        }
    }
}
