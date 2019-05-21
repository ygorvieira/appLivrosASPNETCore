using LojaLivros.Models;

namespace LojaLivros.Respositories
{
    public interface ICadastroRepository
    {

    }

    public class CadastroRepository : BaseRepository<Cadastro>, ICadastroRepository
    {
        public CadastroRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
