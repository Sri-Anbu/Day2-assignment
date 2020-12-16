using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers.App
{
    class Program
    {
       static  public void PrimeNumber(int a,int b)
        {
            int flag;
            for (int i = a; i <= b; i++)
            {

               
                if (i == 1 || i == 0)
                    continue;

          
                flag = 1;

                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

               
                if (flag == 1)
                    Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            PrimeNumber(10, 20);
        }
    }
}
