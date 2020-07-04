using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exercise
{
    class Banana : fruit
    {
       public bool _hasBlackSpots;
       public bool _isGreen;
       public float _size;
        public override bool IsThisMyFavorite()
        {
            return true;
        }

        public override string ToString()
        {
            return base.ToString()+ $"is it green {_isGreen}, does it have black spots {_hasBlackSpots}, size {_size}";
        }
    }
}
