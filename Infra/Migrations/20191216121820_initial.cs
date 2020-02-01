using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ISA3.Infra.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountryData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElectronicAddressData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectronicAddressData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ContentsDescription = table.Column<string>(nullable: true),
                    TotalOrderValue = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItemData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    OrderItemSeqId = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    ShippingInstructions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItemData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PartyRoleData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    RoleType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyRoleData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TelecommunicationsNumber",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    TelNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelecommunicationsNumber", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostalAddressData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: true),
                    Building = table.Column<string>(nullable: true),
                    Apartment = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    CountryId = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostalAddressData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostalAddressData_CountryData_CountryId",
                        column: x => x.CountryId,
                        principalTable: "CountryData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order_OrderItemData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    OrderId = table.Column<string>(nullable: false),
                    OrderItemId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_OrderItemData", x => new { x.Id, x.OrderId, x.OrderItemId });
                    table.ForeignKey(
                        name: "FK_Order_OrderItemData_OrderData_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_OrderItemData_OrderItemData_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItemData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactMechanismData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PostalAddressId = table.Column<string>(nullable: true),
                    ElectronicAddressId = table.Column<string>(nullable: true),
                    TelecommunicationsNumberId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMechanismData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactMechanismData_ElectronicAddressData_ElectronicAddressId",
                        column: x => x.ElectronicAddressId,
                        principalTable: "ElectronicAddressData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContactMechanismData_PostalAddressData_PostalAddressId",
                        column: x => x.PostalAddressId,
                        principalTable: "PostalAddressData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContactMechanismData_TelecommunicationsNumber_TelecommunicationsNumberId",
                        column: x => x.TelecommunicationsNumberId,
                        principalTable: "TelecommunicationsNumber",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Party",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ContactMechanismId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Party", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Party_ContactMechanismData_ContactMechanismId",
                        column: x => x.ContactMechanismId,
                        principalTable: "ContactMechanismData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PartyId = table.Column<string>(nullable: true),
                    OrganizationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationData_Party_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Party",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Party_PartyRolesData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PartyId = table.Column<string>(nullable: false),
                    PartyRoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Party_PartyRolesData", x => new { x.Id, x.PartyRoleId, x.PartyId });
                    table.ForeignKey(
                        name: "FK_Party_PartyRolesData_Party_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Party",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Party_PartyRolesData_PartyRoleData_PartyRoleId",
                        column: x => x.PartyRoleId,
                        principalTable: "PartyRoleData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PartyId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CurrentWorkTitle = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    IdentityCode = table.Column<string>(nullable: true),
                    NationalityId = table.Column<string>(nullable: true),
                    PartnerSince = table.Column<DateTime>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonData_Party_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Party",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IncomingShipmentData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    BillNumber = table.Column<long>(nullable: false),
                    CountryId = table.Column<string>(nullable: true),
                    DeliveryNumber = table.Column<long>(nullable: false),
                    ArrivalDate = table.Column<DateTime>(nullable: true),
                    EstimatedReadyDate = table.Column<DateTime>(nullable: true),
                    ShipmentReportCreationDate = table.Column<DateTime>(nullable: true),
                    LandCadastre = table.Column<string>(nullable: true),
                    OrderId = table.Column<string>(nullable: true),
                    ShippingCompanyId = table.Column<string>(nullable: true),
                    TransportCompanyId = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomingShipmentData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncomingShipmentData_CountryData_CountryId",
                        column: x => x.CountryId,
                        principalTable: "CountryData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IncomingShipmentData_OrderData_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IncomingShipmentData_OrganizationData_ShippingCompanyId",
                        column: x => x.ShippingCompanyId,
                        principalTable: "OrganizationData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IncomingShipmentData_OrganizationData_TransportCompanyId",
                        column: x => x.TransportCompanyId,
                        principalTable: "OrganizationData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutgoingShipmentData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    BillNumber = table.Column<long>(nullable: false),
                    CountryId = table.Column<string>(nullable: true),
                    DeliveryNumber = table.Column<long>(nullable: false),
                    ArrivalDate = table.Column<DateTime>(nullable: true),
                    EstimatedReadyDate = table.Column<DateTime>(nullable: true),
                    ShipmentReportCreationDate = table.Column<DateTime>(nullable: true),
                    LandCadastre = table.Column<string>(nullable: true),
                    OrderId = table.Column<string>(nullable: true),
                    ShippingCompanyId = table.Column<string>(nullable: true),
                    TransportCompanyId = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutgoingShipmentData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutgoingShipmentData_CountryData_CountryId",
                        column: x => x.CountryId,
                        principalTable: "CountryData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutgoingShipmentData_OrderData_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutgoingShipmentData_OrganizationData_ShippingCompanyId",
                        column: x => x.ShippingCompanyId,
                        principalTable: "OrganizationData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutgoingShipmentData_OrganizationData_TransportCompanyId",
                        column: x => x.TransportCompanyId,
                        principalTable: "OrganizationData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactMechanismData_ElectronicAddressId",
                table: "ContactMechanismData",
                column: "ElectronicAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactMechanismData_PostalAddressId",
                table: "ContactMechanismData",
                column: "PostalAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactMechanismData_TelecommunicationsNumberId",
                table: "ContactMechanismData",
                column: "TelecommunicationsNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomingShipmentData_CountryId",
                table: "IncomingShipmentData",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomingShipmentData_OrderId",
                table: "IncomingShipmentData",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomingShipmentData_ShippingCompanyId",
                table: "IncomingShipmentData",
                column: "ShippingCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomingShipmentData_TransportCompanyId",
                table: "IncomingShipmentData",
                column: "TransportCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderItemData_OrderId",
                table: "Order_OrderItemData",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderItemData_OrderItemId",
                table: "Order_OrderItemData",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationData_PartyId",
                table: "OrganizationData",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_OutgoingShipmentData_CountryId",
                table: "OutgoingShipmentData",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_OutgoingShipmentData_OrderId",
                table: "OutgoingShipmentData",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OutgoingShipmentData_ShippingCompanyId",
                table: "OutgoingShipmentData",
                column: "ShippingCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_OutgoingShipmentData_TransportCompanyId",
                table: "OutgoingShipmentData",
                column: "TransportCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Party_ContactMechanismId",
                table: "Party",
                column: "ContactMechanismId");

            migrationBuilder.CreateIndex(
                name: "IX_Party_PartyRolesData_PartyId",
                table: "Party_PartyRolesData",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_Party_PartyRolesData_PartyRoleId",
                table: "Party_PartyRolesData",
                column: "PartyRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonData_PartyId",
                table: "PersonData",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_PostalAddressData_CountryId",
                table: "PostalAddressData",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IncomingShipmentData");

            migrationBuilder.DropTable(
                name: "Order_OrderItemData");

            migrationBuilder.DropTable(
                name: "OutgoingShipmentData");

            migrationBuilder.DropTable(
                name: "Party_PartyRolesData");

            migrationBuilder.DropTable(
                name: "PersonData");

            migrationBuilder.DropTable(
                name: "OrderItemData");

            migrationBuilder.DropTable(
                name: "OrderData");

            migrationBuilder.DropTable(
                name: "OrganizationData");

            migrationBuilder.DropTable(
                name: "PartyRoleData");

            migrationBuilder.DropTable(
                name: "Party");

            migrationBuilder.DropTable(
                name: "ContactMechanismData");

            migrationBuilder.DropTable(
                name: "ElectronicAddressData");

            migrationBuilder.DropTable(
                name: "PostalAddressData");

            migrationBuilder.DropTable(
                name: "TelecommunicationsNumber");

            migrationBuilder.DropTable(
                name: "CountryData");
        }
    }
}
