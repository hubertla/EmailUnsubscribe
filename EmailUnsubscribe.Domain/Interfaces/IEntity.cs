using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailUnsubscribe.Domain.Interfaces
{
    public interface IModifiableEntity
    {
        string EntityName { get; set; }
    }

    public interface IEntity : IModifiableEntity
    {
        object Id { get; }
        DateTime CreatedAt { get; set; }
        DateTime? ModifiedAt { get; set; }
        string CreatedBy { get; set; }
        string ModifiedBy { get; set; }
        byte[] Version { get; set; }
    }

    public interface IEntity<T> : IEntity
    {
        new T Id { get; set; }
    }
}
