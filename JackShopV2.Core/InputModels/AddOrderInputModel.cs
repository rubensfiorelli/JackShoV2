using JackShopV2.Core.Entities;
using JackShopV2.Core.Enums;

namespace JackShopV2.Core.InputModels
{
    public class AddOrderInputModel
    {
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public DeliveryAddress ToValueObject()
            => new DeliveryAddress(ZipCode, Street, Number, Complement, City, State);
    }

    public class OrderInputModel
    {
        public string TrackingCode { get; set; }
        public string Description { get; set; }
        public DateTime PostedAt { get; set; }
        public Guid DeliveryAddressId { get; set; }
        public ECatlogOrderStatus Status { get; set; }
        public decimal TotalPrice { get; set; }
        public List<CatalogInputModel> Products { get; set; }

        public Order ToEntity()
            => new(Description, DeliveryAddressId, TotalPrice);

    }


}
