using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void exercise1()
        {
            /*
             * Write a program that creates an array which has 20 elements. The elements have to be integers.
             * Every element has to have value equal to the index value and multiplied by 5.
             * Print the elements on the console.
             */

            int[] array = new int[20];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i + 1) * 5;
                Console.Write(array[i] + " ");
            }
        }

        static void exercise2()
        {
            // Write a program that prints the values of the odd numbered indexes of an array.

            Console.Write("Input array length: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Element[{0}]: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Output of odd elements: ");
            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", array[i]);
                }
            }
        }

        static void exercise3()
        {
            // Write a program that checks whether an array is symmetrical.

            Console.WriteLine("Input array length: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Element[{0}]: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            bool symetric = true;
            for (int i = 0; i < size / 2; i++)
			{
                if (array[i] != array[size-i-1]) symetric = false;
			}
            Console.Write("Symetric? {0}",symetric);
        }

        static void exercise4()
        {
            // Write a program, which creates an array with all the English letters.
            // Let the user input a word in the console.
            // The program has to output the indexes of the letters in the user's word.

            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.Write("Enter a word: ");
            char[] word = (Console.ReadLine()).ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j]) Console.Write("{0} ", j);
                }
            }
        }

        static void exercise5()
        {
            // Write a program which takes the elements of a given array and outputs them backwards.
            Console.Write("Input array length: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            int[] backwards = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Element[{0}]: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                backwards[size - i - 1] = array[i];
            }

            Console.Write("The output backwards is: ");
            for (int j = 0; j < size; j++)
            {
                Console.Write(backwards[j] + " ");
            }
        }

        static void exercise6()
        {
            // Write a program which reads two arrays and outputs whether their elements are equal.

            Console.Write("Input the length of arrays arrA and arrB: ");
            int size = int.Parse(Console.ReadLine());
            int[] arrA = new int[size];
            int[] arrB = new int[size];

            for (int a = 0; a < size; a++)
            {
                Console.Write("A[{0}]: ", a + 1);
                arrA[a] = int.Parse(Console.ReadLine());
            }

            for (int b = 0; b < size; b++)
            {
                Console.Write("B[{0}]: ", b + 1);
                arrB[b] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                if (arrA[i] != arrB[i])
                {
                    Console.Write("Arrays are NOT equal.");
                    break;
                }
                else
                {
                    Console.Write("Arrays are equal.");
                }
            }
        }

        static void exercise7()
        {
            // Write a program that shows the most frequently seen element in an array.

            Console.Write("Input array length: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Element[{0}]: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            int counter = 0, temp = 1, num = 0;
            for (int i = 0; i < size - 1; i++)
            {
                if (array[i] == array[i + 1]) temp++;
                else temp = 1;

                if (temp > counter)
                {
                    counter = temp;
                    num = array[i];
                }
            }
            Console.Write("| {0} was found {1} times.", num, counter);
        }

        static void exercise8()
        {
            int sum = 0;
            int product = 1;

            Console.Write("Input array length: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("How many elements do you want to sum? ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("How many elements do you want to multiply? ");
            int q = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            if (n > k)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Element[{0}]: ", i + 1);
                    array[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < k; i++)
                {
                    sum += array[i];
                }

                for (int i = 0; i < q; i++)
                {
                    product *= array[i];
                }
                Console.Write("The sum of the first {0} elements is {1}. ", k, sum);
                Console.Write("The product of the first {0} elements is {1}.", q, product);
            }
            else Console.Write("The amount of elements should be shorter than the array length! Try again!");
        }

        static void exercise9()
        {
            /*
             * Write a program, which generate a random integer array with a random size.
             * Sort the array. Find how many times the array size is found as an element in the array.
             * Find the sum and the product of the array elements.
             */
            Random rng = new Random();
            int size = rng.Next(1, 20);
            int[] array = new int[size];

            Console.Write("Generated a[{0}] = ", size);
            for (int i = 0; i < size; i++)
            {
                array[i] = rng.Next(0, 20);
                Console.Write("{0} ", array[i]);
            }

            Array.Sort(array);
            Console.Write("\nSorted a[{0}] = ", size);
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            int counter = 0;
            for (int i = 0; i < size; i++)
            {
                if (array[i] == size) counter++;
            }
            Console.WriteLine("\nThe number {0} is found {1} times.", size, counter);

            int sum = 0;
            double product = 1;
            for (int i = 0; i < size; i++)
            {
                sum += array[i];
                product *= array[i];
            }
            Console.Write("The sum of the elements is {0}.", sum);
            Console.Write("\nThe product of the elements is {0}.", product);
        }

        static void exercise10()
        {
            // Game
            Console.WriteLine("Welcome to the Lucky Carnival!");
            Console.WriteLine("This is a game where the program will generate a number for you but you won't know it!");
            Console.WriteLine("The generated number will be anywhere between 1 and 1000.");
            Console.WriteLine("To win this game, you have to input 5 numbers which will be summed in the end.");
            Console.WriteLine("The range that the sum can cover is anywhere between -100 and +100 from the generated number.");
            Console.WriteLine("If the sum is anywhere close to the generated number: You win a cookie!");
            Console.WriteLine("But if it isn't: Better luck next time!");

            Random rng = new Random();
            int number = rng.Next(1, 1000);
            //Console.WriteLine(number); // for maintenance purposes

            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
               sum += array[i];
            }
            Console.WriteLine("Your sum is {0}", sum);
            Console.WriteLine("The generated number was {0}", number);

            if (number > sum) Console.WriteLine("The difference is only {0}", number - sum);
            else Console.WriteLine("The difference is only {0}", sum - number);

            if (number - 100 == sum || number + 100 == sum)
            {
                Console.Write("Congratulations! Have a cookie!");
            }
            else if (sum == number)
            {
                Console.WriteLine("ARE YOU A WIZARD?! YOU GUESSED THE NUMBER!");
            }
            else
            {
                Console.Write("Better luck next time!");
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("=*=*=*= MENU =*=*=*=");
            Console.WriteLine("1) Exercise 1");
            Console.WriteLine("2) Exercise 2");
            Console.WriteLine("3) Exercise 3");
            Console.WriteLine("4) Exercise 4");
            Console.WriteLine("5) Exercise 5");
            Console.WriteLine("6) Exercise 6");
            Console.WriteLine("7) Exercise 7");
            Console.WriteLine("8) Exercise 8");
            Console.WriteLine("9) Exercise 9");
            Console.WriteLine("10) Exercise 10");
            Console.WriteLine("11) Exit");

            bool forever = true;
            do
            {
                Console.Write("Option #");
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1: Console.WriteLine("=*=*=*= Exercise 1 =*=*=*=");
                        exercise1(); Console.WriteLine();
                        break;
                    case 2: Console.WriteLine("=*=*=*= Exercise 2 =*=*=*=");
                        exercise2(); Console.WriteLine();
                        break;
                    case 3: Console.WriteLine("=*=*=*= Exercise 3 =*=*=*=");
                        exercise3(); Console.WriteLine();
                        break;
                    case 4: Console.WriteLine("=*=*=*= Exercise 4 =*=*=*=");
                        exercise4(); Console.WriteLine();
                        break;
                    case 5: Console.WriteLine("=*=*=*= Exercise 5 =*=*=*=");
                        exercise5(); Console.WriteLine();
                        break;
                    case 6: Console.WriteLine("=*=*=*= Exercise 6 =*=*=*=");
                        exercise6(); Console.WriteLine();
                        break;
                    case 7: Console.WriteLine("=*=*=*= Exercise 7 =*=*=*=");
                        exercise7(); Console.WriteLine();
                        break;
                    case 8: Console.WriteLine("=*=*=*= Exercise 8 =*=*=*=");
                        exercise8(); Console.WriteLine();
                        break;
                    case 9: Console.WriteLine("=*=*=*= Exercise 9 =*=*=*=");
                        exercise9(); Console.WriteLine();
                        break;
                    case 10: Console.WriteLine("=*=*=*= Exercise 10 =*=*=*=");
                        exercise10(); Console.WriteLine();
                        break;
                    case 11: Console.WriteLine("You've decided to exit the program.");
                            forever = false;
                            break;
                    default: Console.WriteLine("Please, pick a valid option!");
                        break;
                }
            } while (forever);

            Console.ReadKey();
        }
    }
}