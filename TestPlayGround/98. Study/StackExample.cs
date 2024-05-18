using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlayGround._98._Study
{
    public class StackExample
    {
        public StackExample()
        {
            myStack = new Stack<Guid>();
        }

        public Stack<Guid> myStack { get; set; }

        public void DoWork()
        {
            AddElements();

            RemoveElements();

            Console.WriteLine("Stack flushed.");
        }

        public void AddElements()
        {
            while (myStack.Count() < 10)
            {

                myStack.Push(Guid.NewGuid());
                Console.WriteLine($"Pushed one item: {myStack.Peek()}");
                Thread.Sleep(1000);
            }
        }

        public void RemoveElements()
        {
            while (myStack.Count() > 0)
            {
                var item = myStack.Pop();
                Console.WriteLine($"Poped one item: {item}");
                Thread.Sleep(500);
            }
        }
    }
}
