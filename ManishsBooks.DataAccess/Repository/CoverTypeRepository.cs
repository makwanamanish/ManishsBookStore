using ManishsBooks.DataAccess.Repository.IRepository;
using ManishsBooks.DataAccess.Repository;
using ManishsBooks.Models;
using ManishsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManishsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {

            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null) // save changes if not null
            {
                objFromDb.Name = coverType.Name;
                //_db.SaveChanges();
            }
        }
    }
}