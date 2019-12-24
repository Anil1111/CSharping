using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/unsafe
    //Tick Check Box Allow Unsafe Code in Project Properties Press F4 key and go to build option otherwise compilation error
    class UnSafeBlock
    {
        public unsafe int PointersMethod()
        {
            //Check Box Allow Unsafe Code in Project Properties Press F4 key and go to build option
            int i = 20;
            int* k = &i;
            Console.WriteLine("The Pointer Address of i=20 is : " + (int)k);  //Changes at every run or instance
            return 0;
        }

        public void PointersMethod2()
        {
            unsafe
            {
                Console.WriteLine(sizeof(double));  // output: 8
            }
        }

        public unsafe int PointersMethod3()
        {
            int i = 20;
            int* k = &i;
            Console.WriteLine("The Pointer Address of i=20 is : " + (int)k); 
            return 0;
        }
    }
}
