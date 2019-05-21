using LojaLivros.Models;

namespace LojaLivros.Respositories
{
    public interface IItemPedidoRepository
    {

    }

    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
