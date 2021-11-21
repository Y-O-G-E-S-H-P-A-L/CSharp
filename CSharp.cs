using System;
using System.Linq; // This namespace for accessing of Array Methods.
using System.IO;  // This namespace for file and its methods.
						//using Exception;  // This namespace for Exception

namespace CSharpLearningCode
{
	//class Program
	//{
	//    static void Main(string[] args)
	//    {
	//Console.WriteLine("Hello Yogesh, Welcome in C-Sharp Programming Language...");

	//After Commit using System
	//System.Console.WriteLine("Hello Yogesh, Welcome in C-Sharp Programming Language...");
	//System.Console.ReadLine();


	//It is also possible to convert data types explicitly by using built-in methods, 
	//such as :-
	//Convert.ToBoolean, 
	//Convert.ToDouble,
	//Convert.ToString,
	//Convert.ToInt32(int),
	//Convert.ToInt64(long):

	//Console.WriteLine("Enter Any String :");
	//string str = Console.ReadLine();
	//Console.WriteLine("String is : " + str);

	//Console.WriteLine("Enter Any Integer Number :");
	//int i = Convert.ToInt32(Console.ReadLine());
	//Console.WriteLine("Integer is : " + i);

	//Console.WriteLine("Enter Any Floating Point Number :");
	//float f = Convert.ToSingle(Console.ReadLine());
	//Console.WriteLine("Float is : " + f);

	//Console.WriteLine("Enter Any Character :");
	//char ch = Convert.ToChar(Console.ReadLine());
	//Console.WriteLine("String is : " + ch);

	//                                        Operators in C#
	//                                      ===================

	//Arithmatic operator

	// +
	// -
	// *
	// /
	// %
	// ++
	// --

	//Assignment operator

	// =         
	// +=        
	// -=        
	// *= 
	// /= 
	// %= 
	// &= 
	// |= 
	// ^= 
	// >>=   
	// <<=

	// Comparasion operator

	//==      Equal to 
	//!=      Not equal 
	//>      Greater than
	//<      Less than 
	//>=      Greater than or equal to    
	//<=      Less than or equal to

	//Logical operator

	// &&
	// ||
	// !

	// Mathematic Methods

	//Math.Max()
	//Math.Min()
	//Math.Sqrt()
	//Math.Abs()
	//Math.Round()

	//                                      String in C#
	//                                   ==================

	//string str = "abcDEFGHijkLMNOPqrsTUVWxyz";
	//Console.WriteLine("The length of the string is: " + str.Length);

	//string firstName = "Peter";
	//string lastName = " Parker";

	//Console.WriteLine(str.ToUpper());   
	//Console.WriteLine(str.ToLower());

	//string name = string.Concat(firstName, lastName);
	//Console.WriteLine(name);

	//name = $"My full name is: {firstName} {lastName}";
	//Console.WriteLine(name);

	//Console.WriteLine(str[10]);
	//Console.WriteLine(str.IndexOf("y"));
	//Console.WriteLine(str.Substring(20));

	//Console.WriteLine("Hello \'Yogesh\',Welcome in \" C# Programming \"...\\");
	//Console.WriteLine("Hello Yogesh \b\t,Welcome in C# Programming...\n");

	//bool isCSharpFun = true;
	//bool isFishTasty = false;
	//Console.WriteLine(isCSharpFun);   
	//Console.WriteLine(isFishTasty);

	//If Statement:-

	//if (20 > 18)
	//{
	//    Console.WriteLine("20 is greater than 18");
	//}

	//If-Else Statement :-

	//int time = 20;
	//if (time < 18)
	//{
	//    Console.WriteLine("Good day.");
	//}
	//else
	//{
	//    Console.WriteLine("Good evening.");
	//}

	//Else-If Statement :-

	//int time = 18;
	//if (time < 10)
	//{
	//    Console.WriteLine("Good morning.");
	//}
	//else if (time < 20)
	//{
	//    Console.WriteLine("Good day.");
	//}
	//else
	//{
	//    Console.WriteLine("Good evening.");
	//}

