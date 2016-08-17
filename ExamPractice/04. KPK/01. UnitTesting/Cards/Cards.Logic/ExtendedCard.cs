using Cards.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Logic
{
    public static class ExtendedCard
    {
        public static string ToFriendlyString(this CardType cardType)
        {
            switch (cardType)
            {
                case CardType.Ten: return "T";
                  
                case CardType.Jack: return "J";
                  
                case CardType.Queen: return "Q";
                  
                case CardType.King: return "K";
                   
                case CardType.Ace: return "A";
                    
                default:
                    throw new ArgumentException("cardType");
                   
            }

        }

        public static string ToFriendlyString(this CardSuit cardSuit)
        {
            switch (cardSuit)
            {
                case CardSuit.Heart: return "♥";
                case CardSuit.Club: return "♣";
                case CardSuit.Spade: return "♠";
                case CardSuit.Diamond: return "♦";
                default:
                    throw new ArgumentException("No such suit");
                   
            }
        }
    }
}
