using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class StringSearcher
    {
        public delegate void SearcherHandler(string str);
        public event SearcherHandler Notify;
        public void Searcher(List<string> Text, string  str)
        {
            if (Text is null)
            {
                //throw new ArgumentNullException(nameof(Text));
                Console.WriteLine("Нет данных для поиска");
            }

            if (!string.IsNullOrEmpty(str))
            {
                for (int i = 0; i < Text.Count; i++)
                {
                    if (Text[i].Contains(str))
                    {
                        Notify?.Invoke(Text[i]);
                    } 
                }
            }
            else
            {
                Console.WriteLine("Не знаю, что искать!");
            }
        }
    }
}
