namespace PetStorePart6
{
    public static class ListExtensions
    {
        /// <summary>
        /// Filters the list to retrieve only in-stock products.
        /// </summary>
        public static List<T> InStock<T>(this List<T> list) where T : Product
        {
            return list.Where(product => product.Quantity > 0).ToList();
        }
    }
}
