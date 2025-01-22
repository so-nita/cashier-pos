using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CashierPOS.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Code = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Contact = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    CompanyId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    CustomerTypeCode = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    EarningPoint = table.Column<int>(type: "int", nullable: true),
                    EarningAmount = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Address = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Gender = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    Nationality = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Code = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NameKh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiscountTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    StartAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRates",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Value = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Last_Updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Currency = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    PaymentCode = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReasonRefundTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Code = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReasonRefundTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReasonTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Reason_Type = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReasonTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Desctiption = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Code = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NameKh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Contact = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false),
                    System_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Image = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    Website = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true),
                    Exchange_Rate = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    SaleExchangeRate = table.Column<decimal>(type: "decimal(8,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_SystemTypes_System_Id",
                        column: x => x.System_Id,
                        principalTable: "SystemTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CompanyId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Status = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Divisions_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    UserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Contact = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false),
                    Image = table.Column<string>(type: "varchar(550)", maxLength: 550, nullable: true),
                    Company_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    User_Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Companies_Company_Id",
                        column: x => x.Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "varchar(556)", maxLength: 556, nullable: true),
                    DivisionId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturnOrders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    ShiftId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    InvoiceNo = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Sub_Total = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Total_Discount = table.Column<decimal>(type: "decimal(10,4)", nullable: true),
                    Grand_Total = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    ReturnReasonCode = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ApprovedBy = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    ApprovedByUserName = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnOrders_Users_ApprovedBy",
                        column: x => x.ApprovedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PosId = table.Column<int>(type: "int", nullable: false),
                    User_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    User_Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    User_Role = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Action = table.Column<int>(type: "int", nullable: false),
                    LoginAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    LogoutAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLogs_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "varchar(550)", maxLength: 550, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuId = table.Column<string>(type: "varchar(36)", nullable: true),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReturnOrderDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    ReturnId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    ProductId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Sub_Amount = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ProductCode = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Discount_Percent = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    Discount_Amount = table.Column<decimal>(type: "decimal(10,4)", nullable: true),
                    Total_Discount = table.Column<decimal>(type: "decimal(10,4)", nullable: true),
                    Reason_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnOrderDetails_ReturnOrders_ReturnId",
                        column: x => x.ReturnId,
                        principalTable: "ReturnOrders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChangeShifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pos_Id = table.Column<int>(type: "int", nullable: false),
                    UserLogId = table.Column<int>(type: "int", nullable: false),
                    Start_Shift = table.Column<DateTime>(type: "datetime", nullable: false),
                    End_Shift = table.Column<DateTime>(type: "datetime", nullable: true),
                    Start_Balance = table.Column<decimal>(type: "decimal(8,4)", nullable: false),
                    Start_Balance_Kh = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    End_Balance = table.Column<decimal>(type: "decimal(12,4)", nullable: true),
                    Total_Sale = table.Column<decimal>(type: "decimal(12,4)", nullable: true),
                    Total_Discount = table.Column<decimal>(type: "decimal(8,4)", nullable: true),
                    Total_Tax = table.Column<decimal>(type: "decimal(8,4)", nullable: true),
                    Total_Changed = table.Column<decimal>(type: "decimal(8,4)", nullable: true),
                    Net_Sale = table.Column<decimal>(type: "decimal(12,4)", nullable: true),
                    Change_Shift_By = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Company_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Company_Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Print_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Shift_Status = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeShifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChangeShifts_Companies_Company_Id",
                        column: x => x.Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChangeShifts_UserLogs_UserLogId",
                        column: x => x.UserLogId,
                        principalTable: "UserLogs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChangeShifts_Users_Change_Shift_By",
                        column: x => x.Change_Shift_By,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "varchar(550)", maxLength: 550, nullable: true),
                    Main_Category_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Company_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_Main_Category_Id",
                        column: x => x.Main_Category_Id,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChangeShiftDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    ChangeShift_Id = table.Column<int>(type: "int", nullable: false),
                    PaymentMethod_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeShiftDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChangeShiftDetails_ChangeShifts_ChangeShift_Id",
                        column: x => x.ChangeShift_Id,
                        principalTable: "ChangeShifts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChangeShiftDetails_PaymentMethods_PaymentMethod_Id",
                        column: x => x.PaymentMethod_Id,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Sub_Total = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Total_Discount = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Grand_Total = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    ShiftId = table.Column<int>(type: "int", nullable: false),
                    ExchangeRate = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Reference_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Company_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Tax = table.Column<decimal>(type: "decimal(8,4)", nullable: true),
                    Order_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Order_Status = table.Column<string>(type: "varchar(50)", nullable: false),
                    ReasonTypeId = table.Column<string>(type: "varchar(36)", nullable: true),
                    Cancelled_At = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Received = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    ReceivedKh = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    Remaining = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    RemainingKh = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    Change = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    ChangeKh = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    PaymentTypeCode = table.Column<string>(type: "varchar(36)", nullable: true),
                    SellType = table.Column<string>(type: "varchar(36)", nullable: true),
                    CustomerId = table.Column<string>(type: "varchar(36)", nullable: true),
                    CustomerType = table.Column<string>(type: "varchar(36)", nullable: true),
                    PaymentMethodId = table.Column<string>(type: "varchar(36)", nullable: true),
                    Delivery = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    DataSource = table.Column<string>(type: "varchar(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_ChangeShifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "ChangeShifts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Users_Reference_Id",
                        column: x => x.Reference_Id,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Code = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NameKh = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Create_By = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Company_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Category_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Brand = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Image = table.Column<string>(type: "varchar(550)", maxLength: 550, nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Tax = table.Column<int>(type: "int", nullable: false),
                    ExpiredDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Companies_Company_Id",
                        column: x => x.Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "SubCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Users_Create_By",
                        column: x => x.Create_By,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderPayments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    DiscountName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Total = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Total_Kh = table.Column<decimal>(type: "decimal(12,0)", nullable: false),
                    Received = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    ReceivedKh = table.Column<decimal>(type: "decimal(12,0)", nullable: true),
                    Remaining = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    RemainingKh = table.Column<decimal>(type: "decimal(12,0)", nullable: true),
                    Change = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    ChangeKh = table.Column<decimal>(type: "decimal(12,0)", nullable: true),
                    Exchange_Rate = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Reference = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Transaction_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    PaymentTypeName = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    PaymentCode = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    PaymentTypeId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    PaymentMethodId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    SourceId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    CustomerTypeId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    CustomerCode = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderPayments_CustomerTypes_CustomerTypeId",
                        column: x => x.CustomerTypeId,
                        principalTable: "CustomerTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderPayments_Orders_Order_Id",
                        column: x => x.Order_Id,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderPayments_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderPayments_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderPayments_Users_Reference",
                        column: x => x.Reference,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SellInvoices",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    InvoiceNo = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    OrderId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    ShiftId = table.Column<int>(type: "int", nullable: false),
                    PrintDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: true),
                    OrderReturnId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    OldInvoiceNo = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellInvoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SellInvoices_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Order_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Product_Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Product_Code = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Discount_Percent = table.Column<decimal>(type: "decimal(8,4)", nullable: true),
                    Discount_Amount = table.Column<decimal>(type: "decimal(10,4)", nullable: true),
                    Total_Discount = table.Column<decimal>(type: "decimal(10,4)", nullable: true),
                    Sub_Amount = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Grand_Amount = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Status = table.Column<string>(type: "varchar(30)", nullable: false),
                    ReasonId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    TaxType = table.Column<int>(type: "int", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime", nullable: false),
                    SynData_At = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_Order_Id",
                        column: x => x.Order_Id,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductDiscounts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    ProductId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    DiscountId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Description = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDiscounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDiscounts_DiscountTypes_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "DiscountTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductDiscounts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SellInvoiceDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    InvoiceId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    InvoiceNo = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    PrintDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ByUserId = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    PosId = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellInvoiceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SellInvoiceDetails_SellInvoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "SellInvoices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brands_Name",
                table: "Brands",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_MenuId",
                table: "Categories",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChangeShiftDetails_ChangeShift_Id",
                table: "ChangeShiftDetails",
                column: "ChangeShift_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ChangeShiftDetails_PaymentMethod_Id",
                table: "ChangeShiftDetails",
                column: "PaymentMethod_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ChangeShifts_Change_Shift_By",
                table: "ChangeShifts",
                column: "Change_Shift_By");

            migrationBuilder.CreateIndex(
                name: "IX_ChangeShifts_Company_Id",
                table: "ChangeShifts",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ChangeShifts_UserLogId",
                table: "ChangeShifts",
                column: "UserLogId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_System_Id",
                table: "Companies",
                column: "System_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Contact",
                table: "Customers",
                column: "Contact",
                unique: true,
                filter: "[Contact] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Divisions_CompanyId",
                table: "Divisions",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_DivisionId",
                table: "Menu",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Order_Id",
                table: "OrderDetails",
                column: "Order_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Product_Id",
                table: "OrderDetails",
                column: "Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPayments_Code",
                table: "OrderPayments",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderPayments_CustomerTypeId",
                table: "OrderPayments",
                column: "CustomerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPayments_Order_Id",
                table: "OrderPayments",
                column: "Order_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPayments_PaymentTypeId",
                table: "OrderPayments",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPayments_Reference",
                table: "OrderPayments",
                column: "Reference");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPayments_SourceId",
                table: "OrderPayments",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Reference_Id",
                table: "Orders",
                column: "Reference_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShiftId",
                table: "Orders",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_PaymentCode",
                table: "PaymentTypes",
                column: "PaymentCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductDiscounts_DiscountId",
                table: "ProductDiscounts",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDiscounts_ProductId",
                table: "ProductDiscounts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category_Id",
                table: "Products",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Code",
                table: "Products",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Company_Id",
                table: "Products",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Create_By",
                table: "Products",
                column: "Create_By");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrderDetails_ReturnId",
                table: "ReturnOrderDetails",
                column: "ReturnId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnOrders_ApprovedBy",
                table: "ReturnOrders",
                column: "ApprovedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SellInvoiceDetails_InvoiceId",
                table: "SellInvoiceDetails",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SellInvoices_InvoiceNo",
                table: "SellInvoices",
                column: "InvoiceNo");

            migrationBuilder.CreateIndex(
                name: "IX_SellInvoices_OrderId",
                table: "SellInvoices",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_Main_Category_Id",
                table: "SubCategories",
                column: "Main_Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogs_User_Id",
                table: "UserLogs",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Company_Id",
                table: "Users",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "ChangeShiftDetails");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ExchangeRates");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OrderPayments");

            migrationBuilder.DropTable(
                name: "ProductDiscounts");

            migrationBuilder.DropTable(
                name: "ReasonRefundTypes");

            migrationBuilder.DropTable(
                name: "ReasonTypes");

            migrationBuilder.DropTable(
                name: "ReturnOrderDetails");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SellInvoiceDetails");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "CustomerTypes");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropTable(
                name: "DiscountTypes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ReturnOrders");

            migrationBuilder.DropTable(
                name: "SellInvoices");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ChangeShifts");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "UserLogs");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "SystemTypes");
        }
    }
}
