using System;


namespace Nile.Web.Models
{
    public static class ProductModelExtensions
    {
        public static Product ToDomain (this ProductModel source)
        {
            if (source == null)
                return null;

            return new Product () {
                Id =source.Id,
                Name = source.Name,
                Description = source.Description,
                Price = source.Price,
                IsDiscontinued = source.IsDiscontinued
            };
        }

        public static ProductModel ToModel ( this Product source )
        {
            if (source == null)
                return null;

            return new ProductModel() {
                Id =source.Id,
                Name = source.Name,
                Description = source.Description,
                Price = source.Price,
                IsDiscontinued = source.IsDiscontinued
            };
        }
    }
}