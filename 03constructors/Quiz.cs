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
        internal string gegevenAntwoord;
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
    }

    class Program
    {
        private void Run()
        {
            Quiz quiz = new Quiz(10);   // quiz met 10 vragen

            quiz.vragen[0] = new QuizVraag("Wat is de hoofdstad van Nederland?", "Amsterdam");
            quiz.vragen[1] = new QuizVraag("Welke kleur krijg je door blauw en geel te mengen?", "Groen");
            quiz.vragen[2] = new QuizVraag("Hoeveel dagen heeft een week?", "7");
            quiz.vragen[3] = new QuizVraag("Wat is het grootste land ter wereld?", "Rusland");
            quiz.vragen[4] = new QuizVraag("Hoeveel poten heeft een spin?", "8");
            quiz.vragen[5] = new QuizVraag("Wat is de som van 12 + 8?", "20");
            quiz.vragen[6] = new QuizVraag("Welke planeet staat het dichtst bij de zon?", "Mercurius");
            quiz.vragen[7] = new QuizVraag("Hoe heet de grootste oceaan?", "Stille Oceaan");
            quiz.vragen[8] = new QuizVraag("Hoeveel seconden zitten er in een minuut?", "60");
            quiz.vragen[9] = new QuizVraag("Wat is de hoofdstad van België?", "Brussel");
        }

        static void Main()
        {
            new Program().Run();
        }
    }
}
