using CoreRepositoryApp.Models;
using EF.Core.Repository.Interface.Manager;

namespace CoreRepositoryApp.Interfaces.Manager
{
    public interface IProductManager:ICommonManager<Product>
    {
        Product GetById(int id);
        
    }
}
