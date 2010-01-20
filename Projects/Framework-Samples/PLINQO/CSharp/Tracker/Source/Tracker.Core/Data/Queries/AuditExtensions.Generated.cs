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
    /// The query extension class for Audit.
    /// </summary>
    public static partial class AuditExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static Tracker.Core.Data.Audit GetByKey(this IQueryable<Tracker.Core.Data.Audit> queryable, int id)
        {
            var entity = queryable as System.Data.Linq.Table<Tracker.Core.Data.Audit>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.GetByKey.Invoke((Tracker.Core.Data.TrackerDataContext)entity.Context, id);

            return queryable.FirstOrDefault(a => a.Id == id);
        }

        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        /// <returns>The number of rows deleted from the database.</returns>
        public static int Delete(this System.Data.Linq.Table<Tracker.Core.Data.Audit> table, int id)
        {
            return table.Delete(a => a.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ById(this IQueryable<Tracker.Core.Data.Audit> queryable, int id)
        {
            return queryable.Where(a => a.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ById(this IQueryable<Tracker.Core.Data.Audit> queryable, int id, ComparisonOperator comparisonOperator)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(a => id > a.Id);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(a => id >= a.Id);
                case ComparisonOperator.LessThan:
                    return queryable.Where(a => id < a.Id);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(a => id <= a.Id);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(a => a.Id != id);
                default:
                    return queryable.Where(a => a.Id == id);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ById(this IQueryable<Tracker.Core.Data.Audit> queryable, int id, params int[] additionalValues)
        {
            var idList = new List<int> { id };

            if (additionalValues != null)
                idList.AddRange(additionalValues);

            if (idList.Count == 1)
                return queryable.ById(idList[0]);

            return queryable.ById(idList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ById(this IQueryable<Tracker.Core.Data.Audit> queryable, IEnumerable<int> values)
        {
            return queryable.Where(a => values.Contains(a.Id));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="createdDate">CreatedDate to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByCreatedDate(this IQueryable<Tracker.Core.Data.Audit> queryable, System.DateTime createdDate)
        {
            return queryable.Where(a => a.CreatedDate == createdDate);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="createdDate">CreatedDate to search for.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByCreatedDate(this IQueryable<Tracker.Core.Data.Audit> queryable, System.DateTime createdDate, ComparisonOperator comparisonOperator)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(a => createdDate > a.CreatedDate);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(a => createdDate >= a.CreatedDate);
                case ComparisonOperator.LessThan:
                    return queryable.Where(a => createdDate < a.CreatedDate);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(a => createdDate <= a.CreatedDate);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(a => a.CreatedDate != createdDate);
                default:
                    return queryable.Where(a => a.CreatedDate == createdDate);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="createdDate">CreatedDate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByCreatedDate(this IQueryable<Tracker.Core.Data.Audit> queryable, System.DateTime createdDate, params System.DateTime[] additionalValues)
        {
            var createdDateList = new List<System.DateTime> { createdDate };

            if (additionalValues != null)
                createdDateList.AddRange(additionalValues);

            if (createdDateList.Count == 1)
                return queryable.ByCreatedDate(createdDateList[0]);

            return queryable.ByCreatedDate(createdDateList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByCreatedDate(this IQueryable<Tracker.Core.Data.Audit> queryable, IEnumerable<System.DateTime> values)
        {
            return queryable.Where(a => values.Contains(a.CreatedDate));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Date"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="date">Date to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByDate(this IQueryable<Tracker.Core.Data.Audit> queryable, System.DateTime date)
        {
            return queryable.Where(a => a.Date == date);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Date"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="date">Date to search for.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByDate(this IQueryable<Tracker.Core.Data.Audit> queryable, System.DateTime date, ComparisonOperator comparisonOperator)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(a => date > a.Date);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(a => date >= a.Date);
                case ComparisonOperator.LessThan:
                    return queryable.Where(a => date < a.Date);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(a => date <= a.Date);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(a => a.Date != date);
                default:
                    return queryable.Where(a => a.Date == date);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Date"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="date">Date to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByDate(this IQueryable<Tracker.Core.Data.Audit> queryable, System.DateTime date, params System.DateTime[] additionalValues)
        {
            var dateList = new List<System.DateTime> { date };

            if (additionalValues != null)
                dateList.AddRange(additionalValues);

            if (dateList.Count == 1)
                return queryable.ByDate(dateList[0]);

            return queryable.ByDate(dateList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Date"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByDate(this IQueryable<Tracker.Core.Data.Audit> queryable, IEnumerable<System.DateTime> values)
        {
            return queryable.Where(a => values.Contains(a.Date));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Username"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="username">Username to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByUsername(this IQueryable<Tracker.Core.Data.Audit> queryable, string username)
        {
            return queryable.Where(a => a.Username == username);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Username"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="username">Username to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByUsername(this IQueryable<Tracker.Core.Data.Audit> queryable, string username, ContainmentOperator containmentOperator)
        {
            if (username == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("username", "Parameter 'username' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(a => a.Username.Contains(username));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(a => a.Username.StartsWith(username));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(a => a.Username.EndsWith(username));
                case ContainmentOperator.NotContains:
                    return queryable.Where(a => a.Username.Contains(username) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(a => a.Username != username);
                default:
                    return queryable.Where(a => a.Username == username);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Username"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="username">Username to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByUsername(this IQueryable<Tracker.Core.Data.Audit> queryable, string username, params string[] additionalValues)
        {
            var usernameList = new List<string> { username };

            if (additionalValues != null)
                usernameList.AddRange(additionalValues);

            if (usernameList.Count == 1)
                return queryable.ByUsername(usernameList[0]);

            return queryable.ByUsername(usernameList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Username"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByUsername(this IQueryable<Tracker.Core.Data.Audit> queryable, IEnumerable<string> values)
        {
            return queryable.Where(a => values.Contains(a.Username));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Content"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="content">Content to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByContent(this IQueryable<Tracker.Core.Data.Audit> queryable, string content)
        {
            return queryable.Where(a => a.Content == content);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Content"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="content">Content to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByContent(this IQueryable<Tracker.Core.Data.Audit> queryable, string content, ContainmentOperator containmentOperator)
        {
            if (content == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("content", "Parameter 'content' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(a => a.Content.Contains(content));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(a => a.Content.StartsWith(content));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(a => a.Content.EndsWith(content));
                case ContainmentOperator.NotContains:
                    return queryable.Where(a => a.Content.Contains(content) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(a => a.Content != content);
                default:
                    return queryable.Where(a => a.Content == content);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Content"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="content">Content to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByContent(this IQueryable<Tracker.Core.Data.Audit> queryable, string content, params string[] additionalValues)
        {
            var contentList = new List<string> { content };

            if (additionalValues != null)
                contentList.AddRange(additionalValues);

            if (contentList.Count == 1)
                return queryable.ByContent(contentList[0]);

            return queryable.ByContent(contentList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Content"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByContent(this IQueryable<Tracker.Core.Data.Audit> queryable, IEnumerable<string> values)
        {
            return queryable.Where(a => values.Contains(a.Content));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.UserId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="userId">UserId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByUserId(this IQueryable<Tracker.Core.Data.Audit> queryable, int? userId)
        {
            // support nulls
            return userId == null 
                ? queryable.Where(a => a.UserId == null) 
                : queryable.Where(a => a.UserId == userId);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.UserId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="userId">UserId to search for.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByUserId(this IQueryable<Tracker.Core.Data.Audit> queryable, int? userId, ComparisonOperator comparisonOperator)
        {
            if (userId == null && comparisonOperator != ComparisonOperator.Equals && comparisonOperator != ComparisonOperator.NotEquals)
                throw new ArgumentNullException("userId", "Parameter 'userId' cannot be null with the specified ComparisonOperator.  Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support null.");

            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(a => userId > a.UserId);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(a => userId >= a.UserId);
                case ComparisonOperator.LessThan:
                    return queryable.Where(a => userId < a.UserId);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(a => userId <= a.UserId);
                case ComparisonOperator.NotEquals:
                    return userId == null 
                        ? queryable.Where(a => a.UserId != null) 
                        : queryable.Where(a => a.UserId != userId);
                default:
                    return userId == null 
                        ? queryable.Where(a => a.UserId == null) 
                        : queryable.Where(a => a.UserId == userId);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.UserId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="userId">UserId to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByUserId(this IQueryable<Tracker.Core.Data.Audit> queryable, int? userId, params int?[] additionalValues)
        {
            var userIdList = new List<int?> { userId };

            if (additionalValues != null)
                userIdList.AddRange(additionalValues);
            else
                userIdList.Add(null);

            if (userIdList.Count == 1)
                return queryable.ByUserId(userIdList[0]);

            return queryable.ByUserId(userIdList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.UserId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByUserId(this IQueryable<Tracker.Core.Data.Audit> queryable, IEnumerable<int?> values)
        {
            // creating dynmic expression to support nulls
            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.Audit, bool>("UserId", values);
            return queryable.Where(expression);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.TaskId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="taskId">TaskId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByTaskId(this IQueryable<Tracker.Core.Data.Audit> queryable, int? taskId)
        {
            // support nulls
            return taskId == null 
                ? queryable.Where(a => a.TaskId == null) 
                : queryable.Where(a => a.TaskId == taskId);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.TaskId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="taskId">TaskId to search for.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByTaskId(this IQueryable<Tracker.Core.Data.Audit> queryable, int? taskId, ComparisonOperator comparisonOperator)
        {
            if (taskId == null && comparisonOperator != ComparisonOperator.Equals && comparisonOperator != ComparisonOperator.NotEquals)
                throw new ArgumentNullException("taskId", "Parameter 'taskId' cannot be null with the specified ComparisonOperator.  Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support null.");

            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(a => taskId > a.TaskId);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(a => taskId >= a.TaskId);
                case ComparisonOperator.LessThan:
                    return queryable.Where(a => taskId < a.TaskId);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(a => taskId <= a.TaskId);
                case ComparisonOperator.NotEquals:
                    return taskId == null 
                        ? queryable.Where(a => a.TaskId != null) 
                        : queryable.Where(a => a.TaskId != taskId);
                default:
                    return taskId == null 
                        ? queryable.Where(a => a.TaskId == null) 
                        : queryable.Where(a => a.TaskId == taskId);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.TaskId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="taskId">TaskId to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByTaskId(this IQueryable<Tracker.Core.Data.Audit> queryable, int? taskId, params int?[] additionalValues)
        {
            var taskIdList = new List<int?> { taskId };

            if (additionalValues != null)
                taskIdList.AddRange(additionalValues);
            else
                taskIdList.Add(null);

            if (taskIdList.Count == 1)
                return queryable.ByTaskId(taskIdList[0]);

            return queryable.ByTaskId(taskIdList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.TaskId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByTaskId(this IQueryable<Tracker.Core.Data.Audit> queryable, IEnumerable<int?> values)
        {
            // creating dynmic expression to support nulls
            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.Audit, bool>("TaskId", values);
            return queryable.Where(expression);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Myxml"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="myxml">Myxml to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByMyxml(this IQueryable<Tracker.Core.Data.Audit> queryable, string myxml)
        {
            // support nulls
            return myxml == null 
                ? queryable.Where(a => a.Myxml == null) 
                : queryable.Where(a => a.Myxml == myxml);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Myxml"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="myxml">Myxml to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByMyxml(this IQueryable<Tracker.Core.Data.Audit> queryable, string myxml, ContainmentOperator containmentOperator)
        {
            if (myxml == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("myxml", "Parameter 'myxml' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(a => a.Myxml.Contains(myxml));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(a => a.Myxml.StartsWith(myxml));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(a => a.Myxml.EndsWith(myxml));
                case ContainmentOperator.NotContains:
                    return queryable.Where(a => a.Myxml.Contains(myxml) == false);
                case ContainmentOperator.NotEquals:
                    return myxml == null 
                        ? queryable.Where(a => a.Myxml != null) 
                        : queryable.Where(a => a.Myxml != myxml);
                default:
                    return myxml == null 
                        ? queryable.Where(a => a.Myxml == null) 
                        : queryable.Where(a => a.Myxml == myxml);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Myxml"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="myxml">Myxml to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByMyxml(this IQueryable<Tracker.Core.Data.Audit> queryable, string myxml, params string[] additionalValues)
        {
            var myxmlList = new List<string> { myxml };

            if (additionalValues != null)
                myxmlList.AddRange(additionalValues);
            else
                myxmlList.Add(null);

            if (myxmlList.Count == 1)
                return queryable.ByMyxml(myxmlList[0]);

            return queryable.ByMyxml(myxmlList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Audit.Myxml"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        public static IQueryable<Tracker.Core.Data.Audit> ByMyxml(this IQueryable<Tracker.Core.Data.Audit> queryable, IEnumerable<string> values)
        {
            // creating dynmic expression to support nulls
            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.Audit, bool>("Myxml", values);
            return queryable.Where(expression);
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            internal static readonly Func<Tracker.Core.Data.TrackerDataContext, int, Tracker.Core.Data.Audit> GetByKey =
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Core.Data.TrackerDataContext db, int id) =>
                        db.Audit.FirstOrDefault(a => a.Id == id));

        }
        #endregion
    }
}

