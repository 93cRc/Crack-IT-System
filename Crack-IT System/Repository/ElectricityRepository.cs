using Crack_IT_System.Db_Context;
using Crack_IT_System.Model;

namespace Crack_IT_System.Repository {
	internal class ElectricityRepository {
		internal IQueryable<Kraje>? SelectKraje() {
			using (Crack_IT_DbContext context = new Crack_IT_DbContext()) {
				return (IQueryable<Kraje>?)context.TbKraje;
			}
		}
	}
}