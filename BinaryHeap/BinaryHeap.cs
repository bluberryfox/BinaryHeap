using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeapLab
{
    class BinaryHeap<T>
        where T :IComparable
    {
        public  List<T> ArgumentsList;

        public BinaryHeap()
        {
            ArgumentsList = new List<T>();
        }
        public BinaryHeap(params T[] arraySource)
        {
            ArgumentsList = arraySource.ToList();
            for (int i = ArgumentsList.Count / 2; i >= 0; i--)
            {
                Heapify(i);
            }
        }

        protected virtual void Heapify(int i)
        {
            
        }

        public abstract void Insert(T value)
        {
           

        }
        public T Extract()
        {
            try { 
                T result = ArgumentsList[0];
                ArgumentsList[0] = ArgumentsList[ArgumentsList.Count - 1];
                ArgumentsList.RemoveAt(ArgumentsList.Count - 1);
                Heapify(0);
                return result;
            } catch(ArgumentNullException e)
            {
                Console.WriteLine("В куче ничего нет!");
                return default(T);
            }

        }
    }
}
