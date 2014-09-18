using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer_øvelse
{
    public class Producer
    {
        public int LastElement { get; set; }
        public int LastItem { get; set; }

        public Producer(int lastElement, int lastItem)
        {
            LastElement = lastElement;
            LastItem = lastItem;
        }

        public void Run()
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                bool isfull = BoundedBuffer.IsFull();
                if (isfull == false)
                {
                    int elementNumber = rnd.Next(1, 100);
                    BoundedBuffer.Put(elementNumber);
                }
                
                
            }
                
                
            
        }

        
    }
}
