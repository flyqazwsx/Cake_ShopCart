using Cake_Shop_Cart.DataAccess.Data;
using Cake_Shop_Cart.DataAccess.Repository.IRepository;
using Cake_Shop_Cart.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Shop_Cart.DataAccess.Repository
{
    public class StoreRepository : Repository<Store>, IStoreRepository
    {
        private ApplicationDbContext _db;
        public StoreRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
       
        public void Update(Store obj)
        {
            _db.Stores.Update(obj);
        }
    }
}
