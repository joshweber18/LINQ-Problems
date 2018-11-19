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
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //var thword = words.Where(w => w.Contains("th"));
            Main3();
            //foreach (var word in thword)
            {
                //Console.WriteLine(word);
                //Console.ReadLine();
            }
        }

        static void Main2()
        {
            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            //var distinctName = names.Select(n => n).Distinct();
            //foreach (var name in distinctName)
            {
                //Console.WriteLine(name);
                //Console.ReadLine();
            }
        }

        static void Main3()
        {
            List<string> classGrades = new List<string>(){"80,100,92,89,65","93,81,78,84,69","73,88,83,99,64","98,100,66,74,55"};
            var listOfList = classGrades.Select(c => c.Split(',')).ToList();
            List<double> averages = new List<double>();
            double totalAverage;

            foreach (var item in listOfList)
            {
                List<int> studentGrades = new List<int>();
                foreach (var thing in item)
                {
                    studentGrades.Add(int.Parse(thing));
                }
                studentGrades.OrderByDescending(s => s);
                studentGrades.RemoveAt(studentGrades.Count - 1);
                double studentAverage = studentGrades.Average();
                // List<double> averages = new List<double>();
                averages.Add(studentAverage);
            }
            totalAverage = averages.Average();
            Console.WriteLine(totalAverage);
            Console.ReadLine();
        }
    }
}
