using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Data.Entities;

public class BaseEntity : IEntity
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public DateTime DateOfCreate { get; private set; } = DateTime.Now;
}
