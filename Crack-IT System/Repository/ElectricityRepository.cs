using Crack_IT_System.Db_Context;
using Crack_IT_System.Model;
using System.Diagnostics;

namespace Crack_IT_System.Repository {
	internal class ElectricityRepository {
		internal IQueryable<Miejscowosci> SelectCities() {
			Crack_IT_DbContext.MyDbContext context = new();
			
			var query = context.TbCities;
			
			foreach (var city in query) {
				Debug.WriteLine($"{city.Id} - {city.Nazwa}");
			}

			return query;
		}


		internal IQueryable<Kraje> SelectCountries() {
			Crack_IT_DbContext.MyDbContext context = new();

			var query = context.TbCountries;

			foreach (var city in query) {
				Debug.WriteLine($"{city.Id} - {city.Nazwa}");
			}

			return query;
		}
	}
}