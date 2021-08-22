namespace Karavaev
{
    partial class Form_practic_rebuilding
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
            this.pictureBox_rebuilding_GraphView = new System.Windows.Forms.PictureBox();
            this.panel_practic_rebuilding = new System.Windows.Forms.Panel();
            this.pictureBox_practic_rebuilding = new System.Windows.Forms.PictureBox();
            this.button_practic_rebuilding_cycle = new System.Windows.Forms.Button();
            this.button_practic_rebuilding_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_rebuilding_GraphView)).BeginInit();
            this.panel_practic_rebuilding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_practic_rebuilding)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_rebuilding_GraphView
            // 
            this.pictureBox_rebuilding_GraphView.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_rebuilding_GraphView.Name = "pictureBox_rebuilding_GraphView";
            this.pictureBox_rebuilding_GraphView.Size = new System.Drawing.Size(500, 400);
            this.pictureBox_rebuilding_GraphView.TabIndex = 2;
            this.pictureBox_rebuilding_GraphView.TabStop = false;
            // 
            // panel_practic_rebuilding
            // 
            this.panel_practic_rebuilding.AutoScroll = true;
            this.panel_practic_rebuilding.Controls.Add(this.pictureBox_practic_rebuilding);
            this.panel_practic_rebuilding.Location = new System.Drawing.Point(545, 12);
            this.panel_practic_rebuilding.Name = "panel_practic_rebuilding";
            this.panel_practic_rebuilding.Size = new System.Drawing.Size(625, 600);
            this.panel_practic_rebuilding.TabIndex = 28;
            // 
            // pictureBox_practic_rebuilding
            // 
            this.pictureBox_practic_rebuilding.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_practic_rebuilding.Name = "pictureBox_practic_rebuilding";
            this.pictureBox_practic_rebuilding.Size = new System.Drawing.Size(2000, 2000);
            this.pictureBox_practic_rebuilding.TabIndex = 0;
            this.pictureBox_practic_rebuilding.TabStop = false;
            // 
            // button_practic_rebuilding_cycle
            // 
            this.button_practic_rebuilding_cycle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_practic_rebuilding_cycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_practic_rebuilding_cycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_practic_rebuilding_cycle.Location = new System.Drawing.Point(62, 428);
            this.button_practic_rebuilding_cycle.Margin = new System.Windows.Forms.Padding(4);
            this.button_practic_rebuilding_cycle.Name = "button_practic_rebuilding_cycle";
            this.button_practic_rebuilding_cycle.Size = new System.Drawing.Size(390, 56);
            this.button_practic_rebuilding_cycle.TabIndex = 29;
            this.button_practic_rebuilding_cycle.Text = "Відобразити цикли\r\n";
            this.button_practic_rebuilding_cycle.UseVisualStyleBackColor = true;
            this.button_practic_rebuilding_cycle.Click += new System.EventHandler(this.Button_practic_rebuilding_cycle_Click);
            // 
            // button_practic_rebuilding_back
            // 
            this.button_practic_rebuilding_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_practic_rebuilding_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_practic_rebuilding_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_practic_rebuilding_back.Location = new System.Drawing.Point(62, 492);
            this.button_practic_rebuilding_back.Margin = new System.Windows.Forms.Padding(4);
            this.button_practic_rebuilding_back.Name = "button_practic_rebuilding_back";
            this.button_practic_rebuilding_back.Size = new System.Drawing.Size(390, 56);
            this.button_practic_rebuilding_back.TabIndex = 30;
            this.button_practic_rebuilding_back.Text = "Повернутись назад";
            this.button_practic_rebuilding_back.UseVisualStyleBackColor = true;
            this.button_practic_rebuilding_back.Click += new System.EventHandler(this.Button_practic_rebuilding_back_Click);
            // 
            // Form_practic_rebuilding
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.button_practic_rebuilding_back);
            this.Controls.Add(this.button_practic_rebuilding_cycle);
            this.Controls.Add(this.panel_practic_rebuilding);
            this.Controls.Add(this.pictureBox_rebuilding_GraphView);
            this.Name = "Form_practic_rebuilding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Візуалізація дерева стеків";
            this.Load += new System.EventHandler(this.Form_practic_rebuilding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_rebuilding_GraphView)).EndInit();
            this.panel_practic_rebuilding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_practic_rebuilding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_rebuilding_GraphView;
        private System.Windows.Forms.Panel panel_practic_rebuilding;
        private System.Windows.Forms.PictureBox pictureBox_practic_rebuilding;
        private System.Windows.Forms.Button button_practic_rebuilding_cycle;
        private System.Windows.Forms.Button button_practic_rebuilding_back;
    }
}