using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_05_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<String> queue = new Queue<string>();

            queue.Enqueue("Hi");
            queue.Enqueue(" Cesar,");
            queue.Enqueue(" how");
            queue.Enqueue(" are");
            queue.Enqueue(" you?");            

            StringBuilder sb = new StringBuilder();
            String s;

            do
            {

                s = queue.Dequeue();
                sb.Append(s);

            } while (s != null);

            Console.WriteLine(sb.ToString());

            queue.Enqueue("Hi");
            queue.Enqueue(" Cesar,");
            queue.Enqueue(" how");
            queue.Enqueue(" are");
            queue.Enqueue(" you?");

            sb = new StringBuilder();
            
            do
            {

                s = queue.Dequeue();
                sb.Append(s);

            } while (s != null);

            Console.WriteLine(sb.ToString());

        }
    }
}
