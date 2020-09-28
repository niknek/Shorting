using AssignmentNektarios.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNektarios.SortingAlgorithms
{
    class QuickSort
    {

        public static void SortShirtsAscS(List<Shirt> shirts)
        {
            QuicksortS(shirts, 0, shirts.Count - 1);
            //QuicksortAlternative(shirts, 0, shirts.Count - 1);
        }

        private static void QuicksortS(List<Shirt> shirts, int left, int right)
        {
            int i = left;
            int j = right;
            var pivot = shirts[(left + right) / 2].Size;

            while (i <= j)
            {
                while (shirts[i].Size < pivot)
                    i++;
                while (shirts[j].Size > pivot)
                    j--;

                if (i <= j)
                {
                    // swap
                    var temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuicksortS(shirts, left, j);
            if (i < right)
                QuicksortS(shirts, i, right);
        }


        public static void SortShirtsDescS(List<Shirt> shirts)
        {
            QuicksortDS(shirts, 0, shirts.Count - 1);
            //QuicksortAlternative(shirts, 0, shirts.Count - 1);
        }


        private static void QuicksortDS(List<Shirt> shirts, int left, int right)
        {
            int i = left;
            int j = right;
            var pivot = shirts[(left + right) / 2].Size;

            while (i <= j)
            {
                while (shirts[i].Size < pivot)
                    i++;
                while (shirts[j].Size > pivot)
                    j--;

                if (i <= j)
                {
                    // swap
                    var temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuicksortS(shirts, left, j);
            if (i < right)
                QuicksortS(shirts, i, right);
        }


        private static void QuicksortAlternative(List<Shirt> shirts, int left, int right)
        {
            if (left > right)
                return;

            var pivot = (int)shirts[(left + right) / 2].Size;
            int index = Partition(shirts, left, right, pivot);
            QuicksortS(shirts, left, index - 1);
            QuicksortS(shirts, index, right);
        }

        private static int Partition(List<Shirt> shirts, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while ((int)shirts[left].Size < pivot)
                {
                    left++;
                }

                while ((int)shirts[right].Size > pivot)
                {
                    right--;
                }

                if (left <= right)
                {
                    //swap
                    var temp = shirts[left];
                    shirts[left] = shirts[right];
                    shirts[right] = temp;
                    left++;
                    right--;
                }
            }
            return left;
        }
    }
}
