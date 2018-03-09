using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_MyQueues.Properties
{
    class MyQueue
    {

            int head = 0, tail = 0, size;

            int[] data;
            public MyQueue(int si)
            {
                size = si;
                data = new int[size];
            }
            public void enqueue(int i)
            {
                if ((tail + 1) % size != head)
                {
                    data[tail++] = i;

                    tail %= size;
                }
                else
                    throw new IndexOutOfRangeException();
            }
            public int dequeue()
            {
                head %= size;

                if (head != tail)

                    return data[head++];

                else

                throw new IndexOutOfRangeException();

            }

        }
    }

