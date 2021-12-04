using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Data.Entities;

public class DeviceEntity : BaseEntity
{
    public int Price { get; set; }
    public int SquareMeters { get; set; }
    public int EnergyPerHour { get; set; }
    public string Author { get; set; }
    public string DeviceType { get; set; }
}
