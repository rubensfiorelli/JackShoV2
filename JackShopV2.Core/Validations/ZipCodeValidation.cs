using JackShopV2.Core.Notifications;


namespace JackShopV2.Core.Validations.Contract
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> ZipCodeIsOk(string zipcode, short minLength, short maxLength, string message, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(zipcode) || (zipcode.Length < minLength) || (zipcode.Length > maxLength))

                AddNotification(new Notification(message, propertyName));

            return this;
        }
    }
}