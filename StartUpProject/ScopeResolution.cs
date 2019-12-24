using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUpProject
{
    class ScopeResolution
    {
       public void sr() => global::System.Console.WriteLine("Using global alias");
    }

    class ScopeResolutionConsole
    {
        string Suggestion => "Consider renaming this class";
    }
}