	//int time = 17;
	//string result = (time < 18) ? "Good day." : "Good evening.";
	//Console.WriteLine(result);

	//Switch Case Statement :-

	//int day = 1;
	//switch (day)
	//{
	//    case 1:
	//        Console.WriteLine("Monday");
	//        break;
	//    case 2:
	//        Console.WriteLine("Tuesday");
	//        break;
	//    case 3:
	//        Console.WriteLine("Wednesday");
	//        break;
	//    case 4:
	//        Console.WriteLine("Thursday");
	//        break;
	//    case 5:
	//        Console.WriteLine("Friday");
	//        break;
	//    case 6:
	//        Console.WriteLine("Saturday");
	//        break;
	//    case 7:
	//        Console.WriteLine("Sunday");
	//        break;
	//}

	//int day = 4;
	//switch (day)
	//{
	//    case 6:
	//        Console.WriteLine("Today is Saturday.");
	//        break;
	//    case 7:
	//        Console.WriteLine("Today is Sunday.");
	//        break;
	//    default:
	//        Console.WriteLine("Looking forward to the Weekend.");
	//        break;
	//}

	//                                        Looping in C#
	//                                      =================

	// While Loop :-

	//int i = 0;
	//while (i < 5)
	//{
	//    i++;
	//    Console.WriteLine(i);
	//}

	// Do- While Loop :-

	//int i = 0;
	//do
	//{
	//    i++;
	//    Console.WriteLine(i);
	//}
	//while (i < 5);

	//For Loop :-

	//for (int i = 0; i < 5; i++)
	//{
	//    Console.WriteLine(i);
	//}

	//for (int i = 0; i <= 10; i = i + 2)
	//{
	//    Console.WriteLine(i);
	//}

	//Foreach Loop :-

	//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
	//foreach (string i in cars)
	//{
	//    Console.WriteLine(i);
	//}

	// Break Statement :-

	//for (int i = 0; i < 10; i++)
	//{
	//    if (i == 6)
	//    {
	//        break;
	//    }
	//    Console.WriteLine(i);
	//}

	// Continue :-

	//for (int i = 0; i < 10; i++)
	//{
	//    if (i == 4)
	//    {
	//        continue;
	//    }
	//    Console.WriteLine(i);
	//}

	//                                            Array in C#
	//                                           =============

	// Array Declaration in C#

	//string[] cars;   //String Array
	//int[] arr;     // Integer Array
	//int[] arr =new int[5];  //Integer array declaration with limit.

	// Change in Array Element

	//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
	//cars[0] = "Opel";
	//Console.WriteLine(cars[0]);
	//Console.WriteLine(cars.Length);

	//Loop through an Array :-

	//for (int i = 0; i < cars.Length; i++)
	//{
	//    Console.WriteLine(cars[i]);
	//}

	//Foreach Loop in Array :-

	//foreach (string i in cars)
	//{
	//    Console.WriteLine(i);
	//}

	// Sorting of an String Array

	//Array.Sort(cars);
	//foreach (string i in cars)
	//{
	//    Console.WriteLine(i);
	//}

	// Sorting of an Integer Array

	//int[] myNumbers = { 5, 1, 8, 9 };
	//Array.Sort(myNumbers);
	//foreach (int i in myNumbers)
	//{
	//    Console.WriteLine(i);
	//}

	//Console.WriteLine(myNumbers.Max());  // returns the largest value
	//Console.WriteLine(myNumbers.Min());  // returns the smallest value
	//Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

	// Create an array of four elements, and add values later
	//string[] cars = new string[4];

	// Create an array of four elements , also initialized with specifying the size 
	//string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

	// Create an array of four elements without specifying the size 
	//string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

	// Create an array of four elements, omitting the new keyword, and without specifying the size
	//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

	//                                           Function in C#
	//                                         ==================

	//class Program
	//{
	// Function without return and without parameter

	//static void MyMethod()
	//{
	//    Console.WriteLine("Have a Nice Day Sir..!");
	//}

	// Function without return and with parameter

