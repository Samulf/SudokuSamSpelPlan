using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suddo_test
{
    class Program
    {
        static void Main(string[] args)
        {
            SpelplansSkaparen("619030040270061008000047621" +
                              "486302079000014580031009060" +
                              "005720806320106057160400030");

            
        }



        static int[,] SpelplansSkaparen(string skaparInput)
        {
                             

            int k = 0; //int som räknar vilken siffra i stringen
         
            int[,] cell = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {

                for (int j = 0; j < 9; j++)
                {
                    
                    cell[j, i] = int.Parse(skaparInput.Substring(k, 1));
                    k++;
                    Console.Write(cell[j,i]);
                }
                Console.WriteLine();
            }
            
            return cell;
        }
    }
}
