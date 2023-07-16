using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageList = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserModifyId = table.Column<int>(type: "int", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flavour",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    ImageList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserModifyId = table.Column<int>(type: "int", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flavour", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    FilePath = table.Column<string>(type: "text", nullable: true),
                    OrgFileName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserModifyId = table.Column<int>(type: "int", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    AccessType = table.Column<byte>(type: "tinyint", nullable: true),
                    ImageList = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserModifyId = table.Column<int>(type: "int", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecipeFlavour",
                columns: table => new
                {
                    FlavourId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserModifyId = table.Column<int>(type: "int", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeFlavour", x => new { x.RecipeId, x.FlavourId });
                    table.ForeignKey(
                        name: "FK_RecipeFlavour_Flavour_FlavourId",
                        column: x => x.FlavourId,
                        principalTable: "Flavour",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeFlavour_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Budget",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Balance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budget", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    BudgetId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserModifyId = table.Column<int>(type: "int", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAccount_Budget_BudgetId",
                        column: x => x.BudgetId,
                        principalTable: "Budget",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FeedBack",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "ntext", maxLength: 200, nullable: false),
                    Star = table.Column<byte>(type: "tinyint", nullable: true),
                    ImageList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: true),
                    RecipeId = table.Column<int>(type: "int", nullable: true),
                    UserAccountId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserModifyId = table.Column<int>(type: "int", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedBack_UserAccount_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "UserAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    PayingOption = table.Column<byte>(type: "tinyint", nullable: false),
                    Note = table.Column<string>(type: "ntext", maxLength: 200, nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: true),
                    UserAccountId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserModifyId = table.Column<int>(type: "int", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_UserAccount_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "UserAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    PayingOption = table.Column<byte>(type: "tinyint", nullable: false),
                    Note = table.Column<string>(type: "ntext", maxLength: 200, nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    UserAccountId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserModifyId = table.Column<int>(type: "int", nullable: true),
                    UserCreatedId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderHistory_UserAccount_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "UserAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ImageList = table.Column<string>(type: "text", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderHistoryDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ImageList = table.Column<string>(type: "text", nullable: true),
                    OrderHistoryId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHistoryDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderHistoryDetail_OrderHistory_OrderHistoryId",
                        column: x => x.OrderHistoryId,
                        principalTable: "OrderHistory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Author", "CreatedAt", "Description", "ImageList", "Name", "Price", "Status", "UpdatedAt", "UserCreatedId", "UserModifyId" },
                values: new object[,]
                {
                    { 1, "Louis", new DateTime(2023, 7, 16, 20, 59, 19, 917, DateTimeKind.Local).AddTicks(9701), "Hello, My Name Is Ice Cream: The Art and Science of the Scoop: A Cookbook", null, "Hello, My Name Is Ice Cream: The Art and Science of the Scoop: A Cookbook", 500000.0, null, new DateTime(2023, 7, 16, 20, 59, 19, 917, DateTimeKind.Local).AddTicks(9727), 1, 1 },
                    { 2, "Hoang Cong Chien", new DateTime(2023, 7, 16, 20, 59, 19, 917, DateTimeKind.Local).AddTicks(9741), "Big Gay Ice Cream: Saucy Stories & Frozen Treats: Going All the Way with Ice Cream: A Cookbook", null, "Big Gay Ice Cream: Saucy Stories & Frozen Treats: Going All the Way with Ice Cream: A Cookbook", 700000.0, null, new DateTime(2023, 7, 16, 20, 59, 19, 917, DateTimeKind.Local).AddTicks(9742), 1, 1 },
                    { 3, "Nguyen Thi Hue", new DateTime(2023, 7, 16, 20, 59, 19, 917, DateTimeKind.Local).AddTicks(9747), "Gelupo Gelato: A delectable palette of ice cream recipes ", null, "Gelupo Gelato: A delectable palette of ice cream recipes", 1000000.0, null, new DateTime(2023, 7, 16, 20, 59, 19, 917, DateTimeKind.Local).AddTicks(9749), 1, 1 },
                    { 4, "Louis", new DateTime(2023, 7, 16, 20, 59, 19, 917, DateTimeKind.Local).AddTicks(9914), "Salt & Straw Ice Cream Cookbook", null, "Salt & Straw Ice Cream Cookbook", 800000.0, null, new DateTime(2023, 7, 16, 20, 59, 19, 917, DateTimeKind.Local).AddTicks(9917), 1, 1 },
                    { 5, "Louis", new DateTime(2023, 7, 16, 20, 59, 19, 917, DateTimeKind.Local).AddTicks(9924), "Food52 Ice Cream and Friends: 60 Recipes and Riffs", null, "Food52 Ice Cream and Friends: 60 Recipes and Riffs", 300000.0, null, new DateTime(2023, 7, 16, 20, 59, 19, 917, DateTimeKind.Local).AddTicks(9926), 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Flavour",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageList", "Name", "Status", "UpdatedAt", "UserCreatedId", "UserModifyId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(8980), "Vanilla", null, "Vanilla", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(8982), 1, 1 },
                    { 2, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(8990), "Chocolate", null, "Chocolate", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(8991), 1, 1 },
                    { 3, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(8996), "Chocolate chip", null, "Chocolate chip", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(8997), 1, 1 },
                    { 4, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9012), "Strawberry", null, "Strawberry", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9014), 1, 1 },
                    { 5, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9020), "Mango", null, "Mango", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9028), 1, 1 },
                    { 6, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9062), "Coffee", null, "Coffee", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9064), 1, 1 },
                    { 7, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9069), "Black currant", null, "Black currant", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9071), 1, 1 },
                    { 8, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9075), "Cherry", null, "Cherry", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9077), 1, 1 },
                    { 9, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9082), "Butterscotch", null, "Butterscotch", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9084), 1, 1 },
                    { 10, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9093), "Walnut", null, "Walnut", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9095), 1, 1 },
                    { 11, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9438), "Vanilla and strawberry (two in one)", null, "Vanilla and strawberry (two in one)", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9441), 1, 1 },
                    { 12, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9447), "Pistachio", null, "Pistachio", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9449), 1, 1 },
                    { 13, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9454), "Banana", null, "Banana", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9456), 1, 1 },
                    { 14, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9460), "Banana Chocolate chip", null, "Banana Chocolate chip", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9462), 1, 1 },
                    { 15, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9467), "Chocolate almond", null, "Chocolate almond", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9469), 1, 1 },
                    { 16, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9473), "Chocolate truffle", null, "Chocolate truffle", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9475), 1, 1 },
                    { 17, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9480), "Kiwi fruit", null, "Kiwi fruit", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9482), 1, 1 },
                    { 18, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9493), "Pineapple", null, "Pineapple", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9496), 1, 1 },
                    { 19, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9500), "Fruit and nut", null, "Fruit and nut", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9502), 1, 1 },
                    { 20, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9507), "Cashew Caramel crunch", null, "Cashew Caramel crunch", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9509), 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "AccessType", "CreatedAt", "Description", "ImageList", "Name", "Status", "UpdatedAt", "UserCreatedId", "UserModifyId" },
                values: new object[,]
                {
                    { 1, (byte)0, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(8878), "Classic Custard Ice Cream Base", null, "Classic Custard Ice Cream Base", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(8904), 1, 1 },
                    { 2, (byte)0, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(8927), "Simple Vanila Ice Cream", null, "Simple Vanila Ice Cream", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(8928), 1, 1 },
                    { 3, (byte)1, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(8934), "Cookie Monster Ice Cream", null, "Cookie Monster Ice Cream", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(8937), 1, 1 },
                    { 4, (byte)1, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(8943), "Salted Caramel Ice Cream", null, "Salted Caramel Ice Cream", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(8945), 1, 1 },
                    { 5, (byte)1, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(8952), "Strawberry Shortcake Ice Cream", null, "Strawberry Shortcake Ice Cream", null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(8954), 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserAccount",
                columns: new[] { "Id", "BudgetId", "CreatedAt", "Description", "Email", "Name", "Password", "PhoneNumber", "Status", "Type", "UpdatedAt", "UserCreatedId", "UserModifyId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9521), "Hello, I'm Louis Handsome", "duclongdo1997@gmail.com", "Louis", "25031997", "0375326233", null, (byte)1, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9522), 1, 1 },
                    { 2, null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9531), "TPM Hoang Cong Chien", "prolagicoanduockhong@gmail.com", "Hoang Cong Chien", "1", "1111111111", null, (byte)1, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9533), 1, 1 },
                    { 3, null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9538), "Hue xinh gai", "huenguyenthi@gmail.com", "Nguyen Thi Hue", "25031997", "2222222222", null, (byte)1, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9539), 1, 1 },
                    { 4, null, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9544), "Thao Muoi xinh gai dang yeu", "thuthaopham1998@gmail.com", "Thao Muoi", "14081998", "0365619881", null, (byte)2, new DateTime(2023, 7, 16, 20, 59, 19, 919, DateTimeKind.Local).AddTicks(9546), 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Budget",
                columns: new[] { "Id", "Balance", "UserId" },
                values: new object[] { 1, 1000000000000.0, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Book_Name",
                table: "Book",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Budget_UserId",
                table: "Budget",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FeedBack_UserAccountId",
                table: "FeedBack",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Flavour_Name",
                table: "Flavour",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserAccountId",
                table: "Order",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHistory_UserAccountId",
                table: "OrderHistory",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHistoryDetail_OrderHistoryId",
                table: "OrderHistoryDetail",
                column: "OrderHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_Name",
                table: "Recipe",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RecipeFlavour_FlavourId",
                table: "RecipeFlavour",
                column: "FlavourId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccount_BudgetId",
                table: "UserAccount",
                column: "BudgetId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccount_Email",
                table: "UserAccount",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAccount_PhoneNumber",
                table: "UserAccount",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Budget_UserAccount_UserId",
                table: "Budget",
                column: "UserId",
                principalTable: "UserAccount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Budget_UserAccount_UserId",
                table: "Budget");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "FeedBack");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "OrderHistoryDetail");

            migrationBuilder.DropTable(
                name: "RecipeFlavour");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "OrderHistory");

            migrationBuilder.DropTable(
                name: "Flavour");

            migrationBuilder.DropTable(
                name: "Recipe");

            migrationBuilder.DropTable(
                name: "UserAccount");

            migrationBuilder.DropTable(
                name: "Budget");
        }
    }
}
