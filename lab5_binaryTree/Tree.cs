using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab5_binaryTree
{
    public class Tree<T>
        where T : IComparable, IComparable<T>
    {
        Node<T> Root { get; set; }
        public int Count { get; private set; }

        public List<int> res = new List<int>();

        public void Add(T data, Graphics g, Font drawFont, SolidBrush solidBrush)
        {

            if (Root == null)
            {
                Root = new Node<T>(data);
               
                g.DrawEllipse(Pens.Black, 265, 30, 18, 18);
                if (data.ToString().Length == 1)
                {
                    g.DrawString(data.ToString(), drawFont, solidBrush, 269, 32);
                }
                else
                {
                    g.DrawString(data.ToString(), drawFont, solidBrush, 265, 32);
                }
                Count = 1;
                return;
            }

            Root.Add(data, g, drawFont, solidBrush, 265, 30, 0);
            Count++;
        }

        public List<int> Search(T n, Graphics g, Font drawFont, SolidBrush solidBrush)
        {
            res.Clear();
            res.Add(Convert.ToInt32(Root.Data));

            return Search(n, Root, g, drawFont, solidBrush);
        }

        List<int> Search(T n, Node<T> node, Graphics g, Font drawFont, SolidBrush solidBrush)
        {

            if (n.CompareTo(node.Data) == 0)
            {
                res.Add(Convert.ToInt32(node.Data));
                return res;
            }
            if (n.CompareTo(node.Data) < 0)
            {
                if (node.Left == null)
                {
                    Add(n, g, drawFont, solidBrush);
                    //res.Clear();
                    res.Add(Convert.ToInt32(n));
                    return res;
                }
                if (n.CompareTo(node.Left.Data) == 0)
                {
                    res.Add(Convert.ToInt32(node.Left.Data));
                    return res;
                }
                res.Add(Convert.ToInt32(node.Left.Data));
                Search(n, node.Left, g, drawFont, solidBrush);
            }
            else
            {
                if(node.Right == null)
                {
                    Add(n, g, drawFont, solidBrush);
                    //res.Clear();
                    res.Add(Convert.ToInt32(n));
                    return res;
                }
                if (n.CompareTo(node.Right.Data) == 0)
                {
                    res.Add(Convert.ToInt32(node.Right.Data));
                    return res;
                }
                res.Add(Convert.ToInt32(node.Right.Data));
                Search(n, node.Right, g, drawFont, solidBrush);
            }


            return res;
        }

        public List<T> Preorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Preorder(Root);
        }

        private List<T> Preorder(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                list.Add(node.Data);

                if (node.Left != null)
                {
                    list.AddRange(Preorder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(Preorder(node.Right));
                }
            }

            return list;
        }

        public List<T> Postorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Postorder(Root);
        }

        private List<T> Postorder(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Postorder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(Postorder(node.Right));
                }

                list.Add(node.Data);
            }

            return list;
        }

        public List<T> Inorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Inorder(Root);
        }

        private List<T> Inorder(Node<T> node)
        {
            var list = new List<T>();

            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inorder(node.Left));
                }

                list.Add(node.Data);

                if (node.Right != null)
                {
                    list.AddRange(Inorder(node.Right));
                }
            }

            return list;
        }
    }
}
