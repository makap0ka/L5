using System;
using System.Text;

namespace _05_String_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.WriteLine("TASK 1");

            Console.Write("Enter main text: ");
            string mainText = Console.ReadLine();
            StringBuilder builder = new StringBuilder(mainText);
            
            Console.Write("Enter text to insert: ");
            string textToInsert = Console.ReadLine();

            Console.Write($"Enter position (0 to {builder.Length}): ");
            int position = Convert.ToInt32(Console.ReadLine());

            if (position >= 0 && position <= builder.Length)
            {
                builder.Insert(position, textToInsert);
                Console.WriteLine($"Result: {builder}");
            }
            else
            {
                Console.WriteLine("Wrong position!");
            }

            // Task 2
            Console.WriteLine("\nTASK 2");

            Console.Write("Enter text: ");
            string inputPhrase = Console.ReadLine();

            string cleanedWord = inputPhrase.Replace(" ", "").ToLower();
            string reverse = "";

            for (int i = cleanedWord.Length - 1; i >= 0; i--)
            {
                reverse += cleanedWord[i];
            }

            if (cleanedWord == reverse && cleanedWord.Length > 0)
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("It is not a palindrome");
            }

            // task 3
            Console.WriteLine("\nTASK 3");

            Console.Write("Enter text: ");
            string sentence = Console.ReadLine();

            int upper = 0;
            int lower = 0;

            foreach (char letter in sentence)
            {
                if (char.IsUpper(letter))
                {
                    upper++;
                }
                else if (char.IsLower(letter))
                {
                    lower++;
                }
            }

            if (sentence.Length > 0)
            {
               
                double upperPercent = (double)upper / sentence.Length * 100;
                double lowerPercent = (double)lower / sentence.Length * 100;

                Console.WriteLine($"Uppercase letters: {upperPercent:F2}%");
                Console.WriteLine($"Lowercase letters: {lowerPercent:F2}%");
            }
            else
            {
                Console.WriteLine("Text is empty!");
            }


            // Task 4
            Console.WriteLine("\nTASK 4");

            Console.Write("Enter text: ");
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.Write("Enter word length to target: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == length && words[i].Length >= 3)
                {
                    StringBuilder wordBuilder = new StringBuilder(words[i]);
                    wordBuilder.Remove(wordBuilder.Length - 3, 3);
                    wordBuilder.Append("$$$");
                    words[i] = wordBuilder.ToString();
                }
            }

            Console.WriteLine("Result:"); 
            foreach (string item in words)
            {
                Console.Write(item + " "); 
            }
            Console.WriteLine();

            // Task 5
            Console.WriteLine("\nTASK 5");

            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            string[] word = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.Write($"Enter word number (1 to {word.Length}): ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0 && number <= word.Length)
            {
                string targetWord = word[number - 1];

                char firstLetter = targetWord[0];

                Console.WriteLine($"Word #{number} is '{targetWord}'. Its first letter is: '{firstLetter}'");
            }
            else
            {
                Console.WriteLine("Wrong word number");
            }

            // Task 6
            Console.WriteLine("\nTASK 6");

            Console.Write("Enter text: ");
            string textTask6 = Console.ReadLine();

            string[] wordsTask6 = textTask6.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            StringBuilder builderTask6 = new StringBuilder();

            for (int i = 0; i < wordsTask6.Length; i++)
            {
                builderTask6.Append(wordsTask6[i]);

                if (i < wordsTask6.Length - 1)
                {
                    builderTask6.Append("*");
                }
            }

            Console.WriteLine("Result: " + builderTask6);

            // Task 7
            Console.WriteLine("\nTASK 7");

            StringBuilder builderTask7 = new StringBuilder();

            string inputWord;

            do
            {
                Console.Write("Enter word: ");
                inputWord = Console.ReadLine();

                if (builderTask7.Length > 0)
                {
                    builderTask7.Append(", ");
                }

                builderTask7.Append(inputWord);

            } while (!inputWord.EndsWith("."));

            Console.WriteLine("Result: " + builderTask7);
        }
    }
}