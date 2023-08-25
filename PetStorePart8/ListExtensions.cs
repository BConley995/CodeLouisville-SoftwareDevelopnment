namespace PetStorePart8
{
    public static class ListExtensions
    {
        /// Filters the list to retrieve only in-stock products. 
        public static List<T> InStock<T>(this List<T> list) where T : Product
        {
            return list.Where(product => product.Quantity > 0).ToList();
        }
    }
}
