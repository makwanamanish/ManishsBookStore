using ManishsBooks.DataAccess.Repository.IRepository;
using ManishsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManishsBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}