using Crack_IT_System.Models;
using Crack_IT_System.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Crack_IT_System.Controllers {
	internal class ElectricityController {
		private readonly ElectricityRepository _electricityRepo;


		internal ElectricityController() {
			_electricityRepo = new();
		}


		internal async Task<IList<Miejscowosci>> LoadCities() {
			const string funcName = "LoadCities()";
			Debug.WriteLine($"-Controller - {funcName} - START");

			try {
				var query = await _electricityRepo.SelectCities()
					.ToListAsync();

				Debug.WriteLine($"-Controller - {funcName} - END with success");

				return query;
			}
			catch (Exception ex) {
				Debug.WriteLine($"-Controller - {funcName} - END with error:\n{ex.Message}");

				return null;
			}
		}


		internal async Task<IList<Kraje>> LoadCountries() {
			const string funcName = "LoadCountries()";
			Debug.WriteLine($"-Controller - {funcName} - START");

			try {
				var query = await _electricityRepo.SelectCountries()
					.ToListAsync();

				Debug.WriteLine($"-Controller - {funcName} - END with success");

				return query;
			}
			catch (Exception ex) {
				Debug.WriteLine($"-Controller - {funcName} - END with error:\n{ex.Message}");

				return null;
			}
		}
	}
}