namespace QuickPay
{
    partial class AddAccounts
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
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            AcNameTb = new TextBox();
            label4 = new Label();
            AcPhoneTb = new TextBox();
            label5 = new Label();
            AcAddressTb = new TextBox();
            label6 = new Label();
            AcGenderCb = new ComboBox();
            AcEducationCb = new ComboBox();
            label7 = new Label();
            AcOccupationTb = new TextBox();
            label8 = new Label();
            SubmitBtn = new Button();
            EditBtn = new Button();
            CancelBtn = new Button();
            AccountDGV = new DataGridView();
            AcIncomeTb = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)AccountDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.DarkCyan;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(53, 743);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(484, 25);
            label1.Name = "label1";
            label1.Size = new Size(479, 56);
            label1.TabIndex = 2;
            label1.Text = "New Account Form";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.CadetBlue;
            label3.Location = new Point(212, 161);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 8;
            label3.Text = "Name";
            // 
            // AcNameTb
            // 
            AcNameTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AcNameTb.Location = new Point(212, 189);
            AcNameTb.Name = "AcNameTb";
            AcNameTb.Size = new Size(226, 30);
            AcNameTb.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.CadetBlue;
            label4.Location = new Point(498, 154);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 10;
            label4.Text = "Phone";
            // 
            // AcPhoneTb
            // 
            AcPhoneTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AcPhoneTb.Location = new Point(498, 189);
            AcPhoneTb.Name = "AcPhoneTb";
            AcPhoneTb.Size = new Size(235, 30);
            AcPhoneTb.TabIndex = 9;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.CadetBlue;
            label5.Location = new Point(779, 154);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 12;
            label5.Text = "Address";
            // 
            // AcAddressTb
            // 
            AcAddressTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AcAddressTb.Location = new Point(779, 189);
            AcAddressTb.Multiline = true;
            AcAddressTb.Name = "AcAddressTb";
            AcAddressTb.Size = new Size(231, 79);
            AcAddressTb.TabIndex = 11;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.CadetBlue;
            label6.Location = new Point(499, 238);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 13;
            label6.Text = "Gender";
            // 
            // AcGenderCb
            // 
            AcGenderCb.FormattingEnabled = true;
            AcGenderCb.Items.AddRange(new object[] { "Male", "Female", "Prefer not to answer" });
            AcGenderCb.Location = new Point(499, 276);
            AcGenderCb.Name = "AcGenderCb";
            AcGenderCb.Size = new Size(151, 28);
            AcGenderCb.TabIndex = 15;
            // 
            // AcEducationCb
            // 
            AcEducationCb.FormattingEnabled = true;
            AcEducationCb.Items.AddRange(new object[] { "High School Diploma", "Associate Degree", "Bachelor's Degree ", "PG", "Graduate", "PHD", "None", "Prefer not to answer" });
            AcEducationCb.Location = new Point(1053, 276);
            AcEducationCb.Name = "AcEducationCb";
            AcEducationCb.Size = new Size(151, 28);
            AcEducationCb.TabIndex = 17;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.CadetBlue;
            label7.Location = new Point(1053, 154);
            label7.Name = "label7";
            label7.Size = new Size(128, 25);
            label7.TabIndex = 16;
            label7.Text = "Occupation";
            label7.Click += label7_Click;
            // 
            // AcOccupationTb
            // 
            AcOccupationTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AcOccupationTb.Location = new Point(1053, 189);
            AcOccupationTb.Name = "AcOccupationTb";
            AcOccupationTb.Size = new Size(165, 30);
            AcOccupationTb.TabIndex = 18;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.CadetBlue;
            label8.Location = new Point(1053, 238);
            label8.Name = "label8";
            label8.Size = new Size(114, 25);
            label8.TabIndex = 19;
            label8.Text = "Education";
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.CadetBlue;
            SubmitBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitBtn.Location = new Point(332, 390);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(120, 50);
            SubmitBtn.TabIndex = 20;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.CadetBlue;
            EditBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.Location = new Point(645, 390);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(120, 50);
            EditBtn.TabIndex = 21;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.CadetBlue;
            CancelBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CancelBtn.Location = new Point(962, 390);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(120, 50);
            CancelBtn.TabIndex = 22;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // AccountDGV
            // 
            AccountDGV.BackgroundColor = SystemColors.Control;
            AccountDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccountDGV.Location = new Point(59, 446);
            AccountDGV.Name = "AccountDGV";
            AccountDGV.RowHeadersWidth = 51;
            AccountDGV.RowTemplate.Height = 29;
            AccountDGV.Size = new Size(1345, 285);
            AccountDGV.TabIndex = 23;
            AccountDGV.CellContentClick += AccountDGV_CellContentClick;
            // 
            // AcIncomeTb
            // 
            AcIncomeTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AcIncomeTb.Location = new Point(212, 276);
            AcIncomeTb.Name = "AcIncomeTb";
            AcIncomeTb.Size = new Size(165, 30);
            AcIncomeTb.TabIndex = 25;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.CadetBlue;
            label2.Location = new Point(212, 241);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 24;
            label2.Text = "Income";
            // 
            // AddAccounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(1404, 743);
            Controls.Add(AcIncomeTb);
            Controls.Add(label2);
            Controls.Add(AccountDGV);
            Controls.Add(CancelBtn);
            Controls.Add(EditBtn);
            Controls.Add(SubmitBtn);
            Controls.Add(label8);
            Controls.Add(AcOccupationTb);
            Controls.Add(AcEducationCb);
            Controls.Add(label7);
            Controls.Add(AcGenderCb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(AcAddressTb);
            Controls.Add(label4);
            Controls.Add(AcPhoneTb);
            Controls.Add(label3);
            Controls.Add(AcNameTb);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "AddAccounts";
            Text = "AddAccounts";
            ((System.ComponentModel.ISupportInitialize)AccountDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private TextBox AcNameTb;
        private Label label4;
        private TextBox AcPhoneTb;
        private Label label5;
        private TextBox AcAddressTb;
        private Label label6;
        private ComboBox AcGenderCb;
        private ComboBox AcEducationCb;
        private Label label7;
        private TextBox AcOccupationTb;
        private Label label8;
        private Button SubmitBtn;
        private Button EditBtn;
        private Button CancelBtn;
        private DataGridView AccountDGV;
        private TextBox AcIncomeTb;
        private Label label2;
    }
}