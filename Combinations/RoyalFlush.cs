using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksOrBetter
{
    class RoyalFlush : ICombination
    {
        public string name
        {
            get
            {
                return "Royal Flush";
            }
        }
        public int prize
        {
            get
            {
                return 800;
            }
        }

        public ICombination Combination(Hand hand)
        {
            List<Card> tempList = hand.cards.OrderBy(order => order.value).ToList();//sorts the list
            int count1 = 0;
            int count2 = 0;
            Value value = tempList.ElementAt(1).value;
            Suits suit = tempList.ElementAt(0).suit;
            for (int i = 0; i < tempList.Count; i++)
            {
                if (value == tempList.ElementAt(i).value)
                {
                    count1++;
                    value++;
                }//checks if cards go straight up to four

                if (suit == tempList.ElementAt(i).suit)
                {
                    count2++;
                }
            }

            if (count1==4&&count2==5&&tempList.ElementAt(0).value==Value.Ace&& tempList.ElementAt(1).value == Value.Ten &&tempList.ElementAt(0).suit == suit)// checks if there is ace and if the second value is Ten
            {
                return this;
            }

                return null;

            
        }
    }
}
