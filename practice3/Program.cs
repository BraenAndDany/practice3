using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace practice3
{
    internal class Program
    {
        static string NumberToLetters(int number)
        {
            string result;
            if (number > 0)
            {
                int alphabets = (number - 1) / 26;
                int remainder = (number - 1) % 26;
                result = ((char)('A' + remainder)).ToString();
                if (alphabets > 0)
                    result = NumberToLetters(alphabets) + result;
            }
            else
                result = null;
            return result;
        }
        static void Main(string[] args)
        {
            //int[] digits = {2,6,8,3,2};
            //int numb =2491;
            //int copy = 0;
            //int sch = 10;
            //for (int i = 0; i < digits.Length; i++)
            //{
            //    if (i==digits.Length-1)
            //    {
            //        copy = copy + digits[i];
            //    }
            //    else
            //    {
            //        copy = copy + digits[i];
            //        copy = copy * 10;
            //    }

            //}
            //copy = copy + numb;
            //Array.Resize(ref digits, copy.ToString().Length);
            //for (int i = copy.ToString().Length-1; i>0; i--)
            //{
            //    digits[i] = copy % sch;
            //    copy = copy / 10;
            //}
            //for (int i = 0; i < digits.Length; i++)
            //{
            //    Console.Write(digits[i]);
            //}

            //List<int> people = new List<int>() {4,3,2,1,3};
            //int number = 2;
            //people.Insert(number, people[people.Count-1]);
            //people.RemoveAt(people.Count-1);
            //for (int i = 0; i < people.Count; i++)
            //{
            //    Console.Write(people[i] + " ");
            //}

            int number = 2700;
            Console.WriteLine(NumberToLetters(number));
        }
    }
}
