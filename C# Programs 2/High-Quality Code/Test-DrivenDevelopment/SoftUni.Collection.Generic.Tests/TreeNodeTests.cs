namespace SoftUni.Collection.Generic.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SoftUni.Collection.Generic.Tree;
    using System.Collections.Generic;
    [TestClass]
    public class TreeNodeTests
    {
        [TestMethod]
        public void Test_TreeNodeConstructorEmpty_ShouldCreateTheTreeNore()
        {
            var node = new TreeNode<int>();

            Assert.IsNotNull(node);
        }

        [TestMethod]
        public void Test_TreeNodeConstructorEmpty_ShouldHaveTheDefaultValue()
        {
            var node = new TreeNode<int>();

            Assert.AreEqual(default(int), node.Value);
        }

        [TestMethod]
        public void Test_TreeNodeConstructorEmpty_WithReferenceType_ShouldHaveTheDefaultValue()
        {
            var node = new TreeNode<string>();

            Assert.AreEqual(default(string), node.Value);
        }

        [TestMethod]
        public void Test_TreeNodeConstructor_ShouldHaveTheRequestedValue()
        {
            int testNumber = 5;

            var node = new TreeNode<int>(testNumber);

            Assert.AreEqual(testNumber, node.Value);
        }

        [TestMethod]
        public void Test_TreeNodeConstructor_WithReferenceType_ShouldHaveTheRequestedValue()
        {
            var pesho = "Pesho";
            var gosho = "Gosho";
            var node = new TreeNode<List<string>>(new List<string>() { pesho, gosho});

            Assert.IsInstanceOfType(node.Value, typeof(List<string>));
            CollectionAssert.AreEqual(new List<string>() { pesho, gosho }, node.Value);
        }

        [TestMethod]
        public void Test_TreeNodeConstructorWithEmptyChildren_ShouldHaveChildren()
        {
            int testNumber = 5;
            var node = new TreeNode<int>(testNumber);

            Assert.IsNotNull(node.Children);
            Assert.AreEqual(0, node.Children.Count);           
        }

        [TestMethod]
        public void Test_TreeNodeConstructorWithEmptyChildren_ShouldHaveRequestedChildren()
        {
            int testNumber = 5;
            var node = new TreeNode<int>(testNumber, new List<TreeNode<int>>());

            Assert.IsNotNull(node.Children);
            Assert.AreEqual(0, node.Children.Count);
        }

        [TestMethod]
        public void Test_TreeNodeConstructorWithNotEmptyChildren_ShouldHaveRequestedChildren()
        {
            int testNumber = 5;
            var children = new List<TreeNode<int>>();
            var firstNode = new TreeNode<int>(2);
            var secondNode = new TreeNode<int>(4);
            var thirdNode = new TreeNode<int>(6);
            children.Add(firstNode);
            children.Add(secondNode);
            children.Add(thirdNode);

            var node = new TreeNode<int>(testNumber, children);

            Assert.IsNotNull(node.Children);
            Assert.AreEqual(3, node.Children.Count);
            Assert.AreSame(firstNode, node.Children[0]);
            Assert.AreSame(secondNode, node.Children[1]);
            Assert.AreSame(thirdNode, node.Children[2]);
        }
    }
}