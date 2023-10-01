using PetStore.Data;

namespace PetStorePart9
{
    public static class ListExtensions
    {
        public static List<T> InStock<T>(this List<T> list) where T : Product
        {
            return list.Where(product => product.Quantity > 0).ToList();
        }
    }
}
