using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksOrBetter
{
    class AllOther : ICombination
    {
        public string name
        {
            get
            {
                return "All other";
            }
        }
        public int prize
        {
            get
            {
                return 0;
            }
        }

        public ICombination Combination(Hand hand)
        {
            return this;
        }
    }
}
