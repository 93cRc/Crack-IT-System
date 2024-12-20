using System.ComponentModel.DataAnnotations;

namespace Crack_IT_System.Model.Electricity {
	internal class Pomiary_elektryczne_typy_budynkow {
		[Key]
		public uint Id { get; set; }
		public string Nazwa { get; set; } = string.Empty;
	}
}