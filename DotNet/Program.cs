using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            int divOf3 = 0;
for(int i=1 ; i<21 ; i++){
    if (i%3==0){
        divOf3+=i;
        }
        }
Console.WriteLine(divOf3);
Console.ReadLine();
        }
    }
}
