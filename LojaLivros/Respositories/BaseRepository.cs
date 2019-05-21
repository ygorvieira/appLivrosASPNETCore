using LojaLivros.Models;
using LojaLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaLivros.Respositories
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected readonly ApplicationContext contexto;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();
        }
    }
}
