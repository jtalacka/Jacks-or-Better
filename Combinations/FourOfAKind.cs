using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksOrBetter
{
    class FourOfAKind : ICombination
    {
        public string name
        {
            get
            {
                return "Four of a kind";
            }
        }
        public int prize
        {
            get
            {
                return 25;
            }
        }

        public ICombination Combination(Hand hand)
        {
            List<Card> tempList = hand.cards.OrderBy(order => order.value).ToList();//sorts the list
            int count1 = 0;
            int count2 = 0;
            Value value1 = hand.cards.ElementAt(0).value;
            Value value2= hand.cards.ElementAt(1).value;
            for (int i = 0; i < tempList.Count; i++)
            {
                if(value1== hand.cards.ElementAt(i).value)
                {
                    count1++;
                }else if (value2 == hand.cards.ElementAt(i).value)
                {
                    count2++;
                }

            }
            if (count1 == 4 || count2 == 4)// checks if four cards have the save value
            {
                return this;
            }
            else {
                return null;
            }
        }
    }
}
