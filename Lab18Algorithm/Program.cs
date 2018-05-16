using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set arrays
            int[] numbers = new int[3] {3,4,3};
            int[] Count = new int[3] {3,4,3};
            int i, j;
            //Create counter
            int counter;
            //Allow the integer i to reach length of array
            for (i = 0; i <= numbers.Length; i++)
            {
                //Start at 1 to create occurrences
                counter = 1;
                for (j = i + 1; j <= numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                        Count[j] = 0;
                    }
                }

                if (Count[i] != 0)
                {
                    Count[i] = counter;
                }
            }
            for (i = 0; i <= numbers.Length; i++)
            {
                if (Count[i] != 0)
                {
                    //Print number of each occurrence
                   Console.Write("{0} occurs {1} times\n", numbers[i], Count[i]);
                }
            }
        }
    }
}

