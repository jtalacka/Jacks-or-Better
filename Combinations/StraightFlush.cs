using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksOrBetter
{
    class StraightFlush : ICombination
    {
        public string name
        {
            get
            {
                return "Straight Flush";
            }
        }
        public int prize
        {
            get
            {
                return 50;
            }
        }

        public ICombination Combination(Hand hand)
        {
            List<Card> tempList = hand.cards.OrderBy(order => order.value).ToList();
            int count1 = 0;
            int count2 = 0;
            Value value = tempList.ElementAt(0).value;
            Suits suit = tempList.ElementAt(0).suit;
            for (int i = 0; i < tempList.Count; i++)
            {
                if (value == tempList.ElementAt(i).value)
                {
                    count1++;
                    value++;
                }

                if (suit == tempList.ElementAt(i).suit)
                {
                    count2++;
                }
            }
            if (count1 == 5 && count2 == 5)
            {
                return this;
            }
            else
            {
                count1 = 0;
                value = tempList.ElementAt(1).value;

                for (int i = 0; i < tempList.Count; i++)
                {
                    if (value == tempList.ElementAt(i).value)
                    {
                        count1++;
                        value++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count1 == 4 && count2==5&&tempList.ElementAt(0).value == Value.Ace && tempList.ElementAt(1).value == Value.Ten)//Checks if there are four cards that go straight up and if the is an ace and ten next to it also checks if all the colors match
                {
                    return this;
                }
                return null;

            }
            }
    }
}
