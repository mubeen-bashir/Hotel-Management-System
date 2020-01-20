namespace HotelManagementSystem
{
    partial class InventoryItems
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
            this.lable1 = new System.Windows.Forms.Label();
            this.GClearFields = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.GRemove = new System.Windows.Forms.Button();
            this.GEdit = new System.Windows.Forms.Button();
            this.GAddNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxGName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxGId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lable1.Location = new System.Drawing.Point(369, 21);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(232, 37);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Inventory Items";
            this.lable1.UseWaitCursor = true;
            // 
            // GClearFields
            // 
            this.GClearFields.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GClearFields.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GClearFields.Location = new System.Drawing.Point(102, 429);
            this.GClearFields.Name = "GClearFields";
            this.GClearFields.Size = new System.Drawing.Size(257, 43);
            this.GClearFields.TabIndex = 16;
            this.GClearFields.Text = "Clear Fields";
            this.GClearFields.UseVisualStyleBackColor = true;
            this.GClearFields.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(519, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Records View:";
            this.label7.UseWaitCursor = true;
            // 
            // GRemove
            // 
            this.GRemove.BackColor = System.Drawing.Color.Salmon;
            this.GRemove.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRemove.Location = new System.Drawing.Point(308, 371);
            this.GRemove.Name = "GRemove";
            this.GRemove.Size = new System.Drawing.Size(119, 43);
            this.GRemove.TabIndex = 14;
            this.GRemove.Text = "Remove";
            this.GRemove.UseVisualStyleBackColor = false;
            this.GRemove.UseWaitCursor = true;
            // 
            // GEdit
            // 
            this.GEdit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GEdit.Location = new System.Drawing.Point(169, 371);
            this.GEdit.Name = "GEdit";
            this.GEdit.Size = new System.Drawing.Size(119, 43);
            this.GEdit.TabIndex = 13;
            this.GEdit.Text = "Edit";
            this.GEdit.UseVisualStyleBackColor = true;
            this.GEdit.UseWaitCursor = true;
            // 
            // GAddNew
            // 
            this.GAddNew.BackColor = System.Drawing.Color.PowderBlue;
            this.GAddNew.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GAddNew.Location = new System.Drawing.Point(12, 371);
            this.GAddNew.Name = "GAddNew";
            this.GAddNew.Size = new System.Drawing.Size(147, 43);
            this.GAddNew.TabIndex = 12;
            this.GAddNew.Text = "Add New";
            this.GAddNew.UseVisualStyleBackColor = false;
            this.GAddNew.UseWaitCursor = true;
            this.GAddNew.Click += new System.EventHandler(this.GAddNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(523, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 337);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.UseWaitCursor = true;
            // 
            // textBoxGName
            // 
            this.textBoxGName.Location = new System.Drawing.Point(144, 210);
            this.textBoxGName.Multiline = true;
            this.textBoxGName.Name = "textBoxGName";
            this.textBoxGName.Size = new System.Drawing.Size(274, 50);
            this.textBoxGName.TabIndex = 2;
            this.textBoxGName.UseWaitCursor = true;
            this.textBoxGName.TextChanged += new System.EventHandler(this.textBoxGName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Item Name:";
            this.label5.UseWaitCursor = true;
            // 
            // txtBoxGId
            // 
            this.txtBoxGId.Location = new System.Drawing.Point(144, 134);
            this.txtBoxGId.Multiline = true;
            this.txtBoxGId.Name = "txtBoxGId";
            this.txtBoxGId.Size = new System.Drawing.Size(274, 50);
            this.txtBoxGId.TabIndex = 1;
            this.txtBoxGId.UseWaitCursor = true;
            this.txtBoxGId.TextChanged += new System.EventHandler(this.txtBoxGId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            this.label2.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.lable1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 68);
            this.panel2.TabIndex = 0;
            this.panel2.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.GClearFields);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.GRemove);
            this.panel1.Controls.Add(this.GEdit);
            this.panel1.Controls.Add(this.GAddNew);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBoxGName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBoxGId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(17, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 481);
            this.panel1.TabIndex = 1;
            this.panel1.UseWaitCursor = true;
            // 
            // InventoryItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 476);
            this.Controls.Add(this.panel1);
            this.Name = "InventoryItems";
            this.Text = "InventoryItems";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Button GClearFields;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GRemove;
        private System.Windows.Forms.Button GEdit;
        private System.Windows.Forms.Button GAddNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxGName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxGId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}