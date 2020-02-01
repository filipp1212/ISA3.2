using ISA3.Data.ContactMechanism;
using ISA3.Data.Country;
using ISA3.Data.Order;
using ISA3.Data.Party;
using ISA3.Data.Shipment;
using ISA3.Infra.Common;
using Microsoft.EntityFrameworkCore;

namespace ISA3.Infra
{
    public class GateAccountingDbContext : BaseGateAccountingDbContext<GateAccountingDbContext>
    {
        public GateAccountingDbContext(DbContextOptions<GateAccountingDbContext> options) : base(options) { }

        public DbSet<IncomingShipmentData> IncomingShipments { get; set; }
        public DbSet<OutgoingShipmentData> OutgoingShipments { get; set; }
        public DbSet<OrganizationData> Organization { get; set; }
        public DbSet<PersonData> Person { get; set; }
        public DbSet<OrderItemData> OrderItem { get; set; }
        //public DbSet<ShipmentType> Shipment

        public DbSet<PartyRoleData> PartyRole { get; set; }
        public DbSet<ContactMechanismData> ContactMechanism { get; set; }
        public DbSet<OrderOrderItemData> OrderOrderItem { get; set; }
        public DbSet<CountryData> Countries { get; set; }
        public DbSet<OrderData> Order { get; set; }
        public DbSet<PartyData> Party { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            createIncomingShipmentTable(builder);
            createOutgoingShipmentTable(builder);
            createParty_PartyRoleTable(builder);
            createOrderOrderItemTable(builder);
            createContactMechanismTable(builder);
            createOrganizationTable(builder);
            createPersonTable(builder);
            createPostalAddressTable(builder);

            builder.Entity<OrderData>().ToTable("OrderData"); 
            builder.Entity<OrderItemData>().ToTable("OrderItemData");
            builder.Entity<CountryData>().ToTable("CountryData");
            builder.Entity<PartyRoleData>().ToTable("PartyRoleData");
        }
        public static void createIncomingShipmentTable(ModelBuilder b)
        {
            const string table = "IncomingShipmentData";
            createPrimaryKey<IncomingShipmentData>(b, table, a => new { a.Id });
            createForeignKey<IncomingShipmentData, OrderData>(b, x => x.OrderId, y => y.Order);
            createForeignKey<IncomingShipmentData, CountryData>(b, x => x.CountryId, y => y.Country);
            createForeignKey<IncomingShipmentData, OrganizationData>(b, x => x.ShippingCompanyId, y => y.ShippingCompany);
            createForeignKey<IncomingShipmentData, OrganizationData>(b, x => x.TransportCompanyId, y => y.TransportCompany);
        }
        public static void createOutgoingShipmentTable(ModelBuilder b)
        {
            const string table = "OutgoingShipmentData";
            createPrimaryKey<OutgoingShipmentData>(b, table, a => new { a.Id });
            createForeignKey<OutgoingShipmentData, OrderData>(b, x => x.OrderId, y => y.Order);
            createForeignKey<OutgoingShipmentData, CountryData>(b, x => x.CountryId, y => y.Country);
            createForeignKey<OutgoingShipmentData, OrganizationData>(b, x => x.ShippingCompanyId, y => y.ShippingCompany);
            createForeignKey<OutgoingShipmentData, OrganizationData>(b, x => x.TransportCompanyId, y => y.TransportCompany);
        }

        //public static void createPartyTable(ModelBuilder b)
        //{
        //    const string table = "Parties";
        //    createPrimaryKey<PartyData>(b, table, a => new { a.Id });
        //}



        public static void createContactMechanismTable(ModelBuilder b)
        {
            const string table = "ContactMechanismData";
            createPrimaryKey<ContactMechanismData>(b, table, a => new { a.Id });
            createForeignKey<ContactMechanismData, PostalAddressData>(b, x => x.PostalAddressId, y => y.PostalAddress);
            createForeignKey<ContactMechanismData, ElectronicAddressData>(b, x => x.ElectronicAddressId, y => y.ElectronicAddress);
            createForeignKey<ContactMechanismData, TelecommunicationsNumber>(b, x => x.TelecommunicationsNumberId, y => y.TelecommunicationsNumber);
        }
        public static void createPostalAddressTable(ModelBuilder b)
        {
            const string table = "PostalAddressData";
            createPrimaryKey<PostalAddressData>(b, table, a => new { a.Id });
            createForeignKey<PostalAddressData, CountryData>(b, x => x.CountryId, y => y.Country);
        }

        public static void createOrganizationTable(ModelBuilder b)
        {
            const string table = "OrganizationData";
            createPrimaryKey<OrganizationData>(b, table, a => new { a.Id });
            createForeignKey<OrganizationData, PartyData>(b, x => x.PartyId, y => y.Party);
        }
        public static void createPersonTable(ModelBuilder b)
        {
            const string table = "PersonData";
            createPrimaryKey<PersonData>(b, table, a => new { a.Id });
            createForeignKey<PersonData, PartyData>(b, x => x.PartyId, y => y.Party);
        }

        public static void createParty_PartyRoleTable(ModelBuilder b)
        {
            const string table = "Party_PartyRolesData";
            createPrimaryKey<PartyPartyRole>(b, table, a => new { a.Id, a.PartyRoleId, a.PartyId });
            createForeignKey<PartyPartyRole, PartyData>(b, x => x.PartyId, y => y.Party);
            createForeignKey<PartyPartyRole, PartyRoleData>(b, x => x.PartyRoleId, y => y.Role);
        }

        public static void createOrderOrderItemTable(ModelBuilder b)
        {
            const string table = "Order_OrderItemData";
            createPrimaryKey<OrderOrderItemData>(b, table, a => new { a.Id, a.OrderId, a.OrderItemId });
            createForeignKey<OrderOrderItemData, OrderItemData>(b, x => x.OrderItemId, y => y.OrderItem);
            createForeignKey<OrderOrderItemData, OrderData>(b, x => x.OrderId, y => y.Order);
        }



    }
}
