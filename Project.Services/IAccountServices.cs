using Project.Database.Repository;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services
{
    public interface IAccountServices
    {
        UserLogin UserLogin(string userName, string password);
    }

    public class Account : IAccountServices
    {
        protected readonly IAccountRepository _accountRepository;
        public Account(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public UserLogin UserLogin(string userName, string password)
        {
            return _accountRepository.UserLogin(userName, password);
        }
    }
}
