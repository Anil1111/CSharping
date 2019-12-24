using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{   //https://www.tutorialsteacher.com/csharp/csharp-dynamic-type
    //No compilation timer type check
    //Throws error at runtime
    class DynamicType
    {
        public void AMethod()
        {
            dynamic dynamicVariable = 1;
            Console.WriteLine(dynamicVariable.GetType().ToString());

            dynamicVariable = 100;
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamicVariable = "Hello World!!";
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamicVariable = true;
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamicVariable = DateTime.Now;
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

        }
        
    }
}
