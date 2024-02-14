namespace AAD.Tests;

public class BSTreeNodeTest
{
    [Fact]
    public void Constructor()
    {
        var n = new BSTreeNode(value: 10);
        
        Assert.Equal(10, n.Value);
        Assert.Null(n.Left);
        Assert.Null(n.Right);
    }

    [Fact]
    public void Add_RepeatedValue()
    {
        var n = new BSTreeNode(value: 10);
        n.Add(10);
        
        Assert.Null(n.Left);
        Assert.Null(n.Right);
    }
    
    [Fact]
    public void Add_Left()
    {
        var n = new BSTreeNode(value: 10);
        n.Add(5);
        
        Assert.NotNull(n.Left);
        Assert.Equal(5, n.LeftValue);
        
        Assert.Null(n.Right);
    }
    
    [Fact]
    public void Add_LeftIsNotNull()
    {
        var n = new BSTreeNode(value: 10);
        n.Add(5);
        n.Add(3);

        Assert.Equal(5, n.LeftValue);
        var left = n.Left;
        
        Assert.NotNull(left);
        Assert.Equal(3, left.LeftValue);
    }
    
    [Fact]
    public void Add_Right()
    {
        var n = new BSTreeNode(value: 10);
        n.Add(15);
        
        Assert.Null(n.Left);
        
        Assert.NotNull(n.Right);
        Assert.Equal(15, n.RightValue);
    }
    
    [Fact]
    public void Add_RightIsNotNull()
    {
        var n = new BSTreeNode(value: 10);
        n.Add(15);
        n.Add(20);

        Assert.Equal(15, n.RightValue);
        var right = n.Right;
        
        Assert.NotNull(right);
        Assert.Equal(20, right.RightValue);
    }
    
    [Fact]
    public void Contains_OneNode()
    {
        var n = BSTreeNode
            .From(new[] { 15 });

        Assert.True(n.Contains(15));
    }
    
    [Fact]
    public void Contains_InLeft()
    {
        var n = BSTreeNode
            .From(new[] { 15, 5 });

        Assert.True(n.Contains(5));
    }
    
    [Fact]
    public void Contains_InRight()
    {
        var n = BSTreeNode
            .From(new[] { 15, 20 });

        Assert.True(n.Contains(20));
    }
    
    [Fact]
    public void Contains_DotNotExistInLeft()
    {
        var n = BSTreeNode
            .From(new[] { 15 });

        Assert.False(n.Contains(5));
    }
    
    [Fact]
    public void Contains_DotNotExistInRight()
    {
        var n = BSTreeNode
            .From(new[] { 15 });

        Assert.False(n.Contains(20));
    }
}