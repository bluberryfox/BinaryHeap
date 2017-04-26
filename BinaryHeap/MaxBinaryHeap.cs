using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeapLab
{
    class MaxBinaryHeap<T> : BinaryHeap<T>
        where T : IComparable
    {


        public MaxBinaryHeap() : base()
        {

        }
        public MaxBinaryHeap(params T[] arraySource) : base(arraySource)
        {

        }


        protected override void Heapify(int i)
        {
            int leftChild;
            int rightChild;
            int largestChild;

            for (;;)
            {
                leftChild = 2 * i + 1;
                rightChild = 2 * i + 2;
                largestChild = i;


                if (leftChild < ArgumentsList.Count && ArgumentsList[leftChild].CompareTo(ArgumentsList[largestChild]) > 0)
                {
                    largestChild = leftChild;
                }
                if (rightChild < ArgumentsList.Count && ArgumentsList[rightChild].CompareTo(ArgumentsList[largestChild]) > 0)
                {
                    largestChild = rightChild;
                }
                if (largestChild == i)
                {
                    break;
                }

                T temp = ArgumentsList[i];
                ArgumentsList[i] = ArgumentsList[largestChild];
                ArgumentsList[largestChild] = temp;
                i = largestChild;
            }
        }
        public override void Insert(T value)
        {
            ArgumentsList.Add(value);
            int i = ArgumentsList.Count - 1;
            int parent = (i - 1) / 2;

            while (i > 0 && ArgumentsList[parent].CompareTo(ArgumentsList[i]) < 0)
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

