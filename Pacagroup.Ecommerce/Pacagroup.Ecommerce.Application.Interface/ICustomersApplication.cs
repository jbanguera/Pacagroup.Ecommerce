using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Transversal.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Application.Interface
{
    public interface ICustomersApplication
    {
        #region Metodos sincronos
        Response<bool> Insert(CustomersDTO customersDto);
        Response<bool> Update(CustomersDTO customersDto);
        Response<bool> Delete(string customerId);
        Response<CustomersDTO> Get(string customerId);
        Response<IEnumerable<CustomersDTO>> GetAll();
        #endregion

        #region Metodos asincronos
        Task<Response<bool>> InsertAsync(CustomersDTO customersDto);
        Task<Response<bool>> UpdateAsync(CustomersDTO customersDto);
        Task<Response<bool>> DeleteAsync(string customerId);
        Task<Response<CustomersDTO>> GetAsync(string customerId);
        Task<Response<IEnumerable<CustomersDTO>>> GetAllAsync();
        #endregion
    }
}
