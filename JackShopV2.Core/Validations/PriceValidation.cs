using JackShopV2.Core.Notifications;


namespace JackShopV2.Core.Validations.Contract
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> PriceValidation(decimal price, string message, string propertyName)
        {
            if (decimal.IsNegative(price))

                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}