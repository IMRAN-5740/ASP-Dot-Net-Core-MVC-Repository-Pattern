using CoreRepositoryApp.Models;
using EF.Core.Repository.Interface.Repository;

namespace CoreRepositoryApp.Interfaces.Repository
{
    public interface IProductRepository:ICommonRepository<Product>
    {

    }
}
