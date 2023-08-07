using JackShopV2.Core.Entities;

namespace JackShopV2.Core.ViewModels
{
    public class OrderViewModel
    {
        public OrderViewModel(string trackingCode,
                               string description,
                               DateTime postedAt,
                               decimal totalPrice,
                               string fullAddress)
        {

            TrackingCode = trackingCode;
            Description = description;
            PostedAt = postedAt;
            TotalPrice = totalPrice;
            DeliveryAddress = fullAddress;
        }

        public string TrackingCode { get; private set; }
        public string Description { get; private set; }
        public DateTime PostedAt { get; private set; }
        public decimal TotalPrice { get; private set; }
        public string DeliveryAddress { get; private set; }

        public static OrderViewModel FromEntity(Order order)
        {
            var address = order.DeliveryAddress;

            return new OrderViewModel(

                order.TrackingCode,
                order.Description,
                order.PostedAt,
                order.TotalPrice,
                $"{address.ZipCode}, {address.Street}, {address.Number}, {address.Complement}, " +
                $"{address.City}, {address.State}"

                );
        }
    }
}
