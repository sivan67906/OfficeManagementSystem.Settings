using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Settings.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractPrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractNumberSeprator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractNumberDigits = table.Column<int>(type: "int", nullable: false),
                    ContractNumberExample = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencySymbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCryptocurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USDPrice = table.Column<int>(type: "int", nullable: false),
                    ExchangeRate = table.Column<int>(type: "int", nullable: false),
                    CurrencyPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThousandSeparator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecimalSeparator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberofDecimals = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomQuestionCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CQCategoryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CQCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomQuestionCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomQuestionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CQTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CQTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomQuestionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobApplicationCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JACategoryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JACategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplicationCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobApplicationPositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JAPositionCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JAPositionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplicationPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadAgents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadAgents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadSources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    source = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadSources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllowChatClientEmployee = table.Column<bool>(type: "bit", nullable: false),
                    All = table.Column<bool>(type: "bit", nullable: false),
                    OnlyProjectMembercanwithclient = table.Column<bool>(type: "bit", nullable: false),
                    Allowchatclientadmin = table.Column<bool>(type: "bit", nullable: false),
                    SoundNotifyAlert = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plannings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanPrice = table.Column<float>(type: "real", nullable: false),
                    Validity = table.Column<int>(type: "int", nullable: false),
                    Employee = table.Column<int>(type: "int", nullable: false),
                    Designation = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<int>(type: "int", nullable: false),
                    Company = table.Column<int>(type: "int", nullable: false),
                    Roles = table.Column<int>(type: "int", nullable: false),
                    Permission = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plannings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectReminderPersons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectReminderPersons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefaultStatus = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecruiterSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecruiterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecruiterStatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecruiterSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecruitFooterSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FooterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterSlug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterStatusId = table.Column<int>(type: "int", nullable: false),
                    FooterDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecruitFooterSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecruitGeneralSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralCompanyWebsite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralCompanyLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralCompanyLogoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralCompanyLogoImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralAboutCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralLegalTerm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralDuplJobApplnRestrictDays = table.Column<int>(type: "int", nullable: false),
                    GeneralOLReminderToCandidate = table.Column<int>(type: "int", nullable: false),
                    GeneralBGLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralBGLogoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralBGLogoImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralBGColorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralCBJsonSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecruitGeneralSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecruitNotificationSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CBEMailJsonSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CBEMailNotificationJsonSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecruitNotificationSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeforeXDate = table.Column<int>(type: "int", nullable: false),
                    SendReminderDueDate = table.Column<bool>(type: "bit", nullable: false),
                    AfterXDate = table.Column<int>(type: "int", nullable: false),
                    Statuss = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskboardLength = table.Column<int>(type: "int", nullable: false),
                    TaskCategory = table.Column<bool>(type: "bit", nullable: false),
                    Project = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<bool>(type: "bit", nullable: false),
                    DueDate = table.Column<bool>(type: "bit", nullable: false),
                    AssignedTo = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<bool>(type: "bit", nullable: false),
                    Label = table.Column<bool>(type: "bit", nullable: false),
                    AssignedBy = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Priority = table.Column<bool>(type: "bit", nullable: false),
                    MakePrivate = table.Column<bool>(type: "bit", nullable: false),
                    TimeEstimate = table.Column<bool>(type: "bit", nullable: false),
                    Comment = table.Column<bool>(type: "bit", nullable: false),
                    AddFile = table.Column<bool>(type: "bit", nullable: false),
                    SubTask = table.Column<bool>(type: "bit", nullable: false),
                    Timesheet = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<bool>(type: "bit", nullable: false),
                    History = table.Column<bool>(type: "bit", nullable: false),
                    HoursLogged = table.Column<bool>(type: "bit", nullable: false),
                    CustomFields = table.Column<bool>(type: "bit", nullable: false),
                    CopyTaskLink = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Taxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegnNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstablishedYear = table.Column<int>(type: "int", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessTypeId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_BusinessTypes_BusinessTypeId",
                        column: x => x.BusinessTypeId,
                        principalTable: "BusinessTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Companies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                    table.ForeignKey(
                        name: "FK_States_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultTimezone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatatableRowLimit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeCanExportData = table.Column<bool>(type: "bit", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RecruitCustomQuestionSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CQQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomQuestionTypeId = table.Column<int>(type: "int", nullable: false),
                    CustomQuestionCategoryId = table.Column<int>(type: "int", nullable: false),
                    CQStatusId = table.Column<int>(type: "int", nullable: false),
                    CQIsRequiredId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecruitCustomQuestionSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecruitCustomQuestionSettings_CustomQuestionCategories_CustomQuestionCategoryId",
                        column: x => x.CustomQuestionCategoryId,
                        principalTable: "CustomQuestionCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RecruitCustomQuestionSettings_CustomQuestionTypes_CustomQuestionTypeId",
                        column: x => x.CustomQuestionTypeId,
                        principalTable: "CustomQuestionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RecruitJobApplicationStatusSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobApplicationPositionId = table.Column<int>(type: "int", nullable: false),
                    JobApplicationCategoryId = table.Column<int>(type: "int", nullable: false),
                    JASStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JASColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JASIsModelChecked = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecruitJobApplicationStatusSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecruitJobApplicationStatusSettings_JobApplicationCategories_JobApplicationCategoryId",
                        column: x => x.JobApplicationCategoryId,
                        principalTable: "JobApplicationCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RecruitJobApplicationStatusSettings_JobApplicationPositions_JobApplicationPositionId",
                        column: x => x.JobApplicationPositionId,
                        principalTable: "JobApplicationPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsSendReminder = table.Column<bool>(type: "bit", nullable: false),
                    ProjectReminderPersonId = table.Column<int>(type: "int", nullable: false),
                    RemindBefore = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectSettings_ProjectReminderPersons_ProjectReminderPersonId",
                        column: x => x.ProjectReminderPersonId,
                        principalTable: "ProjectReminderPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Designations_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Designations_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    DesignationId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Roles_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Roles_Designations_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "BusinessLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    TaxName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessLocations_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BusinessLocations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BusinessLocations_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BusinessLocations_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BusinessLocations_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TimeLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CBTimeLogJsonSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsTimeTrackerReminderEnabled = table.Column<bool>(type: "bit", nullable: false),
                    TLTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDailyTimeLogReportEnabled = table.Column<bool>(type: "bit", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeLogs_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_CurrencyId",
                table: "Applications",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessLocations_AddressId",
                table: "BusinessLocations",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessLocations_CityId",
                table: "BusinessLocations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessLocations_CompanyId",
                table: "BusinessLocations",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessLocations_CountryId",
                table: "BusinessLocations",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessLocations_StateId",
                table: "BusinessLocations",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_StateId",
                table: "Cities",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_BusinessTypeId",
                table: "Companies",
                column: "BusinessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CategoryId",
                table: "Companies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CompanyId",
                table: "Departments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Designations_CompanyId",
                table: "Designations",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Designations_DepartmentId",
                table: "Designations",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSettings_ProjectReminderPersonId",
                table: "ProjectSettings",
                column: "ProjectReminderPersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RecruitCustomQuestionSettings_CustomQuestionCategoryId",
                table: "RecruitCustomQuestionSettings",
                column: "CustomQuestionCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RecruitCustomQuestionSettings_CustomQuestionTypeId",
                table: "RecruitCustomQuestionSettings",
                column: "CustomQuestionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecruitJobApplicationStatusSettings_JobApplicationCategoryId",
                table: "RecruitJobApplicationStatusSettings",
                column: "JobApplicationCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RecruitJobApplicationStatusSettings_JobApplicationPositionId",
                table: "RecruitJobApplicationStatusSettings",
                column: "JobApplicationPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_CompanyId",
                table: "Roles",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_DepartmentId",
                table: "Roles",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_DesignationId",
                table: "Roles",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_States_CountryId",
                table: "States",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeLogs_RoleId",
                table: "TimeLogs",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "BusinessLocations");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "LeadAgents");

            migrationBuilder.DropTable(
                name: "LeadCategories");

            migrationBuilder.DropTable(
                name: "LeadSources");

            migrationBuilder.DropTable(
                name: "LeadStatuses");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Plannings");

            migrationBuilder.DropTable(
                name: "ProjectCategories");

            migrationBuilder.DropTable(
                name: "ProjectSettings");

            migrationBuilder.DropTable(
                name: "ProjectStatuses");

            migrationBuilder.DropTable(
                name: "RecruitCustomQuestionSettings");

            migrationBuilder.DropTable(
                name: "RecruiterSettings");

            migrationBuilder.DropTable(
                name: "RecruitFooterSettings");

            migrationBuilder.DropTable(
                name: "RecruitGeneralSettings");

            migrationBuilder.DropTable(
                name: "RecruitJobApplicationStatusSettings");

            migrationBuilder.DropTable(
                name: "RecruitNotificationSettings");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Taxes");

            migrationBuilder.DropTable(
                name: "TimeLogs");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "ProjectReminderPersons");

            migrationBuilder.DropTable(
                name: "CustomQuestionCategories");

            migrationBuilder.DropTable(
                name: "CustomQuestionTypes");

            migrationBuilder.DropTable(
                name: "JobApplicationCategories");

            migrationBuilder.DropTable(
                name: "JobApplicationPositions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Designations");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "BusinessTypes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