	//static void MyMethod(string fname)
	//{
	//    Console.WriteLine(fname + " Pal");
	//}

	// Function with default parameter/optional parameter

	//static void MyMethod(string country = "INDIA")
	//{
	//    Console.WriteLine(country);
	//}

	// Function without return and with multiple parameter

	//static void MyMethod(string fname, int age)
	//{
	//    Console.WriteLine("Hello " + fname + " ,Your age is " + age);
	//}

	// Function with return and with parameter

	//static int MyMethod(int x)
	//{
	//    return 5 + x;
	//}

	// Function with return and with multiple parameter

	//static int MyMethod(int x, int y)
	//{
	//    return x + y;
	//}

	//static void MyMethod(string child1, string child2, string child3)
	//{
	//    Console.WriteLine("The youngest child is: " + child3);
	//}

	//static void MyMethod(string child1 = "Liam", string child2 = "Jenny", string child3 = "John")
	//{
	//    Console.WriteLine(child3);
	//}

	//                                    Method Overloading in C# 
	//                                   ==========================

	//static int PlusMethod(int x, int y)
	//{
	//    return x + y;
	//}

	//static double PlusMethod(double x, double y)
	//{
	//    return x + y;
	//}
	//static void Main(string[] args)
	//{
	//MyMethod();

	//MyMethod("Yogesh");

	//MyMethod();
	//MyMethod("USA");

	//MyMethod("Yogesh",19);

	//Console.WriteLine( MyMethod(45) );

	//Console.WriteLine(MyMethod(45,55));

	//int z = MyMethod(5, 3);
	//Console.WriteLine(z);

	//MyMethod(child3: "John", child1: "Liam", child2: "Max");
	//MyMethod("child3");

	//         int myNum1 = PlusMethod(8, 5);
	//         double myNum2 = PlusMethod(4.3, 6.26);
	//         Console.WriteLine("Int: " + myNum1);
	//         Console.WriteLine("Double: " + myNum2);

	//        Console.ReadLine();
	//    }
	//}


	//                                          Class and Objects
	//                                        ======================

	//class Program
	//{
	//private string model = "Mustang";

	//static void Main(string[] args)
	//{
	// Create Object of an Class :-

	//Car myObj = new Car();
	//Console.WriteLine(myObj.color);

	// Create Multiple Object of an same Class :-

	//Car myObj1 = new Car();
	//Car myObj2 = new Car();
	//Console.WriteLine(myObj1.color);
	//Console.WriteLine(myObj2.color);

	//Car myObj = new Car();
	//Console.WriteLine(myObj.color);
	//Console.WriteLine(myObj.maxSpeed);

	//myObj.color = "Green";
	//myObj.maxSpeed = 300;
	//Console.WriteLine(myObj.color);
	//Console.WriteLine(myObj.maxSpeed);

	//Car Ford = new Car();
	//Ford.model = "Mustang";
	//Ford.color = "red";
	//Ford.year = 1969;

	//Car Opel = new Car();
	//Opel.model = "Astra";
	//Opel.color = "white";
	//Opel.year = 2005;

	//Console.WriteLine(Ford.model);
	//Console.WriteLine(Opel.model);

	//Car myObj = new Car();
	//myObj.fullThrottle();

	//Car myObj = new Car();
	//Console.WriteLine(myObj.model);

	//Car myObj = new Car("Mustang");
	//Console.WriteLine(myObj.model);

	//Car Ford = new Car("Mustang", "Red", 1969);
	//Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);

	//Car myObj = new Car();
	//Console.WriteLine(myObj.model);

	//Program obj = new Program();
	//Console.WriteLine(obj.model);

	//Properties obj = new Properties();
	//obj.Name = "Maharshi";
	//Console.WriteLine(obj.Name);

	//Properties obj = new Properties();
	//obj.Name = "Maharshi";
	//Console.WriteLine(obj.Name);

	//Car myCar = new Car();
	//myCar.honk();
	//Console.WriteLine(myCar.brand + " " + myCar.modelName);

