using Domain.Core.Base;

namespace Domain.Core.ProductManagement.Interfaces
{
    public interface IProductLister: IBaseLister<Product>
    {
        void WithName(string name);
    }
}