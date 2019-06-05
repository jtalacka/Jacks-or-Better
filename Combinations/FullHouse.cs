using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksOrBetter
{
    class FullHouse : ICombination
    {
        public string name
        {
            get
            {
                return "Full House";
            }
        }
        public int prize
        {
            get
            {
                return 9;
            }
        }

        public ICombination Combination(Hand hand)
        {
            List<Card> tempList = hand.cards.OrderBy(order => order.value).ToList();//sorts the list
            int count1 = 0;
            int count2 = 0;
            Value value1 = hand.cards.ElementAt(0).value;
            Value value2 = hand.cards.ElementAt(hand.cards.Count-1).value;
            for (int i = 0; i < tempList.Count; i++)
            {
                if (value1 == hand.cards.ElementAt(i).value)
                {
                    count1++;
                }
                if (value2 == hand.cards.ElementAt(i).value)
                {
                    count2++;
                }

            }
            if ((count1 == 3 && count2 == 2) || (count1 == 2 && count2 == 3))
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
