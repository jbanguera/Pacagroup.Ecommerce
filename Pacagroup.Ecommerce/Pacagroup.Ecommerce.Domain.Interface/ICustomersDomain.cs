using System;
using System.Collections.Generic;
using System.Text;
using Pacagroup.Ecommerce.Domain.Entity;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Domain.Interface
{
    public interface ICustomersDomain
    {
        #region Metodos sincronos
        bool Insert(Customers customers);
        bool Update(Customers customers);
        bool Delete(string customerId);
        Customers Get(string customerId);
        IEnumerable<Customers> GetAll();
        #endregion

        #region Metodos asincronos
        Task<bool> InsertAsync(Customers customers);
        Task<bool> UpdateAsync(Customers customers);
        Task<bool> DeleteAsync(string customerId);
        Task<Customers> GetAsync(string customerId);
        Task<IEnumerable<Customers>> GetAllAsync();
        #endregion
    }
}
