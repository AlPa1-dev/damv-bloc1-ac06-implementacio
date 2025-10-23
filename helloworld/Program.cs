using System;
namespace HelloWorldProject
{
    public class HelloWorld
    {
        public static void Main()
        {
            const string Msg = "Introdueix el teu nom: ";
            string name;
            Console.WriteLine(Msg);
            name = Console.ReadLine();
            Console.WriteLine("Hola, " + name + "!");
        }
    }
}
