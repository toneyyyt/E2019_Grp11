using Business;
using Corelib;
using MyLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interface
{
    public interface IUserAccount : IBaseRepository<UserAccount>
    {
        string saveUserAccount(int AccountId, string AccountName, string AccountUserName, string AccountPassword, string accountEmail, string AccountType);

        List<UserAccountViewModel> geAlltUserAccount();

        List<UserAccountViewModel> getUserAccount(string Username, string Password);
    }
}
