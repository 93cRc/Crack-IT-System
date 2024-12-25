using Crack_IT_System.Models;
using Crack_IT_System.Models.Electricity;
using Crack_IT_System.Properties;
using Microsoft.EntityFrameworkCore;

namespace Crack_IT_System.DbContextes {
	internal class Crack_ITDbContext {
		public class MyDbContext : DbContext {
			public virtual DbSet<Kody_pocztowe> TbZipCodes { get; set; }
			public virtual DbSet<Kraje> TbCountries { get; set; }
			public virtual DbSet<Miejscowosci> TbCities { get; set; }
			public virtual DbSet<Pomiary_elektryczne_napiecia_sieci> TbNapieciaSieci { get; set; }
			public virtual DbSet<Pomiary_elektryczne_typy_budynkow> TbTypyBudynkow { get; set; }
			public virtual DbSet<Pomiary_elektryczne_typy_sieci> TbTypySieci { get; set; }
			public virtual DbSet<Pomiary_elektryczne_wykonawcy> TbTypyWykonawcy { get; set; }


			protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
				optionsBuilder.UseMySql(
				    Settings.Default.SRV_Crack_IT_ConnString,
				    new MySqlServerVersion(new Version(8, 0, 33))
				);
			}


			protected override void OnModelCreating(ModelBuilder modelBuilder) {
				modelBuilder.Entity<Pomiary_elektryczne_napiecia_sieci>()
					.Property(u => u.Nazwa).HasMaxLength(10);
			}
		}
	}
}