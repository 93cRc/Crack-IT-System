using Crack_IT_System.Db_Context;
using Crack_IT_System.Model;

namespace Crack_IT_System.Repository {
	internal class ElectricityRepository {
		internal IQueryable<Miejscowosci> SelectCities() {
			Crack_IT_DbContext.MyDbContext context = new();
			return context.TbCities;
		}


		internal IQueryable<Kraje> SelectCountries() {
			Crack_IT_DbContext.MyDbContext context = new();
			return context.TbCountries;
		}
	}
}