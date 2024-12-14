using System.ComponentModel.DataAnnotations;

namespace Crack_IT_System.Model {
	internal class Kraje {
		[Key]
		public uint Id { get; set; }
		public string Nazwa { get; set; } = string.Empty;
		public string Skrot { get; set; } = string.Empty;
	}
}