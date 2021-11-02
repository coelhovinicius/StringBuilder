/* STRINGBUILDER - Composicao com StringBuilder - Solucao em https://github.com/acenelio/composition2-csharp
 * 
 * Exercicio 2 - Aplicativo de rede social: Instancie manualmente os objetos mostrados abaixo e mostre-os na tela do
 * terminal, conforme *EXEMPLO*:
 * 
 * Diagrama de Classes:
 * - CLASE POST:
 *      > Moment : DateTime;
 *      > Title : string;
 *      > Content : string;
 *      > Likes : int;
 *      
 * A classe Post esta relacionada com a classe Comment na razao de 1 para Varios. Portanto, um Post pode conter diversos
 * Comments
 * 
 * - CLASSE COMMENT:
 *      > Text : string;
 *      
 * 
 * *EXEMPLO*:
 *      Title: Traveling to New Zealand
 *      Likes: 12 Likes - 21/06/2018 13:05:44
 *      Content: I'm going to visit this wonderful country!
 *      Comments:
 *      Comment: Have a nice trip
 *      Comment: Wow that's awesome!
 *      
 *      Title: Good night guys
 *      Likes: 5 Likes - 28/07/2018 23:14:19
 *      Content: See you tomorrow
 *      Comments:
 *      Comment: Good night
 *      Comment: May the Force be with you
 * 
 */

using System;
using System.Globalization;
using Aula122_Exercicio2_StrigBuilder.Entities;

namespace Aula122_Exercicio2_StrigBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // ENTRADA DE DADOS DIRETO NO CODIGO
            Comment c1 = new Comment("Have a nice trip"); // COMENTARIOS
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zeland ",
                "I'm going to visit this wonderful country!",
                12); // POST
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                12);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
