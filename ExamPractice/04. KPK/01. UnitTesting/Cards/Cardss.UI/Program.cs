using Cards.Logic;
using Cards.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardss.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card(CardSuit.Club, CardType.Ace);
            Console.WriteLine(card.ToString());
        }
    }
}
