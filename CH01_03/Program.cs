using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH01_03
{
    class Program
    {
          
        static void Main(string[] args)
        {
            
            //Find how many times a substring appears ina string

            string str = "abbcdaatdzcaxtw";
            String subStr = "cat";
            Console.WriteLine(str);
            Console.WriteLine(GetTimesOfStr(str, subStr));

            str = "abdbcddaaotdgzocagxgtw";
            subStr = "dog";
            Console.WriteLine(str);
            Console.WriteLine(GetTimesOfStr(str, subStr));

            str = "cabbcabtct";
            subStr = "cat";
            Console.WriteLine(str);
            Console.WriteLine(GetTimesOfStr(str, subStr));

            str = "cabibcrairbdtcdt";
            subStr = "bird";
            Console.WriteLine(str);
            Console.WriteLine(GetTimesOfStr(str, subStr));

            str = "cpadbiobcrg dairobdtgcdtg";
            subStr = "parrot";
            Console.WriteLine(str);
            Console.WriteLine(GetTimesOfStr(str, subStr));

        }

        static int strTimes;

        static char[] arrStr;
        static char[] arrSubStr;
        static int maxIdxStr;
        static int maxIdxSubStr;
        static int GetTimesOfStr(String str, String subStr)
        {
            string newStr = RemoveUnusedChars(str, subStr);

            Console.WriteLine(newStr);

            strTimes = 0;

            arrStr = newStr.ToCharArray();
            arrSubStr = subStr.ToCharArray();

            maxIdxStr = newStr.Length - 1;
            maxIdxSubStr = subStr.Length - 1;

            CountSubStringTimesInString(0, 0);

            return strTimes;

        }
       
        static int CountSubStringTimesInString(int IdxStr, int IdxSubStr)
        {
            int Idx = IdxStr;

            if (IdxSubStr > maxIdxSubStr)
                strTimes++;
            else
            {
                while(IdxSubStr <= maxIdxSubStr && Idx <= maxIdxStr )
                {
                    if (arrSubStr[IdxSubStr] == arrStr[Idx])
                    {
                        Idx = CountSubStringTimesInString(IdxStr + 1, IdxSubStr + 1);

                        Idx = CountSubStringTimesInString(IdxStr + 1, IdxSubStr);
                    }
                    else
                        Idx = CountSubStringTimesInString(Idx + 1, IdxSubStr);

                    IdxSubStr++;
                }                
            }

            return Idx;

        }

        static string RemoveUnusedChars(String str, String substr)
        {
            StringBuilder sb = new StringBuilder();

            foreach(char c in str)
            {
                foreach(char sc in substr)
                {
                    if (c == sc)
                        sb.Append(c);
                }
            }

            return sb.ToString();

        }

    }
}
