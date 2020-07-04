using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop_exercise
{
    class Apple : fruit
    {
      
        public string _color;
        public bool _pinkLady;
        public override bool IsThisMyFavorite()
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString()+ $"color {_color}, is it pink lady {_pinkLady}";
        }
    }
}
