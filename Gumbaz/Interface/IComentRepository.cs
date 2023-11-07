using Gumbaz.Entity;

namespace Gumbaz.Interface
{
    public interface IComentRepository
    {
        Task Save(Coment coment);
    }
}
