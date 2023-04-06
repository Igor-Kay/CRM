using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DataBase_1v
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var doc = new XmlDocument();
            doc.Load("struct.xml");

            XmlNode root = doc.DocumentElement;

            TreeNode rootNode = new TreeNode();

            rootNode.Text = root.Attributes.Item(0).Value;

            rootNode.ImageIndex = Convert.ToInt32(root.Attributes.Item(1).Value);
            rootNode.SelectedImageIndex = Convert.ToInt32(root.Attributes.Item(1).Value);
            rootNode.Tag = root.Attributes.Item(2).Value;
            treeView1.Nodes.Add(rootNode);

            treeView1.Nodes.Add(rootNode);

            if ((root.ChildNodes != null) && (root.ChildNodes.Count > 0))
{
                RecursiveTreeBuilder(rootNode, root);

            }


            treeView1.ExpandAll();
            treeView1.SelectedNode = rootNode;


        }

        private void RecursiveTreeBuilder (TreeNode tn, XmlNode xn)
        {
            foreach(XmlNode c in xn.ChildNodes)
            {
                TreeNode childNode = new TreeNode();
                childNode.Text = c.Attributes.Item(0).Value;
                childNode.ImageIndex = Convert.ToInt32(c.Attributes.Item(1).Value);
                childNode.SelectedImageIndex = Convert.ToInt32(c.Attributes.Item(1).Value);
                childNode.Tag = c.Attributes.Item(2).Value;
                tn.Nodes.Add(childNode);

                if ((c.ChildNodes != null) && (c.ChildNodes.Count > 0))
                {
                    RecursiveTreeBuilder(childNode, c);
                }
            }
        }

    }


}

