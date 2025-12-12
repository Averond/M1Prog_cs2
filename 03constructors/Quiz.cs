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

        internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
        {
            vragen[index] = vraag;
        }

        internal void VoegVraagToeOpIndex(int index, string vraagText, string antwoord)
        {
            QuizVraag nieuweVraag = new QuizVraag(vraagText, antwoord);
            VoegVraagToeOpIndex(index, nieuweVraag);
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
        }

        static void Main()
        {
            new Program().Run();
        }
    }
}
