// <copyright file="DocsTests.cs" company="ne1410s">
// Copyright (c) ne1410s. All rights reserved.
// </copyright>

namespace ne14.library.message_contracts.tests.Docs;

using System.Text.Json;
using ne14.library.message_contracts.Docs;

public class DocsTests
{
    private const string Namespace = "Docs";
    private const string Extension = ".json";
    private static readonly JsonSerializerOptions Opts = new()
    {
        WriteIndented = true,
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    };

    [Theory]
    [InlineData(typeof(PdfConversionFailed))]
    [InlineData(typeof(PdfConversionRequired))]
    [InlineData(typeof(PdfConversionSucceeded))]
    public void Test1(Type type)
    {
        // Arrange
        var path = new FileInfo(Path.Combine(Namespace, type.Name + Extension)).FullName;

        // Act
        var expected = File.ReadAllText(path);
        var poco = JsonSerializer.Deserialize(expected, type, Opts);
        var actual = JsonSerializer.Serialize(poco, Opts);

        // Assert
        actual.Should().Be(expected);
    }
}