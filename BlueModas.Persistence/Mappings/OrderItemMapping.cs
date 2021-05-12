using BlueModas.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueModas.Persistence.Mappings
{
    public class OrderItemMapping : EntityTypeConfigurationGeneric<OrderItem>
    {
        protected override string TableName { get; } = nameof(OrderItem);

        public override void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            base.Configure(builder);

        }
    }
}
