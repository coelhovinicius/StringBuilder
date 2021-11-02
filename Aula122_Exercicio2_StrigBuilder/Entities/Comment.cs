/* >>> CLASSE COMMENT <<< */

namespace Aula122_Exercicio2_StrigBuilder.Entities
{
    class Comment
    {
        public string Text { get; set; }

        // Construtores
        public Comment()
        {
        }

        public Comment(string text) // Using "Generate constructor..."
        {
            Text = text;
        }
    }
}
