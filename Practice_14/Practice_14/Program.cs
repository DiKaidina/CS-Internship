using System.Text.RegularExpressions;

public class Program
{
    private static void Main(string[] args)
    {

        /**/
        string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

        // игнорировать знаки препинания и разделить 
        string[] words = Regex.Split(text, @"\W+");

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (!string.IsNullOrWhiteSpace(word))
            {
                string low_word = word.ToLower(); // Приводим слово к нижнему регистру
                if (wordCount.ContainsKey(low_word))
                {
                    wordCount[low_word]++;
                }
                else
                {
                    wordCount[low_word] = 1;
                }
            }
        }

        // Вывод результатов
        Console.WriteLine("Слова и количество их вхождений:");
        foreach (var pair in wordCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
