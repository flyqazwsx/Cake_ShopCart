using Cake_Shop_Cart.DataAccess.Data;
using Cake_Shop_Cart.DataAccess.Repository.IRepository;
using Cake_Shop_Cart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Shop_Cart.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
       
        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
