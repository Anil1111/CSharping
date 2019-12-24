using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class EnumType
    {
        enum Colors
        {
            Red = 100,
            Green = 50,
            Blue = 80
        }

        enum Temperatures
        {
            Morning = 20,
            Afternoon = 25,
            Evening = 23,
            Night = 20
        }

        enum Weekdays
        {
            Sunday = 0,
            Monday = 1,
            Tuesday = 2,
            Wensday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6
        }
        public void EnumTypeMethod()
        {
            // foreach(int i in Weekdays)
            Console.WriteLine(Weekdays.Friday);
            Console.WriteLine((int)Weekdays.Friday);

            int dayNum = (int)Weekdays.Friday;
            Console.WriteLine(dayNum);

            Console.WriteLine(Enum.GetName(typeof(Weekdays), 4));

            Console.WriteLine("WeekDays constant names:");

            foreach (string str in Enum.GetNames(typeof(Weekdays)))
                Console.WriteLine(str);

            foreach (int i in Enum.GetValues(typeof(Weekdays)))
            Console.WriteLine(i);

            //Console.WriteLine("Enum.TryParse():");

            //Weekdays wdEnum;
            //Enum.TryParse<Weekdays>("1", out wdEnum);
            //Console.WriteLine(wdEnum);
        }


    }
}
