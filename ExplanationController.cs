using Telegram.Bot.Types;

namespace ExplanationTgBotGame
{
    internal class ExplanationController
    {
        private ExplanationModel GameModel;


        public ExplanationController()
        {
            this.GameModel = new ExplanationModel();
        }

        public void StartNewGame()
        {
            //this.GetWord();
        }

        public string GetWord()
        {
            return "Слово: " + GameModel.GetWord() + ". Буква: " + GameModel.GetLetter() + ". Осталось слов: " + GameModel.Words.Count;
        }
    }
}
