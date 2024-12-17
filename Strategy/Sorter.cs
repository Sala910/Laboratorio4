using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    public class Sorter
    {
        private ISortingStrategy _strategy;

        public void SetStrategy(ISortingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SortArray(int[] array)
        {
            _strategy?.Sort(array);
        }
    }

}