	//Animal myAnimal = new Animal();  // Create a Animal object
	//Animal Snake = new Snake();  // Create a Snake object
	//Animal Tiger = new Tiger();  // Create a Tiger object

	//myAnimal.animalSound();
	//Snake.animalSound();
	//Tiger.animalSound();

	//myAnimal.animalSound();
	//Snake.animalSound();
	//Tiger.animalSound();

	//Animal Tiger = new Tiger();  // Create a Tiger object
	//Tiger.animalSound();  // Call the abstract method
	//Tiger.sleep();  // Call the regular method

	//Snake obj = new Snake();  // Create a Snake object
	//obj.animalSound();

	//DemoClass myObj = new DemoClass();
	//myObj.myFIMethod();
	//myObj.mySIMethod();

	//                                             Enums in C# 
	//                                           ===============

	//enum Level
	//{
	//    Low,
	//    Medium,
	//    High
	//}
	//class Program 
	//{ 
	//enum Months
	//{
	//    January,    // 0
	//    February,    // 1
	//    March,    // 2
	//    April,    // 3
	//    May,    // 4
	//    June,    // 5
	//    July,    // 6
	//    August,    // 7
	//    September,    // 8
	//    Octumber,    // 9
	//    November,    // 10
	//    December    // 11
	//}
	//enum Months
	//{
	//    January,    // 0
	//    February,   // 1
	//    March = 6,    // 6
	//    April,      // 7
	//    May,        // 8
	//    June,       // 9
	//    July        // 10
	//}
	//static void Main(string[] args)
	//{
	//Level objL = Level.Medium;
	//Console.WriteLine(objL);

	//Months objM = Months.April;
	//int objMonNumber = (int)Months.April;
	//Console.WriteLine((objMonNumber) + "   " + objM);

	//Level myVar = Level.Medium;
	//switch (myVar)
	//{
	//    case Level.Low:
	//        Console.WriteLine("Low level");
	//        break;
	//    case Level.Medium:
	//        Console.WriteLine("Medium level");
	//        break;
	//    case Level.High:
	//        Console.WriteLine("High level");
	//        break;
	//}

	//                                               File in C#
	//                                            ===============

	// class Program
	// {
	//     static void Main(String[] args)
	//     {
	// Create a file in common Path

	//string writeText = "Hello World!";

	// Create a file and write the content of writeText to it
	//File.WriteAllText("filename.txt", writeText);

	// Read the contents of the file
	//string readText = File.ReadAllText("filename.txt");

	//Console.WriteLine(readText);  // Output the content

	// Create a file in Specified Path

	// string fileName  = @"D:\@Palji\C#\CSharpLearningCode\Temprary Text File\fileName.txt";

	// try
	// {
	//     if (File.Exists(fileName))
	//     {
	//         File.Delete(fileName);
	//     }
	//      // Create a new file     
	//      using (StreamWriter sw = File.CreateText(fileName))    
	//      {    
	//          //sw.WriteLine("New file created: {0}", DateTime.Now.ToString());    
	//          sw.WriteLine("Author: Yogesh Pal");    
	//          sw.WriteLine("Add one more line ");    
	//          sw.WriteLine("Done! ");    
	//      }    

	//      // Write file contents on console.     
	//      using (StreamReader sr = File.OpenText(fileName))    
	//      {    
	//          string s = "";    
	//          while ((s = sr.ReadLine()) != null)    
	//          {    
	//              Console.WriteLine(s);    
	//          }    
	//      }    
	// }
	// catch(Exception Ec)
	// {
	//     Console.WriteLine(Ec.ToString());
	// }


	//                               Exception in C#
	//                            =====================


	// When executing C# code, different errors can occur:
	// coding errors made by the programmer, errors due to wrong input, or other unforeseeable things.

	// When an error occurs, C# will normally stop and generate an error message.
	// The technical term for this is: C# will throw an exception (throw an error).

	// Try-catch Block :-

	// The try statement allows you to define a block of code to be tested for errors while
	// it is being executed.

	// The catch statement allows you to define a block of code to be executed,
	// if an error occurs in the try block.

	// The try and catch keywords come in pairs.

