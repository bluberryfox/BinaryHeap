using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeapLab
{
    class MinBinaryHeap<T> : BinaryHeap<T>
        where T : IComparable
    {


        public MinBinaryHeap() : base()
        {

        }
        public MinBinaryHeap(params T[] arraySource) : base(arraySource)
        {

        }


        protected override void Heapify(int i)
        {
            int leftChild;
            int rightChild;
            int smallestChild;

            for (;;)
            {
                leftChild = 2 * i + 1;
                rightChild = 2 * i + 2;
                smallestChild = i;


                if (leftChild < ArgumentsList.Count && ArgumentsList[leftChild].CompareTo(ArgumentsList[smallestChild]) < 0)
                {
                    smallestChild = leftChild;
                }
                if (rightChild < ArgumentsList.Count && ArgumentsList[rightChild].CompareTo(ArgumentsList[smallestChild]) < 0)
                {
                    smallestChild = rightChild;
                }
                if (smallestChild == i)
                {
                    break;
                }

                T temp = ArgumentsList[i];
                ArgumentsList[i] = ArgumentsList[smallestChild];
                ArgumentsList[smallestChild] = temp;
                i = smallestChild;
            }
        }
        public override void Insert(T value)
        {
            ArgumentsList.Add(value);
            int i = ArgumentsList.Count - 1;
            int parent = (i - 1) / 2;

            while (i > 0 && ArgumentsList[parent].CompareTo(ArgumentsList[i]) > 0)
            {
                T temp = ArgumentsList[i];
                ArgumentsList[i] = ArgumentsList[parent];
                ArgumentsList[parent] = temp;

                i = parent;
                parent = (i - 1) / 2;
            }

        }
    }
}
