namespace Karavaev
{
    partial class Form_practic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_practic));
            this.pictureBox_GraphView = new System.Windows.Forms.PictureBox();
            this.button_practic_back = new System.Windows.Forms.Button();
            this.button_practic_random = new System.Windows.Forms.Button();
            this.button_practic_model = new System.Windows.Forms.Button();
            this.button_practic_modellling = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_practic_random_tree = new System.Windows.Forms.Button();
            this.button_practic_random_acyclic = new System.Windows.Forms.Button();
            this.button_practic_model_text_save = new System.Windows.Forms.Button();
            this.button_practic_model_text_download = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GraphView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_GraphView
            // 
            this.pictureBox_GraphView.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_GraphView.Name = "pictureBox_GraphView";
            this.pictureBox_GraphView.Size = new System.Drawing.Size(500, 400);
            this.pictureBox_GraphView.TabIndex = 0;
            this.pictureBox_GraphView.TabStop = false;
            // 
            // button_practic_back
            // 
            this.button_practic_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_practic_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_practic_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.button_practic_back.Location = new System.Drawing.Point(988, 541);
            this.button_practic_back.Margin = new System.Windows.Forms.Padding(4);
            this.button_practic_back.Name = "button_practic_back";
            this.button_practic_back.Size = new System.Drawing.Size(181, 74);
            this.button_practic_back.TabIndex = 18;
            this.button_practic_back.Text = "Назад";
            this.button_practic_back.UseVisualStyleBackColor = true;
            this.button_practic_back.Click += new System.EventHandler(this.Button_practic_back_Click);
            // 
            // button_practic_random
            // 
            this.button_practic_random.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_practic_random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_practic_random.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_practic_random.Location = new System.Drawing.Point(621, 273);
            this.button_practic_random.Margin = new System.Windows.Forms.Padding(4);
            this.button_practic_random.Name = "button_practic_random";
            this.button_practic_random.Size = new System.Drawing.Size(225, 56);
            this.button_practic_random.TabIndex = 19;
            this.button_practic_random.Text = "Граф";
            this.button_practic_random.UseVisualStyleBackColor = true;
            this.button_practic_random.Click += new System.EventHandler(this.Button_practic_random_Click);
            // 
            // button_practic_model
            // 
            this.button_practic_model.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_practic_model.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_practic_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_practic_model.Location = new System.Drawing.Point(62, 431);
            this.button_practic_model.Margin = new System.Windows.Forms.Padding(4);
            this.button_practic_model.Name = "button_practic_model";
            this.button_practic_model.Size = new System.Drawing.Size(390, 56);
            this.button_practic_model.TabIndex = 20;
            this.button_practic_model.Text = "Побудувати власноруч";
            this.button_practic_model.UseVisualStyleBackColor = true;
            this.button_practic_model.Click += new System.EventHandler(this.Button_practic_model_Click);
            // 
            // button_practic_modellling
            // 
            this.button_practic_modellling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_practic_modellling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_practic_modellling.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_practic_modellling.Location = new System.Drawing.Point(47, 504);
            this.button_practic_modellling.Margin = new System.Windows.Forms.Padding(4);
            this.button_practic_modellling.Name = "button_practic_modellling";
            this.button_practic_modellling.Size = new System.Drawing.Size(417, 56);
            this.button_practic_modellling.TabIndex = 26;
            this.button_practic_modellling.Text = "Розпочати моделювання";
            this.button_practic_modellling.UseVisualStyleBackColor = true;
            this.button_practic_modellling.Click += new System.EventHandler(this.Button_practic_modellling_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(537, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 196);
            this.label1.TabIndex = 27;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button_practic_random_tree
            // 
            this.button_practic_random_tree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_practic_random_tree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_practic_random_tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_practic_random_tree.Location = new System.Drawing.Point(621, 345);
            this.button_practic_random_tree.Margin = new System.Windows.Forms.Padding(4);
            this.button_practic_random_tree.Name = "button_practic_random_tree";
            this.button_practic_random_tree.Size = new System.Drawing.Size(225, 56);
            this.button_practic_random_tree.TabIndex = 28;
            this.button_practic_random_tree.Text = "Дерево";
            this.button_practic_random_tree.UseVisualStyleBackColor = true;
            this.button_practic_random_tree.Click += new System.EventHandler(this.Button_practic_random_tree_Click);
            // 
            // button_practic_random_acyclic
            // 
            this.button_practic_random_acyclic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_practic_random_acyclic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_practic_random_acyclic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_practic_random_acyclic.Location = new System.Drawing.Point(864, 303);
            this.button_practic_random_acyclic.Margin = new System.Windows.Forms.Padding(4);
            this.button_practic_random_acyclic.Name = "button_practic_random_acyclic";
            this.button_practic_random_acyclic.Size = new System.Drawing.Size(225, 83);
            this.button_practic_random_acyclic.TabIndex = 29;
            this.button_practic_random_acyclic.Text = "Ациклічний граф";
            this.button_practic_random_acyclic.UseVisualStyleBackColor = true;
            this.button_practic_random_acyclic.Click += new System.EventHandler(this.Button_practic_random_acyclic_Click);
            // 
            // button_practic_model_text_save
            // 
            this.button_practic_model_text_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_practic_model_text_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_practic_model_text_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_practic_model_text_save.Location = new System.Drawing.Point(748, 440);
            this.button_practic_model_text_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_practic_model_text_save.Name = "button_practic_model_text_save";
            this.button_practic_model_text_save.Size = new System.Drawing.Size(210, 120);
            this.button_practic_model_text_save.TabIndex = 37;
            this.button_practic_model_text_save.Text = "Зберегти до текстового файлу\r\n";
            this.button_practic_model_text_save.UseVisualStyleBackColor = true;
            this.button_practic_model_text_save.Click += new System.EventHandler(this.Button_practic_model_text_save_Click);
            // 
            // button_practic_model_text_download
            // 
            this.button_practic_model_text_download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_practic_model_text_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_practic_model_text_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_practic_model_text_download.Location = new System.Drawing.Point(494, 440);
            this.button_practic_model_text_download.Margin = new System.Windows.Forms.Padding(4);
            this.button_practic_model_text_download.Name = "button_practic_model_text_download";
            this.button_practic_model_text_download.Size = new System.Drawing.Size(224, 120);
            this.button_practic_model_text_download.TabIndex = 38;
            this.button_practic_model_text_download.Text = "Завантажити з текстового файлу\r\n";
            this.button_practic_model_text_download.UseVisualStyleBackColor = true;
            this.button_practic_model_text_download.Click += new System.EventHandler(this.Button_practic_model_text_download_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(621, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 54);
            this.label2.TabIndex = 39;
            this.label2.Text = "Побудувати випадково:\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_practic
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_practic_model_text_download);
            this.Controls.Add(this.button_practic_model_text_save);
            this.Controls.Add(this.button_practic_random_acyclic);
            this.Controls.Add(this.button_practic_random_tree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_practic_modellling);
            this.Controls.Add(this.button_practic_model);
            this.Controls.Add(this.button_practic_random);
            this.Controls.Add(this.button_practic_back);
            this.Controls.Add(this.pictureBox_GraphView);
            this.Name = "Form_practic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Побудова";
            this.Load += new System.EventHandler(this.Form_practic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GraphView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_GraphView;
        private System.Windows.Forms.Button button_practic_back;
        private System.Windows.Forms.Button button_practic_random;
        private System.Windows.Forms.Button button_practic_model;
        private System.Windows.Forms.Button button_practic_modellling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_practic_random_tree;
        private System.Windows.Forms.Button button_practic_random_acyclic;
        private System.Windows.Forms.Button button_practic_model_text_save;
        private System.Windows.Forms.Button button_practic_model_text_download;
        private System.Windows.Forms.Label label2;
    }
}