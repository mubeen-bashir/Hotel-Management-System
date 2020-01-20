namespace HotelManagementSystem
{
    partial class MainForm2
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
            this.chefsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chefsToolStripMenuItem
            // 
            this.chefsToolStripMenuItem.Name = "chefsToolStripMenuItem";
            this.chefsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.chefsToolStripMenuItem.Text = "Chefs";
            this.chefsToolStripMenuItem.Click += new System.EventHandler(this.chefsToolStripMenuItem_Click);
            // 
            // waiterToolStripMenuItem
            // 
            this.waiterToolStripMenuItem.Name = "waiterToolStripMenuItem";
            this.waiterToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.waiterToolStripMenuItem.Text = "Waiter";
            this.waiterToolStripMenuItem.Click += new System.EventHandler(this.waiterToolStripMenuItem_Click);
            // 
            // foodItemsToolStripMenuItem
            // 
            this.foodItemsToolStripMenuItem.Name = "foodItemsToolStripMenuItem";
            this.foodItemsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.foodItemsToolStripMenuItem.Text = "FoodItems";
            this.foodItemsToolStripMenuItem.Click += new System.EventHandler(this.foodItemsToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chefsToolStripMenuItem,
            this.waiterToolStripMenuItem,
            this.foodItemsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1037, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 440);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm2";
            this.Text = "MainForm2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem chefsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodItemsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;


    }
}