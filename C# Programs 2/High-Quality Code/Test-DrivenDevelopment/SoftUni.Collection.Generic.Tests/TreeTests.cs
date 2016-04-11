namespace SoftUni.Collection.Generic.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SoftUni.Collection.Generic.Tree;

    [TestClass]
    public class TreeTests
    {
        [TestMethod]
        public void Test_TreeConstructor_ShouldCreateEmptyTree1()
        {
            var root = new TreeNode<int>();
            var tree = new Tree<int>(root);

            Assert.AreSame(root, tree.Root);
            Assert.IsNotNull(tree.Root.Children);
            Assert.AreEqual(0, tree.Root.Children.Count);
        }

        [TestMethod]
        public void Test_TreeConstructorWithDchildren_ShouldCreateNotEmptyTree1()
        {
            var root = new TreeNode<int>(0);
            root.AddChild(1);
            root.AddChild(2);
            var tree = new Tree<int>(root);

            Assert.AreSame(root, tree.Root);
            Assert.IsNotNull(tree.Root.Children);
            Assert.AreEqual(2, tree.Root.Children.Count);
        }
    }
}