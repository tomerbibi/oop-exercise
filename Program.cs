using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace oop_exercise
{
    class Program
    {
        public static void PrintIfContainsMyFavoriteFruit(FruitSlasad f)
        {
            for (int i = 0; i < f._fruit.Length; i++)
            {
                if (f._fruit[i].IsThisMyFavorite())
                {
                    Console.WriteLine("this fruit salad contain my favorite fruit");
                    break;
                }
                if (i == f._fruit.Length-1)
                {
                    Console.WriteLine("this fruit salad doesnt contain my favorite fruit");
                }
            }


        }
        public static void GetBananaSize(Banana b)
        {
            Console.WriteLine($"the size of this banana is {b._size}");
        }
        public static void PrintAppleColor(Apple a)

        {
            Console.WriteLine($"the color of this apple is {a._color}");
        }
      

        public static void PrintTotalCalories(FruitSlasad f)
        {
            Console.WriteLine(f.GetTotalCalories());
        }

       


        static void Main(string[] args)
        {

            FruitSlasad f = new FruitSlasad()
            {
                _fruit = new fruit[4]
                {
                    new Apple { _calories = 80, _color = "red", _name = "apple", _pinkLady = true },
                    new Banana { _calories = 100, _name = "banana", _hasBlackSpots = false, _isGreen = true, _size = 8.9f },
                    new Peach { _name = "peach", _size = 7f, _calories = 70, _isScrached = false },
                    new Orange { _calories = 90, _name = "orange", _isHard = true, _isRound = true }
                }
            };

            Apple a = new Apple { _color = "green"};
            Banana b = new Banana() { _size = 8};
            PrintAppleColor(a);
            GetBananaSize(b);
            PrintIfContainsMyFavoriteFruit(f);
            PrintTotalCalories(f);
            
        }
    }
}
