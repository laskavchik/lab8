using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF.Interfaces
{
   public interface IOsbbContext : IBaseContext
    {
        DbSet<Product> Products { get; set; }
    }
}
