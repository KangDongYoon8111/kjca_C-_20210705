using System;

namespace p357
{
    class Program
    {
        static void Main(string[] args)
        {
            int input_number = -1;
            do
            {
                Console.Write("Enter the exit number : ");
                String input = Console.ReadLine();
                input_number = Convert.ToInt32(input);


                int exit_number = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (exit_number++ == input_number)
                                goto EXIT_FOR;

                            Console.WriteLine(exit_number);

                        }

                    }
                }

                goto EXIT_PROGRAM;

            EXIT_FOR:
                Console.WriteLine("\nExit nested for...");

            EXIT_PROGRAM:
                Console.WriteLine("Exit program...");
            } while (input_number != 119);
            

                

        }
    }
}
