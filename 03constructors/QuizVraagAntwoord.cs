namespace _03constructors
{
    class QuizVraagAntwoord
    {
        internal QuizVraag vraag;
        internal bool goed;

        internal QuizVraagAntwoord(QuizVraag vraag)
        {
            this.vraag = vraag;
            this.goed = false;
        }
    }
}
