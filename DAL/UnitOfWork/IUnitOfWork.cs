using System;
using System.Collections.Generic;
using System.Text;
using DAL.Repositories.Interfaces;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        void Save();
    }
}
