using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Data.Entities;

public class RoomEntity : BaseEntity
{
    public CustomerEntity Customer { get; set; }
    public int SquareMeters { get; set; }
}
