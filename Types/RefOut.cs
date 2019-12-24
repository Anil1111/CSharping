using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref
    //Call by value and call by reference
    //Cannot define overloaded
    class RefKeyWord
    {
        public void AMethod()
        {
            int k = 20;
            BMethod(ref k);
        }

        public void BMethod(ref int k)
        {
            Console.WriteLine(k);
        }
    }
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier
    class OutKeyWord
    {
   
        public void AMethod()
        {
           int k;
           BMethod(out k);
        }
        public void BMethod(out int k)
        {
            k = 20;
            Console.WriteLine(k);
        }
    }
}
