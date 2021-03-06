﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer_øvelse
{
    class Program
    {
        static void Main(string[] args)
        {
            BoundedBuffer buf = new BoundedBuffer(4);

            Producer prod = new Producer(buf, 10);
            Consumer cons = new Consumer(buf);

            Parallel.Invoke(prod.Run, cons.Run);

        }
    }
}
