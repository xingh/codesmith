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

namespace Tracker.Core.Data
{
    /// <summary>
    /// The query extension class for TaskExtended.
    /// </summary>
    public static partial class TaskExtendedExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static Tracker.Core.Data.TaskExtended GetByKey(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, int taskId)
        {
            var entity = queryable as System.Data.Linq.Table<Tracker.Core.Data.TaskExtended>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.GetByKey.Invoke((Tracker.Core.Data.TrackerDataContext)entity.Context, taskId);

            return queryable.FirstOrDefault(t => t.TaskId == taskId);
        }

        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        /// <returns>The number of rows deleted from the database.</returns>
        public static int Delete(this System.Data.Linq.Table<Tracker.Core.Data.TaskExtended> table, int taskId)
        {
            return table.Delete(t => t.TaskId == taskId);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.TaskId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="taskId">TaskId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByTaskId(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, int taskId)
        {
            return queryable.Where(t => t.TaskId == taskId);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.TaskId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="taskId">TaskId to search for.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByTaskId(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, int taskId, ComparisonOperator comparisonOperator)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(t => taskId > t.TaskId);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(t => taskId >= t.TaskId);
                case ComparisonOperator.LessThan:
                    return queryable.Where(t => taskId < t.TaskId);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(t => taskId <= t.TaskId);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(t => t.TaskId != taskId);
                default:
                    return queryable.Where(t => t.TaskId == taskId);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.TaskId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="taskId">TaskId to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByTaskId(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, int taskId, params int[] additionalValues)
        {
            var taskIdList = new List<int> { taskId };

            if (additionalValues != null)
                taskIdList.AddRange(additionalValues);

            if (taskIdList.Count == 1)
                return queryable.ByTaskId(taskIdList[0]);

            return queryable.ByTaskId(taskIdList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.TaskId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByTaskId(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, IEnumerable<int> values)
        {
            return queryable.Where(t => values.Contains(t.TaskId));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.Browser"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="browser">Browser to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByBrowser(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, string browser)
        {
            // support nulls
            return browser == null 
                ? queryable.Where(t => t.Browser == null) 
                : queryable.Where(t => t.Browser == browser);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.Browser"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="browser">Browser to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByBrowser(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, string browser, ContainmentOperator containmentOperator)
        {
            if (browser == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("browser", "Parameter 'browser' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(t => t.Browser.Contains(browser));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(t => t.Browser.StartsWith(browser));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(t => t.Browser.EndsWith(browser));
                case ContainmentOperator.NotContains:
                    return queryable.Where(t => t.Browser.Contains(browser) == false);
                case ContainmentOperator.NotEquals:
                    return browser == null 
                        ? queryable.Where(t => t.Browser != null) 
                        : queryable.Where(t => t.Browser != browser);
                default:
                    return browser == null 
                        ? queryable.Where(t => t.Browser == null) 
                        : queryable.Where(t => t.Browser == browser);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.Browser"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="browser">Browser to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByBrowser(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, string browser, params string[] additionalValues)
        {
            var browserList = new List<string> { browser };

            if (additionalValues != null)
                browserList.AddRange(additionalValues);
            else
                browserList.Add(null);

            if (browserList.Count == 1)
                return queryable.ByBrowser(browserList[0]);

            return queryable.ByBrowser(browserList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.Browser"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByBrowser(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, IEnumerable<string> values)
        {
            // creating dynmic expression to support nulls
            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.TaskExtended, bool>("Browser", values);
            return queryable.Where(expression);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.Os"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="os">Os to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByOs(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, string os)
        {
            // support nulls
            return os == null 
                ? queryable.Where(t => t.Os == null) 
                : queryable.Where(t => t.Os == os);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.Os"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="os">Os to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByOs(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, string os, ContainmentOperator containmentOperator)
        {
            if (os == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("os", "Parameter 'os' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(t => t.Os.Contains(os));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(t => t.Os.StartsWith(os));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(t => t.Os.EndsWith(os));
                case ContainmentOperator.NotContains:
                    return queryable.Where(t => t.Os.Contains(os) == false);
                case ContainmentOperator.NotEquals:
                    return os == null 
                        ? queryable.Where(t => t.Os != null) 
                        : queryable.Where(t => t.Os != os);
                default:
                    return os == null 
                        ? queryable.Where(t => t.Os == null) 
                        : queryable.Where(t => t.Os == os);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.Os"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="os">Os to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByOs(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, string os, params string[] additionalValues)
        {
            var osList = new List<string> { os };

            if (additionalValues != null)
                osList.AddRange(additionalValues);
            else
                osList.Add(null);

            if (osList.Count == 1)
                return queryable.ByOs(osList[0]);

            return queryable.ByOs(osList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.Os"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByOs(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, IEnumerable<string> values)
        {
            // creating dynmic expression to support nulls
            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.TaskExtended, bool>("Os", values);
            return queryable.Where(expression);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="createdDate">CreatedDate to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByCreatedDate(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, System.DateTime createdDate)
        {
            return queryable.Where(t => t.CreatedDate == createdDate);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="createdDate">CreatedDate to search for.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByCreatedDate(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, System.DateTime createdDate, ComparisonOperator comparisonOperator)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(t => createdDate > t.CreatedDate);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(t => createdDate >= t.CreatedDate);
                case ComparisonOperator.LessThan:
                    return queryable.Where(t => createdDate < t.CreatedDate);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(t => createdDate <= t.CreatedDate);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(t => t.CreatedDate != createdDate);
                default:
                    return queryable.Where(t => t.CreatedDate == createdDate);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="createdDate">CreatedDate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByCreatedDate(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, System.DateTime createdDate, params System.DateTime[] additionalValues)
        {
            var createdDateList = new List<System.DateTime> { createdDate };

            if (additionalValues != null)
                createdDateList.AddRange(additionalValues);

            if (createdDateList.Count == 1)
                return queryable.ByCreatedDate(createdDateList[0]);

            return queryable.ByCreatedDate(createdDateList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByCreatedDate(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, IEnumerable<System.DateTime> values)
        {
            return queryable.Where(t => values.Contains(t.CreatedDate));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="modifiedDate">ModifiedDate to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByModifiedDate(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, System.DateTime modifiedDate)
        {
            return queryable.Where(t => t.ModifiedDate == modifiedDate);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="modifiedDate">ModifiedDate to search for.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByModifiedDate(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, System.DateTime modifiedDate, ComparisonOperator comparisonOperator)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(t => modifiedDate > t.ModifiedDate);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(t => modifiedDate >= t.ModifiedDate);
                case ComparisonOperator.LessThan:
                    return queryable.Where(t => modifiedDate < t.ModifiedDate);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(t => modifiedDate <= t.ModifiedDate);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(t => t.ModifiedDate != modifiedDate);
                default:
                    return queryable.Where(t => t.ModifiedDate == modifiedDate);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="modifiedDate">ModifiedDate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByModifiedDate(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, System.DateTime modifiedDate, params System.DateTime[] additionalValues)
        {
            var modifiedDateList = new List<System.DateTime> { modifiedDate };

            if (additionalValues != null)
                modifiedDateList.AddRange(additionalValues);

            if (modifiedDateList.Count == 1)
                return queryable.ByModifiedDate(modifiedDateList[0]);

            return queryable.ByModifiedDate(modifiedDateList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.TaskExtended.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.TaskExtended> ByModifiedDate(this IQueryable<Tracker.Core.Data.TaskExtended> queryable, IEnumerable<System.DateTime> values)
        {
            return queryable.Where(t => values.Contains(t.ModifiedDate));
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            internal static readonly Func<Tracker.Core.Data.TrackerDataContext, int, Tracker.Core.Data.TaskExtended> GetByKey =
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Core.Data.TrackerDataContext db, int taskId) =>
                        db.TaskExtended.FirstOrDefault(t => t.TaskId == taskId));

        }
        #endregion
    }
}

