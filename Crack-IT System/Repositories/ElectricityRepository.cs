using Crack_IT_System.DbContextes;
using Crack_IT_System.Models;
using System.Diagnostics;

namespace Crack_IT_System.Repositories {
	internal class ElectricityRepository {
		internal IQueryable<Miejscowosci> SelectCities() {
			const string funcName = "SelectCities()";
			Debug.WriteLine($"--Repository - {funcName} - START");

			Crack_ITDbContext.MyDbContext context = new();

			var query = context.TbCities;

			foreach (var row in query) {
				Debug.WriteLine($"---Result of {funcName}:\n{row.Id} - {row.Nazwa}");
			}

			Debug.WriteLine($"--Repository - {funcName} - END");

			return query;
		}


		internal IQueryable<Kraje> SelectCountries() {
			const string funcName = "SelectCountries()";
			Debug.WriteLine($"--Repository - {funcName} - START");
			
			Crack_ITDbContext.MyDbContext context = new();

			var query = context.TbCountries;

			foreach (var row in query) {
				Debug.WriteLine($"---Result of {funcName}:\n{row.Id} - {row.Nazwa}");
			}

			Debug.WriteLine($"--Repository - {funcName} - END");

			return query;
		}
	}
}