// дан файл numsTask1.txt со словами. Выведите все слова нечетной длины;

using System;
using System.IO;

class work_5_1
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("numsTask1.txt"); 
        string[] words = lines[0].Split(' '); 

        foreach (string i in words)
        {
            if (i.Length % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
 
