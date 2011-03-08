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
using System.Data.Linq;
using CodeSmith.Data.Linq;
using CodeSmith.Data.Linq.Dynamic;

namespace PetShop.Core.Data
{
    /// <summary>
    /// The query extension class for Cart.
    /// </summary>
    public static partial class CartExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static PetShop.Core.Data.Cart GetByKey(this IQueryable<PetShop.Core.Data.Cart> queryable, int cartId)
        {
            var entity = queryable as System.Data.Linq.Table<PetShop.Core.Data.Cart>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.GetByKey.Invoke((PetShop.Core.Data.PetShopDataContext)entity.Context, cartId);

            return queryable.FirstOrDefault(c => c.CartId == cartId);
        }

        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        /// <returns>The number of rows deleted from the database.</returns>
        public static int Delete(this System.Data.Linq.Table<PetShop.Core.Data.Cart> table, int cartId)
        {
            return table.Delete(c => c.CartId == cartId);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.UniqueID"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="uniqueID">UniqueID to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByUniqueID(this IQueryable<PetShop.Core.Data.Cart> queryable, int uniqueID)
        {
            return queryable.Where(c => c.UniqueID == uniqueID);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.UniqueID"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="uniqueID">UniqueID to search for.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByUniqueID(this IQueryable<PetShop.Core.Data.Cart> queryable, int uniqueID, ComparisonOperator comparisonOperator)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(c => uniqueID > c.UniqueID);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(c => uniqueID >= c.UniqueID);
                case ComparisonOperator.LessThan:
                    return queryable.Where(c => uniqueID < c.UniqueID);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(c => uniqueID <= c.UniqueID);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(c => c.UniqueID != uniqueID);
                default:
                    return queryable.Where(c => c.UniqueID == uniqueID);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.UniqueID"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="uniqueID">UniqueID to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByUniqueID(this IQueryable<PetShop.Core.Data.Cart> queryable, int uniqueID, params int[] additionalValues)
        {
            var uniqueIDList = new List<int> { uniqueID };

            if (additionalValues != null)
                uniqueIDList.AddRange(additionalValues);

            if (uniqueIDList.Count == 1)
                return queryable.ByUniqueID(uniqueIDList[0]);

            return queryable.ByUniqueID(uniqueIDList);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.UniqueID"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByUniqueID(this IQueryable<PetShop.Core.Data.Cart> queryable, IEnumerable<int> values)
        {
            return queryable.Where(c => values.Contains(c.UniqueID));
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.ItemId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="itemId">ItemId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByItemId(this IQueryable<PetShop.Core.Data.Cart> queryable, string itemId)
        {
            return queryable.Where(c => c.ItemId == itemId);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.ItemId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="itemId">ItemId to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByItemId(this IQueryable<PetShop.Core.Data.Cart> queryable, string itemId, ContainmentOperator containmentOperator)
        {
            if (itemId == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("itemId", "Parameter 'itemId' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(c => c.ItemId.Contains(itemId));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(c => c.ItemId.StartsWith(itemId));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(c => c.ItemId.EndsWith(itemId));
                case ContainmentOperator.NotContains:
                    return queryable.Where(c => c.ItemId.Contains(itemId) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(c => c.ItemId != itemId);
                default:
                    return queryable.Where(c => c.ItemId == itemId);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.ItemId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="itemId">ItemId to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByItemId(this IQueryable<PetShop.Core.Data.Cart> queryable, string itemId, params string[] additionalValues)
        {
            var itemIdList = new List<string> { itemId };

            if (additionalValues != null)
                itemIdList.AddRange(additionalValues);

            if (itemIdList.Count == 1)
                return queryable.ByItemId(itemIdList[0]);

            return queryable.ByItemId(itemIdList);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.ItemId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByItemId(this IQueryable<PetShop.Core.Data.Cart> queryable, IEnumerable<string> values)
        {
            return queryable.Where(c => values.Contains(c.ItemId));
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByName(this IQueryable<PetShop.Core.Data.Cart> queryable, string name)
        {
            return queryable.Where(c => c.Name == name);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByName(this IQueryable<PetShop.Core.Data.Cart> queryable, string name, ContainmentOperator containmentOperator)
        {
            if (name == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("name", "Parameter 'name' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(c => c.Name.Contains(name));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(c => c.Name.StartsWith(name));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(c => c.Name.EndsWith(name));
                case ContainmentOperator.NotContains:
                    return queryable.Where(c => c.Name.Contains(name) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(c => c.Name != name);
                default:
                    return queryable.Where(c => c.Name == name);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByName(this IQueryable<PetShop.Core.Data.Cart> queryable, string name, params string[] additionalValues)
        {
            var nameList = new List<string> { name };

            if (additionalValues != null)
                nameList.AddRange(additionalValues);

            if (nameList.Count == 1)
                return queryable.ByName(nameList[0]);

            return queryable.ByName(nameList);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByName(this IQueryable<PetShop.Core.Data.Cart> queryable, IEnumerable<string> values)
        {
            return queryable.Where(c => values.Contains(c.Name));
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.Type"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="type">Type to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByType(this IQueryable<PetShop.Core.Data.Cart> queryable, string type)
        {
            return queryable.Where(c => c.Type == type);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.Type"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="type">Type to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByType(this IQueryable<PetShop.Core.Data.Cart> queryable, string type, ContainmentOperator containmentOperator)
        {
            if (type == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("type", "Parameter 'type' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(c => c.Type.Contains(type));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(c => c.Type.StartsWith(type));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(c => c.Type.EndsWith(type));
                case ContainmentOperator.NotContains:
                    return queryable.Where(c => c.Type.Contains(type) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(c => c.Type != type);
                default:
                    return queryable.Where(c => c.Type == type);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.Type"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="type">Type to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByType(this IQueryable<PetShop.Core.Data.Cart> queryable, string type, params string[] additionalValues)
        {
            var typeList = new List<string> { type };

            if (additionalValues != null)
                typeList.AddRange(additionalValues);

            if (typeList.Count == 1)
                return queryable.ByType(typeList[0]);

            return queryable.ByType(typeList);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.Type"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByType(this IQueryable<PetShop.Core.Data.Cart> queryable, IEnumerable<string> values)
        {
            return queryable.Where(c => values.Contains(c.Type));
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.Price"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="price">Price to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByPrice(this IQueryable<PetShop.Core.Data.Cart> queryable, decimal price)
        {
            return queryable.Where(c => c.Price == price);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.Price"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="price">Price to search for.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByPrice(this IQueryable<PetShop.Core.Data.Cart> queryable, decimal price, ComparisonOperator comparisonOperator)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(c => price > c.Price);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(c => price >= c.Price);
                case ComparisonOperator.LessThan:
                    return queryable.Where(c => price < c.Price);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(c => price <= c.Price);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(c => c.Price != price);
                default:
                    return queryable.Where(c => c.Price == price);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.Price"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="price">Price to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByPrice(this IQueryable<PetShop.Core.Data.Cart> queryable, decimal price, params decimal[] additionalValues)
        {
            var priceList = new List<decimal> { price };

            if (additionalValues != null)
                priceList.AddRange(additionalValues);

            if (priceList.Count == 1)
                return queryable.ByPrice(priceList[0]);

            return queryable.ByPrice(priceList);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.Price"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByPrice(this IQueryable<PetShop.Core.Data.Cart> queryable, IEnumerable<decimal> values)
        {
            return queryable.Where(c => values.Contains(c.Price));
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.CategoryId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="categoryId">CategoryId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByCategoryId(this IQueryable<PetShop.Core.Data.Cart> queryable, string categoryId)
        {
            return queryable.Where(c => c.CategoryId == categoryId);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.CategoryId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="categoryId">CategoryId to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByCategoryId(this IQueryable<PetShop.Core.Data.Cart> queryable, string categoryId, ContainmentOperator containmentOperator)
        {
            if (categoryId == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("categoryId", "Parameter 'categoryId' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(c => c.CategoryId.Contains(categoryId));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(c => c.CategoryId.StartsWith(categoryId));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(c => c.CategoryId.EndsWith(categoryId));
                case ContainmentOperator.NotContains:
                    return queryable.Where(c => c.CategoryId.Contains(categoryId) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(c => c.CategoryId != categoryId);
                default:
                    return queryable.Where(c => c.CategoryId == categoryId);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.CategoryId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="categoryId">CategoryId to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByCategoryId(this IQueryable<PetShop.Core.Data.Cart> queryable, string categoryId, params string[] additionalValues)
        {
            var categoryIdList = new List<string> { categoryId };

            if (additionalValues != null)
                categoryIdList.AddRange(additionalValues);

            if (categoryIdList.Count == 1)
                return queryable.ByCategoryId(categoryIdList[0]);

            return queryable.ByCategoryId(categoryIdList);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.CategoryId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByCategoryId(this IQueryable<PetShop.Core.Data.Cart> queryable, IEnumerable<string> values)
        {
            return queryable.Where(c => values.Contains(c.CategoryId));
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.ProductId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="productId">ProductId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByProductId(this IQueryable<PetShop.Core.Data.Cart> queryable, string productId)
        {
            return queryable.Where(c => c.ProductId == productId);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.ProductId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="productId">ProductId to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByProductId(this IQueryable<PetShop.Core.Data.Cart> queryable, string productId, ContainmentOperator containmentOperator)
        {
            if (productId == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("productId", "Parameter 'productId' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(c => c.ProductId.Contains(productId));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(c => c.ProductId.StartsWith(productId));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(c => c.ProductId.EndsWith(productId));
                case ContainmentOperator.NotContains:
                    return queryable.Where(c => c.ProductId.Contains(productId) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(c => c.ProductId != productId);
                default:
                    return queryable.Where(c => c.ProductId == productId);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.ProductId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="productId">ProductId to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByProductId(this IQueryable<PetShop.Core.Data.Cart> queryable, string productId, params string[] additionalValues)
        {
            var productIdList = new List<string> { productId };

            if (additionalValues != null)
                productIdList.AddRange(additionalValues);

            if (productIdList.Count == 1)
                return queryable.ByProductId(productIdList[0]);

            return queryable.ByProductId(productIdList);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.ProductId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByProductId(this IQueryable<PetShop.Core.Data.Cart> queryable, IEnumerable<string> values)
        {
            return queryable.Where(c => values.Contains(c.ProductId));
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.IsShoppingCart"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="isShoppingCart">IsShoppingCart to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByIsShoppingCart(this IQueryable<PetShop.Core.Data.Cart> queryable, bool isShoppingCart)
        {
            return queryable.Where(c => c.IsShoppingCart == isShoppingCart);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.IsShoppingCart"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="isShoppingCart">IsShoppingCart to search for.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByIsShoppingCart(this IQueryable<PetShop.Core.Data.Cart> queryable, bool isShoppingCart, ComparisonOperator comparisonOperator)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                case ComparisonOperator.GreaterThanOrEquals:
                case ComparisonOperator.LessThan:
                case ComparisonOperator.LessThanOrEquals:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support bool type.", "comparisonOperator");
                case ComparisonOperator.NotEquals:
                    return queryable.Where(c => c.IsShoppingCart != isShoppingCart);
                default:
                    return queryable.Where(c => c.IsShoppingCart == isShoppingCart);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.IsShoppingCart"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="isShoppingCart">IsShoppingCart to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByIsShoppingCart(this IQueryable<PetShop.Core.Data.Cart> queryable, bool isShoppingCart, params bool[] additionalValues)
        {
            var isShoppingCartList = new List<bool> { isShoppingCart };

            if (additionalValues != null)
                isShoppingCartList.AddRange(additionalValues);

            if (isShoppingCartList.Count == 1)
                return queryable.ByIsShoppingCart(isShoppingCartList[0]);

            return queryable.ByIsShoppingCart(isShoppingCartList);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.IsShoppingCart"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByIsShoppingCart(this IQueryable<PetShop.Core.Data.Cart> queryable, IEnumerable<bool> values)
        {
            return queryable.Where(c => values.Contains(c.IsShoppingCart));
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.Quantity"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="quantity">Quantity to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByQuantity(this IQueryable<PetShop.Core.Data.Cart> queryable, int quantity)
        {
            return queryable.Where(c => c.Quantity == quantity);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.Quantity"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="quantity">Quantity to search for.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByQuantity(this IQueryable<PetShop.Core.Data.Cart> queryable, int quantity, ComparisonOperator comparisonOperator)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(c => quantity > c.Quantity);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(c => quantity >= c.Quantity);
                case ComparisonOperator.LessThan:
                    return queryable.Where(c => quantity < c.Quantity);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(c => quantity <= c.Quantity);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(c => c.Quantity != quantity);
                default:
                    return queryable.Where(c => c.Quantity == quantity);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.Quantity"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="quantity">Quantity to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByQuantity(this IQueryable<PetShop.Core.Data.Cart> queryable, int quantity, params int[] additionalValues)
        {
            var quantityList = new List<int> { quantity };

            if (additionalValues != null)
                quantityList.AddRange(additionalValues);

            if (quantityList.Count == 1)
                return queryable.ByQuantity(quantityList[0]);

            return queryable.ByQuantity(quantityList);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.Quantity"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByQuantity(this IQueryable<PetShop.Core.Data.Cart> queryable, IEnumerable<int> values)
        {
            return queryable.Where(c => values.Contains(c.Quantity));
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.CartId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="cartId">CartId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByCartId(this IQueryable<PetShop.Core.Data.Cart> queryable, int cartId)
        {
            return queryable.Where(c => c.CartId == cartId);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.CartId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="cartId">CartId to search for.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByCartId(this IQueryable<PetShop.Core.Data.Cart> queryable, int cartId, ComparisonOperator comparisonOperator)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(c => cartId > c.CartId);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(c => cartId >= c.CartId);
                case ComparisonOperator.LessThan:
                    return queryable.Where(c => cartId < c.CartId);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(c => cartId <= c.CartId);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(c => c.CartId != cartId);
                default:
                    return queryable.Where(c => c.CartId == cartId);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.CartId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="cartId">CartId to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByCartId(this IQueryable<PetShop.Core.Data.Cart> queryable, int cartId, params int[] additionalValues)
        {
            var cartIdList = new List<int> { cartId };

            if (additionalValues != null)
                cartIdList.AddRange(additionalValues);

            if (cartIdList.Count == 1)
                return queryable.ByCartId(cartIdList[0]);

            return queryable.ByCartId(cartIdList);
        }

        /// <summary>
        /// Gets a query for <see cref="PetShop.Core.Data.Cart.CartId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<PetShop.Core.Data.Cart> ByCartId(this IQueryable<PetShop.Core.Data.Cart> queryable, IEnumerable<int> values)
        {
            return queryable.Where(c => values.Contains(c.CartId));
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            internal static readonly Func<PetShop.Core.Data.PetShopDataContext, int, PetShop.Core.Data.Cart> GetByKey =
                System.Data.Linq.CompiledQuery.Compile(
                    (PetShop.Core.Data.PetShopDataContext db, int cartId) =>
                        db.Cart.FirstOrDefault(c => c.CartId == cartId));

        }
        #endregion
    }
}
