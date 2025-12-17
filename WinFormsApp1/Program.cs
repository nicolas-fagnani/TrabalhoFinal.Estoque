using Estoque.Application.Services;
using Estoque.Application.Validators;
using Estoque.Repository.Context;
using Estoque.Repository.Repository;

namespace WinFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var dbContext = new EstoqueDbContext();

            var userRepo = new UserRepository(dbContext);
            var categoryRepo = new CategoryRepository(dbContext);
            var productRepo = new ProductRepository(dbContext);
            var supplierRepo = new SupplierRepository(dbContext);
            var customerRepo = new CustomerRepository(dbContext);
            var stockRepo = new StockMovementRepository(dbContext);

            var userValidator = new UserValidator();
            var categoryValidator = new CategoryValidator();
            var productValidator = new ProductValidator(); 
            var supplierValidator = new SupplierValidator();
            var customerValidator = new CustomerValidator();
            var stockValidator = new StockMovementValidator();

            var userService = new UserService(userRepo);

            Application.Run(new FormLogin(userService));
        }
    }
}