using System;

namespace Books
{
    public class Product
    {
        public Guid Id => Guid.NewGuid();
        public string Name => "Iogurte";
        public string[] Sizes => new[] {"Small, Medium, Large"};
        public double Price => 2.5;
        public DateTime ExpiryDate => new DateTime(2021, 04, 04);
        public string Brand => "Grego";
    }
}
