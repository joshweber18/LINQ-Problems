using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class Program
    {
       

        static void Main(string[] args)
        {

            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var thword = words.Where(w => w.Contains("th"));

            foreach (var word in thword)
            {
                Console.WriteLine(word);
                Console.ReadLine();
            }
           


        }  
    }
}
