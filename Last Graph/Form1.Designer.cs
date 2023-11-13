namespace GraphTheoryProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtInfo = new System.Windows.Forms.RichTextBox();
            this.numLinesBTN = new System.Windows.Forms.Button();
            this.allGraphBTN = new System.Windows.Forms.Button();
            this.numNodesBTN = new System.Windows.Forms.Button();
            this.degreeBTN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dfsBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bfsBTN = new System.Windows.Forms.Button();
            this.rtExplor = new System.Windows.Forms.RichTextBox();
            this.cbRoot = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSink = new System.Windows.Forms.ComboBox();
            this.btnAugPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtResult = new System.Windows.Forms.RichTextBox();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtInfo
            // 
            this.rtInfo.Location = new System.Drawing.Point(3, 3);
            this.rtInfo.Name = "rtInfo";
            this.rtInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtInfo.Size = new System.Drawing.Size(440, 221);
            this.rtInfo.TabIndex = 41;
            this.rtInfo.Text = "";
            this.rtInfo.TextChanged += new System.EventHandler(this.rtInfo_TextChanged);
            // 
            // numLinesBTN
            // 
            this.numLinesBTN.Location = new System.Drawing.Point(19, 75);
            this.numLinesBTN.Name = "numLinesBTN";
            this.numLinesBTN.Size = new System.Drawing.Size(129, 21);
            this.numLinesBTN.TabIndex = 3;
            this.numLinesBTN.Text = "Num Of Lines";
            this.numLinesBTN.UseVisualStyleBackColor = true;
            this.numLinesBTN.Click += new System.EventHandler(this.btnNumLines_Click);
            // 
            // allGraphBTN
            // 
            this.allGraphBTN.Location = new System.Drawing.Point(19, 21);
            this.allGraphBTN.Name = "allGraphBTN";
            this.allGraphBTN.Size = new System.Drawing.Size(129, 21);
            this.allGraphBTN.TabIndex = 1;
            this.allGraphBTN.Text = "All Graph";
            this.allGraphBTN.UseVisualStyleBackColor = true;
            this.allGraphBTN.Click += new System.EventHandler(this.btnAllGraph_Click);
            // 
            // numNodesBTN
            // 
            this.numNodesBTN.Location = new System.Drawing.Point(19, 48);
            this.numNodesBTN.Name = "numNodesBTN";
            this.numNodesBTN.Size = new System.Drawing.Size(129, 21);
            this.numNodesBTN.TabIndex = 2;
            this.numNodesBTN.Text = "Num Of Nodes";
            this.numNodesBTN.UseVisualStyleBackColor = true;
            this.numNodesBTN.Click += new System.EventHandler(this.btnNumNodes_Click);
            // 
            // degreeBTN
            // 
            this.degreeBTN.Location = new System.Drawing.Point(19, 102);
            this.degreeBTN.Name = "degreeBTN";
            this.degreeBTN.Size = new System.Drawing.Size(129, 21);
            this.degreeBTN.TabIndex = 4;
            this.degreeBTN.Text = "Degree";
            this.degreeBTN.UseVisualStyleBackColor = true;
            this.degreeBTN.Click += new System.EventHandler(this.btnDegree_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dfsBTN);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bfsBTN);
            this.groupBox2.Controls.Add(this.rtExplor);
            this.groupBox2.Controls.Add(this.cbRoot);
            this.groupBox2.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 169);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exploration";
            // 
            // dfsBTN
            // 
            this.dfsBTN.Enabled = false;
            this.dfsBTN.ForeColor = System.Drawing.Color.Red;
            this.dfsBTN.ImageKey = "(none)";
            this.dfsBTN.Location = new System.Drawing.Point(14, 61);
            this.dfsBTN.Name = "dfsBTN";
            this.dfsBTN.Size = new System.Drawing.Size(134, 23);
            this.dfsBTN.TabIndex = 7;
            this.dfsBTN.Text = "Explor Graph (DFS)";
            this.dfsBTN.UseVisualStyleBackColor = true;
            this.dfsBTN.Click += new System.EventHandler(this.DFSbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "Chose root node";
            // 
            // bfsBTN
            // 
            this.bfsBTN.Enabled = false;
            this.bfsBTN.ForeColor = System.Drawing.Color.Red;
            this.bfsBTN.ImageKey = "(none)";
            this.bfsBTN.Location = new System.Drawing.Point(154, 61);
            this.bfsBTN.Name = "bfsBTN";
            this.bfsBTN.Size = new System.Drawing.Size(140, 23);
            this.bfsBTN.TabIndex = 6;
            this.bfsBTN.Text = "Explor Graph (BFS)";
            this.bfsBTN.UseVisualStyleBackColor = true;
            this.bfsBTN.Click += new System.EventHandler(this.BFSbtn_Click);
            // 
            // rtExplor
            // 
            this.rtExplor.Location = new System.Drawing.Point(14, 90);
            this.rtExplor.Name = "rtExplor";
            this.rtExplor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtExplor.Size = new System.Drawing.Size(280, 69);
            this.rtExplor.TabIndex = 57;
            this.rtExplor.Text = "";
            // 
            // cbRoot
            // 
            this.cbRoot.FormattingEnabled = true;
            this.cbRoot.Location = new System.Drawing.Point(154, 32);
            this.cbRoot.Name = "cbRoot";
            this.cbRoot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbRoot.Size = new System.Drawing.Size(85, 20);
            this.cbRoot.TabIndex = 5;
            this.cbRoot.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 95;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "Clear";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.rtInfo);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(172, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(450, 232);
            this.flowLayoutPanel1.TabIndex = 102;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numLinesBTN);
            this.groupBox3.Controls.Add(this.allGraphBTN);
            this.groupBox3.Controls.Add(this.numNodesBTN);
            this.groupBox3.Controls.Add(this.degreeBTN);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 137);
            this.groupBox3.TabIndex = 104;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graph Items";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbSink);
            this.groupBox1.Controls.Add(this.btnAugPath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rtResult);
            this.groupBox1.Controls.Add(this.cbSource);
            this.groupBox1.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(322, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 169);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Augmented Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Buxton Sketch", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 98;
            this.label3.Text = "Choose Sink";
            // 
            // cbSink
            // 
            this.cbSink.FormattingEnabled = true;
            this.cbSink.Location = new System.Drawing.Point(250, 28);
            this.cbSink.Name = "cbSink";
            this.cbSink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbSink.Size = new System.Drawing.Size(49, 20);
            this.cbSink.TabIndex = 9;
            this.cbSink.SelectedIndexChanged += new System.EventHandler(this.cbSink_SelectedIndexChanged);
            // 
            // btnAugPath
            // 
            this.btnAugPath.Enabled = false;
            this.btnAugPath.ForeColor = System.Drawing.Color.Red;
            this.btnAugPath.ImageKey = "(none)";
            this.btnAugPath.Location = new System.Drawing.Point(12, 61);
            this.btnAugPath.Name = "btnAugPath";
            this.btnAugPath.Size = new System.Drawing.Size(278, 23);
            this.btnAugPath.TabIndex = 10;
            this.btnAugPath.Text = "Find Augmented Path";
            this.btnAugPath.UseVisualStyleBackColor = true;
            this.btnAugPath.Click += new System.EventHandler(this.btnAugPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Buxton Sketch", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 94;
            this.label2.Text = "Choose Source";
            // 
            // rtResult
            // 
            this.rtResult.Location = new System.Drawing.Point(12, 90);
            this.rtResult.Name = "rtResult";
            this.rtResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtResult.Size = new System.Drawing.Size(278, 69);
            this.rtResult.TabIndex = 57;
            this.rtResult.Text = "";
            // 
            // cbSource
            // 
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Location = new System.Drawing.Point(105, 28);
            this.cbSource.Name = "cbSource";
            this.cbSource.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbSource.Size = new System.Drawing.Size(55, 20);
            this.cbSource.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 106;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Graph Theory Progect";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtInfo;
        private System.Windows.Forms.Button numLinesBTN;
        private System.Windows.Forms.Button allGraphBTN;
        private System.Windows.Forms.Button numNodesBTN;
        private System.Windows.Forms.Button degreeBTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtExplor;
        private System.Windows.Forms.ComboBox cbRoot;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button bfsBTN;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button dfsBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAugPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtResult;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSink;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

