using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControls
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            FromSelectLoop fromSelectLoop = new FromSelectLoop();
            fromSelectLoop.FromSelectMethod();

            //SwitchCase scobj = new SwitchCase();
            //scobj.SwitchCaseMethod();

            //WhileLoop wlobj = new WhileLoop();
            //wlobj.Whileloopmethod();

            //DoWhileLoop dlobj = new DoWhileLoop();
            //dlobj.DoWhileLoopMethod();

            //Forloop flobj = new Forloop();
            //flobj.ForLoopMethod();

            //ForeachLoop feobj = new ForeachLoop();
            //feobj.ForeachMethod();

            Console.ReadLine();
        }
    }
}
