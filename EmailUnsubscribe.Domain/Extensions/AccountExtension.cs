using EmailUnsubscribe.Domain.Enums;
using System;
using System.Security.Cryptography;
using System.Text;

namespace EmailUnsubscribe.Domain.Extensions
{
    public static class AccountExtension
    {
        public static string HashPassword(this string originPassword)
        {
            if (!string.IsNullOrEmpty(originPassword))
            {
                string saltPassword = string.Concat(originPassword, DomainConfig.GetValue(DomainConfig.Enums.PasswordSalt));
                var sha512 = new SHA512CryptoServiceProvider();
                return Convert.ToBase64String(sha512.ComputeHash(new UTF8Encoding().GetBytes(saltPassword)));
            }
            return string.Empty;
        }
    }
}
