using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo
{
    // 1. create delegate type 
    delegate void PrintDelegate();
    delegate void Print2Delegate(string msg);
    delegate int  MathDelegate(int n1, int n2);
    delegate Tout Process<Tin,Tout>(Tin v1, Tin v2);

    class DelegateDemo
    {
        static void Main(string[] args)
        {
            // 2. Create delegate
            PrintDelegate d1 = new PrintDelegate(Print);

            // 2.0
            PrintDelegate d2 = Print;
            
            PrintDelegate d3 = delegate ()
            {
                Console.WriteLine("In Anonymous Method");
            };
            // 3.0
            PrintDelegate d4 = () => Console.WriteLine("Lambda");

            PrintDelegate d5 = () =>
            {
                Console.WriteLine("Lambda  Block");
            };



            Print2Delegate pd2 = new Print2Delegate(Print2);

            // 3. Invoke method 
            d1();
            d2();
            d3();
            d4();

            MathDelegate md1 = (a,b) => a + b;

            MathDelegate md2 = (a, b) =>
            {
                if (a > b)
                    return a;
                else
                    return b; 

            };


        }

        static void Print()
        {
            Console.WriteLine("I am in Print()");
        }

        static void Print2(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
