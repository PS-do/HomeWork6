namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2.    Обязательная задача*.\n" +
                " Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.\n" +
                " Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом\n" +
                " без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).\n\n" +
                "Введите исходную строку");
            string startStr=Console.ReadLine().ToLower().Replace(" ", "");
            string endStr = "";
            foreach (char s in startStr) endStr = s + endStr;            
            Console.WriteLine(endStr);
            if (endStr == startStr) Console.WriteLine("Является ли строка палиндромомбез учёта пробелов и регистра? Является!");
            else Console.WriteLine("Является ли строка палиндромомбез учёта пробелов и регистра? Не является!");

        }
    }
}