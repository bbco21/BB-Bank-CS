using BB_Bank.classes;

namespace BB_Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Clear();

            Program pr = new Program();
            Console.WriteLine(Constants.MESSAGE);

            TesztClass teszt1 = new TesztClass();
            teszt1.TesztFasz();
        }


        public void Init()
        {
            Console.WriteLine("Inicializacio...");
        }
    }
}