using LojaLivros.Models;
using System.Collections.Generic;

namespace LojaLivros.Respositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
        IList<Produto> GetProdutos();
    }
}