using TinyBankRepository.Models;
using TinyBankRepository.Interfaces;
using System.Text.Json;
using System.Text;

namespace TinyBankRepository.Implementations
{
    public class AccountRepository : IAccountRepository
    {

        private readonly string _filePath;
        private readonly List<Account> _accounts;

        public AccountRepository(string filePath)
        {
            _filePath = filePath;
            _accounts = LoadData();
        }

        public List<Account> GetAccounts() => _accounts;

        public List<Account> GetAccountsOfCustomer(int customerId) =>
            _accounts
            .Where(a => a.CustomerId == customerId)
            .ToList();

        public Account GetSingleAccount(int id) => _accounts.FirstOrDefault(a => a.Id == id);

        public int DeleteAccount(int id)
        {
            var account = _accounts.FirstOrDefault(a => a.Id == id);

            _accounts.Remove(account);
            SaveData();

            return account.Id;
        }

        public int AddAccount(Account newAccount)
        {
            newAccount.Id = _accounts.Any() ? _accounts.Max(c => c.Id) : 1;
            _accounts.Add(newAccount);
            SaveData();

            return newAccount.Id;
        }

        public int UpdateAccount(Account account)
        {
            var accountIndex = _accounts.FindIndex(c => c.Id == account.Id);

            if (accountIndex >= 0)
            {
                _accounts[accountIndex] = account;
                SaveData();
            }

            return account.Id;
        }


        #region HELPERS
        private List<Account> LoadData()
        {
            if (!File.Exists(_filePath))
                return new List<Account>();

            string json;

            using (FileStream fs = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length];
                fs.ReadExactly(buffer);
                json = Encoding.UTF8.GetString(buffer);
            }

            List<Account> accounts = FromJson(json);

            return accounts ?? new List<Account>();
        }

        private List<Account> FromJson(string line) =>
            JsonSerializer.Deserialize<List<Account>>(line, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        private string ToJson(List<Account> accounts) =>
            JsonSerializer.Serialize(accounts, new JsonSerializerOptions { WriteIndented = true });

        private void SaveData()
        {
            string json = ToJson(_accounts);

            byte[] bytes = Encoding.UTF8.GetBytes(json);

            using (FileStream fs = new FileStream(_filePath, FileMode.Open, FileAccess.Write))
                fs.Write(bytes, 0, bytes.Length);
        }

        #endregion
    }
}