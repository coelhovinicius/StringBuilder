/* >>> CLASSE POST <<< */

using System;
using System.Collections.Generic;
using System.Text;

namespace Aula122_Exercicio2_StrigBuilder.Entities
{
    class Post
    {
        // Propriedades da classe Post
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>(); /* Composicao de classes - Associacao entre 
                                                                            * as classes Post e Comment - Cria uma Lista
                                                                            * tipo Comment, de nome "Comments", e instancia
                                                                            * essa lista, para garantir que nao seja nula */

        // Construtores
        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        // PADRAO: Metodos de Adicao e Remocao de objetos - Adicionar, mesmo que nao esteja indicado no projeto
        public void AddComment (Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment (Comment comment)
        {
            Comments.Remove(comment);
        }
        // Obs.: Os metodos Add e Remove so nao serao criados caso haja uma especificidade do projeto que indique isso

        // TOSTRING
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); // Pertence ao Namespace System.Text
            sb.AppendLine(Title); // AppendLine adiciona o que esta entre parenteses (Title) + quebra de linha
            sb.Append(Likes); // Append adiciona o que esta entre parenteses, porem, sem quebra de linha
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            
            // Percorrer a lista de comentarios e adicionar o comentario
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
