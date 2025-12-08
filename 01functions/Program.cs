namespace _01functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();

            program.Vraag1();
            program.Vraag2();
            program.Vraag3();
            program.Vraag4();
            program.Vraag5();
            program.Vraag6();
        }

        void Run()
        {
            Console.WriteLine("Run methode werkt!");
        }


        internal void Vraag1()
        {
            Console.WriteLine("Vraag 1: How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();
            Console.WriteLine("Jouw antwoord: " + antwoord);
        }

        internal void Vraag2()
        {
            Console.WriteLine("Vraag 2: What would you do if you won a million dollars?");
            string antwoord = Console.ReadLine();
            Console.WriteLine("Jouw antwoord: " + antwoord);
        }

        internal void Vraag3()
        {
            Console.WriteLine("Vraag 3: Why do round pizzas come in square boxes?");
            string antwoord = Console.ReadLine();
            Console.WriteLine("Jouw antwoord: " + antwoord);
        }

        internal void Vraag4()
        {
            Console.WriteLine("Vraag 4: Has someone caught you dancing in front of the mirror?");
            string antwoord = Console.ReadLine();
            Console.WriteLine("Jouw antwoord: " + antwoord);
        }

        internal void Vraag5()
        {
            Console.WriteLine("Vraag 5: Which species would be the rudest if all animals could talk?");
            string antwoord = Console.ReadLine();
            Console.WriteLine("Jouw antwoord: " + antwoord);
        }

        internal void Vraag6()
        {
            Console.WriteLine("Vraag 6: What secret conspiracy would you like to actually start letting other people know?");
            string antwoord = Console.ReadLine();
            Console.WriteLine("Jouw antwoord: " + antwoord);
        }
    }
}