	// try
	// {
	//   int[] myNumbers = {1, 2, 3};
	//   Console.WriteLine(myNumbers[10]);
	// }
	// catch (Exception e)
	// {
	//   Console.WriteLine(e.Message);
	// }

	// Finally Keyword :-

	//      The finally statement lets you execute code, after try...catch, regardless of the result.

	// try
	// {
	//   int[] myNumbers = {1, 2, 3};
	//   Console.WriteLine(myNumbers[10]);
	// }
	// catch (Exception e)
	// {
	//   Console.WriteLine("Something went wrong.");
	// }
	// finally
	// {
	//   Console.WriteLine("The 'try catch' is finished.");
	// }

	// Throw Keyword :-

	// The throw statement allows you to create a custom error.
	// The throw statement is used together with an exception class. 
	// There are many exception classes available in C#: ArithmeticException, FileNotFoundException, 
	// IndexOutOfRangeException, TimeOutException, etc:

	// User Defined Exception:-
	class Program
	{
		static void checkAge(int age)
		{
			if (age < 18)
			{
				throw new ArithmeticException("Access denied - You must be at least 18 years old.");
			}
			else
			{
				Console.WriteLine("Access granted - You are old enough!");
			}
		}
		static void Main(String[] args)
		{
			checkAge(20);
			Console.ReadLine();
		}
	}
}



