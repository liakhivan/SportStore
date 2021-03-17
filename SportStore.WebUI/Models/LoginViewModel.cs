﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.WebUI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please, enter email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please, enter password.")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}