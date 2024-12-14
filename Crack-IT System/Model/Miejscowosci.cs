using System.ComponentModel.DataAnnotations;

namespace Crack_IT_System.Model {
	internal class Miejscowosci {
		[Key]
		public uint Id { get; set; }
		public string Nazwa { get; set; } = string.Empty;
	}
}