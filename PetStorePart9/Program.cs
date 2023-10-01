using PetStorePart9;
using Microsoft.Extensions.DependencyInjection;
using PetStore.Data;
using PetStore.Data.Repositories;

namespace PetStorePart9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = CreateServiceCollection();

            IProductLogic productLogic = serviceProvider.GetService<IProductLogic>();

            UILogic uiLogic = new UILogic(productLogic);
            uiLogic.Start(args);  
        }


        private static IServiceProvider CreateServiceCollection()
        {
            return new ServiceCollection()
                .AddTransient<IProductLogic, ProductLogic>()  
                .AddScoped<IProductRepository, ProductRepository>()  
                .BuildServiceProvider();
        }

    }
}
