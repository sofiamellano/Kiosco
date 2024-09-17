using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KioscoInformaticoBackend.Migrations
{
    /// <inheritdoc />
    public partial class agregadodeDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "localidades",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "San Justo" },
                    { 2, "Videla" },
                    { 3, "Escalada" }
                });

            migrationBuilder.InsertData(
                table: "productos",
                columns: new[] { "Id", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, "Coca Cola 2lts", 2650m },
                    { 2, "Sprite 2lts", 2450m },
                    { 3, "Fanta 2lts", 2550m }
                });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "Id", "Direccion", "FechaNacimiento", "LocalidadId", "Nombre", "Telefonos" },
                values: new object[,]
                {
                    { 1, "Calle Falsa 123", new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Juan Pérez", "123456789" },
                    { 2, "Avenida Siempre Viva 742", new DateTime(1990, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "María López", "987654321" },
                    { 3, "Boulevard de los Sueños Rotos 101", new DateTime(1978, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Carlos García", "555666777" },
                    { 4, "Ruta Nacional 19 Km 58", new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ana Martínez", "444555666" },
                    { 5, "Calle del Sol 456", new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Pedro Fernández", "333444555" }
                });

            migrationBuilder.InsertData(
                table: "detallescompras",
                columns: new[] { "Id", "Cantidad", "CompraId", "PrecioUnitario", "ProductoId" },
                values: new object[,]
                {
                    { 1, 1, 1, 2650m, 1 },
                    { 2, 2, 2, 2450m, 2 },
                    { 3, 1, 3, 2550m, 3 }
                });

            migrationBuilder.InsertData(
                table: "proveedores",
                columns: new[] { "Id", "Cbu", "CondicionIva", "Direccion", "LocalidadId", "Nombre", "Telefonos" },
                values: new object[,]
                {
                    { 1, "0000003100010000000001", 0, "Calle 1", 1, "Proveedor A", "111111111" },
                    { 2, "0000003100010000000002", 5, "Calle 2", 2, "Proveedor B", "222222222" },
                    { 3, "0000003100010000000003", 4, "Calle 3", 3, "Proveedor C", "333333333" },
                    { 4, "0000003100010000000004", 2, "Calle 4", 1, "Proveedor D", "444444444" },
                    { 5, "0000003100010000000005", 3, "Calle 5", 1, "Proveedor E", "555555555" },
                    { 6, "0000003100010000000006", 1, "Calle 6", 2, "Proveedor F", "666666666" },
                    { 7, "0000003100010000000007", 0, "Calle 7", 2, "Proveedor G", "777777777" },
                    { 8, "0000003100010000000008", 6, "Calle 8", 3, "Proveedor H", "888888888" },
                    { 9, "0000003100010000000009", 5, "Calle 9", 3, "Proveedor I", "999999999" },
                    { 10, "0000003100010000000010", 2, "Calle 10", 1, "Proveedor J", "101010101" }
                });

            migrationBuilder.InsertData(
                table: "compras",
                columns: new[] { "ID", "Fecha", "FormaDePago", "Iva", "ProveedorID", "Total" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 21, 1, 1000 },
                    { 2, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 10, 2, 2000 },
                    { 3, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5, 3, 3000 },
                    { 4, new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 4, 4000 }
                });

            migrationBuilder.InsertData(
                table: "ventas",
                columns: new[] { "Id", "ClienteId", "Fecha", "FormaPago", "Iva", "Total" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 6, 14, 25, 11, 254, DateTimeKind.Local).AddTicks(2179), 0, 21m, 3000m },
                    { 2, 2, new DateTime(2024, 9, 6, 14, 25, 11, 254, DateTimeKind.Local).AddTicks(2193), 1, 10m, 5000m },
                    { 3, 1, new DateTime(2024, 9, 6, 14, 25, 11, 254, DateTimeKind.Local).AddTicks(2194), 2, 21m, 8000m }
                });

            migrationBuilder.InsertData(
                table: "detallesventas",
                columns: new[] { "Id", "Cantidad", "PrecioUnitario", "ProductoId", "VentaId" },
                values: new object[,]
                {
                    { 1, 1, 2650m, 1, 1 },
                    { 2, 2, 2450m, 2, 2 },
                    { 3, 1, 2550m, 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "compras",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "compras",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "compras",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "compras",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "detallescompras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "detallescompras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "detallescompras",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "detallesventas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "detallesventas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "detallesventas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "proveedores",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "proveedores",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "proveedores",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "proveedores",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "proveedores",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "proveedores",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "productos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "productos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "productos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "proveedores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "proveedores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "proveedores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "proveedores",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ventas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ventas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ventas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "localidades",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "localidades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "localidades",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
