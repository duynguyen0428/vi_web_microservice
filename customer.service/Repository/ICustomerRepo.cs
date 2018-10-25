using System.Collections.Generic;
using System.Threading.Tasks;
using customer.service.Model;
using MongoDB.Bson.Serialization.Attributes;
namespace customer.service.Repository {
    public interface ICustomerRepo {
        Task Add (CustomerModel cust);

        Task<CustomerModel> GetDetails (string id);

        Task UpdateDetails (string id, CustomerModel update_details);

        Task<IEnumerable<CustomerModel>> GetCustomers ();
    }
}