using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crack_IT_System.Model {
	[Table("kraje")]
	internal class Kraje {
		[Key]
		public uint Id { get; set; }
		public string Nazwa { get; set; } = string.Empty;
		public string Skrot { get; set; } = string.Empty;
	}
}