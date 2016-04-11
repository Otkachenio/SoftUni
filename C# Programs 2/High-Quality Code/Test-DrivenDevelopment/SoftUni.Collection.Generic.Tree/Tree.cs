namespace SoftUni.Collection.Generic.Tree
{
    using System.Collections.Generic;

    public class Tree<T>
    {
        public Tree(TreeNode<T> root)
        {
            this.Root = root;
        }

        public TreeNode<T> Root { get; private set; }
    }
}