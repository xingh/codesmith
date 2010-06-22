﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using CodeSmith.Data.Rules;

namespace CodeSmith.Data.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple= false)]
    sealed public class UserNameAttribute : ValidationAttribute
    {

        public UserNameAttribute()
        {
            IsStateSet = false;
        }

        public UserNameAttribute(EntityState state)
        {
            State = state;
            IsStateSet = true;
        }

        public override bool IsValid(object value)
        {
            if (value != null)
                throw new ValidationException(ErrorMessage);
            return true;
        }
        
        public EntityState State { get; private set; }

        public bool IsStateSet { get; private set; }

        private string _errorMessage = "This field is automatically set.";

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }
    }
}