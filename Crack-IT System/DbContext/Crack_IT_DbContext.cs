using Crack_IT_System.Model.Electricity;

namespace Crack_IT_System.DbContext {
	internal class Crack_IT_DbContext {
		public virtual Pomiary_elektryczne_napiecia_sieci? TbNapieciaSieci { get; set; }
		public virtual Pomiary_elektryczne_typy_budynkow? TbTypyBudynkow { get; set; }
		public virtual Pomiary_elektryczne_typy_sieci? TbTypySieci { get; set; }
		public virtual Pomiary_elektryczne_wykonawcy? TbTypyWykonawcy { get; set; }


		public void OnModelCreating() {

		}
	}
}