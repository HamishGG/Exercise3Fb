using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercise3Fb
{
    internal class Program
    {
        public static void Main()
        {
            var names = new List<string>();
            Console.Write("Please enter what you would like to post about: ");
            var post = Console.ReadLine();
            string[] array = FriendNames(names).ToArray();

            Console.WriteLine("Your Post: " + post);
            Console.WriteLine(LikedPost(array));
            Console.WriteLine("Press enter to close...");
            Console.ReadKey();
        }

        public static List<string> FriendNames(List<string> names)
        {
            while (true)
            {
                Console.Write("Please enter a friends name (enter nothing to finish adding friends): ");
                var input = Console.ReadLine();
                names.Add(input);
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
            }
            Console.Clear();
            return names;
        }

        public static string LikedPost(string[] array)
        {
            if (array.Length <= 4)
            {
                var stringedArray = string.Join(", ", array);
                char[] charsToTrim = { ',', ' ' };
                var textInfo = new CultureInfo("en-UK", false).TextInfo;
                var result =
                    textInfo.ToTitleCase(stringedArray).TrimEnd(charsToTrim) + " Have liked your post";
                return result;
            }
            else
            {
                var otherPeople = array.Length - 4;
                var textInfo = new CultureInfo("en-UK", false).TextInfo;
                var result = textInfo.ToTitleCase(array[0] + ", " + array[1] + ", " + array[2]) + " and " +
                             otherPeople +
                             " Others have liked your post";
                return result;
            }
        }
    }
}