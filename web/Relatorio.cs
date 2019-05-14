using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace web
{
    public class Relatorio : IRelatorio
    {
        private readonly ICatalogo catalogo;

        public Relatorio(ICatalogo catalogo)
        {
            this.catalogo = catalogo;
        }

        public async Task Imprimir(HttpContext context)
        {
            foreach (var livro in catalogo.GetLivros())
            {
                await context.Response.WriteAsync($"Codigo: {livro.Codigo,-10} | Nome: {livro.Nome,-40} | Preco: {livro.Preco.ToString("c"),10}\r\n");
            }
        }
    }
}
