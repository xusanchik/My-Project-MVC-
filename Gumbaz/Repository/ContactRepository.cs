using Gumbaz.Data;
using Gumbaz.Entity;
using Gumbaz.Interface;

namespace Gumbaz.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly AppDbContext _appDbContext;
        public ContactRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task Save(Contact contact)
        {
            _appDbContext.Contacts.Add(contact);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
