using System;
using System.Collections.Generic;

namespace Quest
{
    public class Prize
    {
        private string _text;

        public Prize(string text)
        {
            _text = text;
        }

        public void showPrize(Adventurer player)
        {
            if (player.Awesomeness > 0)
            {
                Console.WriteLine(_text);
            }
            else
            {
                Console.WriteLine("I'm just so.... I'm so...... disappointed...");
            }
        }

    }
}