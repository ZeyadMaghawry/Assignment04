namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            #region 13- Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Enter the string ");
            //string input = Console.ReadLine();
            //string reversed = "";

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversed += input[i];
            //}
            //Console.WriteLine("reversed is " + reversed);
            #endregion

            #region 14- Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.Write("Enter thr num ");
            //int num = int.Parse(Console.ReadLine());
            //int reversed = 0;

            //while (num != 0)
            //{
            //    int digit = num % 10;
            //    reversed = reversed * 10 + digit;
            //    num /= 10;
            //}
            //Console.WriteLine("reversed is " +reversed);

            #endregion

            #region 15- Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.Write("start number of range:");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("end number of range:");
            //int end = int.Parse(Console.ReadLine());

            //for (int num = start; num <= end; num++)
            //{
            //    if (num > 1)
            //    {
            //        bool isPrime = true;
            //        for (int i = 2; i <= Math.Sqrt(num); i++)
            //        {
            //            if (num % i == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }

            //        if (isPrime)
            //        {
            //            Console.Write(num + " ");
            //        }
            //    }

            #endregion

            #region  16- Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.Write("Enter the num to convert:");
            //int decimalnum = int.Parse(Console.ReadLine());
            //string binary = "";

            //while (decimalnum > 0)
            //{
            //    int remainder = decimalnum % 2;
            //    binary = remainder + binary;
            //    decimalnum /= 2;
            //}
            //Console.WriteLine("The Binary of the number is: " + binary);

            #endregion

            #region 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //Console.Write("Enter x1:");
            //int x1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter y1:");
            //int y1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter x2:");
            //int x2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter y2:");
            //int y2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter x3:");
            //int x3 = int.Parse(Console.ReadLine());
            //Console.Write("Enter y3:");
            //int y3 = int.Parse(Console.ReadLine());

            //int area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

            //if (area == 0)
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points not lie on a single straight line");
            //}

            #endregion

            #region MyRegion 18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows:

            //Console.Write("Enter the time (in hours) taken by the work to complete the task:");
            //double timeTake = double.Parse(Console.ReadLine());

            //// Evaluate the efficiency based on the time taken
            //if (timeTake >= 2 && timeTake <= 3)
            //{
            //    Console.WriteLine("The worker is highly efficient");
            //}
            //else if (timeTake > 3 && timeTake <= 4)
            //{
            //    Console.WriteLine("The worker is instructed to increase their speed");
            //}
            //else if (timeTake > 4 && timeTake <= 5)
            //{
            //    Console.WriteLine("they are instructed to increase their speed");
            //}
            //else if (timeTake > 5)
            //{
            //    Console.WriteLine("The worker is required to leave the company");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}
            #endregion


        }
        }
    }
