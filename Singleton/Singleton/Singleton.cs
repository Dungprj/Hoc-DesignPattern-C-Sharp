using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance;
        private static readonly object lockObject = new object();

        private int index;  

        private Singleton(int index) { 
            this.index = index;
        }
        public static Singleton GetInstance()
        {
            if(instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        var random = new Random();
                        instance = new Singleton(random.Next(1, 400));
                    }
                    
                }
            }
            return instance;



        }

        public void Say()
        {
            Console.WriteLine("hello i am dung " + index);
            Thread.Sleep(5000);
        }
    }
}
