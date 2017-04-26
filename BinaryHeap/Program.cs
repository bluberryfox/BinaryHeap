using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeapLab
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxBinaryHeap <int>heap = new MaxBinaryHeap<int>(0, 1, 2, 3, 5, 9, 7, 8, 4, 6);
            for (int i = 0; i < heap.ArgumentsList.Count; i++)
            {
                Console.Write(heap.ArgumentsList[i] + " ");
            }
            Console.WriteLine();
            heap.Insert(10);
            for (int i = 0; i < heap.ArgumentsList.Count; i++)
            {
                Console.Write(heap.ArgumentsList[i] + " ");
            }
            Console.WriteLine();
            heap.Insert(-1);
            for (int i = 0; i < heap.ArgumentsList.Count; i++)
            {
                Console.Write(heap.ArgumentsList[i] + " ");
            }
            Console.WriteLine();
            heap.Extract();
            for (int i = 0; i < heap.ArgumentsList.Count; i++)
            {
                Console.Write(heap.ArgumentsList[i] + " ");
            }
            Console.WriteLine();

            MinBinaryHeap<int> heap2 = new MinBinaryHeap<int>(0, 1, 2, 3, 5, 9, 7, 8, 4, 6);
            for (int i = 0; i < heap2.ArgumentsList.Count; i++)
            {
                Console.Write(heap2.ArgumentsList[i] + " ");
            }
            Console.WriteLine();
            heap2.Insert(10);
            for (int i = 0; i < heap2.ArgumentsList.Count; i++)
            {
                Console.Write(heap2.ArgumentsList[i] + " ");
            }
            Console.WriteLine();
            heap2.Insert(-1);
            for (int i = 0; i < heap2.ArgumentsList.Count; i++)
            {
                Console.Write(heap2.ArgumentsList[i] + " ");
            }
            Console.WriteLine();
            heap2.Extract();
            for (int i = 0; i < heap2.ArgumentsList.Count; i++)
            {
                Console.Write(heap2.ArgumentsList[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
