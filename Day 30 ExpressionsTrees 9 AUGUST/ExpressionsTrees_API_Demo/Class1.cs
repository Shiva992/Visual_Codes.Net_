using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ExpressionsTrees_Linqlambda
{
    class Class1
    {
        static void Main(string[]args)
        {

            Expression<Func<int, bool>> lambda = num =>num < 6;
            bool result = lambda.Compile()(8);

            Console.WriteLine(result);
        }
    }
}
