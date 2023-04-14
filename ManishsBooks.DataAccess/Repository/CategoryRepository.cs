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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            // use .net LINQ to retrive the first or default catgory object.
            // then pass the id as a generic entity which matches the category ID.

            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null) // save changes if not null
            {
                objFromDb.Name = category.Name;
                //_db.SaveChanges();
            }
        }
    }
}