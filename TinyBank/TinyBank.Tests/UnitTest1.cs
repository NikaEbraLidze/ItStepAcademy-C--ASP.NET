using System.IO;
using System.Linq;
using Xunit;
using TinyBank.Repository.Implementations;
using TinyBank.Repository.Models;

namespace TinyBank.Tests
{
    public class CustomerRepositoryRealFileTests
    {
        private readonly string _filePath;

        public string FilePath => _filePath;

        public CustomerRepositoryRealFileTests()
        {
            var currentDir = Directory.GetCurrentDirectory();
            var parent = Directory.GetParent(currentDir);
            var grandParent = parent?.Parent;
            var projectRoot = grandParent?.FullName ?? System.AppContext.BaseDirectory;

            _filePath = Path.Combine(
                projectRoot,
                "TinyBankData",
                "Customers.csv"
            );
        }

        [Fact]
        public void LoadData_Should_Read_Customers_From_File()
        {
            // Arrange
            var repo = new CustomerRepository(_filePath);

            // Act
            var customers = repo.GetCustomers();

            // Assert
            Assert.NotNull(customers);
            Assert.NotEmpty(customers);
        }

        [Fact]
        public void GetSingleCustomer_Should_Return_Existing_Customer()
        {
            // Arrange
            var repo = new CustomerRepository(_filePath);
            var all = repo.GetCustomers();
            var first = all.First();

            // Act
            var single = repo.GetSingleCustomer(first.Id);

            // Assert
            Assert.NotNull(single);
            Assert.Equal(first.Name, single.Name);
        }
    }
}
