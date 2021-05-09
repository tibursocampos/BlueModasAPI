using BlueModas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueModas.Persistence.Mappings
{
    public abstract class EntityTypeConfigurationGeneric<T> : IEntityTypeConfiguration<T> where T : Entity
    {
        protected abstract string TableName { get; }

        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            foreach (var prop in typeof(T).GetProperties())
            {
                if (prop.PropertyType == typeof(string))
                {
                    builder.Property(prop.PropertyType, prop.Name).HasMaxLength(70);
                }
            }

            builder
                .ToTable(TableName)
                .HasKey(x => x.Id);
            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
