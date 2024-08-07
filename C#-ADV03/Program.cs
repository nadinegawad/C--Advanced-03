using static C__ADV03.Helper;

namespace C__ADV03
{
    internal class Program
    {
        //public delegate int StringFunDelegate(string str);
        static void Main(string[] args)
        {
            //Func<string,int> stringFunDelegate;
            //stringFunDelegate = StringFunctions.GetCountOfUpperChars;
            ////int Result= stringFunDelegate.Invoke("aMR AhemED");
            ////Console.WriteLine(Result);

            //stringFunDelegate += StringFunctions.GetCountOfLowerChars;
            ////int Result = stringFunDelegate.Invoke("aMR AhemED");
            ////Console.WriteLine(Result);
            //stringFunDelegate -= StringFunctions.GetCountOfLowerChars;
            //int Result = stringFunDelegate.Invoke("aMR AhemED");
            //Console.WriteLine(Result);

            //E01
            //int[] array = new int[] { 5, 8, 9, 1, 12, 5, 15, 99, 9 };
            //SortingAlgoruthm<int>.BuybbleSort(array, CompareFunctions.CompareGrt);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            //Console.WriteLine("=================================");
            //SortingAlgoruthm<int>.BuybbleSort(array, CompareFunctions.CompareLess);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            //string[] Names = new string[] { "Ahmed", "mohamed", "Amr", "Maha", "Nourhan", "Aya" };
            //SortingAlgoruthm<string>.BuybbleSort(Names, CompareFunctions.SortAsce);

            //for (int i = 0; i < Names.Length; i++)
            //{
            //    Console.WriteLine(Names[i]);
            //}


            //List<int> numbers = Enumerable.Range(1, 100).ToList();

            //Predicate<int> conditionalFuncDel = ConditionalFunctions.IsOdd;
            //List<int> OddNumbers = Helper.GetElements(numbers, conditionalFuncDel);
            //foreach (int number in OddNumbers)
            //{
            //    Console.Write($" {number}");
            //}
            //List<int> EvenNumbers = Helper.GetElements(numbers, ConditionalFunctions.IsEven);

            //Console.WriteLine("\nEven Numbers\n");
            //foreach (int number in EvenNumbers)
            //{
            //    Console.Write($" {number}");
            //}

            //List<int> Divisableby7 = Helper.GetElements(numbers, ConditionalFunctions.IsDivisableBy7);

            //Console.WriteLine("\nDivisableby7 Numbers\n");
            //foreach (int number in Divisableby7)
            //{
            //    Console.Write($" {number}");
            //}

            //List<int> Divisableby10 = Helper.GetElements(numbers, ConditionalFunctions.IsDivisableBy10);

            //Console.WriteLine("\nDivisableby10 Numbers\n");
            //foreach (int number in Divisableby10)
            //{
            //    Console.Write($" {number}");
            //}

            //List<string> list = new List<string>() { "Ahmed", "Amr", "Manar", "Kareem", "Belal" };
            //List<string> Names = Helper.GetElements(list, ConditionalFunctions.NamesLess4Char);
            //foreach (string name in Names)
            //{
            //    Console.WriteLine(name);
            //}

            #region Predicate
            //Predicate<int> predicate;
            //predicate = TestFunctions.Test01;
            //Console.WriteLine(predicate.Invoke(9)); 
            #endregion

            #region Func
            //Func<int, string> func;
            //func = TestFunctions.Test02;
            //Console.WriteLine(func(9)); 
            #endregion

            #region Action
            //non generic
            //Action action;
            //action = TestFunctions.Test03;
            //action(); 

            //generic
            //Action<string> action;
            //action = TestFunctions.Test04;
            //action.Invoke("Amr");
            #endregion


            #region Anonymous Function
            #region Predicate
            //Predicate<int> predicate;
            //predicate = delegate (int x) { return x > 0; };
            //Console.WriteLine(predicate.Invoke(9));
            //#endregion

            //#region Func
            //Func<int, string> func;
            //func = delegate (int x) { return x.ToString(); };

            //Console.WriteLine(func(9));
            //#endregion

            //#region Action
            ////non generic
            ////Action action;
            ////action = delegate () { Console.WriteLine("hellooo"); };
            ////action();

            ////generic
            //Action<string> action;
            //action = delegate (string name) { Console.WriteLine($"Hello {name}"); };
            //action.Invoke("Amr");
            #endregion
            #endregion

            #region Lambda Expersion
            #region Predicate
            //Predicate<int> predicate;
            //predicate = (x) => x > 0;
            //Console.WriteLine(predicate.Invoke(9));
            //#endregion

            //#region Func
            //Func<int, string> func;
            //func =  (x) => x.ToString();

            //Console.WriteLine(func(9));
            //#endregion

            //#region Action
            ////non generic
            //Action action;
            //action = () => Console.WriteLine("hellooo"); 
            //action();

            ////generic
            //Action<string> action;
            //action =(name) => Console.WriteLine($"Hello {name}");
            //action.Invoke("Amr");
            #endregion
            #endregion


            List<int> Numbers= Enumerable.Range(1,100).ToList();
            //foreach(int i in Numbers)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine("\n===========================");
            //List<int> OddNumbers=  Numbers.FindAll(number => number % 2 == 1);
            //foreach(int i in OddNumbers)
            //{
            //    Console.Write($"{i} ");

            //}
            //Console.WriteLine(Numbers.Find(number => number % 2 == 0));
            //Numbers.ForEach(number=> number+=10);
            //foreach (int i in Numbers)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine("\n============================");
            //Numbers.ForEach(number =>Console.Write($"{ number + 10} "));

           //int count= Numbers.RemoveAll(number=>number %5==0);
           // //foreach (int i in Numbers)
           // //{
           // //    Console.Write($"{i} ");
           // //}
           // Console.WriteLine(count);
        }

        //class TestFunctions
        //{
        //    public static bool Test01(int x){return x > 0;}
        //    public static string Test02(int x){return x.ToString();} 

        //    public static void Test03() { Console.WriteLine("hellooo"); }

        //    public static void Test04(string name) { Console.WriteLine($"Hello {name}"); }
        //}
    }
}
