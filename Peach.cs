using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exercise
{
    class Peach : fruit
    {
        public double _size;
        public bool _isScrached;
        public override bool IsThisMyFavorite()
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + $"size {_size}, is it scrached {_isScrached}";
        }
    }
}
