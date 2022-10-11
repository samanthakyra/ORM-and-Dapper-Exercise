﻿using System;
namespace ORM_Dapper
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();

        public void CreateProduct(string name, double price, int categoryID);

        public void UpdateProduct(int productID, string updatedName);

        public void DeleteProduct(int productID);
    }
}

