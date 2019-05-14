using System.ComponentModel.DataAnnotations;

namespace LojaLivros.Models
{
    public class Produto
    {
        public Produto()
        {

        }

        public int Id { get; protected set; }
        [Required]
        public string Codigo { get; private set; }
        [Required]
        public string Nome { get; private set; }
        [Required]
        public decimal Preco { get; private set; }
        
        public Produto(string codigo, string nome, decimal preco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}
