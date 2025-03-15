using System;

namespace Task8.Classes

{
    public class Product : IComparable<Product>
    {
        private int v1;
        private string v2;
        private int v3;

        public Product(int v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(Product? other) => Price.CompareTo(other?.Price);
    }
}