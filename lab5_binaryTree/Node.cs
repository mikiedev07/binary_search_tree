using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab5_binaryTree
{
    class Node<T> : IComparable<T>, IComparable
        where T : IComparable, IComparable<T>
    {
        public T Data { get; private set; }
        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set; }

        public Node(T data)
        {
            Data = data;
        }

        public void Add(T data, Graphics g, Font drawFont, SolidBrush solidBrush, float x, float y, int iter)
        {
            var node = new Node<T>(data);

            float tmp = 70;
            float tmp1 = 70;
            Point pt1 = new Point(Convert.ToInt32(x+9), Convert.ToInt32(y + 15));

            if (node.Data.CompareTo(Data) == -1)
            {
                for (int i = 0; i < iter; i++)
                {
                    tmp -= 15;
                }
                x -= tmp;
                y += 40;

                if (Left == null)
                {
                    Left = node;

                    g.DrawEllipse(Pens.Black, x, y, 18, 18);
                    if (data.ToString().Length == 1)
                    {
                        g.DrawString(data.ToString(), drawFont, solidBrush, x + 4, y + 2);
                    }
                    else
                    {
                        g.DrawString(data.ToString(), drawFont, solidBrush, x, y + 2);
                    }
                    Point pt2 = new Point(Convert.ToInt32(x + 9), Convert.ToInt32(y + 15));
                    g.DrawLine(Pens.Black, pt1, pt2);
                }
                else
                {
                    iter++;
                    Left.Add(data, g, drawFont, solidBrush, x, y, iter);
                }
            }
            else
            {
                for (int i = 0; i < iter; i++)
                {
                    tmp1 -= 15;
                }
                x += tmp1;
                y += 40;

                if (Right == null)
                {
                    Right = node;

                    g.DrawEllipse(Pens.Black, x, y, 18, 18);
                    if (data.ToString().Length == 1)
                    {
                        g.DrawString(data.ToString(), drawFont, solidBrush, x + 4, y + 2);
                    }
                    else
                    {
                        g.DrawString(data.ToString(), drawFont, solidBrush, x, y + 2);
                    }
                    Point pt2 = new Point(Convert.ToInt32(x + 9), Convert.ToInt32(y + 15));
                    g.DrawLine(Pens.Black, pt1, pt2);
                }
                else
                {
                    iter++;
                    Right.Add(data, g, drawFont, solidBrush, x, y, iter);
                }
            }
        }

        public int CompareTo(object obj)
        {
            if (obj is Node<T> item)
            {
                return Data.CompareTo(item);
            }
            else
            {
                throw new ArgumentException("Не совпадение типов");
            }
        }

        public int CompareTo(T other)
        {
            return Data.CompareTo(other);
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
