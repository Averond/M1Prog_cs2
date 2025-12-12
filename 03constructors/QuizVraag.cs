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

    class Program
    {
        private void Run()
        {
            QuizVraag quizVraag = new QuizVraag(
                "Wat is de hoofdstad van Nederland?",
                "Amsterdam"
            );
        }

        static void Main()
        {
            new Program().Run();
        }
    }
}
