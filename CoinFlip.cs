using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problem
{
    class CoinFlip
    {
      //  public  CoinFlip();
    
        int heads = 0;
            int tails = 0;
            int counter = 0;
            Random coinflip = new Random();
        public  CoinFlip()
        {
            Console.WriteLine("How many times will flip ");
            counter = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                int flip = coinflip.Next(0, 2);
                if (flip < 0.5)
                {

                    tails++;
                }
                else
                {
                    heads++;
                } Console.WriteLine("" + flip);
            }

            Console.WriteLine("You flipped a coin " + counter
               + "times " + "and you got " + heads + "heads and " + tails + "tails.");
 
            Console.WriteLine();
            Console.ReadLine(); 
        }

        }
    }

          

