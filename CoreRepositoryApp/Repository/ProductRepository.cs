using CoreRepositoryApp.Interfaces.Repository;
using CoreRepositoryApp.Models;
using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace CoreRepositoryApp.Repository
{
    public class ProductRepository : CommonRepository<Product>, IProductRepository
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
