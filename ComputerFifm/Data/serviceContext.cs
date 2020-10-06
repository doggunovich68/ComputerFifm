using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ComputerFifm.Models;

namespace ComputerFifm.Data
{
    public partial class serviceContext : DbContext
    {
        public serviceContext()
        {
        }

        public serviceContext(DbContextOptions<serviceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ВидыКомплектующих> ВидыКомплектующих { get; set; }
        public virtual DbSet<Должность> Должность { get; set; }
        public virtual DbSet<Заказчики> Заказчики { get; set; }
        public virtual DbSet<Заказы> Заказы { get; set; }
        public virtual DbSet<Комплектующие> Комплектующие { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }
        public virtual DbSet<Услуги> Услуги { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlite("Data Source=C:\\Users\\val\\Documents\\service.db");
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-H50OUDJ7;Database=service;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ВидыКомплектующих>(entity =>
            {
                entity.HasKey(e => e.КодВида);

                entity.ToTable("Виды_комплектующих");

                entity.Property(e => e.КодВида)
                    .HasColumnName("Код_вида")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Наименование).HasColumnType("INT");

                entity.Property(e => e.Описание).HasColumnType("INT");
            });

            modelBuilder.Entity<Должность>(entity =>
            {
                entity.HasKey(e => e.КодДолжности);

                entity.Property(e => e.КодДолжности)
                    .HasColumnName("Код_должности")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.НаименованиеДолжности)
                    .HasColumnName("Наименование_должности")
                    .HasColumnType("INT");

                entity.Property(e => e.Обязанности).HasColumnType("INT");

                entity.Property(e => e.Оклад).HasColumnType("INT");

                entity.Property(e => e.Требования).HasColumnType("INT");
            });

            modelBuilder.Entity<Заказчики>(entity =>
            {
                entity.HasKey(e => e.КодЗаказчика);

                entity.Property(e => e.КодЗаказчика)
                    .HasColumnName("Код_заказчика")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Адрес).HasColumnType("INT");

                entity.Property(e => e.Телефон).HasColumnType("INT");

                entity.Property(e => e.Фио)
                    .HasColumnName("ФИО")
                    .HasColumnType("INT");
            });

