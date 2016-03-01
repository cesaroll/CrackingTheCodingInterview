using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] mystr = "CESAR".ToCharArray();
            //reverse(ref mystr);

            //Console.WriteLine(mystr);

            //string str = mystr.ToString();

            //Console.WriteLine(Permutation("CESAR", "RASEC"));

            //char[] mystr2 = new char[100];

            //int max = 12;  
            //for (int i = 0; i < 12; i++)
            //{
            //    if (i % 2 == 0) mystr2[i] = 'a';
            //    else
            //        mystr2[i] = ' ';

            //}

            //Console.WriteLine(mystr2);
            //Console.WriteLine(ReplaceSpaces(mystr2, max));

            //ReplaceSpaces2(mystr2, max);
            //Console.WriteLine(mystr2);

            //string cs = "abbcccddffffffffffffffffaaaaaaaaaaaaaaaaahhhhhhhhhhhhh";
            //Console.WriteLine(cs);
            //Console.WriteLine(CompressString(cs));


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

        static string CompressString(String str)
        {
            int compSize = GetCompressSize(str);

            if(str.Length <= compSize)
                return str;

            StringBuilder sb = new StringBuilder();

            char charTmp = str[0];
            int countTmp = 1;

            for(int i = 1; i < str.Length; i++)
            {
                if (charTmp == str[i])
                    countTmp++;
                else
                {
                    sb.Append(charTmp).Append(countTmp);

                    charTmp = str[i];
                    countTmp = 1;
                }

            }

            sb.Append(charTmp).Append(countTmp);

            return sb.ToString();


        }

        static int GetCompressSize(String str)
        {
            int compSize = 0;
            char charTmp = str[0];

            for(int i = 1; i < str.Length; i++)
            {
                if (str[i] != charTmp)
                {
                    compSize++;
                    charTmp = str[i];
                }                
            }

            compSize++;

            return compSize * 2;
        }

        static void ReplaceSpaces2(char[] str, int size)
        {
            int numSpaces = 0;

            for(int i=0; i < size; i++)
                if(str[i] == ' ') numSpaces++;

            int newSize = size + numSpaces * 2;

            for (int i = size - 1, j = newSize - 1; i >= 0; i--, j--)
            {
                if (str[i] == ' ')
                {
                    str[j--] = '0';
                    str[j--] = '2';
                    str[j] = '%';
                }
                else
                    str[j] = str[i];

            }
                
        }


        static char[] ReplaceSpaces(char[] str, int size)
        {
            char[] oldStr = new char[size];

            for (int i = 0; i < size; i++)
                oldStr[i] = str[i];

            for (int i = 0, j = 0; i < size; i++, j++)
            {
                if (oldStr[i] == ' ')
                {
                    str[j++] = '%';
                    str[j++] = '2';
                    str[j] = '0';
                }
                else
                    str[j] = oldStr[i];
            }

                return str;
        }

        static void reverse(ref char[] mystr)
        {
            int len = mystr.Length;

            char tmp;

            for (int j = 0, k = len-1; j < k; j++, k--)
            {
                tmp = mystr[j];
                mystr[j] = mystr[k];
                mystr[k] = tmp;
            }

        }


        
        static bool Permutation(string s1, string s2)
        {
	        if(s1.Length != s2.Length)
		        return false;
	
	        int[] charArr = new int[256];
		
	        for(int i =0; i < s1.Length; i++)
	        {
		        charArr[s1[i]]++;
		        charArr[s2[i]]--;
	        }

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] != 0)
                    return false;
            }

            return true;

        }
    }
}
