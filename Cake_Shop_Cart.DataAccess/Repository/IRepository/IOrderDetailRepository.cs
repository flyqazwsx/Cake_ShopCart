﻿using Cake_Shop_Cart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Shop_Cart.DataAccess.Repository.IRepository
{
    public interface IOrderDetailRepository:IRepository<OrderDetail>
    {
        void Update(OrderDetail obj);
    }
}
