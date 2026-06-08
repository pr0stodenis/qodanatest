using System;
using System.Collections.Generic;
using System.Linq;

namespace QodanaTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = GetData();
            ProcessData(data);
        }

        private static List<string> GetData()
        {
            var items = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                items.Add("Item " + i.ToString());
            }

            return items;
        }

        private static void ProcessData(List<string> items)
        {
            string result = "";

            foreach (var item in items)
            {
                result += item + ", ";
            }

            var processed = items.Select(x => x.ToUpper()).ToList();
            var distinct = processed.Distinct().ToArray();

            Console.WriteLine(result);
            Console.WriteLine(string.Join(" | ", distinct));
        }

        private static int UnusedMethod(int a, int b)
        {
            return a + b;
        }
    }
    //123
    public class BadlyNamedClassWithLongNameAndNoDocumentation
    {
        public int SomeField;

        public void DoSomething(object obj)
        {
            if (obj != null)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}