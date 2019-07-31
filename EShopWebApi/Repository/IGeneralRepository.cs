using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopWebApi.Repository
{
	interface IGeneralRepository<T> where T : class
	{
		IQueryable<T> GetAll();
		T GetById(int id);
		void Create(T entity);
		void Update(int id, T entity);
		void Delete(int id);
	}
}
