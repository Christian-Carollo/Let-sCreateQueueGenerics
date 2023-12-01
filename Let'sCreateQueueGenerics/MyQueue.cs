
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_sCreateQueueGenerics
{
    public class MyQueue<T> : IMyQueue<T>
    {
        protected Queue<T> queueList = new Queue<T>();

        public Queue<T> GetQueue() { return queueList; }

        public void Enqueue(T element)
        {
            queueList.Enqueue(element);

        }

        public void Dequeue()
        {
            if (queueList.Count > 0) { queueList.Dequeue(); } else { throw new InvalidOperationException("The queueList is Empty"); }
        }

        public void Peek()
        {

            if (queueList.Count > 0)
            {
                Console.WriteLine($"Elements Peek: {queueList.Peek()}");
            }
            else
            {
                throw new InvalidOperationException("The queueList is Empty");
            }
        }


        public virtual void Print()
        {
            if (queueList.Count > 0)
            {
                Console.WriteLine("Elements in QueueList:\n");
                queueList.Select(q => q).ToList().ForEach(q => Console.WriteLine(q));
            }
            else
            {
                Console.WriteLine("The queueList is Empty");
            }
        }


        public int Count()
        {
            return queueList.Count;
        }
    }
}