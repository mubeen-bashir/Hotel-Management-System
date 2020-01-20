namespace HotelManagementSystem
{
    partial class Recep
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGuestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatePaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCustomerToolStripMenuItem,
            this.manageRoomsToolStripMenuItem,
            this.manageGuestsToolStripMenuItem,
            this.calculatePaymentsToolStripMenuItem,
            this.manageReservationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageCustomerToolStripMenuItem
            // 
            this.manageCustomerToolStripMenuItem.Name = "manageCustomerToolStripMenuItem";
            this.manageCustomerToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.manageCustomerToolStripMenuItem.Text = "ManageCustomer";
            this.manageCustomerToolStripMenuItem.Click += new System.EventHandler(this.manageCustomerToolStripMenuItem_Click);
            // 
            // manageRoomsToolStripMenuItem
            // 
            this.manageRoomsToolStripMenuItem.Name = "manageRoomsToolStripMenuItem";
            this.manageRoomsToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.manageRoomsToolStripMenuItem.Text = "ManageRooms";
            this.manageRoomsToolStripMenuItem.Click += new System.EventHandler(this.manageRoomsToolStripMenuItem_Click);
            // 
            // manageGuestsToolStripMenuItem
            // 
            this.manageGuestsToolStripMenuItem.Name = "manageGuestsToolStripMenuItem";
            this.manageGuestsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.manageGuestsToolStripMenuItem.Text = "ManageGuests";
            this.manageGuestsToolStripMenuItem.Click += new System.EventHandler(this.manageGuestsToolStripMenuItem_Click);
            // 
            // calculatePaymentsToolStripMenuItem
            // 
            this.calculatePaymentsToolStripMenuItem.Name = "calculatePaymentsToolStripMenuItem";
            this.calculatePaymentsToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.calculatePaymentsToolStripMenuItem.Text = "CalculatePayments";
            this.calculatePaymentsToolStripMenuItem.Click += new System.EventHandler(this.calculatePaymentsToolStripMenuItem_Click);
            // 
            // manageReservationToolStripMenuItem
            // 
            this.manageReservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReservationToolStripMenuItem});
            this.manageReservationToolStripMenuItem.Name = "manageReservationToolStripMenuItem";
            this.manageReservationToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.manageReservationToolStripMenuItem.Text = "Manage Reservation";
            // 
            // addReservationToolStripMenuItem
            // 
            this.addReservationToolStripMenuItem.Name = "addReservationToolStripMenuItem";
            this.addReservationToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addReservationToolStripMenuItem.Text = "Add Reservation";
            this.addReservationToolStripMenuItem.Click += new System.EventHandler(this.addReservationToolStripMenuItem_Click);
            // 
            // Recep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 364);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Recep";
            this.Text = "MainForm1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageGuestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatePaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReservationToolStripMenuItem;
    }
}