using AutoMapper;
using eHomeDesigner.Application.Interfaces.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Converters.AutoMapper;

public class Converter : IConverter
{
    private readonly IMapper _mapper;

    public Converter(
        IMapper mapper)
    {
        _mapper = mapper;
    }

    public TResult Convert<TResult, TValue>(TValue value)
        where TResult : class
        where TValue : class
    {
        TResult result = _mapper.Map<TResult>(value);
        return result;
    }
}
