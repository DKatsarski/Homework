﻿using Cards.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Logic
{
    public class Card
    {
        public Card(CardSuit suit, CardType type)
        {
            this.Suit = suit;
            this.Type = type;
        }
        public CardSuit Suit { get; private set; }

        public CardType Type { get; private set; }

        public override bool Equals(object obj)
        {
            var anotherCard = obj as Card;
            if (anotherCard == null)
            {
                return false;
            }

            return this.Suit == anotherCard.Suit 
                && this.Type == anotherCard.Type;

         
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", this.Type.ToFriendlyString(), this.Suit.ToFriendlyString());
        }


    }
}
