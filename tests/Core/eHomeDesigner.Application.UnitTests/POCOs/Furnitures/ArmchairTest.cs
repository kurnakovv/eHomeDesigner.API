using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.POCOs.Furnitures;
using System;
using Xunit;

namespace eHomeDesigner.Application.UnitTests.POCOs.Furnitures
{
    public class ArmchairTest
    {
        [Fact]
        public void CanInitArmchair_Armchair()
        {
            IFurniture armchair = new Armchair(
                                        Guid.NewGuid(),
                                        1000,
                                        5
                                      );

            Assert.NotNull(armchair);
        }
    }
}
