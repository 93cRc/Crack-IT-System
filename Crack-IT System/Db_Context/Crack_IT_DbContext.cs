using Crack_IT_System.Model;
using Crack_IT_System.Model.Electricity;
using Microsoft.EntityFrameworkCore;

namespace Crack_IT_System.Db_Context {
	internal class Crack_IT_DbContext : DbContext {
		public virtual Kraje? TbKraje { get; set; }
		public virtual Pomiary_elektryczne_napiecia_sieci? TbNapieciaSieci { get; set; }
		public virtual Pomiary_elektryczne_typy_budynkow? TbTypyBudynkow { get; set; }
		public virtual Pomiary_elektryczne_typy_sieci? TbTypySieci { get; set; }
		public virtual Pomiary_elektryczne_wykonawcy? TbTypyWykonawcy { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseMySQL(Properties.Settings.Default.SRV_cRc_connString);
		}


		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Pomiary_elektryczne_napiecia_sieci>()
				.Property(u => u.Nazwa).HasMaxLength(10);
		}
	}
}