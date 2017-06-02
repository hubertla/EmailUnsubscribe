using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailUnsubscribe.Domain.Entities
{
    public class Person : BaseEntity<int>
    {
        public Person(string firstName, string lastName, string email, string password = "")
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Account = new Account(email, password);
        }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName { get { return string.Format("{0} {1}", FirstName.Trim(), LastName.Trim()); } }
        [Required]
        public string Email { get; set; }


        // navigation property
        public virtual Account Account { get; set; }
    }
}
