using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_DeckofCards
{
  public class Deck 
  {
    public Card[] DeckCards { get; private set; }
    public int NextCard { get; private set; }
    public string deck;

         Deck()
         {    
                for (int i = 0; i < 52; i++)
                {
                   Card[] DeckCards = new Card[i];
                   Console.WriteLine(DeckCards[i]);
                }
                NextCard = 0;
                
         }


            Deck(Deck existingDeck)
            {
                DeckCards = existingDeck.DeckCards;
            }

        public override string ToString()
        {
            foreach (Card card in DeckCards)
            {
                deck = card.ToString();
                Console.WriteLine($"The original deck is {deck}");
            }
            return $"The original deck is {deck}";
        }

        public  void Shuffle(Card[] DeckCards)
        {
             NextCard = 0;
             Random random = new Random();
                for (int i = 0; i < DeckCards.Length; i++)
                {
                    int CardSwap = random.Next(i, DeckCards.Length);
                    Card temp = DeckCards[i];
                    DeckCards[i] = DeckCards[CardSwap];
                    DeckCards[CardSwap] = temp;
                    Console.WriteLine(DeckCards.ToString);
                }
        }
        

        public Card DealHand(Card[] DeckCards)
        {
            NextCard = 0;
            if (NextCard <= DeckCards.Length)
            {
                return DeckCards[NextCard++];
                Console.WriteLine($"Your card is {DeckCards[NextCard++]}");

            }
                 return DeckCards[NextCard++];
        }
        public Card DealCard()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            var RandomCard = DeckCards[random.Next(0, DeckCards.Length -1)];
            return RandomCard;
        }

        public void ShowDeck()
        {
            string OgDeck;

            for (int i = 0; i <= 52; i++)
            {
                Card card = new Card(i);
                OgDeck = card.ToString();

                Console.WriteLine(OgDeck);
            }
        }


  }     
}
