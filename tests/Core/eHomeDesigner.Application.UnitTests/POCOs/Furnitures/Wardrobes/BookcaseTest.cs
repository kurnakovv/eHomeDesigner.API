using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.POCOs.Furnitures.Wardrobes;
using System;
using Xunit;

namespace eHomeDesigner.Application.UnitTests.POCOs.Furnitures.Wardrobes
{
    public class BookcaseTest 
    { 
        private readonly IWardrobe _bookcase = new Bookcase(
                                                       Guid.NewGuid(),
                                                       1000,
                                                       10,
                                                       50
                                                   );
        [Fact]
        public void CanInitBookcase_Bookcase()
        {
            Assert.NotNull(_bookcase);
        }

        [Fact]
        public void Type_CanGetType_Bookcase()
        {
            // Act
            string result = _bookcase.Type;

            // Assert
            Assert.Equal("Bookcase", result);
        }
    }
}
