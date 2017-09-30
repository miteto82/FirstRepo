using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var magN = int.Parse(Console.ReadLine());
            var s = Math.Abs(b - a);
            var combination = 0;
            for (int row = 1; row <= s+1 ; row++)
            {
                for (int cow = 1; cow <= s+1; cow++)
                {
                    combination = row*cow ;
                    
                }
            }


            for (int i = a; i <= b ; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    var sum = i + j;

                    if(sum == magN)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {sum}");
                        return;
                    }
                    
                }
            }
            Console.WriteLine($"{combination} combinations - neither equals {magN}");
            
            




        }
    }
}
