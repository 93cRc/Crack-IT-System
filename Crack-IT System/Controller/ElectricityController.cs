using Crack_IT_System.Model;
using Crack_IT_System.Repository;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Crack_IT_System.Controller {
	internal class ElectricityController {
		private readonly ElectricityRepository _electricityRepo;


		internal ElectricityController() {
			_electricityRepo = new();
		}


		internal async Task<IList<Miejscowosci>> LoadCities() {
			var query = await _electricityRepo.SelectCities()
				.ToListAsync();

			foreach (var city in query) {
				Debug.WriteLine($"{city.Id} - {city.Nazwa}");
			}

			return query;
		}


		internal async Task<IList<Kraje>> LoadCountries() {
			var query = await _electricityRepo.SelectCountries()
				.ToListAsync();

			foreach (var country in query) {
				Debug.WriteLine($"{country.Id} - {country.Nazwa}");
			}

			return query;
		}
	}
}