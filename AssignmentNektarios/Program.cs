using System;
using System.Collections.Generic;
using System.Diagnostics;
using AssignmentNektarios.SortingAlgorithms;
using AssignmentNektarios.Store;
using SortingAlgorithmsCB10;

namespace AssignmentNektarios
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please choose your shorting method.Pick:");
            Console.WriteLine("1:bubbleShort based on Size In Ascending");
            Console.WriteLine("2:bubbleShort based on Size in Descending");
            Console.WriteLine("3:bubbleShort based on Color in Ascending");
            Console.WriteLine("4:bubbleShort based on Color in Descending");
            Console.WriteLine("5:bubbleShort based on Fabric in Ascending");
            Console.WriteLine("6:bubbleShort based on Fabric in Descending");
            Console.WriteLine("7:QuickSort based on Size in Ascending");
            Console.WriteLine("8:QuickSort based on Size in Descending");
            Console.WriteLine("9:Bucket short based on Size in Descending");
            Console.WriteLine("10:QuickSort based on Size in Descending");
            Console.WriteLine("11:QuickSort based on Size in Descending");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {

                case 1:
                    MyDatabase db = new MyDatabase();
                    Stopwatch watch = new Stopwatch();
                    var newLista = new List<Shirt>(db.Shirts);
                    Console.WriteLine("List sorted with bubbleShort based on Size In Ascending");
                    BubbleSort.SortShirtsAsc(newLista);
                    foreach (var item in newLista)
                    {
                        item.Output();
                    }
                    watch.Restart();
                    break;
                case 2:
                    MyDatabase db1 = new MyDatabase();
                    Stopwatch watch1 = new Stopwatch();
                    var newLista1 = new List<Shirt>(db1.Shirts);
                    Console.WriteLine("List sorted with bubbleShort based on Size in Descending");
                    BubbleSort.SortShirtsDesc(newLista1);
                    foreach (var item in newLista1)
                    {
                        item.Output();
                    }
                    break;
                case 3:
                    MyDatabase db2 = new MyDatabase();
                    Stopwatch watch2 = new Stopwatch();
                    var newLista2 = new List<Shirt>(db2.Shirts);

                    BubbleSort.SortShirtsclAsc(newLista2);
                    Console.WriteLine("List sorted with bubbleShort based on Color in Ascending");
                    foreach (var item in newLista2)
                    {
                        item.Output();
                    }
                    break;
                case 4:
                    MyDatabase db3 = new MyDatabase();
                    Stopwatch watch3 = new Stopwatch();
                    var newLista3 = new List<Shirt>(db3.Shirts);

                    BubbleSort.SortShirtsclDesc(newLista3);
                    Console.WriteLine("List sorted with bubbleShort based on Color in Descending");
                    foreach (var item in newLista3)
                    {
                        item.Output();
                    }
                    break;

                case 5:
                    MyDatabase db4 = new MyDatabase();
                    Stopwatch watch4 = new Stopwatch();
                    var newLista4 = new List<Shirt>(db4.Shirts);
                    BubbleSort.SortShirtsfbAsc(newLista4);
                    Console.WriteLine("List sorted with bubbleShort based on Fabric in Ascending");
                    foreach (var item in newLista4)
                    {
                        item.Output();
                    }

                    break;
                case 6:
                    MyDatabase db5 = new MyDatabase();
                    Stopwatch watch5 = new Stopwatch();
                    var newLista5 = new List<Shirt>(db5.Shirts);
                    BubbleSort.SortShirtsfbDesc(newLista5);
                    Console.WriteLine("List sorted with bubbleShort based on Fabric in Descending");
                    foreach (var item in newLista5)
                    {
                        item.Output();
                    }
                    break;
                case 7:
                    MyDatabase db6 = new MyDatabase();
                    Stopwatch watch6 = new Stopwatch();
                    var newLista6 = new List<Shirt>(db6.Shirts);
                    QuickSort.SortShirtsAscS(newLista6);
                    Console.WriteLine("List sorted with QuickSort based on Size in Ascending");
                    foreach (var item in newLista6)
                    {
                        item.Output();
                    }
                    break;
                case 8:
                    MyDatabase db7 = new MyDatabase();
                    Stopwatch watch7 = new Stopwatch();
                    var newLista7 = new List<Shirt>(db7.Shirts);
                    QuickSort.SortShirtsDescS(newLista7);
                    Console.WriteLine("List sorted with QuickSort based on Size in Descending");
                    foreach (var item in newLista7)
                    {
                        item.Output();
                    }
                    break;
                case 9:
                    MyDatabase db8 = new MyDatabase();
                    Stopwatch watch8 = new Stopwatch();
                    var newLista8 = new List<Shirt>(db8.Shirts);
                    var sortedListBucket = BucketSort.InsertionSortBucketColor(newLista8);
                    Console.WriteLine("List Sorted with Bucket short based on Color in Descending!!!");
                    foreach (var item in sortedListBucket)
                    {
                        item.Output();
                    }
                    break;
                case 10:
                    MyDatabase db9 = new MyDatabase();
                    Stopwatch watch9 = new Stopwatch();
                    var newLista9 = new List<Shirt>(db9.Shirts);
                    var sortedListBucketSize = BucketSort.InsertionSortBucketSize(newLista9);
                    Console.WriteLine("List Sorted with Bucket short based on Size in Descending");
                    foreach (var item in sortedListBucketSize)
                    {
                        item.Output();
                    }
                    break;
                case 11:
                    MyDatabase db10 = new MyDatabase();
                    Stopwatch watch10 = new Stopwatch();
                    var newLista10 = new List<Shirt>(db10.Shirts);
                    var sortedListBucketFabric = BucketSort.InsertionSortBucketFabric(newLista10);
                    Console.WriteLine("List Sorted with Bucket short based on Fabric in Descending");
                    foreach (var item in sortedListBucketFabric)
                    {
                        item.Output();
                    }
                    break;
            }


            List<Shirt> shirts = new List<Shirt>();


            Console.WriteLine("Choose a number from 1...7 for your color:");
            Console.WriteLine("1: BLUE"); 
            Console.WriteLine("2: GREEN");
            Console.WriteLine("3: INDIGO");
            Console.WriteLine("4: ORANGE"); 
            Console.WriteLine("5: RED"); 
            Console.WriteLine("6: VIOLET"); 
            Console.WriteLine("7: YELLOW"); 
            
            int Color = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose a number from 1...7 for your Fabric:");
            Console.WriteLine("1: CASHMERE");
            Console.WriteLine("2: COTTON");
            Console.WriteLine("3: LINEN");
            Console.WriteLine("4: POLYESTER");
            Console.WriteLine("5: RAYON");
            Console.WriteLine("6: SILK");
            Console.WriteLine("7: WOOL");
       
            int Fabric = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Choose a number from 1...6 for your Size:");
            Console.WriteLine("1: XS");
            Console.WriteLine("2: S");
            Console.WriteLine("3: M");
            Console.WriteLine("4: L");
            Console.WriteLine("5: XXL");
            Console.WriteLine("6: XXXL");
          
            int Size = Convert.ToInt32(Console.ReadLine());


            
            Console.WriteLine("You picked a Shirt  color with number {0} , Fabric with number {1} and Size with number {2}", Color, Fabric, Size);

            Shirt sh = new Shirt();
            Console.WriteLine(sh.CalculatePrice(Fabric));
        


            Console.WriteLine();
            Console.WriteLine("Please Choose the payment method.Type:");
            Console.WriteLine("1: Bank transfer" );
            Console.WriteLine("2: Debit Card");
            Console.WriteLine("Type anything else to pay with cash");

            int num = Convert.ToInt32(Console.ReadLine());

            StrategyPayment strategycontext = new StrategyPayment(num);

            IPaymentStartegy strategy = strategycontext.GetpaymentMethod(num);
            








        }
    }
}
