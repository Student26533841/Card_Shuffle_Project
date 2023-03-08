using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Card
    {
        private string face;
        private string suit;

        public Card(string card_face, string card_suit)
        {
            face = card_face;
            suit = card_suit;
        }

        public override string ToString()
        {
            return face + " of " + suit;
        }
    }
}
