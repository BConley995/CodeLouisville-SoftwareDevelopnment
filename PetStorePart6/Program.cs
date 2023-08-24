using PetStorePart6;

namespace PetStorePart6
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
