using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;

namespace BLL.DTO
{
    public class ProductDto
    {
        public int Id { get; set; }
        public decimal Price { get; set; }

        public static implicit operator ProductDto(Product dal) => new ProductDto
        {
            Id = dal.Id,
            Price = dal.Price
        };
    }
}
