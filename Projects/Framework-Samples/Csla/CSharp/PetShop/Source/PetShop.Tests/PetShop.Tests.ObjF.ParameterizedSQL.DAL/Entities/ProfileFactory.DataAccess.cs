//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Profile.cs'.
//
//     Template: ObjectFactory.DataAccess.ParameterizedSQL.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;

using Csla;
using Csla.Data;
using Csla.Server;

using PetShop.Tests.ObjF.ParameterizedSQL;

#endregion

namespace PetShop.Tests.ObjF.ParameterizedSQL.DAL
{
    public partial class ProfileFactory : ObjectFactory
    {
        #region Create

        /// <summary>
        /// Creates new Profile with default values.
        /// </summary>
        /// <returns>new Profile.</returns>
        [RunLocal]
        public Profile Create()
        {
            var item = (Profile)Activator.CreateInstance(typeof(Profile), true);

            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return item;

            using (BypassPropertyChecks(item))
            {
                // Default values.
            }

            CheckRules(item);
            MarkNew(item);
            OnCreated();

            return item;
        }

        /// <summary>
        /// Creates new Profile with default values.
        /// </summary>
        /// <returns>new Profile.</returns>
        [RunLocal]
        private Profile Create(ProfileCriteria criteria)
        {
            var item = (Profile)Activator.CreateInstance(typeof(Profile), true);

            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return item;

            var resource = Fetch(criteria);
            using (BypassPropertyChecks(item))
            {
                item.Username = resource.Username;
                item.ApplicationName = resource.ApplicationName;
                item.IsAnonymous = resource.IsAnonymous;
                item.LastActivityDate = resource.LastActivityDate;
                item.LastUpdatedDate = resource.LastUpdatedDate;
            }

            CheckRules(item);
            MarkNew(item);

            OnCreated();

            return item;
        }

        #endregion

        #region Fetch

        /// <summary>
        /// Fetch Profile.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public Profile Fetch(ProfileCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return null;

            Profile item;
            string commandText = string.Format("SELECT [UniqueID], [Username], [ApplicationName], [IsAnonymous], [LastActivityDate], [LastUpdatedDate] FROM [dbo].[Profiles] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if (reader.Read())
                            item = Map(reader);
                        else
                            throw new Exception(String.Format("The record was not found in 'Profiles' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnFetched();
            return item;
        }

        #endregion

        #region Insert

        private void DoInsert(ref Profile item, bool stopProccessingChildren)
        {
            // Don't update if the item isn't dirty.
            if (!item.IsDirty) return;

            bool cancel = false;
            OnInserting(ref cancel);
            if (cancel) return;

            const string commandText = "INSERT INTO [dbo].[Profiles] ([Username], [ApplicationName], [IsAnonymous], [LastActivityDate], [LastUpdatedDate]) VALUES (@p_Username, @p_ApplicationName, @p_IsAnonymous, @p_LastActivityDate, @p_LastUpdatedDate); SELECT [UniqueID] FROM [dbo].[Profiles] WHERE UniqueID = SCOPE_IDENTITY()";
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@p_Username", item.Username);
					command.Parameters.AddWithValue("@p_ApplicationName", item.ApplicationName);
					command.Parameters.AddWithValue("@p_IsAnonymous", ADOHelper.NullCheck(item.IsAnonymous));
					command.Parameters.AddWithValue("@p_LastActivityDate", ADOHelper.NullCheck(item.LastActivityDate));
					command.Parameters.AddWithValue("@p_LastUpdatedDate", ADOHelper.NullCheck(item.LastUpdatedDate));

                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                            item.UniqueID = reader.GetInt32("UniqueID");
                        }
                    }
                }
            }


            MarkOld(item);
            CheckRules(item);
            
            if(!stopProccessingChildren)
            {
            // Update Child Items.
                Update_Account_Accounts_UniqueID(ref item);
                Update_Cart_Carts_UniqueID(ref item);
            }

