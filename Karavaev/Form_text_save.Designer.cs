namespace Karavaev
{
    partial class Form_text_save
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
            this.button_aboutType = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_fileName = new System.Windows.Forms.TextBox();
            this.button_typeB = new System.Windows.Forms.Button();
            this.button_typeA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_aboutType
            // 
            this.button_aboutType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_aboutType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_aboutType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aboutType.Location = new System.Drawing.Point(13, 139);
            this.button_aboutType.Margin = new System.Windows.Forms.Padding(4);
            this.button_aboutType.Name = "button_aboutType";
            this.button_aboutType.Size = new System.Drawing.Size(131, 40);
            this.button_aboutType.TabIndex = 32;
            this.button_aboutType.Text = "Про типи ";
            this.button_aboutType.UseVisualStyleBackColor = true;
            this.button_aboutType.Click += new System.EventHandler(this.Button_aboutType_Click);
            // 
            // button_save
            // 
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(239, 139);
            this.button_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(131, 40);
            this.button_save.TabIndex = 31;
            this.button_save.Text = "Зберегти";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 48);
            this.label1.TabIndex = 30;
            this.label1.Text = "Введіть назву(наприклад : \"input\")\r\nта оберіть тип файлу!\r\n\r\n\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fileName.Location = new System.Drawing.Point(97, 60);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(185, 24);
            this.textBox_fileName.TabIndex = 29;
            // 
            // button_typeB
            // 
            this.button_typeB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_typeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_typeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_typeB.Location = new System.Drawing.Point(211, 91);
            this.button_typeB.Margin = new System.Windows.Forms.Padding(4);
            this.button_typeB.Name = "button_typeB";
            this.button_typeB.Size = new System.Drawing.Size(80, 40);
            this.button_typeB.TabIndex = 28;
            this.button_typeB.Text = "Type B";
            this.button_typeB.UseVisualStyleBackColor = true;
            this.button_typeB.Click += new System.EventHandler(this.Button_typeB_Click);
            // 
            // button_typeA
            // 
            this.button_typeA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_typeA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_typeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_typeA.Location = new System.Drawing.Point(87, 91);
            this.button_typeA.Margin = new System.Windows.Forms.Padding(4);
            this.button_typeA.Name = "button_typeA";
            this.button_typeA.Size = new System.Drawing.Size(80, 40);
            this.button_typeA.TabIndex = 27;
            this.button_typeA.Text = "Type A";
            this.button_typeA.UseVisualStyleBackColor = true;
            this.button_typeA.Click += new System.EventHandler(this.Button_typeA_Click);
            // 
            // Form_text_save
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 183);
            this.Controls.Add(this.button_aboutType);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_fileName);
            this.Controls.Add(this.button_typeB);
            this.Controls.Add(this.button_typeA);
            this.Name = "Form_text_save";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зберегти дані";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_aboutType;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_fileName;
        private System.Windows.Forms.Button button_typeB;
        private System.Windows.Forms.Button button_typeA;
    }
}