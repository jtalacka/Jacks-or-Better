using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksOrBetter
{
    enum Suits {Clubs,Hearts,Spades,Diamonds};
    enum Value {Ace,Two,Three,Four,Five,Six,Seven,Eight,Nine,Ten,Jack,Queen,King};

    class Card// Card class
    {
      public Suits suit;
      public Value value;
        public bool selected;
        public Card(Suits suit,Value value)
        {
            this.suit = suit;
            this.value = value;
            selected = false;
        }
        public string generateName() {// generate name returns the string of how the card should be called
            if (selected == false)
            {
                return value + " of " + suit;
            }
            else {
                return value + " of " + suit+ "<--- Change";
            }
        }

    }
}
