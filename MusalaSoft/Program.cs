using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusalaSoft
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            char[] s = str.ToCharArray();
            string b = "";

            int biggestNum = 0;

            for (int i = 0; i < (s.Length - 1); i++)
            {




                //getting the num right
                while (Char.IsDigit(s[i]))
                {
                    b += s[i];
                    i++;
                    if (i == s.Length)
                        break;
                }

                //if b has value and biggestNum is smaller than b we change their values
                if (b.Length > 0 && biggestNum < int.Parse(b))
                {
                    biggestNum = int.Parse(b);
                }

                b = "";
            }

            if (biggestNum > 0)
            {
                Console.WriteLine("The biggest num in the array is {0}", biggestNum); 
            }
            else
            {
                Console.WriteLine("there is no numbers in the string");
            }
        }

    }
}

