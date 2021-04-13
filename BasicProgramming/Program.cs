using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Markup;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace BasicProgramming
{
    class Program
    {
        static void Main()
        {
            int menu;

            Console.WriteLine("Menu");
            Console.WriteLine("");
            Console.WriteLine("1. Body Mas Index");
            Console.WriteLine("2. Reprint Name");
            Console.WriteLine("3. Prints Even's Character");
            Console.WriteLine("4. Sum The Inputted Array");
            Console.WriteLine("");
            Console.WriteLine("Input Number From 1-4");
            menu = Convert.ToInt16(Console.ReadLine());
            string restart;
            switch (menu)
            {
                case 1:

                    double weight, height, bmi;
                    Console.WriteLine("Input Your Weight(Kg) : ");
                    weight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Input Your Height(cm) : ");
                    height = Convert.ToDouble(Console.ReadLine());

                    double height_m = height / 100;
                    bmi = weight / (height_m * height_m);

                    Console.WriteLine("You're BMI Score is " + bmi);

                    if (bmi < 18.1)
                    {
                        Console.WriteLine("You're Underweight");
                    }
                    else if (bmi > 18.1 && bmi < 23.1)
                    {
                        Console.WriteLine("You're Normal");
                    }
                    else if (bmi > 23.1 && bmi < 28.1)
                    {
                        Console.WriteLine("You're Overweight");
                    }
                    else if (bmi > 28.1)
                    {
                        Console.WriteLine("You're Obesitas");
                    }
                    Console.WriteLine("...");
                    Console.WriteLine("Type Yes to restart program");
                    restart = Console.ReadLine();
                    if (restart.ToUpper() == "YES")
                    {
                        Main();
                    }
                    break;
                case 2:
                    String Input;
                    Console.WriteLine("Input Your Name");
                    Input = Convert.ToString(Console.ReadLine());
                    char[] characters = Input.ToCharArray();
                    int total = characters.Count();

                    for (int i=1;i<=total;i++)
                    {
                        Console.WriteLine("Huruf ke " + i + " adalah " + characters[i-1]);
                    }
                    Console.WriteLine("...");
                    Console.WriteLine("Type Yes to restart program");
                    restart = Console.ReadLine();
                    if (restart.ToUpper() == "YES")
                    {
                        Main();
                    }
                    break;
                case 3:
                    String Input2;
                    Console.WriteLine("Input Your Name");
                    Input2 = Convert.ToString(Console.ReadLine());
                    char[] character = Input2.ToCharArray();
                    int totals = character.Count();

                    for (int i = 1; i <= totals; i++)
                    {
                        if (i % 2 == 0 ) {
                            Console.WriteLine("Huruf ke " + i + " adalah " + character[i - 1]);
                        }
                              
                    }
                    Console.WriteLine("...");
                    Console.WriteLine("Type Yes to restart program");
                    restart = Console.ReadLine();
                    if (restart.ToUpper() == "YES")
                    {
                        Main();
                    }

                    break;
                case 4:
                    Console.WriteLine("Input Length Array");
                    int input = Convert.ToInt16(Console.ReadLine());
                    int[] temp = new int[input];
                    int totali = 0;
                    for (int i=1;i<=input;i++)
                    {
                        Console.WriteLine("Insert Number "+i);
                        temp[i-1] = int.Parse(Console.ReadLine());
                        totali = totali + temp[i-1];
                    }

                    Console.WriteLine("Total Sum = "+ totali);
                    Console.WriteLine("...");
                    Console.WriteLine("Type Yes to restart program");
                    restart = Console.ReadLine();
                    if (restart.ToUpper() == "YES")
                    {
                        Main();
                    }
                    break;
                default:
                    Console.WriteLine("Please Insert Number 1-4");

                    break;
            }


        }
    }
}
