//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.1357, CSLA Framework: v3.8.0.
//       Changes to this template will not be lost.
//
//     Template: EditableRootList.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;
using Csla;

#endregion

namespace PetShop.Tests.ParameterizedSQL
{
    public partial class CategoryList
    {
        #region Authorization Rules

        protected void AddAuthorizationRules()
        {
            //// More information on these rules can be found here (http://www.devx.com/codemag/Article/40663/1763/page/2).

            //string[] canWrite = { "AdminUser", "RegularUser" };
            //string[] canRead = { "AdminUser", "RegularUser", "ReadOnlyUser" };
            //string[] admin = { "AdminUser" };

            // AuthorizationRules.AllowCreate(typeof(CategoryList), admin);
            // AuthorizationRules.AllowDelete(typeof(CategoryList), admin);
            // AuthorizationRules.AllowEdit(typeof(CategoryList), canWrite);
            // AuthorizationRules.AllowGet(typeof(CategoryList), canRead);

            //// CategoryId
            // AuthorizationRules.AllowRead(_categoryIdProperty, canRead);

            //// Name
            // AuthorizationRules.AllowRead(_nameProperty, canRead);

            //// Descn
            // AuthorizationRules.AllowRead(_descnProperty, canRead);

// NOTE: Many-To-Many support coming soon.
            //// Products
            // AuthorizationRules.AllowRead(_productsProperty, canRead);

        }

        #endregion

    }
}