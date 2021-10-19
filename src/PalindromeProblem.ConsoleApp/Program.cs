using System;


namespace PalindromeProblem
{
    class Program
    {
        static void Main(string[] args)
        
        {

            long palConvertCount = 0;

            for (int i = 1; i < 201; i++)
            {
                if(i==196) 
                {
                    System.Console.WriteLine("Number -> {0} || Lychrel number (A Lychrel number is a natural number that cannot form a palindrome through the iterative process of repeatedly reversing its digits and adding the resulting numbers. This process is sometimes called the 196-algorithm, after the most famous number associated with the process) ", i );
                }
                else
                {
                    palConvertCount = Palindrome.BePalindrome(i);
                    System.Console.WriteLine("Number -> {0} || Times reversed the digits and adding the resulting numbers to make the number a palindrome -> {1}", i, palConvertCount);
                }



            }



        }
    }
}
