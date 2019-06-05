using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksOrBetter
{
    class ThreeOfAKind : ICombination
    {
        public string name
        {
            get
            {
                return "Three of a kind";
            }
        }
        public int prize
        {
            get
            {
                return 3;
            }
        }

        public ICombination Combination(Hand hand)
        {
            List<Card> tempList = hand.cards.OrderBy(order => order.value).ToList();//Sorts the list
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            Value value1 = hand.cards.ElementAt(0).value;
            Value value2 = hand.cards.ElementAt(1).value;
            Value value3 = hand.cards.ElementAt(2).value;
            for (int i = 0; i < tempList.Count; i++)
            {
                if (value1 == hand.cards.ElementAt(i).value)
                {
                    count1++;
                }
                else if (value2 == hand.cards.ElementAt(i).value)
                {
                    count2++;
                }
                else if (value3 == hand.cards.ElementAt(i).value)
                {
                    count3++;
                }

            }
            if (count1 == 3 || count2 == 3 || count3 == 3)
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
