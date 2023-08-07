using JackShopV2.Core.Validations.Contract;
using JackShopV2.Core.Validations.Interfaces;

namespace JackShopV2.Core.Entities
{
    public sealed class DeliveryAddress : BaseEntity, IContract
    {
        public DeliveryAddress(string zipCode,
                               string street,
                               int number,
                               string complement,
                               string city,
                               string state) : base()
        {
            ZipCode = zipCode;
            Street = street;
            Number = number;
            Complement = complement;
            City = city;
            State = state;
        }

        public string ZipCode { get; private set; }
        public string Street { get; private set; }
        public int Number { get; private set; }
        public string Complement { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }


        public void SetAddress(string newZipCode, string newStreet, int newNumber, string newComplement, string newCity, string newState)
        {
            ZipCode = newZipCode;
            Street = newStreet;
            Number = newNumber;
            Complement = newComplement;
            City = newCity;
            State = newState;

        }

        public override bool Validate()
        {
            var contracts = new ContractValidations<DeliveryAddress>()
                   .ZipCodeIsOk(ZipCode, 8, 8, "Informe o CEP com 8 digitos", "Cep localidade");


            return contracts.IsValid();
        }
    }
}
