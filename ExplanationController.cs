using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplanationTgBotGame
{
    internal class ExplanationController
    {

        public string StartNewGame()
        {
            ExplanationModel Game = new ExplanationModel();
            return "Слово: " + Game.GetWord() + ". Буква: "+ Game.GetLetter();
        }


    }
}
