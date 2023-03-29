
using System;  
public class Exercise1
{
    public static void Main()
    {
        //program to accept two integers and check whether they are equal or not.

        int int1, int2;
        Console.Write("\n\n");
        Console.Write("Check whether two integers are equal or not:\n");
        Console.Write("-------------------------------------------");
        Console.Write("\n\n");
        Console.Write("Input 1st number: ");
        int1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input 2nd number: ");
        int2 = Convert.ToInt32(Console.ReadLine());

        if (int1 == int2)
            Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
        else
            Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);
        
        //program to find whether a given year is a leap year or not.

        int chk_year;
        Console.Write("\n\n");
        Console.Write("Check whether a given year is leap year or not:\n");
        Console.Write("----------------------------------------------");
        Console.Write("\n\n");
        Console.Write("Input an year : ");
        chk_year = Convert.ToInt32(Console.ReadLine());

        if ((chk_year % 400) == 0)
            Console.WriteLine("{0} is a leap year.\n", chk_year);
        else if ((chk_year % 100) == 0)
            Console.WriteLine("{0} is not a leap year.\n", chk_year);
        else if ((chk_year % 4) == 0)
            Console.WriteLine("{0} is a leap year.\n", chk_year);
        else
            Console.WriteLine("{0} is not a leap year.\n", chk_year);

        //program to find the largest of three numbers.

        int num1, num2, num3;
        Console.Write("\n\n");
        Console.Write("Find the largest of three numbers:\n");
        Console.Write("------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input the 1st number :");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the  2nd number :");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the 3rd  number :");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.Write("The 1st Number is the greatest among three. \n\n");
            }
            else
            {
                Console.Write("The 3rd Number is the greatest among three. \n\n");
            }
        }
        else if (num2 > num3)
            Console.Write("The 2nd Number is the greatest among three \n\n");
        else
            Console.Write("The 3rd Number is the greatest among three \n\n");

        //program to display n terms of natural number and their sum.

        int i, n, sum = 0;

        Console.Write("\n\n");
        Console.Write("Display n terms of natural number and their sum:\n");
        Console.Write("----------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input Value of terms : ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nThe first {0} natural number are :\n", n);
        for (i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
            sum += i;
        }
        Console.Write("\nThe Sum of Natural Number upto {0} terms : {1} \n", n, sum);

    }
}