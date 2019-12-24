using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUpProject
{
   public class ClassMembers
    {
        public int x=10, y, z;
        public string str = "This a String";
        public ClassMembers() //Constructor
        {
            MethodDef();
        }
        public ClassMembers(int x, string str) //Constructor
        {
            Console.WriteLine(str + x);
            MethodDef();
        }
       // public int xProperty =15;
        public int xProperty
        {
            get
            {
                return x;
            }
            set
            {
                xProperty = 15;
            }
        }
        void MethodDef()
        {
            Console.WriteLine("xProperty Value is :{0}", xProperty);
        }
    }
}
