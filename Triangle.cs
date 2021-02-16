//Name:         Roger Silva Santos Aguiar
//Function:     It implements a method that accepts 3 integer values a, b, c. 
//              The method should return true if a triangle can be built with the 
//              sides of given length and false in any other case.
//Initial date: February 16, 2021
//Last update:  February 16, 2021

using System;

public class Triangle 
{
    private int a;
    private int b;
    private int c;

    public Triangle(int aValue, int bValue, int cValue) 
    {        
        A = aValue;
        B = bValue;
        C = cValue;
    }
    public bool IsTriangle() => ((A + B > C && A + C > B && B + C > A) ? true : false);
    
    public int A 
    {
        get
        {
            return a;
        }
        set
        {
            a = value;
            if(a <= 0)
            {
                Console.WriteLine("Invalid value for side A! It must be greater than 0");
            }
        }
    }

    public int B 
    {
        get
        {
            return b;
        }
        set
        {
            b = value;
            if(b <= 0)
            {
                Console.WriteLine("Invalid value for side B! It must be greater than 0");
            }
        }
    }

    public int C 
    {
        get
        {
            return c;
        }
        set
        {
            c = value;
            if(c <= 0)
            {
                Console.WriteLine("Invalid value for side C! It must be greater than 0");
            }
        }
    }    
}