//                                    Learned by -
//                                                  Code with Harry
// <=====================================================================================================>

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace C_Sharp_Code
// {
//     class Program
//     {
//         static void Greet()
//         {
//             Console.WriteLine("Hello Sir,Good Morning...");
//         }
//         static int Average()
//         {
//             int x=10, y=20, z=30;
//             return ((x + y + z) / 3);
//         }
//         static void Main(string[] args)
//         {
            //Console.Write("Hello Yogesh , Welcome in C# Programming.\n");
            //Console.WriteLine("Continue from here... ");
            //String input = Console.ReadLine();
            //Console.WriteLine(input);

            /*Data Types in C#
               1.Integer - 4 bytes --> int i = 10;
               2.Float - 4 bytes --> float f = 10.5F;
               3.Long - 8 bytes --> long l;
               4.Double - 8 bytes --> double d = 45.8D; // 15 decimal digits pricision
               5.character - 2 bytes --> char a='A';
               6.Boolean - 1 bits --> bool isgreat = true;
               7.String - 2 bytes per Character -->string str = "Yogesh" //12 bytes
             */

            //int a = 34;
            //float b = 34.4F;
            //double c = 35.75D;
            //bool d = true;
            //char e = 'Y';
            //string str = "This is a string.";
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.WriteLine(str);

            //Typecasting in C# 
            //There is two types of typecasting :-
            // 1.Implicit Typecasting:-

            //  Promotion Table =>
            //  ---> char to int to long to float to double

            //  in implicit typecasting is follows promotion table
            //  and explicit typecasting is not follows promotion table.

            // 1.Explicit Typecasting:-

            // Convert.ToInt32();
            // Convert.ToDouble();
            // Convert.ToString();
            // Convert.ToBoolean();
            // Convert.ToChar();
            // etc.

            //Console.WriteLine("Enter your name...");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);

            //Console.WriteLine("How many Cadies do you Want ?");
            //string candies = Console.ReadLine();
            //Console.WriteLine("You will get 5 more candies " + (Convert.ToInt32(candies) + 5));

            // Operators in C# 
            /*
            1.Arithmatic Operator

            int a = 50;
            int b = 10;
            Console.WriteLine("The value of a + b is : " +(a+b));
            Console.WriteLine("The value of a + b is : " +(a-b));
            Console.WriteLine("The value of a + b is : " +(a*b));
            Console.WriteLine("The value of a + b is : " +(a/b));
            Console.WriteLine("The value of a + b is : " +(a%b));
            */
            /*
            2.Assignment operator

            int a = 10;
            int b = a;
            Console.WriteLine(b);
            b+=5;
            Console.WriteLine(b);
            b-=5;
            Console.WriteLine(b);
            b*=2;
            Console.WriteLine(b);
            b/=4;
            Console.WriteLine(b);
            b%=2;
            Console.WriteLine(b);
            */
            /*
            3.Logical operator

            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);

            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);

            Console.WriteLine(!true);
            Console.WriteLine(!false);
            */
            /*
            4.Comparasion operator

            Console.WriteLine(25<5);
            Console.WriteLine(25>5);
            Console.WriteLine(25<=5);
            Console.WriteLine(25>=5);
            Console.WriteLine(25!=5);
            */
            /*
            Math Functions :-

            int max = Math.Max(34,55);
            Console.WriteLine(max);
            int min = Math.Min(34,55);
            Console.WriteLine(min);
            double sqrt = Math.Sqrt(25);
            Console.WriteLine(sqrt);
            double absn = Math.Abs(-74);
            Console.WriteLine(absn);
            double absp = Math.Abs(+47);
            Console.WriteLine(absp);
            */
            /*
            String Functions :-

            string str = "This is a String.";
            Console.WriteLine(str.Length);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine(string.Concat("Hello Yogesh, ", str));
            Console.WriteLine("Hello Yogesh, " + str);

            //String interpolition :-

            Console.WriteLine("Enter your name...");
            string name = Console.ReadLine();
            Console.WriteLine("HOw many candies doo you want ?");
            string candies = Console.ReadLine();

            Console.WriteLine($"Your name is {name} and you will get {candies} candies.");

            Console.WriteLine(str[0]);
            Console.WriteLine(str.IndexOf("String"));
            Console.WriteLine(str.Substring(10));
            Console.WriteLine(str);

            string stre = "This \t is a \" String\". \n. ";
            Console.WriteLine(stre);
            */

            // If-else Statement :-

            /* int age = 56;
             if (age > 18)
             {
                 Console.WriteLine("You can Drive");
             }
             else
             {
                 Console.WriteLine("You cannot Drive.");
             }
            */
            /* 
             Nested If-else :-

             int age = 18;
             int sal = 25000;
             if (age >= 18)
             {
                 if (sal >= 25000)
                 {
                     Console.WriteLine("You are Eligible for Loan");
                 }
                 else
                 {
                     Console.WriteLine("Not Eligible for Loan : Less Salary");
                 }
             }
             else
             {
                 Console.WriteLine("Not Eligible for Loan : Less Age");
             }
            */
            /*
             Ladder if-else :-

             int per = 28;
             if (per >= 90)
             {
                 Console.WriteLine("First Division.");
             }else if(per >= 60)
             {
                 Console.WriteLine("Second Division.");
             }else if(per >= 45)
             {
                 Console.WriteLine("Third Division.");
             }
             else
             {
                 Console.WriteLine("Fail.");
             }
            */

            // Loops in C# :- 

            // 1. For Loop

            // for(int i=0; i < 5; i++)
            // {
            //     Console.WriteLine(i + 1);
            // }

            // 2. Wihile Loop :-

            // int i = 0;
            // while (i < 5)
            // {
            //     Console.WriteLine(i + 1);
            //     i++;
            // }

            // 3. Do-while Loop :-

            // int i = 0;
            // do
            // {
            //     Console.WriteLine(i + 1);
            //     i++;
            // } while (i < 5);

            //Break and Continue
            //break :- Leave the Loop forever
            //continue :- Leave the Loop for a particular ittration

            //for(int i = 0; i < 5; i++)
            //{
            //    if (i == 3)
            //        break;
            //    Console.WriteLine(i + 1);
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 3)
            //        continue;
            //    Console.WriteLine(i + 1);
            //}

            // Functions in C#
            // functions same as c Language
            //Greet();

            //int avg = Average();
            //Console.WriteLine(avg);

            // OOPs  -  Classes and Objects 
//             Player max = new Player();

//             Console.WriteLine(max.name);
//             Console.WriteLine(max.getHealth());
//             max.setHealth(90);
//             Console.WriteLine(max.getHealth());
//             Console.ReadLine();
//         }
//     }
// }