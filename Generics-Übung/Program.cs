using System;
using System.Collections.Generic;

namespace Generics_Übung
{
    class Tree<PLATZHALTER>
    {
        public TreeNode<PLATZHALTER> CreateNode(PLATZHALTER value)
        {
            TreeNode<PLATZHALTER> returnValue = new TreeNode<PLATZHALTER>(); 
            returnValue.Data = value;
            return returnValue;
        }
    }
    class TreeNode<PLATZHALTER>
    {
        public PLATZHALTER Data;
        public List<TreeNode<PLATZHALTER>> ChildrenList = new List<TreeNode<PLATZHALTER>>();

        public void AppendChild(TreeNode<PLATZHALTER> child)
        {
            ChildrenList.Add(child);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          Tree<string> tree= new Tree<String>();
          var root = tree.CreateNode("root");
          var child1 = tree.CreateNode("child1");
          var child2 = tree.CreateNode("child1");
          root.AppendChild(child1);
          root.AppendChild(child2);
          var grand11 = tree.CreateNode("grand11");
          var grand12 = tree.CreateNode("grand12");
          var grand13 = tree.CreateNode("grand13");
          child1.AppendChild(grand11);
          child1.AppendChild(grand12);
          child1.AppendChild(grand13);
          var grand21 = tree.CreateNode("grand21");
          child2.AppendChild(grand21);
          //child1.RemoveChild(grand12);
          
         // root.PrintTree();

        }
    }
}

