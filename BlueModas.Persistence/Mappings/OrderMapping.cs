﻿using BlueModas.Domain.Entities;
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
            builder.HasOne(o => o.Client).WithMany(c => c.Orders).HasForeignKey(o => o.ClientId);
            builder.HasMany(o => o.Carts).WithOne(cart => cart.Order).HasForeignKey(cart => cart.OrderId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
