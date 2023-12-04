using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Let_sCreateQueueGenerics
{
    public class MyQueue<T> : IMyQueue<T>
    {
        protected Queue<T> queueList = new Queue<T>();

        protected readonly ILogger logger;

        public MyQueue(ILogger logger) { this.logger = logger; }

        public void Enqueue(T element)
        {
            queueList.Enqueue(element);
            logger.Log($"Enqueue element: {element}");
        }

        public void Dequeue()
        {
            if (queueList.Count > 0) 
            { 
                T dequeueElement = queueList.Dequeue() ;
                logger.Log($"Dequeue element: {dequeueElement}");
            } else { logger.Log("The queueList is Empty. Cannot Dequeue"); }
        }

        public T Peek()
        {

            if (queueList.Count > 0)
            {
                T peekElement = queueList.Peek();
                logger.Log($"Peek element: {peekElement}");
                return peekElement;
            }
            else
            {
                logger.Log("The queueList is Empty. Cannot Peek");
                return default(T);
            }
        }


        public virtual void Print()
        {
            if (queueList.Count > 0)
            {
                logger.Log("Elements in QueueList:\n");
                queueList.ToList().ForEach(q => logger.Log(q.ToString() ?? string.Empty));
            }
            else
            {
                logger.Log("The queueList is Empty");
            }
        }


        public int Count()
        {
            return queueList.Count;
        }
    }
}