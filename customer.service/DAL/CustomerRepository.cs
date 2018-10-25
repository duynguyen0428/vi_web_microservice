using System.Collections.Generic;
using System.Threading.Tasks;
using customer.service.Model;
using customer.service.Repository;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace customer.service.DAL {
    public class CustomerRepository : ICustomerRepo {
        private readonly ICustomerContext _context;
        public CustomerRepository (ICustomerContext context) {
            this._context = context;
        }
        public async Task Add (CustomerModel cust) {
            try {

                await this._context.Customer.InsertOneAsync (cust);
            } catch (System.Exception) {

                throw;
            }
        }

        public async Task<IEnumerable<CustomerModel>> GetCustomers () {
            try {
                return await this._context.Customer.Find (_ => true).ToListAsync ();

            } catch (System.Exception) {

                throw;
            }
        }

        public async Task<CustomerModel> GetDetails (string id) {
            var internalId = GetInternalId (id);
            return await this._context.Customer.Find (cust => cust.InternalId == internalId)
                .FirstOrDefaultAsync ();
        }

        public Task UpdateDetails (string id, CustomerModel update_details) {
            throw new System.NotImplementedException ();
        }

        // Try to convert the Id to a BSonId value
        private ObjectId GetInternalId (string id) {
            if (!ObjectId.TryParse (id, out ObjectId internalId))
                internalId = ObjectId.Empty;

            return internalId;
        }
    }
}