using System;

namespace laba3._1._1._1._1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            Console.WriteLine("Input string: ");
            string line;
            line = Console.ReadLine();
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            int i;
            int vowels, consonant;
            vowels = consonant = 0;

            foreach (String s in words)
            {
                if (s.Length > 1)
                {
                    word = s;
                    ctr = s.Length;
                    Console.WriteLine(" " + s);
                    for (i = 0; i < ctr; ++i)
                    {
                        if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' ||
                            s[i] == 'o' || s[i] == 'u' || s[i] == 'A' ||
                            s[i] == 'E' || s[i] == 'I' || s[i] == 'O' ||
                            s[i] == 'U')
                        {
                            ++vowels;
                        }
                        else if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z'))
                        {
                            ++consonant;
                        }
                    }
                    if (vowels == consonant)
                    {
                        Console.WriteLine("Vowels == Consonant: ");
                        j++;
                    }
                }
            }
            Console.WriteLine("Vowels == Consonant: " + j);
        }
    }
}