namespace Desafio_Plataforma_Ensino.Entities
{
    public class Video : Lesson
    {
        public string Url { get; private set; }
        public int Seconds { get; private set; }

        public Video(string title, string url, int seconds) : base(title)
        {
            Url = url;
            Seconds = seconds;
        }

        public override int Duration()
        {
            return Seconds;
        }
    }
}
