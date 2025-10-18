using FluentAssertions;
using Src.SearchingAlgorithms;

namespace Tests.SearchingAlgorithms;

public class ClassicLinearSearchTests
{
    [Fact]
    public void TargetElementIsInTheMiddle()
    {
        // Arrange
        var array = new[] { 23, 45, 1, 2, 8, 19, -3, 16, -11, 28 };
        var target = 19;
        var expected = 5;

        // Act
        var result = ClassicLinearSearch.LinearSearch(array, target);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void TargetElementIsNotInTheArray()
    {
        // Arrange
        var array = new[] { 23, 45, 1, 2, 8, 19, -3, 16, -11, 28 };
        var target = 100;
        var expected = -1;

        // Act
        var result = ClassicLinearSearch.LinearSearch(array, target);

        // Assert
        result.Should().Be(expected);
    }
}
