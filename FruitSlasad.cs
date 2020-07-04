using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop_exercise
{
    class FruitSlasad
    {
        public fruit[] _fruit;
        public int GetTotalCalories()
        {
            int totalCalories = 0;
            for (int i = 0; i < _fruit.Length; i++)
            {

                totalCalories = totalCalories + _fruit[i]._calories;

            }
            return totalCalories;
        }
        public bool ContainsMyFavoriteFruit()
        {
            for (int i = 0; i <_fruit.Length; i++)
            {
                if (_fruit[i].IsThisMyFavorite())
                {
                    return true;
                }
            }
            return false;
        }
        string s;
        public override string ToString()
        {
            
            for (int i = 0; i < _fruit.Length; i++)
            {
                s = s + $"{_fruit[i]._name} ";
            }
            return s;
        }
    }
}
