using ManishsBooks.DataAccess.Repository.IRepository;
using ManishsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManishsBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}