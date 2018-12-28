using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {




        static void Main(string[] args)
        {
            PriorityQueue PQ = new PriorityQueue();
            PQ.push(3, "Kilis University");
            PQ.push(4, "Mardin University");
            PQ.push(5, "Batman University");
            PQ.push(1, "Siirt University");
            PQ.push(2, "Fırat University");

            while (!PQ.Empty)
            {
                var Val = PQ.pop();
                Console.WriteLine(Val[0] + " : " + Val[1]);
            }
            Console.ReadKey();
        }
    }
    class PriorityQueue
    {
        private SortedList PseudoQueue;

        public bool Empty
        {
            get
            {
                return PseudoQueue.Count == 0;
            }
        }

        public PriorityQueue()
        {
            PseudoQueue = new SortedList();
        }

        public void push(object Priority, object Value)
        {
            PseudoQueue.Add(Priority, Value);
        }

        public object[] pop()
        {
            object[] ReturnValue = { null, null };
            if (PseudoQueue.Count > 0)
            {
                ReturnValue[0] = PseudoQueue.GetKey(0);
                ReturnValue[1] = PseudoQueue.GetByIndex(0);

                PseudoQueue.RemoveAt(0);
            }
            return ReturnValue;
        }
    }
}
