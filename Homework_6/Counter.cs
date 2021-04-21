using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Counter
    {
        public delegate void CounterHandler(int num);
        public event CounterHandler Notify;
        
        public void StartCounter()
        {
            for (int cnt = 0; cnt < 101; cnt++)
            {
                
                if (cnt == 77)
                {
                    Notify?.Invoke(cnt);
                }
                
            }
        }
        
    }

}
