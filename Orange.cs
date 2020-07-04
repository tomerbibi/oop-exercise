using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exercise
{
    class Orange : fruit
    {
        public bool _isHard;
        public bool _isRound;
        public override bool IsThisMyFavorite()
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + $"is it hard {_isHard}, is it round {_isRound}";
        }
    }
}
