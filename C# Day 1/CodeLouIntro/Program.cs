namespace CodeLouIntro
{
    internal class Program
    {
        static string Name = "My Program";
        
        static string GetName()
        {
            Console.WriteLine("Sending name. . . now!");
            return Name;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Name);
            Console.WriteLine(GetName());
        }
    }
}