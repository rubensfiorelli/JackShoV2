using JackShopV2.Core.Notifications;


namespace JackShopV2.Core.Validations.Contract
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> PricePerKgValidation(decimal pricePerKg, string message, string propertyName)
        {
            if (decimal.IsNegative(pricePerKg))

                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}