using JackShopV2.Core.Notifications;


namespace JackShopV2.Core.Validations.Contract
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> TitleIsOk(string title, short maxLength, short minLength, string message, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(title) || (title.Length < minLength) || (title.Length > maxLength))

                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}