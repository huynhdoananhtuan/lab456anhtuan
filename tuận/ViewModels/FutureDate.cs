using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tuận.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        // GET: FutureDate
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isVaLid = DateTime.TryParseExact(Convert.ToString(value),
                "dd/M/yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);
            return (isVaLid && dateTime > DateTime.Now);
        }
       
    }
}