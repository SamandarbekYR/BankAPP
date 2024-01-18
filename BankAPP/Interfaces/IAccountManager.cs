using BankAPP.Models;

namespace BankAPP.Interfaces
{
    public interface IBankManager
    {
        void Register();
        User Login();
    }
}
