using PetStorePart7;

namespace PetStorePart7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductLogic productLogic = new ProductLogic();
            UILogic uiLogic = new UILogic(productLogic);
            uiLogic.Start();
        }
    }
}
