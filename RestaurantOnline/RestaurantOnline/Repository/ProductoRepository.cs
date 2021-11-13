﻿using RestaurantOnline.Data;
using RestaurantOnline.Entidades;
using RestaurantOnline.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOnline.Repository
{
    public class ProductoRepository : IProducto
    {
        private ApplicationDbContext app;

        public ProductoRepository(ApplicationDbContext app)
        {
            this.app = app;
        }

        public void Delete(tbl_Producto producto)
        {
            app.tbl_Producto.Remove(producto);
        }

        public void Insert(tbl_Producto producto)
        {
            app.Add(producto);
            app.SaveChanges();
        }

        public ICollection<tbl_Producto> producto()
        {
            return app.tbl_Producto.ToList();
        }

        public void Update(tbl_Producto producto)
        {
            app.Update(producto);
            app.SaveChanges();
        }
    }
}