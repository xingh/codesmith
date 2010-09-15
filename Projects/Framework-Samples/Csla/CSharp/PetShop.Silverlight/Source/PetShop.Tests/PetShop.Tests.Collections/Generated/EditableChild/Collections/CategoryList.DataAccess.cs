﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'CategoryList.cs'.
//
//     Template: EditableChildList.DataAccess.StoredProcedures.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Tests.Collections.EditableChild
{
    public partial class CategoryList
    {
        protected override void Child_Create()
        {
            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return;
        
            OnCreated();
        }
    
        private void Child_Fetch(CategoryCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            RaiseListChangedEvents = false;

            // Fetch Child objects.
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("[dbo].[CSLA_Category_Select]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_NameHasValue", criteria.NameHasValue);
					command.Parameters.AddWithValue("@p_DescnHasValue", criteria.DescriptionHasValue);
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                            do
                            {
                                this.Add(new PetShop.Tests.Collections.EditableChild.Category(reader));
                            } while(reader.Read());
                        }
                    }
                }
            }

            RaiseListChangedEvents = true;

            OnFetched();
        }
        
        /// <summary>
        /// Updates the child object.
        /// </summary>
        /// <param name="parameters">The parameters collection may contain more parameters than needed based on the context it was called. We need to filter this list.</param>
        protected override void Child_Update(params object[] parameters)
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

            // We require that one of the parameters be a connection so we can do the CRUD operations.
            SqlConnection connection = parameters.OfType<SqlConnection>().FirstOrDefault();
            if (connection == null)
                throw new ArgumentNullException("parameters", "Must contain a SqlConnection parameter.");

            RaiseListChangedEvents = false;

            foreach (var item in DeletedList)
            {
                DataPortal.UpdateChild(item, connection);
            }

            DeletedList.Clear();
            
            // Trim down the list to what is actually contained in the child class.
            var list = new System.Collections.Generic.Dictionary<string, object>() {};
            foreach (object o in parameters)
            {
                if(o == null) continue;

                var key = o.GetType().ToString();
                if (!list.ContainsKey(key))
                    list.Add(key, o);
            }

            foreach (var item in Items)
            {
                DataPortal.UpdateChild(item, list.Values.ToArray());
            }

            RaiseListChangedEvents = true;

            OnUpdated();
        }
    }
}
