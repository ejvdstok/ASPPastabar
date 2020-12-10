﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPPastabar
{
    public class VerledenAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return true;
            if (!(value is DateTime))
                return false;
            return ((DateTime)value) < DateTime.Today;
        }
    }
}