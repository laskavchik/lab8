using System;
using System.Collections.Generic;
using System.Text;
using DAL.Repositories.Implementations;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork;

namespace DAL.EF
{
    public class EFUnitOfWork
        : IUnitOfWork
    {
        private OsbbContext db;
        private ProductRepository _productRepository;

        public EFUnitOfWork(OsbbContext context)
        {
            db = context;
        }

        public IProductRepository Products
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new ProductRepository(db);
                return _productRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
