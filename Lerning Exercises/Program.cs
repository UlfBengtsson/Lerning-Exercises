using System;

namespace Lerning_Exercises
{
    class Program
    {
        internal static void RunExerciseOne()
        {
            Console.WriteLine("You successfully ran exercise one!");
        }

        internal static void RunExerciseTwo()
        {
            Console.WriteLine("You successfully ran exercise two!");
        }

        //internal static void RunExercise()
        //{
        //    your code here
        //}

        static void Main(string[] args)
        {
            bool keepAlive = true;//will be used to keep the while loop alive until the user wants to exit

            while (keepAlive)//same as (keepAlive == true)
            {
                try
                {
                    Console.Write("Enter assigment number or exit using -1.\nYour input: ");
                    int assignmentChoice = int.Parse(Console.ReadLine() ?? "");

                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            //add the next Exercise method here (look at the patten above)
                            break;

                        //keep adding new case(s) as you progress with your exercises.

                        case -1:
                            keepAlive = false;
                            Console.WriteLine("");
                            break;
                        default:
                            Console.WriteLine("Invalid choise");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;//coloring the text in console red
                    Console.WriteLine("Following exception massage: " + e.Message);
                    Console.ResetColor();//turns the console color back to normal.
                }
            }
        }
    }//end of Program class
}//end of namespace

//the end of program and namespace must be here in the end.