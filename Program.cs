
using System.Text.RegularExpressions;

class Regulars
{
    static void Main(string[] args)
    {
        string[] input = File.ReadAllLines(@"info.txt");
        Regex regex1 = new Regex(@"^(a|a{6}|a\s{1}aa\s{1}a)$");
        Regex regex2 = new Regex(@"^\w{5,}$");
        Regex regex3 = new Regex(@"^[a-zA-Z0-9._]+@[a-zA-Z0-9.]+\.[a-zA-Z]{2,}$");
        for (int i = 0; i < input.Length; i++)
        {
            bool m1 = regex1.IsMatch(input[i]);
            bool m2 = regex2.IsMatch(input[i]);
            bool m3 = regex3.IsMatch(input[i]);

            Console.WriteLine($"Строка {i + 1}:");
            Console.WriteLine($"Соответствие шаблону 1: {m1}");
            Console.WriteLine($"Соответствие шаблону 2: {m2}");
            Console.WriteLine($"Соответствие шаблону 3: {m3}");
            Console.WriteLine();
        }
        Console.ReadLine();

    }
}