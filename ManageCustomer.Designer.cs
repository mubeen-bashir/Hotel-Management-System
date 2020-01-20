namespace HotelManagementSystem
{
    partial class ManageCustomer
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
            this.textBoxEmailId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CClearFields = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CRemove = new System.Windows.Forms.Button();
            this.CEdit = new System.Windows.Forms.Button();
            this.CAddNew = new System.Windows.Forms.Button();
            this.dataGridViewCu = new System.Windows.Forms.DataGridView();
            this.textBoxCAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCNIC = new System.Windows.Forms.TextBox();
            this.textBoxCPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxCId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCu)).BeginInit();
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
            this.lable1.Size = new System.Drawing.Size(280, 37);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Manage Customer";
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
            // textBoxEmailId
            // 
            this.textBoxEmailId.Location = new System.Drawing.Point(169, 209);
            this.textBoxEmailId.Multiline = true;
            this.textBoxEmailId.Name = "textBoxEmailId";
            this.textBoxEmailId.Size = new System.Drawing.Size(274, 32);
            this.textBoxEmailId.TabIndex = 22;
            this.textBoxEmailId.UseWaitCursor = true;
            this.textBoxEmailId.TextChanged += new System.EventHandler(this.textBoxEmailId_TextChanged);
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
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(170, 247);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(83, 39);
            this.comboBoxGender.TabIndex = 20;
            this.comboBoxGender.UseWaitCursor = true;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Age:";
            this.label4.UseWaitCursor = true;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(389, 247);
            this.textBoxAge.Multiline = true;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(54, 39);
            this.textBoxAge.TabIndex = 18;
            this.textBoxAge.UseWaitCursor = true;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBoxAge_TextChanged);
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
            // CClearFields
            // 
            this.CClearFields.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CClearFields.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CClearFields.Location = new System.Drawing.Point(102, 429);
            this.CClearFields.Name = "CClearFields";
            this.CClearFields.Size = new System.Drawing.Size(257, 43);
            this.CClearFields.TabIndex = 16;
            this.CClearFields.Text = "Clear Fields";
            this.CClearFields.UseVisualStyleBackColor = true;
            this.CClearFields.UseWaitCursor = true;
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
            // CRemove
            // 
            this.CRemove.BackColor = System.Drawing.Color.Salmon;
            this.CRemove.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRemove.Location = new System.Drawing.Point(308, 371);
            this.CRemove.Name = "CRemove";
            this.CRemove.Size = new System.Drawing.Size(119, 43);
            this.CRemove.TabIndex = 14;
            this.CRemove.Text = "Remove";
            this.CRemove.UseVisualStyleBackColor = false;
            this.CRemove.UseWaitCursor = true;
            // 
            // CEdit
            // 
            this.CEdit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEdit.Location = new System.Drawing.Point(169, 371);
            this.CEdit.Name = "CEdit";
            this.CEdit.Size = new System.Drawing.Size(119, 43);
            this.CEdit.TabIndex = 13;
            this.CEdit.Text = "Edit";
            this.CEdit.UseVisualStyleBackColor = true;
            this.CEdit.UseWaitCursor = true;
            this.CEdit.Click += new System.EventHandler(this.CEdit_Click);
            // 
            // CAddNew
            // 
            this.CAddNew.BackColor = System.Drawing.Color.PowderBlue;
            this.CAddNew.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAddNew.Location = new System.Drawing.Point(12, 371);
            this.CAddNew.Name = "CAddNew";
            this.CAddNew.Size = new System.Drawing.Size(147, 43);
            this.CAddNew.TabIndex = 12;
            this.CAddNew.Text = "Add";
            this.CAddNew.UseVisualStyleBackColor = false;
            this.CAddNew.UseWaitCursor = true;
            this.CAddNew.Click += new System.EventHandler(this.CAddNew_Click);
            // 
            // dataGridViewCu
            // 
            this.dataGridViewCu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewCu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCu.Location = new System.Drawing.Point(523, 124);
            this.dataGridViewCu.Name = "dataGridViewCu";
            this.dataGridViewCu.Size = new System.Drawing.Size(454, 337);
            this.dataGridViewCu.TabIndex = 11;
            this.dataGridViewCu.UseWaitCursor = true;
            // 
            // textBoxCAddress
            // 
            this.textBoxCAddress.Location = new System.Drawing.Point(169, 330);
            this.textBoxCAddress.Multiline = true;
            this.textBoxCAddress.Name = "textBoxCAddress";
            this.textBoxCAddress.Size = new System.Drawing.Size(274, 32);
            this.textBoxCAddress.TabIndex = 5;
            this.textBoxCAddress.UseWaitCursor = true;
            this.textBoxCAddress.TextChanged += new System.EventHandler(this.textBoxCAddress_TextChanged);
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
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(169, 129);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(274, 32);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.UseWaitCursor = true;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
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
            // textBoxCNIC
            // 
            this.textBoxCNIC.Location = new System.Drawing.Point(169, 169);
            this.textBoxCNIC.Multiline = true;
            this.textBoxCNIC.Name = "textBoxCNIC";
            this.textBoxCNIC.Size = new System.Drawing.Size(274, 32);
            this.textBoxCNIC.TabIndex = 3;
            this.textBoxCNIC.UseWaitCursor = true;
            this.textBoxCNIC.TextChanged += new System.EventHandler(this.textBoxCNIC_TextChanged);
            // 
            // textBoxCPhone
            // 
            this.textBoxCPhone.Location = new System.Drawing.Point(169, 292);
            this.textBoxCPhone.Multiline = true;
            this.textBoxCPhone.Name = "textBoxCPhone";
            this.textBoxCPhone.Size = new System.Drawing.Size(274, 32);
            this.textBoxCPhone.TabIndex = 4;
            this.textBoxCPhone.UseWaitCursor = true;
            this.textBoxCPhone.TextChanged += new System.EventHandler(this.textBoxCPhone_TextChanged);
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
            // txtBoxCId
            // 
            this.txtBoxCId.Location = new System.Drawing.Point(169, 91);
            this.txtBoxCId.Multiline = true;
            this.txtBoxCId.Name = "txtBoxCId";
            this.txtBoxCId.Size = new System.Drawing.Size(274, 32);
            this.txtBoxCId.TabIndex = 1;
            this.txtBoxCId.UseWaitCursor = true;
            this.txtBoxCId.TextChanged += new System.EventHandler(this.txtBoxCId_TextChanged);
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
            this.panel1.Controls.Add(this.textBoxEmailId);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBoxGender);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxAge);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CClearFields);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CRemove);
            this.panel1.Controls.Add(this.CEdit);
            this.panel1.Controls.Add(this.CAddNew);
            this.panel1.Controls.Add(this.dataGridViewCu);
            this.panel1.Controls.Add(this.textBoxCAddress);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxCNIC);
            this.panel1.Controls.Add(this.textBoxCPhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBoxCId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(32, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 487);
            this.panel1.TabIndex = 1;
            this.panel1.UseWaitCursor = true;
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 498);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomer";
            this.Load += new System.EventHandler(this.ManageCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEmailId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CClearFields;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CRemove;
        private System.Windows.Forms.Button CEdit;
        private System.Windows.Forms.Button CAddNew;
        private System.Windows.Forms.DataGridView dataGridViewCu;
        private System.Windows.Forms.TextBox textBoxCAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCNIC;
        private System.Windows.Forms.TextBox textBoxCPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxCId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;

    }
}