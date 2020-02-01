﻿// <auto-generated />
using System;
using ISA3.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ISA3.Infra.Migrations
{
    [DbContext(typeof(GateAccountingDbContext))]
    [Migration("20191216121820_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ISA3.Data.ContactMechanism.ContactMechanismData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ElectronicAddressId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PostalAddressId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TelecommunicationsNumberId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ElectronicAddressId");

                    b.HasIndex("PostalAddressId");

                    b.HasIndex("TelecommunicationsNumberId");

                    b.ToTable("ContactMechanismData");
                });

            modelBuilder.Entity("ISA3.Data.ContactMechanism.ElectronicAddressData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ElectronicAddressData");
                });

            modelBuilder.Entity("ISA3.Data.ContactMechanism.PostalAddressData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Apartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Building")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("PostalAddressData");
                });

            modelBuilder.Entity("ISA3.Data.ContactMechanism.TelecommunicationsNumber", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TelNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TelecommunicationsNumber");
                });

            modelBuilder.Entity("ISA3.Data.Country.CountryData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CountryData");
                });

            modelBuilder.Entity("ISA3.Data.Order.OrderData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ContentsDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalOrderValue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("OrderData");
                });

            modelBuilder.Entity("ISA3.Data.Order.OrderItemData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrderItemSeqId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShippingInstructions")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderItemData");
                });

            modelBuilder.Entity("ISA3.Data.Order.OrderOrderItemData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrderItemId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id", "OrderId", "OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("OrderItemId");

                    b.ToTable("Order_OrderItemData");
                });

            modelBuilder.Entity("ISA3.Data.Party.OrganizationData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrganizationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartyId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.ToTable("OrganizationData");
                });

            modelBuilder.Entity("ISA3.Data.Party.PartyData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ContactMechanismId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ContactMechanismId");

                    b.ToTable("Party");
                });

            modelBuilder.Entity("ISA3.Data.Party.PartyPartyRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PartyRoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PartyId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id", "PartyRoleId", "PartyId");

                    b.HasIndex("PartyId");

                    b.HasIndex("PartyRoleId");

                    b.ToTable("Party_PartyRolesData");
                });

            modelBuilder.Entity("ISA3.Data.Party.PartyRoleData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PartyRoleData");
                });

            modelBuilder.Entity("ISA3.Data.Party.PersonData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentWorkTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("IdentityCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PartnerSince")
                        .HasColumnType("datetime2");

                    b.Property<string>("PartyId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.ToTable("PersonData");
                });

            modelBuilder.Entity("ISA3.Data.Shipment.IncomingShipmentData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("BillNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("CountryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("DeliveryNumber")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("EstimatedReadyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LandCadastre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ShipmentReportCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShippingCompanyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TransportCompanyId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ShippingCompanyId");

                    b.HasIndex("TransportCompanyId");

                    b.ToTable("IncomingShipmentData");
                });

            modelBuilder.Entity("ISA3.Data.Shipment.OutgoingShipmentData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("BillNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("CountryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("DeliveryNumber")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("EstimatedReadyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LandCadastre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ShipmentReportCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShippingCompanyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TransportCompanyId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ShippingCompanyId");

                    b.HasIndex("TransportCompanyId");

                    b.ToTable("OutgoingShipmentData");
                });

            modelBuilder.Entity("ISA3.Data.ContactMechanism.ContactMechanismData", b =>
                {
                    b.HasOne("ISA3.Data.ContactMechanism.ElectronicAddressData", "ElectronicAddress")
                        .WithMany()
                        .HasForeignKey("ElectronicAddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ISA3.Data.ContactMechanism.PostalAddressData", "PostalAddress")
                        .WithMany()
                        .HasForeignKey("PostalAddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ISA3.Data.ContactMechanism.TelecommunicationsNumber", "TelecommunicationsNumber")
                        .WithMany()
                        .HasForeignKey("TelecommunicationsNumberId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ISA3.Data.ContactMechanism.PostalAddressData", b =>
                {
                    b.HasOne("ISA3.Data.Country.CountryData", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ISA3.Data.Order.OrderOrderItemData", b =>
                {
                    b.HasOne("ISA3.Data.Order.OrderData", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ISA3.Data.Order.OrderItemData", "OrderItem")
                        .WithMany()
                        .HasForeignKey("OrderItemId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ISA3.Data.Party.OrganizationData", b =>
                {
                    b.HasOne("ISA3.Data.Party.PartyData", "Party")
                        .WithMany()
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ISA3.Data.Party.PartyData", b =>
                {
                    b.HasOne("ISA3.Data.ContactMechanism.ContactMechanismData", "ContactMechanism")
                        .WithMany()
                        .HasForeignKey("ContactMechanismId");
                });

            modelBuilder.Entity("ISA3.Data.Party.PartyPartyRole", b =>
                {
                    b.HasOne("ISA3.Data.Party.PartyData", "Party")
                        .WithMany()
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ISA3.Data.Party.PartyRoleData", "Role")
                        .WithMany()
                        .HasForeignKey("PartyRoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ISA3.Data.Party.PersonData", b =>
                {
                    b.HasOne("ISA3.Data.Party.PartyData", "Party")
                        .WithMany()
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ISA3.Data.Shipment.IncomingShipmentData", b =>
                {
                    b.HasOne("ISA3.Data.Country.CountryData", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ISA3.Data.Order.OrderData", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ISA3.Data.Party.OrganizationData", "ShippingCompany")
                        .WithMany()
                        .HasForeignKey("ShippingCompanyId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ISA3.Data.Party.OrganizationData", "TransportCompany")
                        .WithMany()
                        .HasForeignKey("TransportCompanyId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ISA3.Data.Shipment.OutgoingShipmentData", b =>
                {
                    b.HasOne("ISA3.Data.Country.CountryData", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ISA3.Data.Order.OrderData", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ISA3.Data.Party.OrganizationData", "ShippingCompany")
                        .WithMany()
                        .HasForeignKey("ShippingCompanyId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ISA3.Data.Party.OrganizationData", "TransportCompany")
                        .WithMany()
                        .HasForeignKey("TransportCompanyId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
