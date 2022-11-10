namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.    Обязательная задача*. \n" +
                "Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.\n" +
                " Знаки препинания не используются. Найти самое длинное слово в строке.");
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            string max = strArray[0];
            foreach (string s  in strArray)
            {
                if(s.Length>max.Length)
                {
                    max = s;
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}