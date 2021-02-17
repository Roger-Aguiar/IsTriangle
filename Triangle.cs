//Name:         Roger Silva Santos Aguiar
//Function:     It implements a method that accepts 3 integer values a, b, c. 
//              The method should return true if a triangle can be built with the 
//              sides of given length and false in any other case.
//Initial date: February 16, 2021
//Last update:  February 17, 2021

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
    
    private void CheckIfValueIsLessOrIgualZero(int sideValue, string side)
    {
        if(sideValue <= 0)
            Console.WriteLine($"Invalid value for side {side}! It must be greater than 0");            
    }

    public int A 
    {
        get
        {
            return a;
        }
        set
        {
            a = value;
            CheckIfValueIsLessOrIgualZero(a, "A");            
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
            CheckIfValueIsLessOrIgualZero(b, "B");
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
            CheckIfValueIsLessOrIgualZero(c, "C");
        }
    }    
}