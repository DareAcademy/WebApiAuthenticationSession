﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionWebApi2102.Model
{
    public class SignInModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RemeberMe { get; set; }
    }
}
