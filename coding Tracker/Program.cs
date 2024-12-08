// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//namespace MyApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//            Console.WriteLine("I am Learning C#");
//            Console.WriteLine("It is awesome!");
//        }
//    }
//}


//public class ReverseExample     {

//     public static void Main(string[] args)  
//  {
//         int n, reverse = 0, rem;
//    Console.Write("Enter a number: ");
//    n = int.Parse(Console.ReadLine());
//          while (n != 0)
//             {
//     rem = n % 10;
//     reverse = reverse * 10 + rem;
//     n /= 10;
//              }
//     Console.Write("Reversed Number: " + reverse);
//     }
//     }  

//    namespace ConsoleApplication1
//       {  
//     class CalcAvgPerc
//    {  
//       static void Main(string[] args)
//        {  
//       int num1;  	          
//           Console.WriteLine("Enter the number to check odd or even");  
//         num1 = int.Parse(Console.ReadLine());  
//           if (num1 % 2 == 0)  
//            {  
//             Console.WriteLine("Number is Even");  
//            }
//            else
//               {
//      Console.WriteLine("Number is odd");
//               }
//      Console.ReadKey();
//         }  
//   }  
//}


//public class Exercise8  // Declaration of the Exercise8 class
//{
//    public static void Main()  // Entry point of the program
//    {
//        int num1, num2, num3;  // Declaration of integer variables num1, num2, and num3
//        Console.Write("\n\n");  // Printing new lines
//        Console.Write("Find the largest of three numbers:\n");  // Displaying the purpose of the program
//        Console.Write("------------------------------------");  // Displaying a separator
//        Console.Write("\n\n");  // Printing new lines

//        Console.Write("Input the 1st number :");  // Prompting user to input the first number
//        num1 = Convert.ToInt32(Console.ReadLine());  // Reading the input first number from the user

//        Console.Write("Input the 2nd number :");  // Prompting user to input the second number
//        num2 = Convert.ToInt32(Console.ReadLine());  // Reading the input second number from the user

//        Console.Write("Input the 3rd number :");  // Prompting user to input the third number
//        num3 = Convert.ToInt32(Console.ReadLine());  // Reading the input third number from the user

//        if (num1 > num2)  // Checking if num1 is greater than num2
//        {
//            if (num1 > num3)  // Checking if num1 is greater than num3
//            {
//                Console.Write("The 1st Number is the greatest among three. \n\n");  // Printing a message if num1 is the greatest
//            }
//            else
//            {
//                Console.Write("The 3rd Number is the greatest among three. \n\n");  // Printing a message if num3 is the greatest
//            }
//        }
//        else if (num2 > num3)  // Checking if num2 is greater than num3
//        {
//            Console.Write("The 2nd Number is the greatest among three \n\n");  // Printing a message if num2 is the greatest
//        }
//        else
//        {
//            Console.Write("The 3rd Number is the greatest among three \n\n");  // Printing a message if num3 is the greatest
//        }
//    }
//}

//public class Exercise2  // Declaration of the Exercise2 class
//{
//    public static void Main()  // Entry point of the program
//    {
//        int num1, rem1;  // Declaration of integer variables num1 and rem1
//        Console.Write("\n\n");  // Printing new lines
//        Console.Write("Check whether a number is even or odd :\n");  // Displaying the purpose of the program
//        Console.Write("---------------------------------------");  // Displaying a separator
//        Console.Write("\n\n");  // Printing new lines
//        Console.Write("Input an integer : ");  // Prompting user to input an integer
//        num1 = Convert.ToInt32(Console.ReadLine());  // Reading the input integer from the user

//        rem1 = num1 % 2;  // Calculating the remainder when num1 is divided by 2

//        if (rem1 == 0)  // Checking if the remainder is equal to 0
//            Console.WriteLine("{0} is an even integer.\n", num1);  // Printing a message if the number is even
//        else
//            Console.WriteLine("{0} is an odd integer.\n", num1);  // Printing a message if the number is odd
//    }
//}


using System;  // Importing necessary namespace

public class Exercise6  // Declaration of the Exercise6 class
{
    public static void Main()  // Main method, entry point of the program
    {
        int j, n;  // Declaration of variables 'j' for iteration and 'n' to store the input number

        Console.Write("\n\n");  // Displaying new lines
        Console.Write("Display the multiplication table:\n");  // Displaying the purpose of the program
        Console.Write("-----------------------------------");  // Displaying a separator
        Console.Write("\n\n");

        Console.Write("Input the number (Table to be calculated) : ");  // Prompting the user to input a number for the multiplication table
        n = Convert.ToInt32(Console.ReadLine());  // Reading the number entered by the user

        Console.Write("\n");  // Displaying a new line

        for (j = 1; j <= 10; j++)  // Loop to calculate and display the multiplication table of the entered number up to 10
        {
            Console.Write("{0} X {1} = {2} \n", n, j, n * j);  // Displaying the multiplication table entry
        }
    }
}


// declaring public class
internal class Class1
{

    // Main Method
    static public void Main()
    {

        int a = 20;
        int[] arr = new int[a];
        int b;

        // initial array of size 10
        for (b = 0; b < a; b++)
            arr[b] = b + 1;

        // print the original array
        for (b = 0; b < a; b++)
            Console.Write(arr[b] + " ");
        Console.WriteLine();

        // element to be inserted
        int x = 25;

        // position at which element
        // is to be inserted
        int pos = 10;

        // create a new array of size n+1
        int[] newarr = new int[a + 1];

        // insert the elements from the
        // old array into the new array
        // insert all elements till pos
        // then insert a at pos
        // then insert rest of the elements
        for (b = 0; b < a + 1; b++)
        {
            if (b < pos - 1)
                newarr[b] = arr[b];
            else if (b == pos - 1)
                newarr[b] = x;
            else
                newarr[b] = arr[b - 1];
        }

        // print the updated array
        for (b = 0; b < a + 1; b++)
            Console.Write(newarr[b] + " ");
        Console.WriteLine();
    }
}
}














