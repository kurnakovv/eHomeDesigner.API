using eHomeDesigner.Application.Interfaces.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Application.Interfaces.Converters;

/// <summary>
/// Converter for convert object to another.
/// </summary>
public interface IConverter
{
    /// <summary>
    /// Convert object to another.
    /// </summary>
    /// <typeparam name="TResult">Expected object.</typeparam>
    /// <typeparam name="TValue">Input value.</typeparam>
    /// <param name="value">Input value.</param>
    /// <returns>Expected object.</returns>
    TResult Convert<TResult, TValue>(TValue value)
        where TResult : class
        where TValue : class;
}
