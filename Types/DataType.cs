using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class DataType
    {
        public void DataTypeMethod()
        {
            //Check Default Values for DataTypes
            //int long short byte => Integer number must end with letters l/L, u/U
            //float, decimal, double => Fractional number must end with letters f/F, d/D, m/M
            //float single precision => 1.1234 Precision is 7 digits after point, supports dividing zero by zero i.e. called Not-a-Number (NaN)
            //double double precision => 1.1234 Precision is 16 digits after point, supports dividing zero by zero i.e. called Not-a-Number (NaN)
            //decimal infinity precision =>1.1234 Precision is 29 digits after point

            //DateTime q= "9999-12-31";

            string dateInput = "Jan 1, 2020";
            DateTime parsedDate = DateTime.Parse(dateInput);
            Console.WriteLine(parsedDate);

            string str = "This is string datatype";
            Console.WriteLine("The DataType is string with Values: {0}", str);

            String strcl = "This is string class";
            Console.WriteLine("The DataType is String with Values: {0}", strcl);

            object obj = "This is object datatype";
            Console.WriteLine("The DataType is object with Values: {0}", obj);

            var varobj = "This is var datatype";
            Console.WriteLine("The DataType is var with Values: {0}", varobj);

            bool botrue = true; //default value false
            bool bofalse = false;
            Console.WriteLine("The DataType is bool with Values: {0}, {1}", botrue, bofalse);

            byte by = 0;  //default value 0
            sbyte sby = -128;
            Console.WriteLine("The DataType is byte with Values: {0}, {1}", by, sby);

            short sh = -32768; //default value 0
            ushort ush = 65535;
            Console.WriteLine("The DataType is short with Values: {0}, {1}", sh, ush);

            int inte = -2147483648; //default value 0
            uint uinte = 4294967295;
            uint uinteu = 100u;
            Console.WriteLine("The DataType is int with Values: {0}, {1}, {2}", inte, uinte, uinteu);
            
            long lo= -9223372036854775808; //default value 0
            ulong ulo= 18446744073709551615;
            long lon = 45755452222222L;
            ulong ul = 45755452222222ul;
            Console.WriteLine("The DataType is long with Values: {0}, {1}, {2}, {3}", lo, ulo, lon, ul);

            float fl= 3.999999f;  //default value 0.0f
            float flr = 3.9999999F;  //Rounded to value 4
            float flo= -10.24f;
            Console.WriteLine("The DataType is float with Values: {0}, {1}, {2}", fl,flr, flo);

            double dou= 1.79; //default value 0.0d
            double db = 11452222.555d;
            double dbl = -234.678D;
            Console.WriteLine("The DataType is double with Values: {0}, {1}, {2}", dou, db, dbl);

            decimal dec=9877.88999M; //default value 0.0m
            decimal de = -1000.15m;
            decimal del = 1.15433245654565654546243565679m;
            Console.WriteLine("The DataType is decimal with Values: {0}, {1}, {2}", dec, de, del);

            char ch='a'; //default value '\x000'
            Console.WriteLine("The DataType is char with Values: {0}", ch);

            

        }
    }
}
