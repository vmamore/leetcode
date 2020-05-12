using System;

namespace number_of_steps_to_reduce_a_number_to_zero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int NumberOfSteps(int num)
        {
            int output = 0;
            do
            {
                if (num % 2 == 0)
                {
                    output++;
                    num = num / 2;
                }
                else
                {
                    output++;
                    num = num - 1;
                }
            } while (num != 0);

            return output;
        }

    }
}
