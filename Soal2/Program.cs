using System;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Input string : ");
        string input = Console.ReadLine();

        string charVowel = ProcessCharacters(procVowel(input));
        string charConsonant = ProcessCharacters(procConsonant(input));

        Console.WriteLine("Vowel Characters : ");
        Console.WriteLine(charVowel);
        Console.WriteLine("Consonant Characters : ");
        Console.WriteLine(charConsonant);
    }

    public static string ProcessCharacters(string input)
    {
        string processedInput = new string(input.Where(char.IsLetter).Select(char.ToLower).ToArray());

        var groupedCharacters = processedInput.GroupBy(c => c).Select(group => new { Char = group.Key, Count = group.Count() });

        StringBuilder result = new StringBuilder();
        foreach (var group in groupedCharacters)
        {
            result.Append(new string(group.Char, group.Count));
        }

        return result.ToString();
    }

    public static string procVowel(string param)
    {
        // Selecting only vowel characters
        return new string(param.Where(c => "aeiou".IndexOf(c) != -1).ToArray());
    }

    public static string procConsonant(string param)
    {
        // Selecting only consonant characters
        return new string(param.Where(c => "aeiou".IndexOf(c) == -1).ToArray());
    }
}
