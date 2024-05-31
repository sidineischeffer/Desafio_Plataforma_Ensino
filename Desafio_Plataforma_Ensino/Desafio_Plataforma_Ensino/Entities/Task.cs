namespace Desafio_Plataforma_Ensino.Entities
{
    public class Task : Lesson
    {
        public string Description { get; private set; }
        public int QuestionCount { get; private set; }

        public Task(string title, string description, int questionCount) : base(title)
        {
            Description = description;
            QuestionCount = questionCount;
        }

        public override int Duration()
        {
            return QuestionCount * 300; 
        }
    }
}
