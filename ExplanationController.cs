using Telegram.Bot.Types;

namespace ExplanationTgBotGame
{
    internal class ExplanationController
    {
        private ExplanationModel Game;


        public ExplanationController()
        {
            this.Game = new ExplanationModel();
        }

        public void StartNewGame()
        {
            //this.GetWord();
        }

        public string GetWord()
        {
            return "Слово: " + Game.GetWord() + ". Буква: " + Game.GetLetter() + ". Осталось слов: " + Game.Words.Count;
        }
    }
}
