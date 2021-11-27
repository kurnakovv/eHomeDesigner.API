using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.POCOs.Furnitures;
using System;
using Xunit;

namespace eHomeDesigner.Application.UnitTests.POCOs.Furnitures
{
    public class SofaTest
    {
        private readonly IFurniture _sofa = new Sofa(
                                                    Guid.NewGuid(),
                                                    1500,
                                                    7
                                                );

        [Fact]
        public void CanInitSofa_Sofa()
        {
            Assert.NotNull(_sofa);
        }

        [Fact]
        public void Type_CanGetType_Sofa()
        {
            // Act
            string result = _sofa.Type;

            // Assert
            Assert.Equal("Sofa", result);
        }
    }
}
