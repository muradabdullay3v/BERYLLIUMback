﻿using System.ComponentModel.DataAnnotations;

namespace BERYLLIUM.ViewModels.Account
{
    public class RegisterVM
    {
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }
        [Required,DataType(DataType.Password),Compare(nameof(Password),ErrorMessage ="Password does not match")]
        public string CheckPassword { get; set; }
    }
}
