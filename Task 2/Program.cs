using System;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringSearcher stringSearcher = new();

            List<string> Text = new()
            {
                "gdhjhdm",
                "fhhffjk",
                "vdvafvf",
                "nffkdva",
                "dfv"
            };

            stringSearcher.Notify += ImFind;
            stringSearcher.Searcher(Text, "dva");


            static void ImFind(string str)
            {
                Console.WriteLine($"Строка найдена! Содержимое строки:{str}");
            }
            //Console.WriteLine(stringSearcher.Text[3]);
        }
    }
}
