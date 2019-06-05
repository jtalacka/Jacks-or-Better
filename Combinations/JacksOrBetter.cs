using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksOrBetter
{
    class JacksOrBetter : ICombination
    {
        public string name
        {
            get
            {
                return "Jacks or Better";
            }
        }
        public int prize
        {
            get
            {
                return 1;
            }
        }

        public ICombination Combination(Hand hand)
        {
            List<Card> tempList = hand.cards.OrderBy(order => order.value).ToList();
            for (int i = 0; i <tempList.Count; i++) {
                if (tempList.ElementAt(i).value >= Value.Jack|| tempList.ElementAt(i).value == Value.Ace)//checks if value is above jack or if it is Ace
                {
                    return this;
                }
            }
            return null;

        }

    }
}
