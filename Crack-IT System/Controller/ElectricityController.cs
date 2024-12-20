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

			return query;
		}


		internal async Task<IList<Kraje>> LoadCountries() {
			var query = await _electricityRepo.SelectCountries()
				.ToListAsync();

			return query;
		}
	}
}