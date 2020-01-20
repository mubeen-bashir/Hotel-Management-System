namespace HotelManagementSystem
{
    partial class ManageReservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.ReservationClearFields = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.RemoveReservation = new System.Windows.Forms.Button();
            this.EditReservation = new System.Windows.Forms.Button();
            this.AddNewReservation = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerin = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRoomNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.textBoxGuestId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReservationId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.Location = new System.Drawing.Point(369, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Reservation";
            this.label1.UseWaitCursor = true;
            // 
            // ReservationClearFields
            // 
            this.ReservationClearFields.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationClearFields.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ReservationClearFields.Location = new System.Drawing.Point(102, 429);
            this.ReservationClearFields.Name = "ReservationClearFields";
            this.ReservationClearFields.Size = new System.Drawing.Size(257, 42);
            this.ReservationClearFields.TabIndex = 16;
            this.ReservationClearFields.Text = "Clear Fields";
            this.ReservationClearFields.UseVisualStyleBackColor = true;
            this.ReservationClearFields.UseWaitCursor = true;
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
            // RemoveReservation
            // 
            this.RemoveReservation.BackColor = System.Drawing.Color.Salmon;
            this.RemoveReservation.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveReservation.Location = new System.Drawing.Point(308, 379);
            this.RemoveReservation.Name = "RemoveReservation";
            this.RemoveReservation.Size = new System.Drawing.Size(119, 44);
            this.RemoveReservation.TabIndex = 14;
            this.RemoveReservation.Text = "Remove";
            this.RemoveReservation.UseVisualStyleBackColor = false;
            this.RemoveReservation.UseWaitCursor = true;
            // 
            // EditReservation
            // 
            this.EditReservation.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditReservation.Location = new System.Drawing.Point(169, 379);
            this.EditReservation.Name = "EditReservation";
            this.EditReservation.Size = new System.Drawing.Size(119, 44);
            this.EditReservation.TabIndex = 13;
            this.EditReservation.Text = "Edit";
            this.EditReservation.UseVisualStyleBackColor = true;
            this.EditReservation.UseWaitCursor = true;
            // 
            // AddNewReservation
            // 
            this.AddNewReservation.BackColor = System.Drawing.Color.PowderBlue;
            this.AddNewReservation.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewReservation.Location = new System.Drawing.Point(40, 379);
            this.AddNewReservation.Name = "AddNewReservation";
            this.AddNewReservation.Size = new System.Drawing.Size(119, 44);
            this.AddNewReservation.TabIndex = 12;
            this.AddNewReservation.Text = "Add New";
            this.AddNewReservation.UseVisualStyleBackColor = false;
            this.AddNewReservation.UseWaitCursor = true;
            this.AddNewReservation.Click += new System.EventHandler(this.AddNewReservation_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date In:";
            this.label6.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePickerin);
            this.panel1.Controls.Add(this.comboBoxRoomNo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBoxRoomType);
            this.panel1.Controls.Add(this.ReservationClearFields);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.RemoveReservation);
            this.panel1.Controls.Add(this.EditReservation);
            this.panel1.Controls.Add(this.AddNewReservation);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxGuestId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxReservationId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 481);
            this.panel1.TabIndex = 1;
            this.panel1.UseWaitCursor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(169, 344);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(274, 26);
            this.dateTimePicker2.TabIndex = 22;
            this.dateTimePicker2.UseWaitCursor = true;
            // 
            // dateTimePickerin
            // 
            this.dateTimePickerin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerin.Location = new System.Drawing.Point(169, 302);
            this.dateTimePickerin.Name = "dateTimePickerin";
            this.dateTimePickerin.Size = new System.Drawing.Size(274, 26);
            this.dateTimePickerin.TabIndex = 21;
            this.dateTimePickerin.UseWaitCursor = true;
            this.dateTimePickerin.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBoxRoomNo
            // 
            this.comboBoxRoomNo.FormattingEnabled = true;
            this.comboBoxRoomNo.Items.AddRange(new object[] {
            "Single Room",
            "Double Room",
            "Suit"});
            this.comboBoxRoomNo.Location = new System.Drawing.Point(169, 248);
            this.comboBoxRoomNo.Name = "comboBoxRoomNo";
            this.comboBoxRoomNo.Size = new System.Drawing.Size(274, 39);
            this.comboBoxRoomNo.TabIndex = 20;
            this.comboBoxRoomNo.UseWaitCursor = true;
            this.comboBoxRoomNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomNo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "Date Out:";
            this.label8.UseWaitCursor = true;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "Single Room",
            "Double Room",
            "Suit"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(169, 190);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(274, 39);
            this.comboBoxRoomType.TabIndex = 18;
            this.comboBoxRoomType.UseWaitCursor = true;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            // 
            // textBoxGuestId
            // 
            this.textBoxGuestId.Location = new System.Drawing.Point(169, 141);
            this.textBoxGuestId.Multiline = true;
            this.textBoxGuestId.Name = "textBoxGuestId";
            this.textBoxGuestId.Size = new System.Drawing.Size(274, 32);
            this.textBoxGuestId.TabIndex = 8;
            this.textBoxGuestId.UseWaitCursor = true;
            this.textBoxGuestId.TextChanged += new System.EventHandler(this.textBoxGuestId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Guest ID:";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Room Type:";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room No:";
            this.label3.UseWaitCursor = true;
            // 
            // textBoxReservationId
            // 
            this.textBoxReservationId.Location = new System.Drawing.Point(169, 91);
            this.textBoxReservationId.Multiline = true;
            this.textBoxReservationId.Name = "textBoxReservationId";
            this.textBoxReservationId.Size = new System.Drawing.Size(274, 32);
            this.textBoxReservationId.TabIndex = 2;
            this.textBoxReservationId.UseWaitCursor = true;
            this.textBoxReservationId.TextChanged += new System.EventHandler(this.textBoxReservationId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reservation ID:";
            this.label2.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 68);
            this.panel2.TabIndex = 0;
            this.panel2.UseWaitCursor = true;
            // 
            // ManageReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 485);
            this.Controls.Add(this.panel1);
            this.Name = "ManageReservation";
            this.Text = "ManageReservation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReservationClearFields;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button RemoveReservation;
        private System.Windows.Forms.Button EditReservation;
        private System.Windows.Forms.Button AddNewReservation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxGuestId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxReservationId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.ComboBox comboBoxRoomNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePickerin;
    }
}