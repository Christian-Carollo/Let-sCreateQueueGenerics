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
        public IntQueue(ILogger logger) : base(logger)
        {
            
        }

        public override void Print()
        {
            if (queueList.Count > 0)
            {
                logger.Log("Elements in IntQueueList:\n");
                queueList.ToList().ForEach(q => logger.Log(q.ToString()));
            }
            else
            {
                logger.Log("The queueList is Empty");
            }
        }
    }
}
