using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextLezer
{
    static class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Wik\Documents\Visual Studio 2017\Projects\TextLezer\TextLezer\randomtext.txt";
            foreach (String word in GetWords(path, s => s.StartsWith("a"))) 
                Console.Write("{0}; ", word);

            Console.WriteLine("\n");

            foreach (String word in GetWords(path, s => s.StartsWith("b")))
                Console.Write("{0}; ", word);
            Console.ReadLine();
        }

        public static IEnumerable<string> GetWords(String path, Func<String, Boolean> startsWith)
        {
            String text = "";

            try
            {
                text = System.IO.File.ReadAllText(path);
            } catch (Exception e)
            {
                Console.WriteLine("File not find", e);                              
            }

            String[] inhoud = text.Split(' ');

            foreach (String word in inhoud)
            {
                if (startsWith(word) == true)
                {
                    yield return word;
                    //String[] ray = inhoud.Select(word.ToString).ToArray(); 
                }
            }





        }
    }
}
