using Gumbaz.Data;
using Gumbaz.Entity;
using Gumbaz.Interface;

namespace Gumbaz.Repository
{
    public class ComentRepository : IComentRepository
    {
        private readonly AppDbContext _appDbContext;
        public ComentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task Save(Coment coment)
        {
            _appDbContext.Coments.Add(coment);
            await _appDbContext.SaveChangesAsync();
        }

    }
}
