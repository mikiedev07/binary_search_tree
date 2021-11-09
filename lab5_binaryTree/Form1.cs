using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_binaryTree
{
    public partial class Form1 : Form
    {
        Tree<int> tree = new Tree<int>();
        Font drawFont = new Font("Arial", 8);
        SolidBrush solidBrush = new SolidBrush(Color.Black);
        public Form1()
        {
            InitializeComponent();
        }

        private void show_tree_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();

            tree.Add(5, g, drawFont, solidBrush);
            tree.Add(3, g, drawFont, solidBrush);
            tree.Add(7, g, drawFont, solidBrush);
            tree.Add(1, g, drawFont, solidBrush);
            tree.Add(4, g, drawFont, solidBrush);
            tree.Add(6, g, drawFont, solidBrush);
            tree.Add(8, g, drawFont, solidBrush);
            tree.Add(2, g, drawFont, solidBrush);
            tree.Add(9, g, drawFont, solidBrush);
            tree.Add(-1, g, drawFont, solidBrush);
        }

        private void add_elem_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();

            int elem = Convert.ToInt32(newElem_textbox.Text);
            tree.Add(elem, g, drawFont, solidBrush);
        }

        private void inorder_Click(object sender, EventArgs e)
        {
            travelsalPath_textbox.Clear();
            int count = tree.Inorder().Count-1;
            int tmp = 0;

            for(int i = 0; i < tree.Inorder().Count; i++)
            {
                travelsalPath_textbox.AppendText(tree.Inorder()[i].ToString());
                if (tmp < count)
                {
                    travelsalPath_textbox.AppendText(" > ");
                }
                tmp++;
            }
        }

        private void preorder_Click(object sender, EventArgs e)
        {
            travelsalPath_textbox.Clear();
            int count = tree.Preorder().Count - 1;
            int tmp = 0;

            for (int i = 0; i < tree.Preorder().Count; i++)
            {
                travelsalPath_textbox.AppendText(tree.Preorder()[i].ToString());
                if (tmp < count)
                {
                    travelsalPath_textbox.AppendText(" > ");
                }
                tmp++;
            }
        }

        private void postorder_Click(object sender, EventArgs e)
        {
            travelsalPath_textbox.Clear();
            int count = tree.Postorder().Count - 1;
            int tmp = 0;

            for (int i = 0; i < tree.Postorder().Count; i++)
            {
                travelsalPath_textbox.AppendText(tree.Postorder()[i].ToString());
                if (tmp < count)
                {
                    travelsalPath_textbox.AppendText(" > ");
                }
                tmp++;
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();

            searchPath_textbox.Clear();
            int elem_to_search = Convert.ToInt32(search_textbox.Text);
            int count = tree.Search(elem_to_search, g, drawFont, solidBrush).Count - 1;
            int tmp = 0;

            for (int i = 0; i < count+1; i++)
            {
                searchPath_textbox.AppendText(tree.Search(elem_to_search, g, drawFont, solidBrush)[i].ToString());
                if (tmp < count)
                {
                    searchPath_textbox.AppendText(" > ");
                }
                tmp++;
            }

            //if (count+1 == 0)
            //{
            //    tree.Add(elem_to_search, g, drawFont, solidBrush);
            //}

        }
    }
}
