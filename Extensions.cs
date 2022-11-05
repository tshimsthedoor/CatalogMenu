using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogMenu.Dtos;
using CatalogMenu.Entities;

namespace CatalogMenu
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item) => new ItemDto
        {
            Id = item.Id,
            Name = item.Name,
            Price = item.Price,
            CreatedDate = item.CreatedDate
        };
    }
}