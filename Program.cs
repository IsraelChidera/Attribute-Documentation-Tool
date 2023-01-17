using Documentation;

namespace Documentation_client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            DocumentDescription documentation = new();
            documentation.GetDocs();
        }
    }
}