using System;
using customer.service.Model;
using customer.service.Repository;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace customer.service.DAL {
    public class CustomerContext : ICustomerContext {
        private readonly IMongoDatabase _database = null;
        public CustomerContext (IOptions<Settings> settings) {
            var client = new MongoClient (settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase (settings.Value.Database);

        }

        public IMongoCollection<CustomerModel> Customer {
            get {
                return this._database.GetCollection<CustomerModel> ("Customer");
            }
        }
    }
}