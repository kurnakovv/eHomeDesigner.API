using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Data.Entities;

public interface IEntity
{
    Guid Id { get; }
    DateTime DateOfCreate { get; }
}
