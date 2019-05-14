using System.Collections.Generic;

namespace web
{
    public class Catalogo : ICatalogo
    {
        public List<Livro> GetLivros()
        {
            var livros = new List<Livro>
            {
                new Livro("001", "Quem Mexeu na Minha Query?", 12.99m),
                new Livro("002", "Fique Rico com C#", 30.99m),
                new Livro("003", "Java Para Baixinhos", 25.99m)
            };

            return livros;
        }
    }
}
