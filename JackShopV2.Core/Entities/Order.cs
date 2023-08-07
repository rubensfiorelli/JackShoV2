using JackShopV2.Core.Enums;
using JackShopV2.Core.Validations.Contract;
using JackShopV2.Core.Validations.Interfaces;

namespace JackShopV2.Core.Entities
{
    public sealed class Order : BaseEntity, IContract
    {
        public Order(string description,
                            Guid deliveryAddressId,
                            decimal totalPrice) : base()
        {
            TrackingCode = GenerateTrackingCode();
            Description = description;
            PostedAt = DateTime.UtcNow;
            DeliveryAddressId = deliveryAddressId;
            Status = ECatlogOrderStatus.Started;
            TotalPrice = totalPrice;
            Products = new List<ItemsOrder>();
        }

        public string TrackingCode { get; private set; }
        public string Description { get; private set; }
        public DateTime PostedAt { get; private set; }
        public Guid DeliveryAddressId { get; private set; }
        public DeliveryAddress? DeliveryAddress { get; private set; }
        public ECatlogOrderStatus Status { get; private set; }
        public decimal TotalPrice { get; private set; }
        public List<ItemsOrder> Products { get; private set; }


        public void SetupOrders(List<Catalog> products)
        {
            foreach (var product in products)
            {
                var productPrice = product.FixedFreight + product.PricePerKg;

                TotalPrice += productPrice;
                Products.Add(new ItemsOrder(product.Title, productPrice));
            }
        }
        private static string GenerateTrackingCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";

            var code = new char[10];
            var random = new Random();

            for (var i = 0; i < 5; i++)
            {
                code[i] = chars[random.Next(chars.Length)];
            }

            for (var i = 5; i < 10; i++)
            {
                code[i] = numbers[random.Next(numbers.Length)];
            }

            return new String(code);
        }

        public void SetCompleted()
        {
            Status = ECatlogOrderStatus.Delivered;
        }

        public override bool Validate()
        {
            var contracts = new ContractValidations<Order>()
                   .DescriptionIsOk(Description, 10, 300, "A descricao precisa ter o minimo de 10 caracteres", nameof(Description))
;
            return contracts.IsValid();
        }
    }
}
