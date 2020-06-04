using System;
using System.Collections.Generic;
using System.Text;
using DAL.EF;
using DAL.Entities;
using DAL.Repositories.Interfaces;

namespace DAL.Repositories.Implementations
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        internal ProductRepository(OsbbContext context) : base(context) { }
    }
}
