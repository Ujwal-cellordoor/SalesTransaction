using SalesTransaction.Application.Model.Account;

namespace SalesTransaction.Application.Service.Account
{
    public interface IAccountService
    {
        dynamic GetLogin(MLogin login);
        dynamic GetUserDetail(string json);
    }
}
