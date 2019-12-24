using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class NullableType
    {
        public void AMethod()
        {
            int? k = null;  //Compilation error for: int k=null;

             Console.WriteLine(k); 

            if (k.HasValue == null)
                Console.WriteLine(k);
            else
                Console.WriteLine("The k value is null");

            //k = 20;
            Console.WriteLine(k);

            try
            {
                //int y = (int?)k;  //compilation error

                int? y= k;

                int x = y.GetValueOrDefault();
                 x=y.Value;
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
