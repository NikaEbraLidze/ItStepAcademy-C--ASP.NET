using Xunit;
using System.Collections.Generic;
using Custom.Projection;
using Custom.Filtering;

namespace CustomAlgorithms.Test;

public class CustomLinqTests
{
    [Fact]
    public void TestCustomWhere()
    {
        var source = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        var expected = new List<int> { 2, 4, 6 };

        var actual = CustomFiltering.Where(source, x => x % 2 == 0);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestCustomWhereWithIndex()
    {
        var source = new List<int> { 1, 2, 3, 4, 5, 7, 6 };
        var expected = new List<int> { 1 };

        var actual = CustomFiltering.Where(source, (x, i) => i == 0);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Select_ShouldMultiplyEachElementByTwo()
    {
        var source = new List<int> { 1, 2, 3 };
        var expected = new List<int> { 2, 4, 6 };

        var actual = CustomProjection.Select(source, x => x * 2);

        Assert.Equal(expected, actual);
    }


    [Fact]
    public void Any_WithoutPredicate_ShouldReturnTrueForNonEmptySequence()
    {
        var source = new List<int> { 1, 2, 3 };

        var actual = CustomFiltering.Any(source);

        Assert.True(actual);
    }

    [Fact]
    public void Any_WithoutPredicate_ShouldReturnFalseForEmptySequence()
    {
        var source = new List<int>();

        var actual = CustomFiltering.Any(source);

        Assert.False(actual);
    }

    [Fact]
    public void Any_WithPredicate_ShouldReturnTrueIfAtLeastOneMatch()
    {
        var source = new List<int> { 1, 5, 10, 20 };

        var actual = CustomFiltering.Any(source, x => x > 15);

        Assert.True(actual);
    }

    [Fact]
    public void Any_WithPredicate_ShouldReturnFalseIfNoMatch()
    {
        var source = new List<int> { 1, 5, 10, 20 };

        var actual = CustomFiltering.Any(source, x => x < 0);

        Assert.False(actual);
    }

    [Fact]
    public void Any_WithPredicate_ShouldReturnFalseForEmptySequence()
    {
        var source = new List<int>();

        var actual = CustomFiltering.Any(source, x => x > 0);

        Assert.False(actual);
    }

    [Fact]
    public void All_ShouldReturnTrueIfAllElementsMatch()
    {
        var source = new List<int> { 2, 4, 6, 8 };

        var actual = CustomFiltering.All(source, x => x % 2 == 0);

        Assert.True(actual);
    }

    [Fact]
    public void All_ShouldReturnFalseIfOneElementFailsToMatch()
    {
        var source = new List<int> { 2, 4, 7, 8 };

        var actual = CustomFiltering.All(source, x => x % 2 == 0);

        Assert.False(actual);
    }

    [Fact]
    public void All_ShouldReturnTrueForEmptySequence()
    {
        var source = new List<int>();

        var actual = CustomFiltering.All(source, x => x > 100);

        Assert.True(actual);
    }
}