using TestPlayGround;

namespace UnitTests;

public class FindInverseTreeDepthTests
{
    [Theory]
    [InlineData("XYY", 2)]
    [InlineData("XXYY", 3)]
    [InlineData("XXYYXYY", 3)]
    [InlineData("XXXYYYY", 4)]
    [InlineData("XXXYYYXYXYXYY", 5)]
    public void Test(string path, int depth)
    {
        FindInverseTreeDepth findInverseTreeDepth = new();
        int treeDepth = findInverseTreeDepth.GetDepth(path);
        Assert.Equal(treeDepth, depth);
    }
}
