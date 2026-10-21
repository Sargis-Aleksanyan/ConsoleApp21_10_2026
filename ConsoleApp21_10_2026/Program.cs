namespace ConsoleApp21_10_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List list = new List();

            list.Add(1);
            list.Add(8);
            list.Add(9);
            list.Insert(2, 15);
            list.Insert(3, 18);
            list.RemoveAt(0);

            int x = list.Get(0);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
