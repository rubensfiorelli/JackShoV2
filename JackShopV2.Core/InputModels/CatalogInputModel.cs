using JackShopV2.Core.Entities;

namespace JackShopV2.Core.InputModels
{
    public class CatalogInputModel
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public decimal FixedFreight { get; set; }
        public decimal PricePerKg { get; set; }
        public decimal Price { get; set; }

        public Catalog ToEntity()
            => new Catalog(Title, Description, FixedFreight, PricePerKg, Price);


    }
}
