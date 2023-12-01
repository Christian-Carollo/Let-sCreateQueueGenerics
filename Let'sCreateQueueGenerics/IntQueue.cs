using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_sCreateQueueGenerics
{
    public class IntQueue : MyQueue<int>
    {

        public override void Print()
        {
            if (queueList.Count > 0)
            {
                Console.WriteLine("Elements in IntQueueList:\n");
                queueList.Select(q => q).ToList().ForEach(q => Console.WriteLine(q));
            }
            else
            {
                Console.WriteLine("The queueList is Empty");
            }
        }
    }
}
