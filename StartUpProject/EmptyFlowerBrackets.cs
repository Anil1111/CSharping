using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    class EmptyFlowerBrackets
    {
        public void AMethod()
        {

            {


            }

            {//empty brackets are allowed
                {
                    {

                    }
                }
            }

            {
                Console.WriteLine("This message is printed from AMethod");
            }
            
        }
    }
}
