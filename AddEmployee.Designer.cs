namespace EmployeeManagementSystem
{
    partial class AddEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addEmpStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addEmpUploadBtn = new System.Windows.Forms.Button();
            this.addEmpClearBtn = new System.Windows.Forms.Button();
            this.addEmpDeleteBtn = new System.Windows.Forms.Button();
            this.addEmpUpdateBtn = new System.Windows.Forms.Button();
            this.addEmpAddBtn = new System.Windows.Forms.Button();
            this.addEmpPictureBox = new System.Windows.Forms.PictureBox();
            this.addEmpPosition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addEmpGender = new System.Windows.Forms.ComboBox();
            this.AddEmpPhoneNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addEmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addEmpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmpPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 297);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(18, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(828, 219);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee\'s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addEmpStatus);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addEmpUploadBtn);
            this.panel2.Controls.Add(this.addEmpClearBtn);
            this.panel2.Controls.Add(this.addEmpDeleteBtn);
            this.panel2.Controls.Add(this.addEmpUpdateBtn);
            this.panel2.Controls.Add(this.addEmpAddBtn);
            this.panel2.Controls.Add(this.addEmpPictureBox);
            this.panel2.Controls.Add(this.addEmpPosition);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addEmpGender);
            this.panel2.Controls.Add(this.AddEmpPhoneNum);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addEmpName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addEmpID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 324);
            this.panel2.TabIndex = 1;
            // 
            // addEmpStatus
            // 
            this.addEmpStatus.FormattingEnabled = true;
            this.addEmpStatus.Items.AddRange(new object[] {
            "Inactive",
            "Active"});
            this.addEmpStatus.Location = new System.Drawing.Point(509, 127);
            this.addEmpStatus.Name = "addEmpStatus";
            this.addEmpStatus.Size = new System.Drawing.Size(189, 24);
            this.addEmpStatus.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(391, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Status:";
            // 
            // addEmpUploadBtn
            // 
            this.addEmpUploadBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addEmpUploadBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addEmpUploadBtn.FlatAppearance.BorderSize = 0;
            this.addEmpUploadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addEmpUploadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addEmpUploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmpUploadBtn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpUploadBtn.ForeColor = System.Drawing.Color.Black;
            this.addEmpUploadBtn.Location = new System.Drawing.Point(745, 151);
            this.addEmpUploadBtn.Name = "addEmpUploadBtn";
            this.addEmpUploadBtn.Size = new System.Drawing.Size(101, 31);
            this.addEmpUploadBtn.TabIndex = 18;
            this.addEmpUploadBtn.Text = "Upload";
            this.addEmpUploadBtn.UseVisualStyleBackColor = false;
            this.addEmpUploadBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // addEmpClearBtn
            // 
            this.addEmpClearBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addEmpClearBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addEmpClearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addEmpClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addEmpClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmpClearBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpClearBtn.ForeColor = System.Drawing.Color.Black;
            this.addEmpClearBtn.Location = new System.Drawing.Point(583, 230);
            this.addEmpClearBtn.Name = "addEmpClearBtn";
            this.addEmpClearBtn.Size = new System.Drawing.Size(114, 42);
            this.addEmpClearBtn.TabIndex = 17;
            this.addEmpClearBtn.Text = "Clear";
            this.addEmpClearBtn.UseVisualStyleBackColor = false;
            this.addEmpClearBtn.Click += new System.EventHandler(this.addEmpClearBtn_Click);
            // 
            // addEmpDeleteBtn
            // 
            this.addEmpDeleteBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addEmpDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addEmpDeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addEmpDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addEmpDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmpDeleteBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpDeleteBtn.ForeColor = System.Drawing.Color.Black;
            this.addEmpDeleteBtn.Location = new System.Drawing.Point(433, 230);
            this.addEmpDeleteBtn.Name = "addEmpDeleteBtn";
            this.addEmpDeleteBtn.Size = new System.Drawing.Size(114, 42);
            this.addEmpDeleteBtn.TabIndex = 16;
            this.addEmpDeleteBtn.Text = "Delete";
            this.addEmpDeleteBtn.UseVisualStyleBackColor = false;
            this.addEmpDeleteBtn.Click += new System.EventHandler(this.addEmpDeleteBtn_Click);
            // 
            // addEmpUpdateBtn
            // 
            this.addEmpUpdateBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addEmpUpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addEmpUpdateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addEmpUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addEmpUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmpUpdateBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpUpdateBtn.ForeColor = System.Drawing.Color.Black;
            this.addEmpUpdateBtn.Location = new System.Drawing.Point(281, 230);
            this.addEmpUpdateBtn.Name = "addEmpUpdateBtn";
            this.addEmpUpdateBtn.Size = new System.Drawing.Size(114, 42);
            this.addEmpUpdateBtn.TabIndex = 15;
            this.addEmpUpdateBtn.Text = "Update";
            this.addEmpUpdateBtn.UseVisualStyleBackColor = false;
            this.addEmpUpdateBtn.Click += new System.EventHandler(this.addEmpUpdateBtn_Click);
            // 
            // addEmpAddBtn
            // 
            this.addEmpAddBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addEmpAddBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addEmpAddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addEmpAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addEmpAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmpAddBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpAddBtn.ForeColor = System.Drawing.Color.Black;
            this.addEmpAddBtn.Location = new System.Drawing.Point(130, 230);
            this.addEmpAddBtn.Name = "addEmpAddBtn";
            this.addEmpAddBtn.Size = new System.Drawing.Size(114, 42);
            this.addEmpAddBtn.TabIndex = 14;
            this.addEmpAddBtn.Text = "Add";
            this.addEmpAddBtn.UseVisualStyleBackColor = false;
            this.addEmpAddBtn.Click += new System.EventHandler(this.addEmpAddBtn_Click);
            // 
            // addEmpPictureBox
            // 
            this.addEmpPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addEmpPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmpPictureBox.Location = new System.Drawing.Point(745, 47);
            this.addEmpPictureBox.Name = "addEmpPictureBox";
            this.addEmpPictureBox.Size = new System.Drawing.Size(101, 101);
            this.addEmpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmpPictureBox.TabIndex = 13;
            this.addEmpPictureBox.TabStop = false;
            // 
            // addEmpPosition
            // 
            this.addEmpPosition.FormattingEnabled = true;
            this.addEmpPosition.Items.AddRange(new object[] {
            "Business Management",
            "Fron-End Developer",
            "Back-End Developer",
            "UI/UX Develpoer",
            "Data Administrator"});
            this.addEmpPosition.Location = new System.Drawing.Point(509, 88);
            this.addEmpPosition.Name = "addEmpPosition";
            this.addEmpPosition.Size = new System.Drawing.Size(189, 24);
            this.addEmpPosition.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(391, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Position:";
            // 
            // addEmpGender
            // 
            this.addEmpGender.FormattingEnabled = true;
            this.addEmpGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.addEmpGender.Location = new System.Drawing.Point(130, 124);
            this.addEmpGender.Name = "addEmpGender";
            this.addEmpGender.Size = new System.Drawing.Size(189, 24);
            this.addEmpGender.TabIndex = 10;
            // 
            // AddEmpPhoneNum
            // 
            this.AddEmpPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmpPhoneNum.Location = new System.Drawing.Point(509, 49);
            this.AddEmpPhoneNum.Name = "AddEmpPhoneNum";
            this.AddEmpPhoneNum.Size = new System.Drawing.Size(189, 24);
            this.AddEmpPhoneNum.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender: ";
            // 
            // addEmpName
            // 
            this.addEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpName.Location = new System.Drawing.Point(130, 85);
            this.addEmpName.Name = "addEmpName";
            this.addEmpName.Size = new System.Drawing.Size(189, 24);
            this.addEmpName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ful Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // addEmpID
            // 
            this.addEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpID.Location = new System.Drawing.Point(130, 46);
            this.addEmpID.Name = "addEmpID";
            this.addEmpID.Size = new System.Drawing.Size(189, 24);
            this.addEmpID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID:";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(901, 713);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmpPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox addEmpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddEmpPhoneNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addEmpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addEmpAddBtn;
        private System.Windows.Forms.PictureBox addEmpPictureBox;
        private System.Windows.Forms.ComboBox addEmpPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addEmpGender;
        private System.Windows.Forms.Button addEmpUploadBtn;
        private System.Windows.Forms.Button addEmpClearBtn;
        private System.Windows.Forms.Button addEmpDeleteBtn;
        private System.Windows.Forms.Button addEmpUpdateBtn;
        private System.Windows.Forms.ComboBox addEmpStatus;
        private System.Windows.Forms.Label label7;
    }
}
