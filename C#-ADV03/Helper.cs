using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ADV03
{
    internal static class Helper
    {


        //public delegate bool ConditionalFuncDel<T>(T x);
        public static List<T> GetElements<T>(List<T> element, Predicate<T> condistion)
        {
            List<T> result = new List<T>();
            if (element is not null && condistion is not null)
            {
                for (int i = 0; i < element.Count; i++)
                {
                    if (condistion(element[i]))
                    {
                        result.Add(element[i]);
                    }
                }

            }
            return result;

        }
        //public static List<int> GetNumbers(List<int> numbers ,ConditionalFuncDel condistion)
        //{
        //    List<int> result = new List<int>();
        //    if(numbers is not null && condistion is not null)
        //    {
        //        for(int i = 0; i < numbers.Count; i++)
        //        {
        //            if (condistion( numbers[i]))
        //            {
        //                result.Add(numbers[i]);
        //            }
        //        }

        //    }
        //    return result;

        //}


        //public static List<int> GetEvenNumbers(List<int> numbers)
        //{
        //    List<int> result = new List<int>();
        //    if (numbers is not null)
        //    {
        //        for (int i = 0; i < numbers.Count; i++)
        //        {
        //            if (numbers[i] % 2 == 0)
        //            {
        //                result.Add(numbers[i]);
        //            }
        //        }

        //    }
        //    return result;

        //}
    }
}
