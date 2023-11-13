using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace GraphTheoryProject
{
    public partial class Form1 : Form
    {
        
        graph grf = new graph();
       
        public LinkedList<Vertix> augPath = new LinkedList<Vertix>();
        public LinkedList<Vertix> close = new LinkedList<Vertix>();

        int maxFlow;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "XML Files |*.xml";

            if (op.ShowDialog() != DialogResult.OK)
            { MessageBox.Show("please choose an XML file"); }

            //if (op.ShowDialog() == DialogResult.OK)
            else
            {
                try
                {
                    grf.readXML(op.FileName);

                    foreach (Edge l in grf.lines)
                    {
                        l.Bigen.Positive_degree++;
                        l.End.Negative_degree++;

                        l.Bigen.Degree++;
                        l.End.Degree++;
                    }
                    
                    foreach (Vertix n in grf.nodes)
                    {
                        cbRoot.Items.Add(n.Name);
                        cbRoot.SelectedIndex = 0;
                        if (n.Negative_degree == 0)
                        {
                            cbSource.Items.Add(n.Name);
                            cbSource.SelectedIndex = 0;
                        }
                        if (n.Positive_degree == 0)
                        {
                            cbSink.Items.Add(n.Name);
                            cbSink.SelectedIndex = 0;
                        }
                        //cbSink.SelectedIndex = cbSink.Items.Count - 1;

                    }

                    groupBox3.Enabled = true;
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
        
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtInfo.Clear();
            rtExplor.Clear();

            grf = new graph();
            // node = new node();
            close = new LinkedList<Vertix>();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAllGraph_Click(object sender, EventArgs e)
        {
            rtInfo.Clear();
            rtInfo.Text += "The nodes of Graph is : ";
            foreach (Vertix n in grf.nodes)
            {
                rtInfo.Text += n.Name + "  ";
            }
            rtInfo.Text += "\n ";

            rtInfo.Text += "line name \tbegins at \tend at  capacity  flow  \n\n";
            foreach(Edge l in grf.lines)
            {
                rtInfo.Text += " \t " + l.Name + "  \t  " + l.Bigen.Name + "  \t  " + l.End.Name + "  \t  " + l.cap + "  \t  " + l.flow + "\n";
            }
        }

        private void btnNumNodes_Click(object sender, EventArgs e)
        {
            rtInfo.Text += "\nThe num of nodes is  " + grf.Nodes_num;
        }

        private void btnNumLines_Click(object sender, EventArgs e)
        {
            rtInfo.Text += "\nThe num of lines is  " + grf.Lines_num;
        }

        private void btnDegree_Click(object sender, EventArgs e)
        {
                rtInfo.Clear();
                int pos, neg;
                string n;

                rtInfo.Text += "\nFor node \tpositive degree  \tnigative degree ";
                for (int i = 0; i < grf.Nodes_num; i++)
                {
                    n = grf.nodes.ElementAt(i).Name;
                    pos = grf.nodes.ElementAt(i).Positive_degree;
                    neg = grf.nodes.ElementAt(i).Negative_degree;
                   
                    grf.nodes.ElementAt(i).Degree = pos + neg;
                    rtInfo.Text += "\n\t " + n +"\t              " + pos +"\t             " + neg;
                }
            
        }

          private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            bfsBTN.Enabled = true;
            dfsBTN.Enabled = true;
        }
   
        #region Exploration
        private void DFSbtn_Click(object sender, EventArgs e)
        {
            
            close = grf.DFS(new Vertix(cbRoot.SelectedItem.ToString()));

                if (close.Count == grf.Nodes_num)
                {
                    rtExplor.Text = "The Path is:\n";
                    for (int i = 0; i < close.Count; i++)
                        rtExplor.Text += " ###>> " + close.ElementAt(i).Name + " ";
                }
                                
        }

        private void BFSbtn_Click(object sender, EventArgs e)
        {
            close = grf.BFS(new Vertix(cbRoot.SelectedItem.ToString()));
                rtExplor.Clear();
                if (close.Count == grf.Nodes_num)
                {
                    rtExplor.Text = "The Path is:\n";
                    for (int i = 0; i < close.Count; i++)
                        rtExplor.Text += " --->> " + close.ElementAt(i).Name + " ";
                }
            
        }
        #endregion

        private void btnAugPath_Click(object sender, EventArgs e)
        {
            if (cbSource.SelectedItem.ToString() == cbSink.SelectedItem.ToString())
            {
                MessageBox.Show("Please choose a valid sourse and sink for graph", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Vertix source = new Vertix();
                Vertix sink=new Vertix();
                foreach (Vertix v in grf.nodes)
                {
                    if (v.Name == cbSource.SelectedItem.ToString())
                        source = v;
                    if (v.Name == cbSink.SelectedItem.ToString())
                        sink = v;
                }
                
                // find max flw of this graph and (s,t) cut
                maxFlow = grf.Ford_Fulkerson(source, sink);
                rtResult.Text = "the max flow of this Network is : " + maxFlow.ToString() + "\n (S,T)-cut is : \n s : ";
                foreach (Vertix v in grf.Vs)
                {
                    rtResult.Text +=" "+ v.Name + "   ";                    
                }
                rtResult.Text += "\n t : ";
                //foreach (Vertix v in grf.Vs)
                foreach (Vertix x in grf.nodes)
                    if (!grf.Vs.Contains(x))
                    {
                        rtResult.Text += " " + x.Name + "   ";
                    }
                rtResult.Text += "\n";
            }
        }

        private void cbSink_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAugPath.Enabled = true;
        }

        private void rtInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grf.check();
        }
              
}

}
                