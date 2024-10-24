﻿using Day15qs3.Data;
using Day15qs3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15qs3.Repository
{
    internal class ProductRepository
    {
        public GenericResponse<List<Product>> GetAllProducts()
        {
            var products = DataStore.Products;
            return new GenericResponse<List<Product>>
            {
                Success = true,
                Data = products,
            };
        }

        public GenericResponse<Product> GetProductById(int id)
        {
            var product = DataStore.Products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return new GenericResponse<Product>
                {
                    Success = false,
                    Message = "Product not found",
                };
            }

            return new GenericResponse<Product>
            {
                Success = true,
                Data = product,
            };
        }
    }
}
