//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.8.X CodeSmith Templates.
//       Changes to this template will not be lost.
//
//     Template: EditableChild.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Security;
using Csla.Validation;

#endregion

namespace PetShop.Tests.ParameterizedSQL
{
    public partial class OrderStatus
    {
        #region Validation Rules

        /// <summary>
        /// All custom rules need to be placed in this method.
        /// </summary>
        /// <returns>Return true to override the generated rules; If false generated rules will be run.</returns>
        protected bool AddBusinessValidationRules()
        {
            // TODO: add validation rules
            //ValidationRules.AddRule(RuleMethod, "");

            return false;
        }

        #endregion

        #region Authorization Rules

        protected override void AddAuthorizationRules()
        {
            //// More information on these rules can be found here (http://www.devx.com/codemag/Article/40663/1763/page/2).

            //string[] canWrite = { "AdminUser", "RegularUser" };
            //string[] canRead = { "AdminUser", "RegularUser", "ReadOnlyUser" };
            //string[] admin = { "AdminUser" };

            // AuthorizationRules.AllowCreate(typeof(OrderStatus), admin);
            // AuthorizationRules.AllowDelete(typeof(OrderStatus), admin);
            // AuthorizationRules.AllowEdit(typeof(OrderStatus), canWrite);
            // AuthorizationRules.AllowGet(typeof(OrderStatus), canRead);

            //// OrderId
            // AuthorizationRules.AllowRead(_orderIdProperty, canRead);

            //// LineNum
            // AuthorizationRules.AllowRead(_lineNumProperty, canRead);

            //// Timestamp
            // AuthorizationRules.AllowRead(_timestampProperty, canRead);

            //// Status
            // AuthorizationRules.AllowRead(_statusProperty, canRead);

            //// OrderMember
            // AuthorizationRules.AllowRead(_orderMemberProperty, canRead);

// NOTE: Many-To-Many support coming soon.
        }

        #endregion
    }
}