using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.POCOs.Furnitures;
using System;
using Xunit;

namespace eHomeDesigner.Application.UnitTests.POCOs.Furnitures
{
    public class SofaTest
    {
        [Fact]
        public void CanInitSofa_Sofa()
        {
            IFurniture sofa = new Sofa(
                                    Guid.NewGuid(),
                                    1500,
                                    7);

            Assert.NotNull(sofa);
        }
    }
}
