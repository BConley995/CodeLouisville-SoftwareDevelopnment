using PetStorePart9;
using Microsoft.Extensions.DependencyInjection;

namespace PetStorePart9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = CreateServiceCollection();

            IProductLogic productLogic = serviceProvider.GetService<IProductLogic>();

            UILogic uiLogic = new UILogic(productLogic);
            uiLogic.Start();
        }

        private static IServiceProvider CreateServiceCollection()
        {
            return new ServiceCollection()
                .AddTransient<IProductLogic, ProductLogic>()  // Add the transient service as instructed
                .BuildServiceProvider();
        }
    }
}
