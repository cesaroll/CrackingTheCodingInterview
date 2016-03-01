using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    class Program
    {
        static Trie trie;

        static void Main(string[] args)
        {
            trie = new Trie();

            trie.Add("to");
            trie.Add("tea");
            trie.Add("ted");            
            trie.Add("ten");
            trie.Add("team");
            trie.Add("a");
            trie.Add("i");
            trie.Add("in");
            trie.Add("inn");

            find("to");
            find("tea");
            find("ted");
            find("too");
            find("t");
            find("ten");
            find("team");
            find("a");
            find("i");
            find("in");
            find("inn");
           
        }

        static void find( string s)
        {
            if(trie.Find(s))
                Console.WriteLine(s + " was found." );
            else
                Console.WriteLine( s + " was not found.");
        }
    }
}
