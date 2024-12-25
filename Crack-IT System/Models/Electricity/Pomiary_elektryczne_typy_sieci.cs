using System.ComponentModel.DataAnnotations;

namespace Crack_IT_System.Models.Electricity {
	internal class Pomiary_elektryczne_typy_sieci {
		[Key]
		public uint Id { get; set; }
		public string Nazwa { get; set; } = string.Empty;
	}
}