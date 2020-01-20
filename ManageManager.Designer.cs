namespace HotelManagementSystem
{
    partial class ManageManager
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
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxmEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxmGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxmAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GClearFields = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.GRemove = new System.Windows.Forms.Button();
            this.GEdit = new System.Windows.Forms.Button();
            this.GAddNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxmAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxmName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxmCNIC = new System.Windows.Forms.TextBox();
            this.textBoxmPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxmid = new System.Windows.Forms.TextBox();
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
            this.lable1.Size = new System.Drawing.Size(267, 37);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Manage Manager";
            this.lable1.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(93, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Email:";
            this.label9.UseWaitCursor = true;
            // 
            // textBoxmEmail
            // 
            this.textBoxmEmail.Location = new System.Drawing.Point(169, 209);
            this.textBoxmEmail.Multiline = true;
            this.textBoxmEmail.Name = "textBoxmEmail";
            this.textBoxmEmail.Size = new System.Drawing.Size(274, 32);
            this.textBoxmEmail.TabIndex = 22;
            this.textBoxmEmail.UseWaitCursor = true;
            this.textBoxmEmail.TextChanged += new System.EventHandler(this.textBoxmEmail_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Gender:";
            this.label8.UseWaitCursor = true;
            // 
            // comboBoxmGender
            // 
            this.comboBoxmGender.FormattingEnabled = true;
            this.comboBoxmGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxmGender.Location = new System.Drawing.Point(170, 247);
            this.comboBoxmGender.Name = "comboBoxmGender";
            this.comboBoxmGender.Size = new System.Drawing.Size(83, 39);
            this.comboBoxmGender.TabIndex = 20;
            this.comboBoxmGender.UseWaitCursor = true;
            this.comboBoxmGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxmGender_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Age:";
            this.label4.UseWaitCursor = true;
            // 
            // textBoxmAge
            // 
            this.textBoxmAge.Location = new System.Drawing.Point(389, 247);
            this.textBoxmAge.Multiline = true;
            this.textBoxmAge.Name = "textBoxmAge";
            this.textBoxmAge.Size = new System.Drawing.Size(54, 39);
            this.textBoxmAge.TabIndex = 18;
            this.textBoxmAge.UseWaitCursor = true;
            this.textBoxmAge.TextChanged += new System.EventHandler(this.textBoxmAge_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "CNIC:";
            this.label1.UseWaitCursor = true;
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
            this.GEdit.Click += new System.EventHandler(this.GEdit_Click);
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
            // textBoxmAddress
            // 
            this.textBoxmAddress.Location = new System.Drawing.Point(169, 330);
            this.textBoxmAddress.Multiline = true;
            this.textBoxmAddress.Name = "textBoxmAddress";
            this.textBoxmAddress.Size = new System.Drawing.Size(274, 32);
            this.textBoxmAddress.TabIndex = 5;
            this.textBoxmAddress.UseWaitCursor = true;
            this.textBoxmAddress.TextChanged += new System.EventHandler(this.textBoxmAddress_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address:";
            this.label6.UseWaitCursor = true;
            // 
            // textBoxmName
            // 
            this.textBoxmName.Location = new System.Drawing.Point(169, 129);
            this.textBoxmName.Multiline = true;
            this.textBoxmName.Name = "textBoxmName";
            this.textBoxmName.Size = new System.Drawing.Size(274, 32);
            this.textBoxmName.TabIndex = 2;
            this.textBoxmName.UseWaitCursor = true;
            this.textBoxmName.TextChanged += new System.EventHandler(this.textBoxmName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            this.label5.UseWaitCursor = true;
            // 
            // textBoxmCNIC
            // 
            this.textBoxmCNIC.Location = new System.Drawing.Point(169, 169);
            this.textBoxmCNIC.Multiline = true;
            this.textBoxmCNIC.Name = "textBoxmCNIC";
            this.textBoxmCNIC.Size = new System.Drawing.Size(274, 32);
            this.textBoxmCNIC.TabIndex = 3;
            this.textBoxmCNIC.UseWaitCursor = true;
            this.textBoxmCNIC.TextChanged += new System.EventHandler(this.textBoxmCNIC_TextChanged);
            // 
            // textBoxmPhone
            // 
            this.textBoxmPhone.Location = new System.Drawing.Point(169, 292);
            this.textBoxmPhone.Multiline = true;
            this.textBoxmPhone.Name = "textBoxmPhone";
            this.textBoxmPhone.Size = new System.Drawing.Size(274, 32);
            this.textBoxmPhone.TabIndex = 4;
            this.textBoxmPhone.UseWaitCursor = true;
            this.textBoxmPhone.TextChanged += new System.EventHandler(this.textBoxmPhone_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone:";
            this.label3.UseWaitCursor = true;
            // 
            // textBoxmid
            // 
            this.textBoxmid.Location = new System.Drawing.Point(169, 91);
            this.textBoxmid.Multiline = true;
            this.textBoxmid.Name = "textBoxmid";
            this.textBoxmid.Size = new System.Drawing.Size(274, 32);
            this.textBoxmid.TabIndex = 1;
            this.textBoxmid.UseWaitCursor = true;
            this.textBoxmid.TextChanged += new System.EventHandler(this.txtBoxGId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 97);
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
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxmEmail);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBoxmGender);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxmAge);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.GClearFields);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.GRemove);
            this.panel1.Controls.Add(this.GEdit);
            this.panel1.Controls.Add(this.GAddNew);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBoxmAddress);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxmName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxmCNIC);
            this.panel1.Controls.Add(this.textBoxmPhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxmid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(20, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 481);
            this.panel1.TabIndex = 1;
            this.panel1.UseWaitCursor = true;
            // 
            // ManageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 495);
            this.Controls.Add(this.panel1);
            this.Name = "ManageManager";
            this.Text = "ManageManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxmEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxmGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxmAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GClearFields;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GRemove;
        private System.Windows.Forms.Button GEdit;
        private System.Windows.Forms.Button GAddNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxmAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxmName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxmCNIC;
        private System.Windows.Forms.TextBox textBoxmPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxmid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;

    }
}