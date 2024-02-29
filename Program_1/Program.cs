namespace Program_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź wartosc graniczną: ");
            int uB = int.Parse(Console.ReadLine());
            FizzBuzz F1 = new FizzBuzz(uB);
            F1.Display();
;        }
    }
}
