

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var thread1 = new Thread(()=>Singleton.GetInstance().Say());
            var thread2 = new Thread(() => Singleton.GetInstance().Say());

            thread1.Start();
            thread2.Start();
        }
    }
}
