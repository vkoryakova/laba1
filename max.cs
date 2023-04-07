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
         sbyte x= Convert.ToSByte(Console.ReadLine());
        sbyte x1= Convert.ToSByte(Console.ReadLine());
        int  z= Convert.ToInt32(Math.Max(x,x1));
        Console.WriteLine (z);
    }
}