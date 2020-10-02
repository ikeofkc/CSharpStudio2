using System;
using System.Collections.Generic;
using System.Threading;

namespace Studio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // string text = Console.ReadLine();
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            char[] sampleText = text.ToCharArray();
            Dictionary<char, int> counts = new Dictionary<char, int>();
            // Console.WriteLine(sampleText);
            foreach(char c in sampleText)
            {
                char clow = Char.ToLower(c);
                if (counts.ContainsKey(clow))
                {
                    counts[clow]++;
                }
                else if (Char.IsLetter(clow))
                {
                    counts.Add(clow, 1);
                }
            }
            foreach(KeyValuePair<char,int> kvp in counts)
            {
                Console.WriteLine(kvp.Key + ":" + kvp.Value);
            }
        }
    }
}