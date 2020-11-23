﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FootballFieldManagement.ViewModels
{
    class TextBoxValidation : ValidationRule
    {
        public int Minimum { get; set; }

        public int Maximum { get; set; }

        public string ErrorMessage { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            ValidationResult result = new ValidationResult(true, null);
            if(value.ToString().Length == 0)
            {
                result = new ValidationResult(false, "Vui lòng nhập tên đăng nhập");
            }
            foreach (char i in value.ToString())
            {
                if (!((i >= 48 && i <= 57) || (i >= 65 && i <= 90) || (i >= 97 && i <= 122)))
                {
                    result = new ValidationResult(false, this.ErrorMessage);
                }
            }
            return result;
        }
    }
}
