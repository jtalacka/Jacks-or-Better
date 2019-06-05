using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksOrBetter
{
    class Flush : ICombination
    {
        public string name
        {
            get
            {
                return "Flush";
            }
        }
        public int prize
        {
            get
            {
                return 6;
            }
        }

        public ICombination Combination(Hand hand)
        {
            List<Card> tempList = hand.cards.OrderBy(order => order.value).ToList();// sorts the list
            int count = 0;
            Suits suit = tempList.ElementAt(0).suit;
            for (int i = 0; i < tempList.Count; i++)
            {
                if (suit == tempList.ElementAt(i).suit)
                {
                    count++;
                }
            }
            if (count == 5)//checks if all the card have the same suit
            {
                return this;
            }
            else
            {
                return null;
            }
        }
    }
}
