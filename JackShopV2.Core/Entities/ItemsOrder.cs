using JackShopV2.Core.Validations.Interfaces;

namespace JackShopV2.Core.Entities
{
    public sealed class ItemsOrder : BaseEntity, IContract
    {
        public ItemsOrder(string title, decimal price) : base()
        {
            Title = title;
            Price = price;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
