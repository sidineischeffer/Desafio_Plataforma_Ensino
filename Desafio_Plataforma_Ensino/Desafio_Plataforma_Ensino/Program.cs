using System;
using System.Collections.Generic;
using Desafio_Plataforma_Ensino.Entities;

namespace Desafio_Plataforma_Ensino
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lesson> lessons = new List<Lesson>();

            Console.Write("Quantas aulas tem o curso? ");
            int lessonCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lessonCount; i++)
            {
                Console.WriteLine($"Dados da {i}a aula:");
                Console.Write("Conteúdo ou tarefa (c/t)? ");
                char lessonType = char.Parse(Console.ReadLine());
                Console.Write("Título: ");
                string title = Console.ReadLine();

                if (lessonType == 'c')
                {
                    Console.Write("URL do vídeo: ");
                    string url = Console.ReadLine();
                    Console.Write("Duração em segundos: ");
                    int seconds = int.Parse(Console.ReadLine());
                    lessons.Add(new Video(title, url, seconds));
                }
                else if (lessonType == 't')
                {
                    Console.Write("Descrição: ");
                    string description = Console.ReadLine();
                    Console.Write("Quantidade de questões: ");
                    int questionCount = int.Parse(Console.ReadLine());
                    lessons.Add(new Task(title, description, questionCount));
                }
            }

            int totalDuration = 0;
            foreach (Lesson lesson in lessons)
            {
                totalDuration += lesson.Duration();
            }

            Console.WriteLine("");
            
            Console.WriteLine($"DURAÇÃO TOTAL DO CURSO = {totalDuration} segundos");

            Console.WriteLine("Pressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
