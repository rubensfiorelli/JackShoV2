using JackShopV2.Core.Validations.Contract;
using JackShopV2.Core.Validations.Interfaces;

namespace JackShopV2.Core.Entities
{
    public sealed class Catalog : BaseEntity, IContract
    {
        public Catalog(string title,
                       string description,
                       decimal fixedFreight,
                       decimal pricePerKg,
                       decimal price) : base()
        {
            Title = title;
            Description = description;
            FixedFreight = fixedFreight;
            PricePerKg = pricePerKg;
            Price = price;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal FixedFreight { get; private set; }
        public decimal PricePerKg { get; private set; }
        public decimal Price { get; private set; }

        public override bool Validate()
        {
            var contracts = new ContractValidations<Catalog>()
                    .TitleIsOk(Title, 3, 15, "O nome precisa ter entre 3 e 15 caracteres", "Nome do produto")
                    .DescriptionIsOk(Description, 10, 300, "A descricao precisa ter o minimo de 10 caracteres", nameof(Description))
                    .FreightValidation(FixedFreight, "O valor nao pode ser negativo", "Frete Fixo")
                    .PricePerKgValidation(PricePerKg, "O valor nao pode ser negativo", "Preco por Kg")
                    .PricePerKgValidation(Price, "O valor nao pode ser negativo", "Preco produto");

            return contracts.IsValid();
        }
    }
}
