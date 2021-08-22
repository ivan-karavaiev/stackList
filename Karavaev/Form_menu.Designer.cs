namespace Karavaev
{
    partial class Form_menu
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
            this.button_menu_test = new System.Windows.Forms.Button();
            this.button_menu_theory = new System.Windows.Forms.Button();
            this.button_menu_practic = new System.Windows.Forms.Button();
            this.button_menu_build = new System.Windows.Forms.Button();
            this.button_menu_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_menu_test
            // 
            this.button_menu_test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_menu_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu_test.Location = new System.Drawing.Point(238, 82);
            this.button_menu_test.Margin = new System.Windows.Forms.Padding(4);
            this.button_menu_test.Name = "button_menu_test";
            this.button_menu_test.Size = new System.Drawing.Size(390, 107);
            this.button_menu_test.TabIndex = 26;
            this.button_menu_test.Text = "Тести";
            this.button_menu_test.UseVisualStyleBackColor = true;
            this.button_menu_test.Click += new System.EventHandler(this.Button_menu_test_Click);
            // 
            // button_menu_theory
            // 
            this.button_menu_theory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_menu_theory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu_theory.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu_theory.Location = new System.Drawing.Point(627, 82);
            this.button_menu_theory.Margin = new System.Windows.Forms.Padding(4);
            this.button_menu_theory.Name = "button_menu_theory";
            this.button_menu_theory.Size = new System.Drawing.Size(348, 208);
            this.button_menu_theory.TabIndex = 27;
            this.button_menu_theory.Text = "Теорія";
            this.button_menu_theory.UseVisualStyleBackColor = true;
            this.button_menu_theory.Click += new System.EventHandler(this.Button_menu_theory_Click);
            // 
            // button_menu_practic
            // 
            this.button_menu_practic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_menu_practic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu_practic.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu_practic.Location = new System.Drawing.Point(238, 186);
            this.button_menu_practic.Margin = new System.Windows.Forms.Padding(4);
            this.button_menu_practic.Name = "button_menu_practic";
            this.button_menu_practic.Size = new System.Drawing.Size(390, 236);
            this.button_menu_practic.TabIndex = 28;
            this.button_menu_practic.Text = "Практика";
            this.button_menu_practic.UseVisualStyleBackColor = true;
            this.button_menu_practic.Click += new System.EventHandler(this.Button_menu_practic_Click);
            // 
            // button_menu_build
            // 
            this.button_menu_build.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_menu_build.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu_build.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu_build.Location = new System.Drawing.Point(627, 287);
            this.button_menu_build.Margin = new System.Windows.Forms.Padding(4);
            this.button_menu_build.Name = "button_menu_build";
            this.button_menu_build.Size = new System.Drawing.Size(348, 135);
            this.button_menu_build.TabIndex = 29;
            this.button_menu_build.Text = "Побудова";
            this.button_menu_build.UseVisualStyleBackColor = true;
            this.button_menu_build.Click += new System.EventHandler(this.Button_menu_build_Click);
            // 
            // button_menu_back
            // 
            this.button_menu_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_menu_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu_back.Location = new System.Drawing.Point(499, 517);
            this.button_menu_back.Margin = new System.Windows.Forms.Padding(4);
            this.button_menu_back.Name = "button_menu_back";
            this.button_menu_back.Size = new System.Drawing.Size(252, 88);
            this.button_menu_back.TabIndex = 30;
            this.button_menu_back.Text = "Назад";
            this.button_menu_back.UseVisualStyleBackColor = true;
            this.button_menu_back.Click += new System.EventHandler(this.Button_menu_back_Click);
            // 
            // Form_menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.button_menu_back);
            this.Controls.Add(this.button_menu_build);
            this.Controls.Add(this.button_menu_practic);
            this.Controls.Add(this.button_menu_theory);
            this.Controls.Add(this.button_menu_test);
            this.Name = "Form_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_menu_test;
        private System.Windows.Forms.Button button_menu_theory;
        private System.Windows.Forms.Button button_menu_practic;
        private System.Windows.Forms.Button button_menu_build;
        private System.Windows.Forms.Button button_menu_back;
    }
}