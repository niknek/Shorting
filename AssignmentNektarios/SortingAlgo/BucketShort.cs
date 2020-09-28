using AssignmentNektarios.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNektarios.SortingAlgorithms
{
    class BucketSort
    {
        public static List<Shirt> SortShirts(List<Shirt> shirts)
        {
            List<Shirt> sortedList = new List<Shirt>();

            int numOfBuckets = 4;
            // create buckets
            List<Shirt>[] buckets = new List<Shirt>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Shirt>();
            }

            // Iterate and aadd each element to the appropriate bucket
            for (int i = 0; i < shirts.Count; i++)
            {
                int bucket = (int)shirts[i].Size;
                if (bucket == 0 || bucket == 1)
                    bucket = 0;
                else if (bucket == 2 || bucket == 3)
                    bucket = 1;
                else if (bucket == 4 || bucket == 5)
                    bucket = 2;
                else
                    bucket = 3;

                buckets[bucket].Add(shirts[i]);
            }

            // Sort each bucket 
            for (int i = 0; i < numOfBuckets; i++)
            {
                List<Shirt> temp = InsertionSortBucketSize(buckets[i]);
                sortedList.AddRange(temp);
            }

            return sortedList;
        }

        public static List<Shirt> InsertionSortBucketSize(List<Shirt> shirts)
        {
            Shirt temp;

            for (int i = 1; i < shirts.Count; i++)
            {
                // STore current value ina variable
                int currentValue = (int)shirts[i].Size;
                int pointer = i - 1;

                while (pointer >= 0)
                {
                    if (currentValue < (int)shirts[pointer].Size)
                    {
                        //swap
                        temp = shirts[pointer + 1];
                        shirts[pointer + 1] = shirts[pointer];
                        shirts[pointer] = temp;
                        pointer--;
                    }
                    else
                        break;
                }
            }
            return shirts;
        }


        public static List<Shirt> InsertionSortBucketFabric(List<Shirt> shirts)
        {
            Shirt temp;

            for (int i = 1; i < shirts.Count; i++)
            {
                // STore current value ina variable
                int currentValue = (int)shirts[i].Fabric;
                int pointer = i - 1;

                while (pointer >= 0)
                {
                    if (currentValue < (int)shirts[pointer].Fabric)
                    {
                        //swap
                        temp = shirts[pointer + 1];
                        shirts[pointer + 1] = shirts[pointer];
                        shirts[pointer] = temp;
                        pointer--;
                    }
                    else
                        break;
                }
            }
            return shirts;
        }

        public static List<Shirt> InsertionSortBucketColor(List<Shirt> shirts)
        {
            Shirt temp;

            for (int i = 1; i < shirts.Count; i++)
            {
                // STore current value ina variable
                int currentValue = (int)shirts[i].Color;
                int pointer = i - 1;

                while (pointer >= 0)
                {
                    if (currentValue < (int)shirts[pointer].Color)
                    {
                        //swap
                        temp = shirts[pointer + 1];
                        shirts[pointer + 1] = shirts[pointer];
                        shirts[pointer] = temp;
                        pointer--;
                    }
                    else
                        break;
                }
            }
            return shirts;
        }
    }
}
