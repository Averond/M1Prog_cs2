using System;

namespace _03constructors
{
    class QuizVraag
    {
        internal string vraag;
        internal string antwoord;

        internal QuizVraag(string vraag, string antwoord)
        {
            this.vraag = vraag;
            this.antwoord = antwoord;
        }
    }

    class QuizVraagAntwoord
    {
        internal QuizVraag vraag;
        internal string gegevenAntwoord;
        internal bool goed;
    }

    class Quiz
    {
        internal QuizVraag[] vragen;
        internal QuizVraagAntwoord[] ingevuldeAntwoorden;

        internal Quiz(int aantalVragen)
        {
            vragen = new QuizVraag[aantalVragen];
            ingevuldeAntwoorden = new QuizVraagAntwoord[aantalVragen];
        }

        internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
        {
            vragen[index] = vraag;
        }

        internal void VoegVraagToeOpIndex(int index, string vraagText, string antwoord)
        {
            QuizVraag nieuweVraag = new QuizVraag(vraagText, antwoord);
            VoegVraagToeOpIndex(index, nieuweVraag);
        }

        internal void StelVraag(int index)
        {
            QuizVraag vraag = vragen[index];
            QuizVraagAntwoord antwoord = new QuizVraagAntwoord();
            antwoord.vraag = vraag;

            Console.WriteLine(vraag.vraag);
            string input = Console.ReadLine();
            antwoord.gegevenAntwoord = input;

            if (input == vraag.antwoord)
            {
                antwoord.goed = true;
                Console.WriteLine("Goed");
            }
            else
            {
                antwoord.goed = false;
                Console.WriteLine("Fout");
            }

            ingevuldeAntwoorden[index] = antwoord;
        }

        internal int Score()
        {
            int score = 0;
            for (int i = 0; i < ingevuldeAntwoorden.Length; i++)
            {
                if (ingevuldeAntwoorden[i] != null && ingevuldeAntwoorden[i].goed)
                {
                    score++;
                }
            }
            return score;
        }
    }

    class Program
    {
        private void Run()
        {
            Quiz quiz = new Quiz(10);

            quiz.VoegVraagToeOpIndex(0, "Wat is de hoofdstad van Nederland?", "Amsterdam");
            quiz.VoegVraagToeOpIndex(1, "Welke kleur krijg je door blauw en geel te mengen?", "Groen");
            quiz.VoegVraagToeOpIndex(2, "Hoeveel dagen heeft een week?", "7");
            quiz.VoegVraagToeOpIndex(3, "Wat is het grootste land ter wereld?", "Rusland");
            quiz.VoegVraagToeOpIndex(4, "Hoeveel poten heeft een spin?", "8");
            quiz.VoegVraagToeOpIndex(5, new QuizVraag("Wat is de som van 12 + 8?", "20"));
            quiz.VoegVraagToeOpIndex(6, new QuizVraag("Welke planeet staat het dichtst bij de zon?", "Mercurius"));
            quiz.VoegVraagToeOpIndex(7, new QuizVraag("Hoe heet de grootste oceaan?", "Stille Oceaan"));
            quiz.VoegVraagToeOpIndex(8, new QuizVraag("Hoeveel seconden zitten er in een minuut?", "60"));
            quiz.VoegVraagToeOpIndex(9, new QuizVraag("Wat is de hoofdstad van België?", "Brussel"));

            for (int i = 0; i < 10; i++)
            {
                quiz.StelVraag(i);
            }

            int eindScore = quiz.Score();
            Console.WriteLine("Je score is: " + eindScore + " van de 10");
        }

        static void Main()
        {
            new Program().Run();
        }
    }
}
