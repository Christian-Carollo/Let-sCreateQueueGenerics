using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_sCreateQueueGenerics
{
    public interface IMyQueue<T>
    {
        void Enqueue(T element);
        void Dequeue();
        void Peek();
        void Print();
        int Count();
    }
}