            OnInserted();
        }

        #endregion

        #region Update

        [Transactional(TransactionalTypes.TransactionScope)]
        public Profile Update(Profile item)
        {
            return Update(item, false);
        }

        public Profile Update(Profile item, bool stopProccessingChildren)
        {
            if(item.IsDeleted)
            {
                DoDelete(ref item);
                MarkNew(item);
            }
            else if(item.IsNew)
            {
                DoInsert(ref item, stopProccessingChildren);
            }
            else
            {
                DoUpdate(ref item, stopProccessingChildren);
            }

            return item;
        }

        private void DoUpdate(ref Profile item, bool stopProccessingChildren)
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

            // Don't update if the item isn't dirty.
            if (item.IsDirty)
            {
                const string commandText = "UPDATE [dbo].[Profiles]  SET [Username] = @p_Username, [ApplicationName] = @p_ApplicationName, [IsAnonymous] = @p_IsAnonymous, [LastActivityDate] = @p_LastActivityDate, [LastUpdatedDate] = @p_LastUpdatedDate WHERE [UniqueID] = @p_UniqueID";
                using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(commandText, connection))
                    {
                        command.Parameters.AddWithValue("@p_UniqueID", item.UniqueID);
					command.Parameters.AddWithValue("@p_Username", item.Username);
					command.Parameters.AddWithValue("@p_ApplicationName", item.ApplicationName);
					command.Parameters.AddWithValue("@p_IsAnonymous", ADOHelper.NullCheck(item.IsAnonymous));
					command.Parameters.AddWithValue("@p_LastActivityDate", ADOHelper.NullCheck(item.LastActivityDate));
					command.Parameters.AddWithValue("@p_LastUpdatedDate", ADOHelper.NullCheck(item.LastUpdatedDate));

                        using(var reader = new SafeDataReader(command.ExecuteReader()))
                        {
                            //RecordsAffected: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                            if(reader.RecordsAffected == 0)
                                throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
    
                            if(reader.Read())
                            {
                                item.UniqueID = reader.GetInt32("UniqueID");
                            }
                        }
                    }
                }
            }


            MarkOld(item);
            CheckRules(item);

            if(!stopProccessingChildren)
            {
                // Update Child Items.
                Update_Account_Accounts_UniqueID(ref item);
                Update_Cart_Carts_UniqueID(ref item);
            }

            OnUpdated();
        }
        #endregion

        #region Delete

        [Transactional(TransactionalTypes.TransactionScope)]
        public void Delete(ProfileCriteria criteria)
        {
            // Note: this call to delete is for immediate deletion and doesn't keep track of any entity state.
            DoDelete(criteria);
        }

        protected void DoDelete(ref Profile item)
        {
            // If we're not dirty then don't update the database.
            if (!item.IsDirty) return;

            // If we're new then don't call delete.
            if (item.IsNew) return;

            var criteria = new ProfileCriteria{UniqueID = item.UniqueID};
            
            DoDelete(criteria);

            MarkNew(item);
        }

        /// <summary>
        /// This call to delete is for immediate deletion and doesn't keep track of any entity state.
        /// </summary>
        /// <param name="criteria">The Criteria.</param>
        private void DoDelete(ProfileCriteria criteria)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            string commandText = string.Format("DELETE FROM [dbo].[Profiles] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                }
            }

            OnDeleted();
        }

        #endregion

        #region Helper Methods

        public Profile Map(SafeDataReader reader)
        {
            var item = (Profile)Activator.CreateInstance(typeof(Profile), true);
            using (BypassPropertyChecks(item))
            {
                item.UniqueID = reader.GetInt32("UniqueID");
                item.Username = reader.GetString("Username");
                item.ApplicationName = reader.GetString("ApplicationName");
                item.IsAnonymous = reader.IsDBNull("IsAnonymous") ? (System.Boolean?)null : reader.GetBoolean("IsAnonymous");
                item.LastActivityDate = reader.IsDBNull("LastActivityDate") ? (System.DateTime?)null : reader.GetDateTime("LastActivityDate");
                item.LastUpdatedDate = reader.IsDBNull("LastUpdatedDate") ? (System.DateTime?)null : reader.GetDateTime("LastUpdatedDate");
            }
            
            MarkOld(item);

            return item;
        }

        //AssociatedOneToMany
        private static void Update_Account_Accounts_UniqueID(ref Profile item)
        {
            foreach(Account itemToUpdate in item.Accounts)
            {
				itemToUpdate.UniqueID = item.UniqueID;

                new AccountFactory().Update(itemToUpdate, true);
            }
        }
        //AssociatedOneToMany
        private static void Update_Cart_Carts_UniqueID(ref Profile item)
        {
            foreach(Cart itemToUpdate in item.Carts)
            {
				itemToUpdate.UniqueID = item.UniqueID;

                new CartFactory().Update(itemToUpdate, true);
            }
        }

        #endregion

        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(ProfileCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnInserting(ref bool cancel);
        partial void OnInserted();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnSelfDeleting(ref bool cancel);
        partial void OnSelfDeleted();
        partial void OnDeleting(ProfileCriteria criteria, ref bool cancel);
        partial void OnDeleted();
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
    }
}