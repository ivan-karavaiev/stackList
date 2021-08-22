namespace Karavaev
{
    partial class Form_help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_help));
            this.label1 = new System.Windows.Forms.Label();
            this.button_practic_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 186);
            this.label1.TabIndex = 28;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button_practic_back
            // 
            this.button_practic_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_practic_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_practic_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.button_practic_back.Location = new System.Drawing.Point(792, 471);
            this.button_practic_back.Margin = new System.Windows.Forms.Padding(4);
            this.button_practic_back.Name = "button_practic_back";
            this.button_practic_back.Size = new System.Drawing.Size(227, 74);
            this.button_practic_back.TabIndex = 29;
            this.button_practic_back.Text = "Закрити";
            this.button_practic_back.UseVisualStyleBackColor = true;
            this.button_practic_back.Click += new System.EventHandler(this.Button_practic_back_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Karavaev.Properties.Resources.Graph_Help;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 513);
            this.panel1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(239, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(728, 241);
            this.label2.TabIndex = 31;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(239, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(728, 159);
            this.label3.TabIndex = 32;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(244, 453);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(531, 81);
            this.label4.TabIndex = 33;
            this.label4.Text = "   Ребра, які утворюють цикли представлені у вигляді списку суміжності вершин, зв" +
    "\'язки між якими є циклічними.";
            // 
            // Form_help
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1032, 558);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_practic_back);
            this.Controls.Add(this.label1);
            this.Name = "Form_help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Допомога";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_practic_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}