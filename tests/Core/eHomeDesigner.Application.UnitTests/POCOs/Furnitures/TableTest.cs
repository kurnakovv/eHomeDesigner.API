using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.POCOs.Furnitures;
using System;
using Xunit;

namespace eHomeDesigner.Application.UnitTests.POCOs.Furnitures
{
    public class TableTest
    {
        [Fact]
        public void CanInitTable_Table()
        {
            IFurniture table = new Table(
                                       Guid.NewGuid(),
                                       800,
                                       15
                                   );

            Assert.NotNull(table);
        }
    }
}
