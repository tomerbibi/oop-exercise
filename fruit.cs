using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exercise
{
    abstract class fruit
    {
        public string _name;
        public int _calories;
        abstract public bool IsThisMyFavorite();

        public override string ToString()
        {
            return $"{_name}, amount of calories: {_calories}, ";
        }
    }
}
