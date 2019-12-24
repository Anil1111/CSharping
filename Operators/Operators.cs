using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
    class Operators
    {
        
        public void MathMethod()
        {
            int a = 4, b = 2;
            int u, v, w, x, y;
            
            u = a + b;
            Console.WriteLine("a+b="+u);
            v = a - b;
            Console.WriteLine("a-b ="+v);
            w = a * b;
            Console.WriteLine("a*b ="+w);
            x = a / b;
            Console.WriteLine("a/b ="+x);
            y = a % b;
            Console.WriteLine("a%b =" + y);
            Console.WriteLine(-(-4));

            Console.WriteLine(b);            // output: 2
            Console.WriteLine(b.GetType());  // output: System.Int64

            Console.WriteLine(-double.NaN);  // output: NaN
        }
        public void UnaryMethod()
        {
            int a = 4, b = 2;
            int i, j;

            i = a++;
            Console.WriteLine("a++ = " + i);
            j = --b;
            Console.WriteLine("--b = " + j);

        }
        public void AssignmentMethod()
        {
            int c=1;
    
            c += 4;
            Console.WriteLine("+= :"+ c);

        }

        public void ConditionalMethod()
        {
            int a = 4, b = 2,c;
            
            c= a > b ? a : b;

            Console.WriteLine("Conditional Operator c=a > b ? a : b; =>" + c);

        }
        public void LogicalComparisonMethod()
        {
            int a = 4, b = 2, c = 9, d = 3, e=108, f=-403;
            if(a==4 && b<=3 || c>=8 && d != 6 || e<109 && f>-402)
            {
                Console.WriteLine("Logical Comparison Become True");
            }
        }
        public void ShiftMethod()
        {   
            // a = 5(00000101), b = 9(00001001) 
            int a = 5, b=9, c, d; //32 bit
            c = a<<1;
            d = b>>2;
            Console.WriteLine("Shift Operator a>>1:{0} a<<1:{0}, b>>1:{1}", c, d);
        }

        public void BitwiseMethod()
        {
            // a = 5(00000101), b = 9(00001001) 
            int a = 5, b = 9, c, d;  //32 bit
            c = a | b;
            d = a & b;
            Console.WriteLine("Shift Operator a|b:{0}, a&b:{1}", c, d);

            bool T =true;
            Console.WriteLine("bool true:  " + T);
            bool F = false;
            Console.WriteLine("bool false:  " + F);
            bool NOT = !F;
            Console.WriteLine("bool ~F:  " + NOT);
            bool or = T | F;
            Console.WriteLine("T|F:  " + or);
            bool and = T & F;
            Console.WriteLine("T&F:  " + and);
            bool xor = T ^ F;
            Console.WriteLine("T^F:  " + xor);
        }

        unsafe public void SizeOfMethod()
        {
            int k = 20;
            int* a = &k;
            Console.WriteLine(sizeof(byte));  // output: 1
            Console.WriteLine(sizeof(double));  // output: 8
            //unsafe
            //{
            //    Console.WriteLine(sizeof(int(a));
            //}
        }

        public void nullable()
        {
            int? a = null;
            int b = a ?? -1;
            Console.WriteLine(a);  // output: -1
        }

        public void FunctionMethod()
        {
            int a=4, b=2, p=8;
            double d, e, f;

            d = Math.Pow(b, p);
            Console.WriteLine("Power of (b, p)= "+ d);
            e = Math.Max(b, p);
            Console.WriteLine("Max of (b, p)= " + e);
            f = Math.Min(a,b);
            Console.WriteLine("Max of (b, p)= " + f);


            Random randobj = new Random();
            int rndnum = randobj.Next();
            Console.WriteLine("Random Number is : " + rndnum);
            int rndnum1 = randobj.Next(1000);
            Console.WriteLine("Random Number is : " + rndnum1);
            int rndnum2 = randobj.Next(1000,2000);
            Console.WriteLine("Random Number is : " + rndnum2);

            //no random.string not working
            string rndstr = randobj.ToString();
            Console.WriteLine("Random Number is : " + rndstr);
        }
        
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/pointer-related-operators
        public unsafe int PointersMethod() //Return type is mandatory for unsafe block method
        {
            int i = 20;
            int[] j = new int[3] { 1, 2, 3 };
            int* k = &i;  //Address-of operator
           // int* a = &j[0], b = &j[1], c = &j[2]; //does not work  //due to fixed issue

            Console.WriteLine("The Pointer Address of i=20 is : "+(int)k);  //Changes at every run or instance

            //foreach (int b in j)
            //{
            //    fixed (int* a = &j[b])  //fixed prefix is mandatory for pointer to array
            //    {
            //        Console.WriteLine($"Using The Pointer Address of j[{b}] is :{(int)a} ");
            //    }
            //}

            fixed (int* a = &j[0])  //fixed prefix is mandatory for pointer to array
            {
                Console.WriteLine("The Pointer Address of j[] is : " + (int)a);
            }

            int* c = stackalloc int[] { 0, 1, 2, 3, 4, 5 };
            int* p1 = &c[1];
            int* p2 = &c[5];
            Console.WriteLine(p2 - p1);  // output: 4
            Console.WriteLine(*p2 - *p1);
            Console.WriteLine(&p2 - &p1);

            int* d = stackalloc int[] { 0, 1, 2 };
            int* p3 = &d[0];
            int* p4 = p1;
            Console.WriteLine($"Before operation: p3 - {(long)p3}, p4 - {(long)p4}");
            Console.WriteLine($"Postfix increment of p3: {(long)(p3++)}");
            Console.WriteLine($"Prefix increment of p4: {(long)(++p4)}");
            Console.WriteLine($"After operation: p3 - {(long)p3}, p4 - {(long)p4}");

            return 0;
            
        }
    }
}
