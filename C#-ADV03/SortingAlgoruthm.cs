using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ADV03
{
    //public delegate TOut CompareFuncDel<in T,out TOut>(T A, T B);
    internal class SortingAlgoruthm<T>
    {

        //public static void BuybbleSort(int[] arr, CompareFuncDel compareFunc)
        //{
        //    if(arr is not null)
        //    {
        //        for(int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - i - 1; j++)
        //            {
        //                if (compareFunc(arr[j], arr[j + 1]))
        //                {
        //                    Swap(ref arr[j], ref arr[j + 1]);   
        //                }
        //            }
        //        }
        //    }
        //}
        public static void BuybbleSort(T[] arr, Func<T,T,bool> compareFunc)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (compareFunc(arr[j], arr[j + 1]))
                        {
                            Swap(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }
            }
        }
        private static void Swap(ref T v1, ref T v2)
        {
            T temp= v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
