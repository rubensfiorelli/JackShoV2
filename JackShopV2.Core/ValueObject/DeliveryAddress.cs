namespace JackShopV2.Core.ValueObject
{
    public record DeliveryAddress(string ZipCode, string Street, int Number, string Complent, string City, string State, string DeliveryAddressId)
    {
    }
}
