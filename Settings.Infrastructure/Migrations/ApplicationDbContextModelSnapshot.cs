﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Settings.Infrastructure.Persistence;

#nullable disable

namespace Settings.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Settings.Domain.Entities.Applications", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<string>("DatatableRowLimit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateFormat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DefaultTimezone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmployeeCanExportData")
                        .HasColumnType("bit");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeFormat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("Settings.Domain.Entities.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContractNumberDigits")
                        .HasColumnType("int");

                    b.Property<string>("ContractNumberExample")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContractNumberSeprator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContractPrefix")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("Settings.Domain.Entities.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CurrencyCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrencyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrencyPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrencySymbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DecimalSeparator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExchangeRate")
                        .HasColumnType("int");

                    b.Property<string>("IsCryptocurrency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberofDecimals")
                        .HasColumnType("int");

                    b.Property<string>("ThousandSeparator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("USDPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("Settings.Domain.Entities.LeadAgent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AgentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LeadAgents");
                });

            modelBuilder.Entity("Settings.Domain.Entities.LeadCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LeadCategories");
                });

            modelBuilder.Entity("Settings.Domain.Entities.LeadSource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("source")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LeadSources");
                });

            modelBuilder.Entity("Settings.Domain.Entities.LeadStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LeadStatuses");
                });

            modelBuilder.Entity("Settings.Domain.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("All")
                        .HasColumnType("bit");

                    b.Property<bool>("AllowChatClientEmployee")
                        .HasColumnType("bit");

                    b.Property<bool>("Allowchatclientadmin")
                        .HasColumnType("bit");

                    b.Property<bool>("OnlyProjectMembercanwithclient")
                        .HasColumnType("bit");

                    b.Property<bool>("SoundNotifyAlert")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Settings.Domain.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Method")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("Settings.Domain.Entities.Planning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Company")
                        .HasColumnType("int");

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Designation")
                        .HasColumnType("int");

                    b.Property<int>("Employee")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Permission")
                        .HasColumnType("int");

                    b.Property<float>("PlanPrice")
                        .HasColumnType("real");

                    b.Property<int>("Roles")
                        .HasColumnType("int");

                    b.Property<int>("Validity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Plannings");
                });

            modelBuilder.Entity("Settings.Domain.Entities.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AddFile")
                        .HasColumnType("bit");

                    b.Property<int>("AfterXDate")
                        .HasColumnType("int");

                    b.Property<bool>("AssignedBy")
                        .HasColumnType("bit");

                    b.Property<bool>("AssignedTo")
                        .HasColumnType("bit");

                    b.Property<int>("BeforeXDate")
                        .HasColumnType("int");

                    b.Property<bool>("Comment")
                        .HasColumnType("bit");

                    b.Property<bool>("CopyTaskLink")
                        .HasColumnType("bit");

                    b.Property<bool>("CustomFields")
                        .HasColumnType("bit");

                    b.Property<bool>("Description")
                        .HasColumnType("bit");

                    b.Property<bool>("DueDate")
                        .HasColumnType("bit");

                    b.Property<bool>("History")
                        .HasColumnType("bit");

                    b.Property<bool>("HoursLogged")
                        .HasColumnType("bit");

                    b.Property<bool>("Label")
                        .HasColumnType("bit");

                    b.Property<bool>("MakePrivate")
                        .HasColumnType("bit");

                    b.Property<bool>("Notes")
                        .HasColumnType("bit");

                    b.Property<bool>("Priority")
                        .HasColumnType("bit");

                    b.Property<bool>("Project")
                        .HasColumnType("bit");

                    b.Property<bool>("SendReminderDueDate")
                        .HasColumnType("bit");

                    b.Property<bool>("StartDate")
                        .HasColumnType("bit");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Statuss")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SubTask")
                        .HasColumnType("bit");

                    b.Property<bool>("TaskCategory")
                        .HasColumnType("bit");

                    b.Property<int>("TaskboardLength")
                        .HasColumnType("int");

                    b.Property<bool>("TimeEstimate")
                        .HasColumnType("bit");

                    b.Property<bool>("Timesheet")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Settings.Domain.Entities.Tax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Rate")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Taxes");
                });

            modelBuilder.Entity("Settings.Domain.Entities.Applications", b =>
                {
                    b.HasOne("Settings.Domain.Entities.Currency", "Currency")
                        .WithMany("Applications")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("Settings.Domain.Entities.Currency", b =>
                {
                    b.Navigation("Applications");
                });
#pragma warning restore 612, 618
        }
    }
}
