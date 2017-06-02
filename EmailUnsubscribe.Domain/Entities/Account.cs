using EmailUnsubscribe.Domain.Extensions;
using EmailUnsubscribe.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace EmailUnsubscribe.Domain.Entities
{
    public class Account
    {
        public Account(string userName, string passWord)
        {
            Username = userName;
            _originPassword = passWord;
            HashPassword = _originPassword.HashPassword();
        }

        public string Username { get; private set; }
        public string HashPassword { get; private set; }
        private string _originPassword;

        // Navigation property
        [ForeignKey("Id")]
        [Required]
        public virtual Person Person { get; set; }
    }
}