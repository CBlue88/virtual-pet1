using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Monkey Madness!");
            Console.WriteLine("You are going to have your very own Funky little Monkey to take care of!");
            Console.WriteLine("After you give your Monkey a name, gender, and color, your monkey will prompt you for care");
            Console.WriteLine("You are will be given options to take care of our monkey, make good decisions, and good luck!");
            //THIS IS THE EXPLAINATION AND PROMPT DETAILING MONKEY MADNESS
            Virtual_Pet monkey = new Virtual_Pet();

            Console.WriteLine("What is your Monkey's name?");
            monkey.nameOfPet = Console.ReadLine();
            Console.WriteLine("What gender is your monkey?");
            monkey.genderOfPet = Console.ReadLine();
            Console.WriteLine("What is the color of your monkey?");
            monkey.colorOfPet = Console.ReadLine();
            Console.WriteLine("Cool! You have a" + "" + monkey.colorOfPet + "monkey!");

            Console.WriteLine("Now lets get started!");
            Console.WriteLine(monkey.nameOfPet + "needs to be taken care of!");
            Random random = new Random();//Random function
            string[] myStrings = new string[] { "hunger", "sleepy", "bored", };
            string[] myFoods = new string[] { "apple", "banana", "roots", "leaves" };
            //----------------------------------------------INSERT LOOP HERE??
            for (int n = 0; n < 1; n++)
            {
                int rnd = random.Next(0, myStrings.Length);
                string s = myStrings[rnd];
                Console.WriteLine("-> {0}", s);
            }

            if (myStrings.Equals("hungry"))
            {
                Console.WriteLine(monkey.nameOfPet + ""+ "is hungry");  // Make the monkey's name a variable here. 
                Console.WriteLine("Would you like to feed" +""+ monkey.nameOfPet?); //Factor in her and him for gender selection
                Console.ReadLine();

                if (Console.ReadLine().Equals("yes"))
                {
                    food();
                }

                else
                {
                    Console.WriteLine("Your monkey is hungry!");
                }
            }

            if (myStrings.Equals("bored"))
            {
                Console.WriteLine("Momo is" + "bored"); //Make the monkey's name a variable here
                Console.WriteLine("Would you like to play with her?");
                if (Console.ReadLine().Equals("yes"))
                {
                    bored();
                }
                else
                {
                    Console.WriteLine("Your monkey is bored!");
                }
            }

            if (myStrings.Equals("sleepy"))
            {
                Console.WriteLine("Momo is" + "sleepy"); //Make the monkey's name a variable here
                Console.WriteLine("Would you like to put her to bed?");
                if (Console.ReadLine().Equals("yes"))
                {
                    sleep();
                }
                else
                {
                    Console.WriteLine("Your monkey needs sleep!");
                }







            }
    }
        // METHODS START HERE
        static void food()
        {
            string[] myFoods = new string[] { "apple", "banana", "roots", "leaves" };
            myFoods.ToList().ForEach(Console.WriteLine);
        }

        static void bored()
        {
            string[] playforpet = { "wrestle", "catch", "groom", "swing" };
            playforpet.ToList().ForEach(Console.WriteLine);
        }
        static void sleep()
        {
            Console.WriteLine("You monkey is asleep and will be well rested!");
        }

    }
