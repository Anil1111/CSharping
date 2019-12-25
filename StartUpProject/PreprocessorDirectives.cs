using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-region

    //Allows block of code to visible, invisible like snippets
    //Used for code decoration only, does nothing as per funtionality
    //throws errors when error in syntax
    class PreprocessorDirectives
    {
        #region variables  //Preprocessor Directive called as code snippets
        int i = 420;
        int k = 108;
        #endregion variables

        #region Functions
        public void PreprocessorDirectiveMethod()
        {
            //Code Snippet
            #region
            Console.WriteLine("These Preprocessor Directives");
            Console.WriteLine("Using Code Snippets");
            #endregion
        }
        #endregion Functions

    }
}
