// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using aws_webapp.Data;

#nullable disable

namespace aws_webapp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("aws_webapp.Participantes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ciudad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("distancia")
                        .HasColumnType("double precision");

                    b.Property<string>("edad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("genero")
                        .HasColumnType("text");

                    b.Property<string>("lugar")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("ritmo")
                        .HasColumnType("double precision");

                    b.Property<string>("rol")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("tiempo")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.ToTable("participantes");
                });
#pragma warning restore 612, 618
        }
    }
}
