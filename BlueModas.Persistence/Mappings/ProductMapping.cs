using BlueModas.Domain.Entities;
using BlueModas.Domain.Enumerators;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueModas.Persistence.Mappings
{
    public class ProductMapping : EntityTypeConfigurationGeneric<Product>
    {
        protected override string TableName { get; } = nameof(Product);

        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Category).IsRequired();
            builder.Property(p => p.Size).IsRequired();
            builder.Property(p => p.Amount).IsRequired();

            builder.HasData(new Product(1, "Camiseta Preta", "Camiseta casual com tecido leve", 20.50, CategoryEnum.TShirt, SizeEnum.G, Gender.Male, 100));
            builder.HasData(new Product(2, "Camiseta Preta", "Camiseta casual com tecido leve", 25.00, CategoryEnum.TShirt, SizeEnum.M, Gender.Female, 100));
            builder.HasData(new Product(3, "Camiseta Vermelha", "Camiseta casual com tecido leve", 30.00, CategoryEnum.TShirt, SizeEnum.G, Gender.Male, 100));
            builder.HasData(new Product(4, "Camiseta Rosa", "Camiseta casual com tecido leve", 30.00, CategoryEnum.TShirt, SizeEnum.P, Gender.Female, 100));
            builder.HasData(new Product(5, "Camisa Preta", "Camisa social de algodão", 60.00, CategoryEnum.Shirt, SizeEnum.GG, Gender.Male, 100));
            builder.HasData(new Product(6, "Camisa Preta", "Camisa social de algodão", 60.00, CategoryEnum.Shirt, SizeEnum.G, Gender.Male, 100));
            builder.HasData(new Product(7, "Calça Branca", "Calça jeans", 110.50, CategoryEnum.Pants, SizeEnum.M, Gender.Female, 100));
            builder.HasData(new Product(8, "Calça Preta", "Calça jeans", 110.50, CategoryEnum.Pants, SizeEnum.G, Gender.Male, 100));
            builder.HasData(new Product(9, "Bermuda Azul", "Bermuda jeans", 40.00, CategoryEnum.Shorts, SizeEnum.G, Gender.Female, 100));
            builder.HasData(new Product(10, "Bermuda Preta", "Bermuda tactel", 30.00, CategoryEnum.Shorts, SizeEnum.GG, Gender.Male, 100));
        }
    }
}
