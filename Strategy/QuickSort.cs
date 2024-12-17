using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    public class QuickSort : ISortingStrategy
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Сортировка с использованием Quick Sort...");
            Array.Sort(array);
        }
    }

}
