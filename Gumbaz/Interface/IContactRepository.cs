using Gumbaz.Entity;

namespace Gumbaz.Interface
{
    public interface IContactRepository
    {
        Task Save(Contact contact);
    }
}
