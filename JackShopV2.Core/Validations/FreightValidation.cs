using JackShopV2.Core.Notifications;


namespace JackShopV2.Core.Validations.Contract
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> FreightValidation(decimal freight, string message, string propertyName)
        {
            if (decimal.IsNegative(freight))

                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}