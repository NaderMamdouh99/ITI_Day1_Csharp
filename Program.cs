using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Day_C_
{
    internal class Program
    {
        #region FUNCTION

        #region Function Prototype and Calling
        static void print(int Count = 5, string Battern = "#_#")
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(Battern);
            }
        }
        #endregion

        #region Value type parameter
        // Passsing by value 
        static void SWAP(int x, int y)
        {
            Console.WriteLine("----------");
            int temp = x;
            x = y;
            y = temp;
        }
        // Passing by reference 
        static void SWAP2(ref int x, ref int y)
        {
            Console.WriteLine("----------");
            int temp = x;
            x = y;
            y = temp;
        }
        #endregion

        #region Reference Type Parametars
        // Passing by value 
        static int SumArray(int[] Arry)
        {
            int Sum = 0;
            Arry[0] = 100;
            if (Arry != null)
                for (int i = 0; i < Arry.Length; i++)
                    Sum += Arry[i];
            return Sum;
        }
        static int SumArray1(ref int[] Arry)
        {
            int Sum = 0;
            Arry[0] = 100;
            if (Arry != null)
                for (int i = 0; i < Arry.Length; i++)
                    Sum += Arry[i];
            return Sum;
        }
        #endregion

        #endregion
        static void Main(string[] args)
        {
			#region Lab
			//============================ POINT 1 Program to print "Hello World"
			//console.writeline ("hello world");



			//============================ POINT 2 Program to print ASCII number of a char

			//char ch = 'A';
			//int asciiValue = Convert.ToInt32(ch);

			//Console.WriteLine("ASCII value of " + ch + " is " + asciiValue);
			//Console.ReadKey();

			//============================ POINT 3 Program to print a float number entered by the user

			//Console.WriteLine(" Enter fLOAT Number Please");
			//float FloatNumber = float.Parse(Console.ReadLine());
			//Console.WriteLine(FloatNumber);
			//Console.ReadLine();


			//============================ POINT 4 Program to add two integers


			//Console.WriteLine("Enter First Number : ");
			//int FirstNumber = int.Parse(Console.ReadLine());
			//Console.WriteLine("Enter Last Number : ");
			//int SecondNumber = int.Parse(Console.ReadLine());
			//Console.WriteLine($"The First Number :{FirstNumber}  and the Second Number:{SecondNumber}");


			//============================ POINT 5 Program to print Hexa of a number

			//int NumberHexa = 1000;
			//string hexa = NumberHexa.ToString("x");
			//Console.WriteLine(hexa);


			//============================ POINT 6 Program to compute Quotient and Remainder


			//Console.WriteLine("Enter First Number ");
			//int Number1 = int.Parse(Console.ReadLine());
			//Console.WriteLine("Enter Second Number ");
			//int Number2 = int.Parse(Console.ReadLine());

			//int Quotient = Number1 / Number2;
			//int Remainder = Number1 % Number2;
			//Console.WriteLine(Quotient);
			//Console.WriteLine(Remainder);

			//============================ POINT 7 Program to Check Whether a Number is Even or Odd


			//Console.WriteLine("Enter First Number ");
			//int Number1 = int.Parse(Console.ReadLine());
			//Console.WriteLine("Enter Second Number ");
			//int Number2 = int.Parse(Console.ReadLine());

			//int Remainder = Number1 % Number2;

			//if (Remainder== 0 )
			//{
			//    Console.WriteLine("Even");
			//}else
			//{
			//    Console.WriteLine("odd");
			//}

			//============================ POINT 8 Program to Find the Largest Number Among Three Numbers


			//Console.WriteLine("Please enter your Degree {A=Excellent, B=Very Good, C=Good, D=fair, E=failed }"); 
			//string Degree = Console.ReadLine();

			//switch (Degree) 
			//{
			//    case "A":
			//        Console.WriteLine("Excellent");
			//        break;
			//    case "B":
			//        Console.WriteLine("Very Good");
			//        break;
			//    case "C":
			//        Console.WriteLine("Good");
			//        break;
			//    case "D":
			//        Console.WriteLine("fair");
			//        break;
			//        case "E":
			//        Console.WriteLine("failed");
			//        break;
			//}

			//============================ POINT 9 Program that takes the degree from user, and switch on it to print the corresponding Grade:
			//A => Excellent
			//B => Very Good
			//C => Good
			//D => fair

			//Console.WriteLine("Enter First Number ");
			//int Number1 = int.Parse(Console.ReadLine());
			//Console.WriteLine("Enter Second Number ");
			//int Number2 = int.Parse(Console.ReadLine());
			//Console.WriteLine("Enter Therid Number ");
			//int Number3= int.Parse(Console.ReadLine());

			//if (Number1>Number2&&Number1>Number3 )
			//{
			//    Console.WriteLine(Number1);

			//}else if (Number2>Number1 && Number2>Number3)
			//{
			//    Console.WriteLine(Number2);

			//}else if (Number3>Number1 && Number3>Number2)
			//{
			//    Console.WriteLine(Number3);
			//}

			//============================ POINT 10 Program to print total of numbers when it gets to 100. (sum)


			//Console.WriteLine("Enter First Number ");
			//int Start = int.Parse(Console.ReadLine());
			//int End = 100;

			//for (int i = Start; i <= End; i++)
			//{
			//    Console.WriteLine(i);
			//}


			//============================ POINT 11 Program to Generate Multiplication Table "1*3=3, 2*3=6, ..."

			//Console.WriteLine("Enter your Number ");
			//int Start = int.Parse(Console.ReadLine());


			//for (int i = 1; i <= 10; i++)
			//{
			//    Console.WriteLine(Start*i);
			//}

			//============================ POINT 12 Program to Check Whether a Character is an Alphabet or not


			//char ch;

			//Console.WriteLine("Enter any character: ");
			//ch = Convert.ToChar(Console.ReadLine());

			//// Alphabet checking condition
			//if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
			//{
			//    Console.WriteLine(ch + ": is an Alphabet. ");
			//}
			//else
			//{
			//    Console.WriteLine(ch + ": is not a Alphabet. ");
			//}

			#endregion


			#region 2D Array
			//int[,] Marks = new int[3, 5];
			//bool flag;
			//for (int i = 0; i < Marks.GetLength(0); i++)
			//{
			//    Console.WriteLine($"Please Enter the Mark of Student : {i+1}");
			//    for(int j = 0; j < Marks.GetLength(1); )
			//    {
			//        Console.Write($"Please Enter the Subject of Student No ({j+1}):");
			//        //Marks[i,j] = int.Parse(Console.ReadLine());
			//        flag = int.TryParse(Console.ReadLine(),out Marks[i, j]);
			//        if (flag && Marks[i,j] >=0)
			//        {
			//            j++;
			//        }

			//    }
			//}
			//Console.Clear();
			//for (int i = 0; i < Marks.GetLength(0); i++)
			//{
			//    Console.WriteLine($"The Mark of Student Number is :{i + 1}");
			//    for (int j = 0; j < Marks.GetLength(1); j++)
			//    {
			//        Console.WriteLine($"The Mark of Subject No({j + 1}) = {Marks[i, j]}");
			//    }
			//    Console.WriteLine("--------------------------");
			//}

			#endregion

			#region Calling Function Parameter Value Type

			//print(10,"@3$+_");
			// Passing by value 
			//Console.WriteLine("Passing by value ");
			//int a = 5,b = 10;
			//Console.WriteLine($"A = {a}");
			//Console.WriteLine($"B = {b}");
			//SWAP(a,b);
			//Console.WriteLine($"A = {a}");
			//Console.WriteLine($"B = {b}");

			//// Passing by reference 
			//Console.WriteLine("========================");
			//Console.WriteLine("Passing by reference ");
			//Console.WriteLine($"A = {a}");
			//Console.WriteLine($"B = {b}");
			//SWAP2(ref a,ref b);
			//Console.WriteLine($"A = {a}");
			//Console.WriteLine($"B = {b}");
			#endregion

			#region Calling Function Parameters Reference type 
			// Passing by value 
			int[] Numbers = { 1, 2, 3, };
            SumArray(Numbers); // Copy from value 
            Console.WriteLine(Numbers[0]);

            // Passing by Ref 

            int[] Numbers1 = { 1, 2, 3, };
            SumArray1(ref Numbers1); // Renames a array  (action نفس النتيجه لكن ال الفعل مختلف ال )
            Console.WriteLine(Numbers[0]);

            #endregion


            Console.ReadKey();

        }
    }
}
