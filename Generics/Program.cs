using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxBinaryHeap<int> maxHeap = new MaxBinaryHeap<int>();
            maxHeap.Insert(1);
            maxHeap.Insert(2);
            maxHeap.Insert(8);
            maxHeap.Insert(0);
            maxHeap.Extract();
            
            MinBinaryHeap<int> minHeap = new MinBinaryHeap<int>();
            minHeap.Insert(0);
            minHeap.Insert(9);
            minHeap.Insert(5);
            minHeap.Insert(2);
            minHeap.Extract();
            
            Console.ReadKey();

        }
    }
}
