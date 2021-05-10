using BlueModas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BlueModas.Persistence.Mappings
{
    public class CartMapping : EntityTypeConfigurationGeneric<Cart>
    {
        protected override string TableName { get; } = nameof(Cart);

        public override void Configure(EntityTypeBuilder<Cart> builder)
        {
            base.Configure(builder);
            builder.HasOne(o => o.Order).WithOne(c => c.Cart).HasForeignKey<Order>(o => o.CartId);
        }
    }
}
