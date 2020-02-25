using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstractions
{
    public interface IUnitOfWork
    {
        IProductTypeRepository GetProductTypeRepository();
        IProductRepository GetProductRepository();

        Task Save();
    }
}
