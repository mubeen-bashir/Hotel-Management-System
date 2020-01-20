namespace HotelManagementSystem
{
    partial class Payments
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lable1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxrescharg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxaddser = new System.Windows.Forms.TextBox();
            this.txtBoxrcharg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.lable1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(10, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 68);
            this.panel2.TabIndex = 1;
            this.panel2.UseWaitCursor = true;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lable1.Location = new System.Drawing.Point(369, 21);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(158, 37);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Payments";
            this.lable1.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Additional Services:";
            this.label1.UseWaitCursor = true;
            // 
            // textBoxrescharg
            // 
            this.textBoxrescharg.Location = new System.Drawing.Point(260, 164);
            this.textBoxrescharg.Multiline = true;
            this.textBoxrescharg.Name = "textBoxrescharg";
            this.textBoxrescharg.Size = new System.Drawing.Size(141, 32);
            this.textBoxrescharg.TabIndex = 21;
            this.textBoxrescharg.UseWaitCursor = true;
            this.textBoxrescharg.TextChanged += new System.EventHandler(this.textBoxGName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Restaurant Charges:";
            this.label5.UseWaitCursor = true;
            // 
            // textBoxaddser
            // 
            this.textBoxaddser.Location = new System.Drawing.Point(260, 231);
            this.textBoxaddser.Multiline = true;
            this.textBoxaddser.Name = "textBoxaddser";
            this.textBoxaddser.Size = new System.Drawing.Size(141, 32);
            this.textBoxaddser.TabIndex = 22;
            this.textBoxaddser.UseWaitCursor = true;
            this.textBoxaddser.TextChanged += new System.EventHandler(this.textBoxGCNIC_TextChanged);
            // 
            // txtBoxrcharg
            // 
            this.txtBoxrcharg.Location = new System.Drawing.Point(260, 108);
            this.txtBoxrcharg.Multiline = true;
            this.txtBoxrcharg.Name = "txtBoxrcharg";
            this.txtBoxrcharg.Size = new System.Drawing.Size(141, 32);
            this.txtBoxrcharg.TabIndex = 20;
            this.txtBoxrcharg.UseWaitCursor = true;
            this.txtBoxrcharg.TextChanged += new System.EventHandler(this.txtBoxGId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "RoomCharges:";
            this.label2.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(540, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "Records View:";
            this.label7.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(544, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 337);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 332);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 68);
            this.textBox1.TabIndex = 26;
            this.textBox1.UseWaitCursor = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Total Bill:";
            this.label3.UseWaitCursor = true;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 460);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxrescharg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxaddser);
            this.Controls.Add(this.txtBoxrcharg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Name = "Payments";
            this.Text = "Payments";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxrescharg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxaddser;
        private System.Windows.Forms.TextBox txtBoxrcharg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}