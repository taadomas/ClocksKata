using FluentAssertions;

namespace Domain.Tests;

public class _1_BasicTests
{
    private readonly NonSenseService _nonSenseService = new();

    [Theory]
    [InlineData("1", "1")]
    [InlineData("2", "2")]
    [InlineData("3", "Foo")]
    [InlineData("4", "4")]
    [InlineData("5", "Bar")]
    [InlineData("6", "Foo")]
    [InlineData("7", "7")]
    [InlineData("8", "8")]
    [InlineData("9", "Foo")]
    [InlineData("10", "Bar")]
    public void _1_1_a(string input, string output)
    {
        var result = _nonSenseService.Compute(input);
        result.Should().NotBeNull();
        result.Should().NotBeEmpty();
        result.Should().Be(output);
    }
}
