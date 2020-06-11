﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tuận.ViewModels
{
    public class ValidTime : ValidationAttribute
    {
        // GET: ValidTime
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "HH:mm",
                CultureInfo.CurrentCulture,
                System.Globalization.DateTimeStyles.None,
                out dateTime);

            return isValid ;
        }
        
    }
}