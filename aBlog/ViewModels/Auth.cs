﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace aBlog.ViewModels
{
    public class AuthLogin
    {
        [Required]
        public string username { get; set; }
        [Required, DataType(DataType.Password)]
        public string password { get; set; }

    }
}