using System.ComponentModel.DataAnnotations;

namespace Crack_IT_System.Model.Electricity {
	internal class Pomiary_elektryczne_wykonawcy {
		[Key]
		public uint Id { get; set; }
		public string Imie { get; set; } = string.Empty;
		public string Nazwisko { get; set; } = string.Empty;
		public string Ulica { get; set; } = string.Empty;
		public string Nr_budynku { get; set; } = string.Empty;
		public int Kod_pocztowy_id { get; set; }
		public string Swiadectwo_kwalifikacyjne { get; set; } = string.Empty;
		public DateTime Data_aktywacji { get; set; }
		public DateTime Data_wygasniecia { get; set; }
	}
}