            modelBuilder.Entity<Заказы>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ДатаЗаказа)
                    .HasColumnName("Дата_заказа")
                    .HasColumnType("INT");

                entity.Property(e => e.ДатаИсполнения)
                    .HasColumnName("Дата_исполнения")
                    .HasColumnType("INT");

                entity.Property(e => e.ДоляПредоплаты)
                    .HasColumnName("Доля_предоплаты")
                    .HasColumnType("INT");

                entity.Property(e => e.КодЗаказчика)
                    .HasColumnName("Код_заказчика")
                    .HasColumnType("INT");

                entity.Property(e => e.КодКомплектующего)
                    .HasColumnName("Код_комплектующего")
                    .HasColumnType("INT");

                entity.Property(e => e.КодКомплектующего1)
                    .HasColumnName("Код_комплектующего_1")
                    .HasColumnType("INT");

                entity.Property(e => e.КодКомплектующего2)
                    .HasColumnName("Код_комплектующего_2")
                    .HasColumnType("INT");

                entity.Property(e => e.КодКомплектующего3)
                    .HasColumnName("Код_комплектующего_3")
                    .HasColumnType("INT");

                entity.Property(e => e.КодСотрудника)
                    .HasColumnName("Код_сотрудника")
                    .HasColumnType("INT");

                entity.Property(e => e.КодУслуги)
                    .HasColumnName("Код_услуги")
                    .HasColumnType("INT");

                entity.Property(e => e.КодУслуги1)
                    .HasColumnName("Код_услуги_1")
                    .HasColumnType("INT");

                entity.Property(e => e.КодУслуги2)
                    .HasColumnName("Код_услуги_2")
                    .HasColumnType("INT");

                entity.Property(e => e.КодУслуги3)
                    .HasColumnName("Код_услуги_3")
                    .HasColumnType("INT");

                entity.Property(e => e.ОбщаяСтоимость)
                    .HasColumnName("Общая_стоимость")
                    .HasColumnType("INT");

                entity.Property(e => e.ОтметкаОбИсполнении)
                    .HasColumnName("Отметка_об_исполнении")
                    .HasColumnType("INT");

                entity.Property(e => e.ОтметкаОбОплате)
                    .HasColumnName("Отметка_об_оплате")
                    .HasColumnType("INT");

                entity.Property(e => e.СрокОбщейГарантии)
                    .HasColumnName("Срок_общей_гарантии")
                    .HasColumnType("INT");

                entity.HasOne(d => d.КодЗаказчикаNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.КодЗаказчика)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодКомплектующегоNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.КодКомплектующего)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодКомплектующего1Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.КодКомплектующего1)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодКомплектующего2Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.КодКомплектующего2)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодКомплектующего3Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.КодКомплектующего3)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодСотрудникаNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.КодСотрудника)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодУслугиNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.КодУслуги)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодУслуги1Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.КодУслуги1)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодУслуги2Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.КодУслуги2)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодУслуги3Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.КодУслуги3)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Комплектующие>(entity =>
            {
                entity.HasKey(e => e.КодКомплектующего);

                entity.Property(e => e.КодКомплектующего)
                    .HasColumnName("Код_комплектующего")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.ДатаВыпуска)
                    .HasColumnName("Дата_выпуска")
                    .HasColumnType("INT");

                entity.Property(e => e.КодВида)
                    .HasColumnName("Код_вида")
                    .HasColumnType("INT");

                entity.Property(e => e.Марка).HasColumnType("INT");

                entity.Property(e => e.Описание).HasColumnType("INT");

                entity.Property(e => e.СрокГарантии)
                    .HasColumnName("Срок_гарантии")
                    .HasColumnType("INT");

                entity.Property(e => e.СтранаПроизводитель)
                    .HasColumnName("Страна_производитель")
                    .HasColumnType("INT");

                entity.Property(e => e.ФирмаПроизводитель)
                    .HasColumnName("Фирма_производитель")
                    .HasColumnType("INT");

                entity.Property(e => e.Характеристики).HasColumnType("INT");

                entity.Property(e => e.Цена).HasColumnType("INT");

                entity.HasOne(d => d.КодВидаNavigation)
                    .WithMany(p => p.Комплектующие)
                    .HasForeignKey(d => d.КодВида)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Сотрудники>(entity =>
            {
                entity.HasKey(e => e.КодСотрудника);

                entity.HasIndex(e => e.ПаспортныеДанные)
                    .IsUnique();

                entity.Property(e => e.КодСотрудника)
                    .HasColumnName("Код_сотрудника")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Адрес).HasColumnType("INT");

                entity.Property(e => e.Возраст).HasColumnType("INT");

                entity.Property(e => e.КодДолжности)
                    .HasColumnName("Код_должности")
                    .HasColumnType("INT");

                entity.Property(e => e.ПаспортныеДанные)
                    .HasColumnName("Паспортные_данные")
                    .HasColumnType("INT");

                entity.Property(e => e.Пол).HasColumnType("INT");

                entity.Property(e => e.Телефон).HasColumnType("INT");

                entity.Property(e => e.Фио)
                    .HasColumnName("ФИО")
                    .HasColumnType("INT");

                entity.HasOne(d => d.КодДолжностиNavigation)
                    .WithMany(p => p.Сотрудники)
                    .HasForeignKey(d => d.КодДолжности)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Услуги>(entity =>
            {
                entity.HasKey(e => e.КодУслуги);

                entity.Property(e => e.КодУслуги)
                    .HasColumnName("Код_услуги")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Наименование).HasColumnType("INT");

                entity.Property(e => e.Описание).HasColumnType("INT");

                entity.Property(e => e.Стоимость).HasColumnType("INT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
