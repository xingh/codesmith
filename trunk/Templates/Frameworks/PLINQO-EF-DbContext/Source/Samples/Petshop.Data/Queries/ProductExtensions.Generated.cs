﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petshop.Data.Queries
{
    public static partial class ProductExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static Petshop.Data.Entities.Product GetByKey(this System.Linq.IQueryable<Petshop.Data.Entities.Product> queryable, string productId)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<Petshop.Data.Entities.Product>;
            if (dbSet != null)
                return dbSet.Find(productId);
                
            return queryable.FirstOrDefault(p => p.ProductId == productId);
        }

        public static IQueryable<Petshop.Data.Entities.Product> ByName(this IQueryable<Petshop.Data.Entities.Product> queryable, string name)
        {
            return queryable.Where(p => (p.Name == name || (name == null && p.Name == null)));
        }

        public static IQueryable<Petshop.Data.Entities.Product> ByCategory(this IQueryable<Petshop.Data.Entities.Product> queryable, string category)
        {
            return queryable.Where(p => p.Category == category);
        }

        public static IQueryable<Petshop.Data.Entities.Product> ByCategoryName(this IQueryable<Petshop.Data.Entities.Product> queryable, string category, string name)
        {
            return queryable.Where(p => p.Category == category
                && (p.Name == name || (name == null && p.Name == null)));
        }

        public static IQueryable<Petshop.Data.Entities.Product> ByCategoryProductIdName(this IQueryable<Petshop.Data.Entities.Product> queryable, string category, string productId, string name)
        {
            return queryable.Where(p => p.Category == category
                && p.ProductId == productId
                && (p.Name == name || (name == null && p.Name == null)));
        }
    }
}
