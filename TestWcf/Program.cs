using WcfServiceLibrary1;

namespace TestWcf
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new Service1();
            var result=   client.Add(10, 80);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
