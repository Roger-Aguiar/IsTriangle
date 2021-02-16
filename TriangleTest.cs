//Name:         Roger Silva Santos Aguiar
//Function:     It tests the Triangle class
//Initial date: February 16, 2021
//Last update:  February 16, 2021
using System;

namespace TriangleTestsProject
{
    class TriangleTest
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value for side A: ");
            int a = Int32.Parse(Console.ReadLine());
         
            Console.Write("Enter a value for side B: ");
            int b = Int32.Parse(Console.ReadLine());

            Console.Write("Enter a value for side C: ");
            int c = Int32.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(a, b, c);           
            bool isTriangle = triangle.IsTriangle();

            if(isTriangle == false)
            {
                Console.WriteLine("It is not possible to build a triangle with the provided values.");
            }
            else
            {
                Console.WriteLine("Great! You have a triangle!");
            }
        }
    }
}
