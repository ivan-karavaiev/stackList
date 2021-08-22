namespace Karavaev
{
    partial class Form_buildTree
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
            this.panel_build_stackTree = new System.Windows.Forms.Panel();
            this.button_textDownload = new System.Windows.Forms.Button();
            this.button_build_save = new System.Windows.Forms.Button();
            this.label_build = new System.Windows.Forms.Label();
            this.radioButton_build_StackTreeCompressed = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_build_StackListFull = new System.Windows.Forms.RadioButton();
            this.radioButton_build_StackList = new System.Windows.Forms.RadioButton();
            this.radioButton_build_StackTree = new System.Windows.Forms.RadioButton();
            this.radioButton_build_AcyclicGraph = new System.Windows.Forms.RadioButton();
            this.radioButton_build_Graph = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox_stackTree = new System.Windows.Forms.PictureBox();
            this.panel_build_stackTree.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_stackTree)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_build_stackTree
            // 
            this.panel_build_stackTree.AutoScroll = true;
            this.panel_build_stackTree.Controls.Add(this.pictureBox_stackTree);
            this.panel_build_stackTree.Location = new System.Drawing.Point(225, 13);
            this.panel_build_stackTree.Name = "panel_build_stackTree";
            this.panel_build_stackTree.Size = new System.Drawing.Size(945, 603);
            this.panel_build_stackTree.TabIndex = 33;
            // 
            // button_textDownload
            // 
            this.button_textDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_textDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_textDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_textDownload.Location = new System.Drawing.Point(22, 13);
            this.button_textDownload.Margin = new System.Windows.Forms.Padding(4);
            this.button_textDownload.Name = "button_textDownload";
            this.button_textDownload.Size = new System.Drawing.Size(182, 118);
            this.button_textDownload.TabIndex = 39;
            this.button_textDownload.Text = "Отримати дані з .txt файлу";
            this.button_textDownload.UseVisualStyleBackColor = true;
            this.button_textDownload.Click += new System.EventHandler(this.Button_textDownload_Click);
            // 
            // button_build_save
            // 
            this.button_build_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_build_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_build_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_build_save.Location = new System.Drawing.Point(22, 464);
            this.button_build_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_build_save.Name = "button_build_save";
            this.button_build_save.Size = new System.Drawing.Size(182, 66);
            this.button_build_save.TabIndex = 40;
            this.button_build_save.Text = "Зберегти";
            this.button_build_save.UseVisualStyleBackColor = true;
            this.button_build_save.Click += new System.EventHandler(this.Button_build_save_Click);
            // 
            // label_build
            // 
            this.label_build.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_build.Location = new System.Drawing.Point(22, 138);
            this.label_build.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_build.Name = "label_build";
            this.label_build.Size = new System.Drawing.Size(182, 35);
            this.label_build.TabIndex = 41;
            this.label_build.Text = "Побудувати:\r\n\r\n";
            this.label_build.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton_build_StackTreeCompressed
            // 
            this.radioButton_build_StackTreeCompressed.AutoSize = true;
            this.radioButton_build_StackTreeCompressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_build_StackTreeCompressed.Location = new System.Drawing.Point(5, 222);
            this.radioButton_build_StackTreeCompressed.Name = "radioButton_build_StackTreeCompressed";
            this.radioButton_build_StackTreeCompressed.Size = new System.Drawing.Size(192, 62);
            this.radioButton_build_StackTreeCompressed.TabIndex = 43;
            this.radioButton_build_StackTreeCompressed.TabStop = true;
            this.radioButton_build_StackTreeCompressed.Text = "Стиснуте \r\nдерево стеків";
            this.radioButton_build_StackTreeCompressed.UseVisualStyleBackColor = true;
            this.radioButton_build_StackTreeCompressed.CheckedChanged += new System.EventHandler(this.RadioButton_build_StackTreeCompressed_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_build_StackListFull);
            this.panel1.Controls.Add(this.radioButton_build_StackList);
            this.panel1.Controls.Add(this.radioButton_build_StackTree);
            this.panel1.Controls.Add(this.radioButton_build_AcyclicGraph);
            this.panel1.Controls.Add(this.radioButton_build_Graph);
            this.panel1.Controls.Add(this.radioButton_build_StackTreeCompressed);
            this.panel1.Location = new System.Drawing.Point(22, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 284);
            this.panel1.TabIndex = 44;
            // 
            // radioButton_build_StackListFull
            // 
            this.radioButton_build_StackListFull.AutoSize = true;
            this.radioButton_build_StackListFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_build_StackListFull.Location = new System.Drawing.Point(5, 115);
            this.radioButton_build_StackListFull.Name = "radioButton_build_StackListFull";
            this.radioButton_build_StackListFull.Size = new System.Drawing.Size(227, 62);
            this.radioButton_build_StackListFull.TabIndex = 48;
            this.radioButton_build_StackListFull.TabStop = true;
            this.radioButton_build_StackListFull.Text = "Список стеків\r\n+ цилкічні ребра";
            this.radioButton_build_StackListFull.UseVisualStyleBackColor = true;
            this.radioButton_build_StackListFull.CheckedChanged += new System.EventHandler(this.RadioButton_build_StackListFull_CheckedChanged);
            // 
            // radioButton_build_StackList
            // 
            this.radioButton_build_StackList.AutoSize = true;
            this.radioButton_build_StackList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_build_StackList.Location = new System.Drawing.Point(5, 76);
            this.radioButton_build_StackList.Name = "radioButton_build_StackList";
            this.radioButton_build_StackList.Size = new System.Drawing.Size(194, 33);
            this.radioButton_build_StackList.TabIndex = 47;
            this.radioButton_build_StackList.TabStop = true;
            this.radioButton_build_StackList.Text = "Список стеків";
            this.radioButton_build_StackList.UseVisualStyleBackColor = true;
            this.radioButton_build_StackList.CheckedChanged += new System.EventHandler(this.RadioButton_build_StackList_CheckedChanged);
            // 
            // radioButton_build_StackTree
            // 
            this.radioButton_build_StackTree.AutoSize = true;
            this.radioButton_build_StackTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_build_StackTree.Location = new System.Drawing.Point(5, 183);
            this.radioButton_build_StackTree.Name = "radioButton_build_StackTree";
            this.radioButton_build_StackTree.Size = new System.Drawing.Size(194, 33);
            this.radioButton_build_StackTree.TabIndex = 46;
            this.radioButton_build_StackTree.TabStop = true;
            this.radioButton_build_StackTree.Text = "Дерево стеків";
            this.radioButton_build_StackTree.UseVisualStyleBackColor = true;
            this.radioButton_build_StackTree.CheckedChanged += new System.EventHandler(this.RadioButton_build_StackTree_CheckedChanged);
            // 
            // radioButton_build_AcyclicGraph
            // 
            this.radioButton_build_AcyclicGraph.AutoSize = true;
            this.radioButton_build_AcyclicGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_build_AcyclicGraph.Location = new System.Drawing.Point(5, 37);
            this.radioButton_build_AcyclicGraph.Name = "radioButton_build_AcyclicGraph";
            this.radioButton_build_AcyclicGraph.Size = new System.Drawing.Size(233, 33);
            this.radioButton_build_AcyclicGraph.TabIndex = 45;
            this.radioButton_build_AcyclicGraph.TabStop = true;
            this.radioButton_build_AcyclicGraph.Text = "Ациклічний граф\r\n";
            this.radioButton_build_AcyclicGraph.UseVisualStyleBackColor = true;
            this.radioButton_build_AcyclicGraph.CheckedChanged += new System.EventHandler(this.RadioButton_build_AcyclicGraph_CheckedChanged);
            // 
            // radioButton_build_Graph
            // 
            this.radioButton_build_Graph.AutoSize = true;
            this.radioButton_build_Graph.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_build_Graph.Location = new System.Drawing.Point(5, 3);
            this.radioButton_build_Graph.Name = "radioButton_build_Graph";
            this.radioButton_build_Graph.Size = new System.Drawing.Size(235, 33);
            this.radioButton_build_Graph.TabIndex = 44;
            this.radioButton_build_Graph.TabStop = true;
            this.radioButton_build_Graph.Text = "Початковий граф\r\n";
            this.radioButton_build_Graph.UseVisualStyleBackColor = true;
            this.radioButton_build_Graph.CheckedChanged += new System.EventHandler(this.RadioButton_build_Graph_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 538);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 61);
            this.button1.TabIndex = 45;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_build_back_Click);
            // 
            // pictureBox_stackTree
            // 
            this.pictureBox_stackTree.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_stackTree.Name = "pictureBox_stackTree";
            this.pictureBox_stackTree.Size = new System.Drawing.Size(945, 603);
            this.pictureBox_stackTree.TabIndex = 30;
            this.pictureBox_stackTree.TabStop = false;
            // 
            // Form_buildTree
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_build);
            this.Controls.Add(this.button_build_save);
            this.Controls.Add(this.button_textDownload);
            this.Controls.Add(this.panel_build_stackTree);
            this.Name = "Form_buildTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Побудова";
            this.Load += new System.EventHandler(this.Form_buildTree_Load);
            this.panel_build_stackTree.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_stackTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_build_stackTree;
        private System.Windows.Forms.PictureBox pictureBox_stackTree;
        private System.Windows.Forms.Button button_textDownload;
        private System.Windows.Forms.Button button_build_save;
        private System.Windows.Forms.Label label_build;
        private System.Windows.Forms.RadioButton radioButton_build_StackTreeCompressed;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_build_AcyclicGraph;
        private System.Windows.Forms.RadioButton radioButton_build_Graph;
        private System.Windows.Forms.RadioButton radioButton_build_StackTree;
        private System.Windows.Forms.RadioButton radioButton_build_StackListFull;
        private System.Windows.Forms.RadioButton radioButton_build_StackList;
        private System.Windows.Forms.Button button1;
    }
}