using System;

namespace _01functions
{
    internal class Program
    {
        string[] vragen = new string[]
        {
            "How long do you think you'd survive in a zombie apocalypse?",
            "What would you do if you won a million dollars?",
            "Why do round pizzas come in square boxes?",
            "Has someone caught you dancing in front of the mirror?",
            "Which species would be the rudest if all animals could talk?",
            "What secret conspiracy would you like to actually start letting other people know?",
            "Have you ever tried talking to an animal?"
        };

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            Console.WriteLine(program.GetVraag(0));
            Console.WriteLine(program.GetRandomVraag());
            program.Vraag1();
            program.Vraag2();
            program.Vraag3();
            program.Vraag4();
            program.Vraag5();
            program.Vraag6();
            program.Vraag7();
        }

        void Run()
        {
            Console.WriteLine("Run methode werkt!");
            Console.WriteLine();
        }

        internal string GetVraag(int vraagindex)
        {
            return vragen[vraagindex];
        }

        internal string GetRandomVraag()
        {
            Random rnd = new Random();
            int index = rnd.Next(vragen.Length);
            return vragen[index];
        }

        internal void Vraag1()
        {
            Console.WriteLine("Vraag 1: " + vragen[0]);
            string antwoord = Console.ReadLine();
            Console.WriteLine("Jouw antwoord: " + antwoord);
            Console.WriteLine();
        }

        internal void Vraag2()
        {
            Console.WriteLine("Vraag 2: " + vragen[1]);
            string antwoord = Console.ReadLine();
            Console.WriteLine("Jouw antwoord: " + antwoord);
            Console.WriteLine();
        }

        internal void Vraag3()
        {
            Console.WriteLine("Vraag 3: " + vragen[2]);
            string antwoord = Console.ReadLine();
            Console.WriteLine("Jouw antwoord: " + antwoord);
            Console.WriteLine();
        }

        internal void Vraag4()
        {
            Console.WriteLine("Vraag 4: " + vragen[3]);
            string antwoord = Console.ReadLine();
            Console.WriteLine("Jouw antwoord: " + antwoord);
            Console.WriteLine();
        }

        internal void Vraag5()
        {
            Console.WriteLine("Vraag 5: " + vragen[4]);
            string antwoord = Console.ReadLine();
            Console.WriteLine("Jouw antwoord: " + antwoord);
            Console.WriteLine();
        }

        internal void Vraag6()
        {
            Console.WriteLine("Vraag 6: " + vragen[5]);
            string antwoord = Console.ReadLine();
            Console.WriteLine("Jouw antwoord: " + antwoord);
            Console.WriteLine();
        }

        internal void Vraag7()
        {
            Console.WriteLine("Vraag 7: " + vragen[6]);
            string antwoord = Console.ReadLine();
            Console.WriteLine("Jouw antwoord: " + antwoord);
            Console.WriteLine();
        }
    }
}
