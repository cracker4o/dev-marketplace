﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UI.Localization;

namespace UI.Models
{
    public class RegisterViewModel
    {
        [Required, DataType(DataType.Text), Display(ResourceType = typeof(AccountContent), Name = "FirstNameText")]
        public string FirstName { get; set; }

        [Required, DataType(DataType.Text), Display(ResourceType = typeof(AccountContent), Name = "LastNameText")]
        public string LastName { get; set; }

        [Required, DataType(DataType.EmailAddress), Display(Name = "EmailText", ResourceType = typeof(AccountContent))]
        public string Email { get; set; }

        [Required, DataType(DataType.Password), Display(Name = "PasswordText", ResourceType = typeof(AccountContent))]
        public string Password { get; set; }
    }
}
