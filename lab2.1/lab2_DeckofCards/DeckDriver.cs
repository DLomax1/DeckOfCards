namespace lab2_DeckofCards
{
    public class DeckDriver 
    {
        static public void Main(string[] args)
        {
            
            int userinput;
            Card card = new Card();
            Card usercard = new Card();
            Console.WriteLine($"The default card is {card}");



            do
            {

                Console.WriteLine("Please enter a non-negative integer between 1-52");
                userinput = int.Parse(Console.ReadLine());


                /// if (userinput < 1 || userinput > 52)
                /// {
                ///   usercard = new Card();
                ///       Console.WriteLine("invalid input please enter an integer 1-52");
                /// }
                /// else
                /// Console.WriteLine($"your card is {usercard} ");
                if (userinput <= 52 && userinput >= 1)
                {
                    usercard = new Card(userinput);
                    Console.WriteLine($"your card is {usercard} ");
                }
                else if (userinput == -1)
                {
                    Console.WriteLine("Goodbye");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            } while (userinput != -1);

            Deck.ToString();
            Deck.Shuffle();
            Deck.DealCard();
            ShowDeck();
           

        }

        private static void ShowDeck()
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