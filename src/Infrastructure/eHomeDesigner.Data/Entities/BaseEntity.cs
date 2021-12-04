using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Data.Entities;

public class BaseEntity : IEntity
{
    public Guid Id { get; } = Guid.NewGuid();
    public DateTime DateOfCreate { get; } = DateTime.Now;
}
