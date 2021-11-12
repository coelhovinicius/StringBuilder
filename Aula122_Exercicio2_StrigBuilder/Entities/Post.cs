/* >>> CLASSE POST <<< */

using System;
using System.Collections.Generic;
using System.Text; // Necessario para utilizar o StringBuilder

namespace Aula122_Exercicio2_StrigBuilder.Entities
{
    class Post
    {
        // Propriedades da classe Post
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        // Lista de comentarios - A Lista de Comentarios e necessaria pois 1 Post pode ter Varios Comentarios
        public List<Comment> Comments { get; set; } = new List<Comment>(); /* Composicao de classes - Associacao entre 
                                                                            * as classes Post e Comment - Cria uma Lista
                                                                            * tipo Comment, de nome "Comments", e instancia
                                                                            * essa lista, para garantir que nao seja nula */

        // Construtores
        public Post() // Construtor padrao (nao recebe argumentos)
        {
        }

        public Post(DateTime moment, string title, string content, int likes) // Construtor com argumentos
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
        // Obs.: Os metodos Add e Remove so nao serao criados caso seja indicado no projeto

        // TOSTRING
        public override string ToString()
        {
            // StringBuilder: Faz a montagem de uma string de maneira mais eficiente, a partir do que queiramos apresentar
            StringBuilder sb = new StringBuilder(); // Propriedade StringBuilder pertence ao Namespace System.Text
            sb.AppendLine(Title); // AppendLine adiciona o que esta entre parenteses (Title) + quebra de linha
            sb.Append(Likes); // Append adiciona o que esta entre parenteses, porem, sem quebra de linha
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss")); // Mascara de formatacao entre parenteses para o ToString
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            
            // Percorrer a lista de comentarios e adicionar cada comentario
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
