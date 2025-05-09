using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplanationTgBotGame.Models
{
    internal class LettersModel
    {
        public static char[] GetList()
        {
            var letters = new char[]
            {
                'Д', 'З', 'К', 'П', 'Н', 'О', 'В', 'С', 'Т', 'М', 'Л', 'Р'
                //'Д', 'З', 'К'
            };

            return letters;
        }
    }
}
