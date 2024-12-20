using System.ComponentModel.DataAnnotations;

namespace Crack_IT_System.Model {
	internal class Kody_pocztowe {
		[Key]
		public uint Id { get; set; }
		public uint Kraj_id { get; set; }
		public string Kod_pocztowy { get; set; } = string.Empty;
		public uint Miejscowosc_id { get; set; }
	}
}