using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer_øvelse
{
    public class BoundedBuffer 
    {
        public int Capacity { get; set; }

        public BoundedBuffer(int capacity)
        {
            Capacity = capacity;
            Capacity = 0; 
            
            Queue<int> buffer = new Queue<int>();
        }       

        public Boolean IsFull()
        {
            if (Capacity == 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Put(int element)
        {
            
        }

        public override int Take()
        {
            
        }

    }
}
