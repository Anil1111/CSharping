using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class StringBuild
    {
        public void StringBuildMethod()
        {
            string s1 = "abcdef";
            string s2 = s1.ToUpper();
            Console.WriteLine("ToUpper function resulted : {0}", s2);

            String s3 = "xyz";
            string s4 = s3.ToUpper();
            Console.WriteLine("ToUpper function resulted : {0}", s4);

            string s5 = "ghijkl";
            String s6= "mnopqr";
            string s7 = "stuvw";
            string s8 = String.Concat(s5, s6, s7);
            Console.WriteLine($"String concatination performed : {s8}, Length : {s8.Length}");

            StringBuilder sb = new StringBuilder("Hello World!!", 50);
            sb.Insert(5, " C#");
            Console.WriteLine("ToUpper function resulted : {0}", sb);
        }
    }
}
