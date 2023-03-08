using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{

    public class Deck
    {        
        private Card[] deck; // creates deck of 52 cards
        private int current_card;
        private const int number_of_cards = 52;
        private Random random_num;

        public Deck() // sets the array of faces and suits
        {
            string[] faces = {"Ace", "Two", "Three", "Four", "Five ", "Six", "Seven",
            "Eight", "Nine", "Ten", "Jack", "Queen", "King"};

            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            deck = new Card[number_of_cards];
            current_card = 0;
            random_num = new Random();
            for (int count = 0; count < deck.Length; count++)
                deck[count] = new Card(faces[count % 11], suits[count / 13]);
        }

        public void shuffle() //shuffles deck
        {
            current_card = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = random_num.Next(number_of_cards);
                Card temp = deck[first]; // makes temp card into first
                deck[first] = deck[second]; // makes first card into second
                deck[second] = temp; // makes second card into temp
            }
        }

        public Card deal_card()
        {
            if (current_card < 52)
            {
                return deck[current_card++];
            }
            else
                return null;
        }
    }
}
