using demo1.Data.Repositories.GenericRepository;
using demo1.Models;

namespace demo1.Data.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {
        }
    }
}
