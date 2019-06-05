using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksOrBetter
{
    interface ICombination
    {
        string name { get;}
        int prize { get;}
        ICombination Combination(Hand hand);
    }
}
