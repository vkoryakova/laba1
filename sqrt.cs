/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double x= Convert.ToDouble(Console.ReadLine());
        int  z= Convert.ToInt32(Math.Sqrt(x));
        Console.WriteLine (z);
    }
}