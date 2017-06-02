using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailUnsubscribe.Domain.Enums
{
    public class DomainConfig
    {
        public enum Enums
        {
            PasswordSalt
        }

        protected static Dictionary<Enums, string> EnumValues = new Dictionary<Enums, string>() {
            { Enums.PasswordSalt, "EmailUnsubscribe" }
        };

        public static string GetValue(Enums enumKey)
        {
            if (EnumValues.Keys.Contains(enumKey))
                return EnumValues[enumKey];
            return "EmailUnsubscribe";
        }
    }
}
