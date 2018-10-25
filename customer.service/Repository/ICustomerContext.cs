using customer.service.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace customer.service.Repository {
    public interface ICustomerContext {
        IMongoCollection<CustomerModel> Customer { get; }
    }
}