using AutoMapper;
using eHomeDesigner.Application.Interfaces.Converters;
using eHomeDesigner.Converters.AutoMapper;
using eHomeDesigner.Converters.IntegrationTests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace eHomeDesigner.Converters.IntegrationTests.AutoMapper;

public class ConverterTest
{
    private readonly IConverter _converter;

    public ConverterTest()
    {
        var configuration = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<MockEntity, MockPOCO>();
            cfg.CreateMap<MockPOCO, MockEntity>();
        });
        // only during development, validate your mappings; remove it before release
        configuration.AssertConfigurationIsValid();
        // use DI (http://docs.automapper.org/en/latest/Dependency-injection.html) or create the mapper yourself
        var mapper = configuration.CreateMapper();

        _converter = new Converter(mapper);
    }

    [Fact]
    public void Convert_CanConvertEntityToPOCO_POCO()
    {
        // Arrange
        MockEntity entity = new MockEntity() { MockProperty = "TestProperty" };

        // Act
        MockPOCO result = _converter.Convert<MockPOCO, MockEntity>(entity);

        // Assert
        Assert.NotNull(result);
        Assert.IsType<MockPOCO>(result);
        Assert.Equal("TestProperty", result.MockProperty);
    }

    [Fact]
    public void Convert_CanConvertPOCOToEntity_Entity()
    {
        // Arrange
        MockPOCO poco = new MockPOCO() { MockProperty = "TestProperty" };

        // Act
        MockEntity result = _converter.Convert<MockEntity, MockPOCO>(poco);

        // Assert
        Assert.NotNull(result);
        Assert.IsType<MockEntity>(result);
        Assert.Equal("TestProperty", result.MockProperty);
    }
}
