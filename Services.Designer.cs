namespace HotelManagementSystem
{
    partial class Service
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
            this.textBoxsertype = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
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
            this.panel2.Location = new System.Drawing.Point(25, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 68);
            this.panel2.TabIndex = 2;
            this.panel2.UseWaitCursor = true;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lable1.Location = new System.Drawing.Point(369, 21);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(137, 37);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Services";
            this.lable1.UseWaitCursor = true;
            // 
            // textBoxsertype
            // 
            this.textBoxsertype.Location = new System.Drawing.Point(285, 165);
            this.textBoxsertype.Multiline = true;
            this.textBoxsertype.Name = "textBoxsertype";
            this.textBoxsertype.Size = new System.Drawing.Size(288, 32);
            this.textBoxsertype.TabIndex = 25;
            this.textBoxsertype.UseWaitCursor = true;
            this.textBoxsertype.TextChanged += new System.EventHandler(this.textBoxsertype_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Service Type:";
            this.label5.UseWaitCursor = true;
            // 
            // textBoxsername
            // 
            this.textBoxsername.Location = new System.Drawing.Point(285, 109);
            this.textBoxsername.Multiline = true;
            this.textBoxsername.Name = "textBoxsername";
            this.textBoxsername.Size = new System.Drawing.Size(288, 32);
            this.textBoxsername.TabIndex = 24;
            this.textBoxsername.UseWaitCursor = true;
            this.textBoxsername.TextChanged += new System.EventHandler(this.txtBoxGId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Service Name:";
            this.label2.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(634, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Records View:";
            this.label7.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(624, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 245);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(144, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 38);
            this.button1.TabIndex = 28;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxsertype);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxsername);
            this.Controls.Add(this.label2);
            this.Name = "Service";
            this.Text = "Services";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox textBoxsertype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}