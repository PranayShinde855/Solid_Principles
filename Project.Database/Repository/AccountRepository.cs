using Project.Database.Infrastructure;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database.Repository
{
    public interface IAccountRepository : IRepository<Category>
    {
        UserLogin UserLogin(string userName, string password);
    }
    public class AccountRepository : Repository<Category>, IAccountRepository
    {
        public AccountRepository(Context context) : base(context)
        {

        }

        public UserLogin UserLogin(string userName, string password)
        {
            UserLogin userLogin = _context.UserLogin.Where(x => x.UserName == userName && x.Password == password).FirstOrDefault();
            return userLogin;
        }
    }
}
