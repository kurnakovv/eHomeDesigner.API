using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.POCOs.Furnitures;
using System;
using Xunit;

namespace eHomeDesigner.Application.UnitTests.POCOs.Furnitures;

public class TableTest
{
    private readonly IFurniture _table = new Table(
                                                 Guid.NewGuid(),
                                                 800,
                                                 15
                                             );

    [Fact]
    public void CanInitTable_Table()
    {
        Assert.NotNull(_table);
    }

    [Fact]
    public void Type_CanGetType_Table()
    {
        // Act
        string result = _table.Type;

        // Assert
        Assert.Equal("Table", result);
    }
}
