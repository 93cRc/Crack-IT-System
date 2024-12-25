using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crack_IT_System.Models {
	[Table("miejscowosci")]
	internal class Miejscowosci {
		[Key]
		public uint Id { get; set; }
		public string Nazwa { get; set; } = string.Empty;
	}
}