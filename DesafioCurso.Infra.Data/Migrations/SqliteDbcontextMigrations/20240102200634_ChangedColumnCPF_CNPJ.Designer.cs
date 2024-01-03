﻿// <auto-generated />
using System;
using DesafioCurso.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DesafioCurso.Infra.Data.Migrations.SqliteDbcontextMigrations
{
    [DbContext(typeof(SqliteDbcontext))]
    [Migration("20240102200634_ChangedColumnCPF_CNPJ")]
    partial class ChangedColumnCPF_CNPJ
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("DesafioCurso.Domain.Entities.User", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("Cpf_Cnpj")
                        .HasMaxLength(14)
                        .HasColumnType("TEXT")
                        .HasColumnName("cpf_cnpj");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("nome_completo");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("senha");

                    b.Property<string>("Surname")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("apelido");

                    b.HasKey("Id");

                    b.HasIndex("Cpf_Cnpj")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Surname")
                        .IsUnique();

                    b.ToTable("usuario", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
