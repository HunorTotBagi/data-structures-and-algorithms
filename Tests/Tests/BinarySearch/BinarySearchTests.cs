using static Src.BinarySearch.BinarySearch;
using FluentAssertions;

namespace Tests.BinarySearch;

public class BinarySearchTests
{
    [Fact]
    public void SimpleTest()
    {
        // Arrange
        var array = new[] { 2, 4, 6, 9, 11, 12, 14, 20, 36, 48 };
        var target = 36;
        var targetIndex = 8;

        // Act
        var result = BasicBinarySearch(array, target);

        // Assert
        result.Should().Be(targetIndex);
    }
}
