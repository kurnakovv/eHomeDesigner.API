﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Data.Entities;

public class ShelvingStorageEntity : BaseEntity
{
    public int Price { get; set; }
    public int SquareMeters { get; set; }
    public int Length { get; set; }
    public string Type { get; set; }
}
