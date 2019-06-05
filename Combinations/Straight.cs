using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksOrBetter
{
    class Straight : ICombination
    {
        public string name
        {
            get
            {
                return "Straight";
            }
        }
        public int prize
        {
            get
            {
                return 4;
            }
        }

        public ICombination Combination(Hand hand)
        {
            List<Card> tempList = hand.cards.OrderBy(order => order.value).ToList();
            int count = 0;
            Value value = tempList.ElementAt(0).value;

            for (int i = 0; i < tempList.Count; i++)
            {
                if (value == tempList.ElementAt(i).value)
                {
                    count++;
                    value++;
                }
                else {
                    break;
                }
            }



            if (count == 5)// checks if all five cards are go straight one after another
            {
                return this;
            }
            else
            {
                count = 0;
                value = tempList.ElementAt(1).value;

                for (int i = 0; i < tempList.Count; i++)
                {
                    if (value == tempList.ElementAt(i).value)
                    {
                        count++;
                        value++;
                    }

                }
                if(count==4&&tempList.ElementAt(0).value==Value.Ace&& tempList.ElementAt(1).value == Value.Ten)//Checks if there are four cards that go straight up and if the is an ace and ten next to it
                {
                    return this;
                }


                return null;
            }
        }
    }
}
