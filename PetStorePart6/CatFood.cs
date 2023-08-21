namespace PetStorePart6
{
    internal class CatFood : Product
    {
        /// <summary>
        /// Gets or sets a value indicating whether the food is suitable for kittens.
        /// </summary>
        public bool KittenFood { get; set; }

        /// <summary>
        /// Gets or sets the weight of the cat food in pounds.
        /// </summary>
        public double WeightPounds { get; set; }
    }
}
