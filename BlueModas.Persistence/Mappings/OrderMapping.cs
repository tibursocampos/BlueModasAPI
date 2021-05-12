using BlueModas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BlueModas.Persistence.Mappings
{
    public class OrderMapping : EntityTypeConfigurationGeneric<Order>
    {
        protected override string TableName { get; } = nameof(Order);

        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.OrderItems).WithOne(x => x.Order).HasForeignKey(x => x.OrderId);
            
        }
    }
}
