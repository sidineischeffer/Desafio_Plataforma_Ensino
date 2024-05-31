namespace Desafio_Plataforma_Ensino.Entities
{
    public abstract class Lesson
    {
        public string Title { get; private set; }

        protected Lesson(string title)
        {
            Title = title;
        }

        public abstract int Duration();
    }
}

