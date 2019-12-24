using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControls
{
    class SwitchCase
    {
        public void SwitchCaseMethod()
        {
            int x = 3;
            switch (x)
            {
                case 1:
                    Console.WriteLine("Case 1 is Printed");
                    break;
                case 2:
                    Console.WriteLine("Case 2 is Printed");
                    break;
                case 3:
                    Console.WriteLine("Case 3 is Printed");
                    break;
                default:
                    Console.WriteLine("Deault case is Printed");
                    break;
            }
        }
    }
}
