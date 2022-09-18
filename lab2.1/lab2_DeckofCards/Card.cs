using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_DeckofCards
{
      public class Card
      {
             Face face;
             Suit suit;


        public Card()
        {
            face = Face.Three;
            suit = Suit.Hearts;
        }

        public Card(Card existingCard)
        {
            face = existingCard.face;
            suit = existingCard.suit;
        }

        public Card(int n)
        {
            face = (Face)Enum.GetValues(typeof(Face)).GetValue(n % 13);
            suit = (Suit)Enum.GetValues(typeof(Suit)).GetValue(n % 4);
        }



        public override string ToString()
        {
            string cardString = $"the {face} of {suit}";
            return cardString;
        }

      }


}

