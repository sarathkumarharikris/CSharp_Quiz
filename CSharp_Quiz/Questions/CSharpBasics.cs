using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYMC.GLOBALIZATION.LOCALIZATION
{
    public class gitTest
    {
        public const int MaxHeight = 600;
        public const int MaxWidth = 800;


        static void Main(string[] args)
        {
            gitTest gittest = new gitTest();
            gittest.ValidateImage();

            gittest.Factorial();

            string reversename = gittest.ReverseName();
            Console.WriteLine("Reversed Name : " + reversename);
            Console.ReadLine();
        }

        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
        /// 

        public void ValidateImage()
        {
            Console.WriteLine("Enter Height of the image : ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Width of the image : ");
            int width = Convert.ToInt32(Console.ReadLine());

            if (height > MaxHeight && width > MaxWidth)
            {
                Console.WriteLine("Image is Landscape");
            }
            else
            {
                Console.WriteLine("Image is Portrait");
            }
            Console.ReadLine();
        }


        /// <summary>
        /// Write a program which takes a single argument from the console, computes the factorial and prints the 
        /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
        /// </summary>
        /// 

        public void Factorial()
        {
            Console.WriteLine("Enter Number for the factorial : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = number - 1; i >= 1; i--)
            {
                number = number * i;
            }
            Console.WriteLine("\nFactorial of Given Number is: " + number);
            Console.ReadLine();
        }


        /// <summary>
        /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        /// Display the reversed name on the console.
        /// </summary>
        /// 

         public string ReverseName()
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();

            char[] charArray = name.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>
        /// 

        public void Consecutive()
        {
            Console.WriteLine("Enter Numbers separated by hyphens : ");
            string numbers = Console.ReadLine();
            
            var num = numbers.Replace("-", "");

            List<string> result = num.Split(',').ToList();        
        }

    }
}

