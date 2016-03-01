using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var prog = new Program();

            //int[] A = new[] {-1, 3, -4, 5, 1, -6, 2, 1};
            //int[] A = new[] { 1, 2, 1, 4, 5, 6, 1, 1 };
           /* int[] A = new[] { 500,1,-2,-1, 2};


            Console.WriteLine(prog.solution(A));*/


            //prog.solution(100000);

            /*int[] A = new[] { 5, 5, 1, 7, 2, 3, 5 };
            Console.WriteLine(prog.solution(5, A));

            int[] B = new[] { 5, 5, 5, 1, 7, 2, 3, 5, 5 };
            Console.WriteLine(prog.solution(5, B));*/

            int[] B = new[] { 5, 5, 5, 1, 7, 5, 5, 2, 3, 5, 1, 4, 6, 8, 5 };
            Console.WriteLine(prog.solution(5, B));

        }


        public int solution(int X, int[] A)
        {
            int idx1 = 0;
            int idx2 = 0;

            int n = A.Length;
            int totX = 0, totNonX = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] == X)
                    totX++;
                else
                    totNonX++;
            }


            int countX = 0, countNonX = 0;
            for (int i = 0; i < n; i++)
            {
                int right = totNonX - countNonX;

                if (countX == right)
                    return i;

                if (A[i] == X)
                    countX++;
                else
                    countNonX++;

            }

            return -1;
        }

        public void solution2(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                string print = string.Empty;

                if (i%3 == 0)
                    print = "Fizz";
                if (i%5 == 0)
                    print += "Buzz";
                if (i%7 == 0)
                    print += "Woof";

                if (string.IsNullOrEmpty(print))
                    print = i.ToString();

                Console.WriteLine(print);


            }

        }

        public int solution1(int[] A)
        {
            int idx1 = 0;
            int idx2 = 0;
            Int64 left = 0, right = 0;

            int n = A.Length;
            Int64 tot = 0;

            for (int i = 0; i < n; i++)
                tot += A[i];

            for (int i = 0; i < n; i++)
            {
                right = tot - left - A[i];
                
                if (left == right)
                    return i;

                left += A[i];
            }

            return -1;

        }

    }
}
