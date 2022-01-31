using System;

//Naga Chaitanya Chintalapudi

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();


            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();

            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //Console.WriteLine(bulls_grid);
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }



        private static string RemoveVowels(string s)
        {
            //kept all vowels capital and small in a string
            string vowels = "AEIOUaeiou"; 
            try
            {
                
                String final_string = "";
                
                //iterating each character in string s
                foreach (Char c in s)
                {
                    //to check if the character is not a vowel
                    if (!(vowels.Contains(c)))
                    {
                     
                        final_string = final_string + c.ToString(); //adding it to final string if not a vowel
                    }
                }
                
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                

                string word1 = string.Concat(bulls_string1); //adding all strings to a single word

                string word2 = string.Concat(bulls_string2);//adding all strings to a single word

                if (word1.Equals(word2)) // checking if both words are same 
                    return true; //return true if both are same
                else
                return false; //return false if both are different
            }
            catch (Exception)
            {

                throw;
            }

        }

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                int sum=0;
                // sort all elements of array to make it easy
                Array.Sort(bull_bucks);

                // if first element is not same as second element then adding it to sum
                if (bull_bucks[0] != bull_bucks[1])
                    sum = sum + bull_bucks[0];
                
                //iterating through the array 
                for (int i = 0; i < bull_bucks.Length-1; i++)
                {
                    if (bull_bucks[i] != bull_bucks[i + 1]) //checking if any element is same as next element
                    {
                        sum = sum + bull_bucks[i+1]; // adding it to sum if it is unique.
                    }
                
                }
                return sum;

                

            }
            catch (Exception)
            {
                throw;
            }
        }


        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                
                int sum = 0;

                //Iterating through all the elements of the matrix
                for (int i = 0; i < bulls_grid.GetLength(0); i++)
                {
                    for (int j = 0; j < bulls_grid.GetLength(1); j++)
                    {
                        if (i == j|| (i + j) == bulls_grid.GetLength(0) - 1) // COndition to find the diagonal elements of matrix
                        {
                            sum = sum + bulls_grid[i,j]; //adding the diagonal elements to sum
                        }
                        
                    }
                }
                return sum;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                // Intializing array of characters
                char[] final_string = new char[bulls_string.Length];


                //iterating to put characters at desired indices of array
                for (int i = 0; i<indices.Length; i++)
                {
                    
                    final_string[indices[i]] = bulls_string[i]; // placing the charcters at right places according to indices array
                }
                
                return new string(final_string);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                String prefix_string = "";
                bool is_char_present = false; //boolean to know if character is present
                int charAt = 1000; // giving some value to index of character

                //iterating to find if the character is present
                for (int i = 0; i < bulls_string6.Length; i++)
                {
                    if (bulls_string6[i] == ch) //if present change boolean value and find the index where it is present
                    {
                        is_char_present = true;
                        charAt = i;
                        break;
                    }
                }
                if (is_char_present) // go forward and reverse the string only if character present
                {
                    string string1 = bulls_string6.Substring(0, charAt + 1); // dividing the string into part1 to be reversed 
                    string string2 = bulls_string6.Substring(charAt + 1); // part2 which need not be reversed

                    //iterating over part 1 to reverse the string
                    for (int j = string1.Length - 1; j >= 0; j--)
                    {
                        prefix_string += string1[j];
                    }
                    prefix_string += string2; // adding reversed string and remaining string
                }
                else
                {
                    prefix_string = bulls_string6;
                }
                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
