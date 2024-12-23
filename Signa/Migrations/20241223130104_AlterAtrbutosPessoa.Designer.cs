﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Signa.Data;

#nullable disable

namespace Signa.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20241223130104_AlterAtrbutosPessoa")]
    partial class AlterAtrbutosPessoa
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Signa.Models.Pessoa", b =>
                {
                    b.Property<int>("PESSOA_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PESSOA_ID"));

                    b.Property<string>("CNPJ_CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOME_FANTASIA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PESSOA_ID");

                    b.ToTable("Pessoas");
                });
#pragma warning restore 612, 618
        }
    }
}
