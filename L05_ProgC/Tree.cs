using System;
using System.Collections.Generic;


namespace L05_progC
{
    public class Tree<T>
    {
        public T _value;
        public List<Tree<T>> _children = new List<Tree<T>>();
        // public List<Tree<T>> found= new List<Tree<T>>();

        public Tree<T> CreateNode(T value)
        {
            Tree<T> newValue = new Tree<T>
            {
                _value = value
            };
            return newValue;
        }

        public void AppendChild(Tree<T> child)
        {
            _children.Add(child);
        }
        public void RemoveChild(Tree<T> child)
        {
            _children.Remove(child);
        }
        //  public List<Tree<T>> FindChild(T search)
        // {
        //     return (_children.FindAll(x => x._value.Equals(search)));
        // // //     // List<Tree<T>> _foundChilds = new List<Tree<T>>();   
        // // //     // Console.WriteLine(_foundChilds);
        // // //     // _foundChilds = _children.FindAll(x => x._children.Contains(child));
        // // //     // Console.WriteLine(_foundChilds);
        // }
        
        public List<Tree<T>> FindChild(T search, List<Tree<T>> found = null)
        {
            if (found == null)
            {
                found = new List<Tree<T>>();
            }
            if (_value.Equals(search))
            {
                found.Add(this);
            }
            foreach (var child in _children)
            {
                child.FindChild(search, found);
            }
            return found;
        }
        public void PrintTree(String str = "")
        {
            Console.WriteLine(str + _value);
            foreach (Tree<T> child in _children)
            {
                child.PrintTree(str + "*");
            }
           
        } 
    }

    }

