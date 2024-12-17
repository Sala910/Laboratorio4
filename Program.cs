using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laba4.ChainOfResponsibility;
using laba4.Iterator;

namespace laba4
{
    internal class Program
    {
        static void Main()
        {
            // 1. Estrategia
            Console.WriteLine("### Паттерн Стратегия ###");
            Sorter sorter = new Sorter();
            int[] array = { 5, 2, 9, 1, 5 };

            sorter.SetStrategy(new BubbleSort());
            sorter.SortArray(array);

            sorter.SetStrategy(new QuickSort());
            sorter.SortArray(array);

            // 2. Cadena de Responsabilidad
            Console.WriteLine("\n### Паттерн Цепочка обязанностей ###");
            IHandler handlerA = new HandlerA();
            IHandler handlerB = new HandlerB();
            handlerA.SetNext(handlerB);

            handlerA.HandleRequest("TypeA");
            handlerA.HandleRequest("TypeB");

            // 3. Iterador
            Console.WriteLine("\n### Паттерн Итератор ###");
            int[] numbers = { 1, 2, 3, 4, 5 };
            IIterator<int> iterator = new ArrayIterator<int>(numbers);

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
