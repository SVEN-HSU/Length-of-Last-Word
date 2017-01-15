//https://leetcode.com/problems/length-of-last-word/
//Accepted
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_of_Last_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = " ";
            Program p = new Program();
            Console.WriteLine("LengthOfLastWord=" + p.LengthOfLastWord(s));
            Console.Read();
        }

        public int LengthOfLastWord(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }

            string[] chunks = s.Split(' ');
            //Console.WriteLine("LastWord=" + chunks.Last());

            if (chunks.Any(x => x.Length > 0))
            {
                return chunks.Where(x => x.Length > 0).Last().Length;
            }
            else
            {
                return 0;
            }            
        }
    }
}
