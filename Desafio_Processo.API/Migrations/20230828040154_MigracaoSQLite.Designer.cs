﻿// <auto-generated />
using Desafio_Processo.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Desafio_Processo.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230828040154_MigracaoSQLite")]
    partial class MigracaoSQLite
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("Desafio_Processo.API.Models.Cadastro", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Grupo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("senha")
                        .HasColumnType("TEXT");

                    b.HasKey("Email");

                    b.ToTable("cadastros");
                });
#pragma warning restore 612, 618
        }
    }
}
