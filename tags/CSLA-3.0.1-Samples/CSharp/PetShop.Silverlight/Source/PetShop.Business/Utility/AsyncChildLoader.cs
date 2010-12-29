﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v4.0.0.
//     Changes to this template will be lost.
//
//     Template: AsyncChildLoader.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Csla;
using Csla.Serialization;

#endregion

namespace PetShop.Business
{
    [Serializable]
    public class AsyncChildLoader<T> : ReadOnlyBase<AsyncChildLoader<T>>
    {
        public static PropertyInfo<T> ChildProperty = RegisterProperty<T>(c => c.Child);
        public T Child
        {
            get { return ReadProperty(ChildProperty); }
            private set { LoadProperty(ChildProperty, value); }
        }

        private void DataPortal_Fetch()
        {
            Child = DataPortal.FetchChild<T>();
        }

        protected override void DataPortal_Fetch(object criteria)
        {
            Child = DataPortal.FetchChild<T>(criteria);
        }
    }
}