namespace JackShopV2.Application.Services
{
    public class CatalogViewModel
    {
        public CatalogViewModel(string title,
                        string description,
                        decimal fixedFreight,
                        decimal pricePerKg,
                        decimal price) : base()
        {
            Title = title;
            Description = description;
            FixedFreight = fixedFreight;
            PricePerKg = pricePerKg;
            Price = price;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal FixedFreight { get; private set; }
        public decimal PricePerKg { get; private set; }
        public decimal Price { get; private set; }


    }
}
