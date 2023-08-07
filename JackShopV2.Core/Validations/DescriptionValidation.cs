using JackShopV2.Core.Notifications;


namespace JackShopV2.Core.Validations.Contract
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> DescriptionIsOk(string description, short minLength, short maxLength, string message, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(description) || (description.Length < minLength) || (description.Length > maxLength))

                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}