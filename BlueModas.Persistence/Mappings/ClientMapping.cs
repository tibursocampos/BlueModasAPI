using BlueModas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BlueModas.Persistence.Mappings
{
    public class ClientMapping : EntityTypeConfigurationGeneric<Client>
    {
        protected override string TableName { get; } = nameof(Client);

        public override void Configure(EntityTypeBuilder<Client> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.Password).IsRequired();
            builder.Property(c => c.Phone).IsRequired();
            builder.HasMany(x => x.Orders).WithOne(x => x.Client).HasForeignKey(x => x.ClientId);


            builder.HasData(new Client(1, "Raphael", "raphael@teste.com", "123456", "(35) 98811-1492"));
            builder.HasData(new Client(2, "Antonella Sarah Cristiane Araújo", "aantonellasarahcristianearaujo@yahool.com", "123456", "(12) 99982-6766"));
            builder.HasData(new Client(3, "César Murilo Moreira", "cesarmurilomoreira..cesarmurilomoreira@ornatopresentes.com.br", "123456", "(82) 98635-7667"));
            builder.HasData(new Client(4, "Emanuelly Cláudia Dias", "emanuellyclaudiadias..emanuellyclaudiadias@osbocops.com", "123456", "(27) 98498-9488"));
            builder.HasData(new Client(5, "Ian Davi Daniel Farias", "iandavidanielfarias__iandavidanielfarias@silnave.com.br", "123456", "(21) 98907-0282"));
            builder.HasData(new Client(6, "Camila Teresinha da Mata", "camilateresinhadamata-72@bds.com.br", "123456", "(89) 98901-1497"));
        }
    }
}
