using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo
{
    class TestStack
    {
        static void Main(string[] args)
        {
            MyStack s = new MyStack();
            s.Push(10);
            s.Push(20);

            Console.WriteLine(s.Pop());

            MyStringStack ss = new MyStringStack();

            MyCommonStack cs = new MyCommonStack();
            cs.Push("Abc");

            MyCommonStack ds = new MyCommonStack();
            ds.Push(DateTime.Now);
            DateTime d = (DateTime) ds.Pop(); 

            Console.WriteLine(d);

            // 2.0 
            GenStack<int> nums = new GenStack<int>();
            nums.Push(10);
            nums.Push(20);

            Console.WriteLine( nums.Pop() + 10 );
            Console.WriteLine(nums.Contains(10));
            Console.WriteLine(nums.Contains(50));


            

            GenStack<string> names = new GenStack<string>();
            Console.WriteLine(nums.GetType().FullName);
            Console.WriteLine(names.GetType().FullName);

        }
    }

    class GenStack<T>
    {
        private T [] data;
        private int top = 0;

        public GenStack()
        {
            data = new T[10];
        }

        public bool Contains(T v)
        {
            // code here 
            return true; 
        }

        public void Reset()
        {
            for(int i=0; i < data.Length; i ++)
            {
                data[i] = default(T);
            }
        }

        public void Push(T v)
        {
            data[top] = v;
            top++;
        }

        public T Pop()
        {
            top--;
            return data[top];
        }

        public int Length
        {
            get
            {
                return top;
            }
        }

    }


    class MyCommonStack
    {
        private object [] data;
        private int top = 0;

        public MyCommonStack()
        {
            data = new object[10];
        }

        public void Push(object v)
        {
            data[top] = v;
            top++;
        }

        public object Pop()
        {
            top--;
            return data[top];
        }

        public int Length
        {
            get
            {
                return top;
            }
        }

    }



    class MyStack
    {
        private int[] data;
        private int top = 0;

        public MyStack()
        {
            data = new int[10];
        }

        public void Push(int v)
        {
            data[top] = v;
            top++;
        }

        public int Pop()
        {
            top--;
            return data[top];
        }

        public int Length
        {
            get
            {
                return top;
            }
        }

    }



    class MyStringStack
    {
        private string[] data;
        private int top = 0;

        public MyStringStack()
        {
            data = new string[10];
        }

        public void Push(string v)
        {
            data[top] = v;
            top++;
        }

        public string Pop()
        {
            top--;
            return data[top];
        }

        public int Length
        {
            get
            {
                return top;
            }
        }

    }
}
