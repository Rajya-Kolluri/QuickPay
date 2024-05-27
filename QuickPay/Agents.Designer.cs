namespace QuickPay
{
    partial class Agents
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
            CancelBtn = new Button();
            EditBtn = new Button();
            SubmitBtn = new Button();
            APhoneTb = new TextBox();
            label7 = new Label();
            label5 = new Label();
            AAddressTb = new TextBox();
            label4 = new Label();
            APasswordTb = new TextBox();
            label3 = new Label();
            ANameTb = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            AgentDGV = new DataGridView();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)AgentDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.CadetBlue;
            CancelBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CancelBtn.Location = new Point(1076, 328);
            CancelBtn.Margin = new Padding(4);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(150, 62);
            CancelBtn.TabIndex = 35;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.CadetBlue;
            EditBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.Location = new Point(680, 328);
            EditBtn.Margin = new Padding(4);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(150, 62);
            EditBtn.TabIndex = 34;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.CadetBlue;
            SubmitBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitBtn.Location = new Point(289, 328);
            SubmitBtn.Margin = new Padding(4);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(150, 62);
            SubmitBtn.TabIndex = 33;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // APhoneTb
            // 
            APhoneTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            APhoneTb.Location = new Point(1181, 200);
            APhoneTb.Margin = new Padding(4);
            APhoneTb.Name = "APhoneTb";
            APhoneTb.Size = new Size(205, 35);
            APhoneTb.TabIndex = 32;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.CadetBlue;
            label7.Location = new Point(1181, 156);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(90, 32);
            label7.TabIndex = 31;
            label7.Text = "Phone";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.CadetBlue;
            label5.Location = new Point(839, 156);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 30;
            label5.Text = "Address";
            // 
            // AAddressTb
            // 
            AAddressTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AAddressTb.Location = new Point(839, 200);
            AAddressTb.Margin = new Padding(4);
            AAddressTb.Multiline = true;
            AAddressTb.Name = "AAddressTb";
            AAddressTb.Size = new Size(288, 98);
            AAddressTb.TabIndex = 29;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.CadetBlue;
            label4.Location = new Point(488, 156);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 32);
            label4.TabIndex = 28;
            label4.Text = "Password";
            // 
            // APasswordTb
            // 
            APasswordTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            APasswordTb.Location = new Point(488, 200);
            APasswordTb.Margin = new Padding(4);
            APasswordTb.Name = "APasswordTb";
            APasswordTb.Size = new Size(293, 35);
            APasswordTb.TabIndex = 27;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.CadetBlue;
            label3.Location = new Point(130, 156);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 26;
            label3.Text = "Name";
            // 
            // ANameTb
            // 
            ANameTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ANameTb.Location = new Point(130, 200);
            ANameTb.Margin = new Padding(4);
            ANameTb.Name = "ANameTb";
            ANameTb.Size = new Size(282, 35);
            ANameTb.TabIndex = 25;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(450, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(471, 68);
            label1.TabIndex = 24;
            label1.Text = "Manage Agents";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.DarkCyan;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(66, 659);
            panel1.TabIndex = 23;
            // 
            // AgentDGV
            // 
            AgentDGV.BackgroundColor = SystemColors.Control;
            AgentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AgentDGV.Location = new Point(64, 409);
            AgentDGV.Margin = new Padding(4);
            AgentDGV.Name = "AgentDGV";
            AgentDGV.RowHeadersWidth = 51;
            AgentDGV.RowTemplate.Height = 29;
            AgentDGV.Size = new Size(1410, 250);
            AgentDGV.TabIndex = 36;
            AgentDGV.CellContentClick += AgentDGV_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.android_lollipop_icons_settings_teal_and_gray_ssetting_icon_png_clipart;
            pictureBox1.Location = new Point(84, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(67, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 26);
            label2.TabIndex = 38;
            label2.Text = "Settings";
            // 
            // Agents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 659);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(AgentDGV);
            Controls.Add(CancelBtn);
            Controls.Add(EditBtn);
            Controls.Add(SubmitBtn);
            Controls.Add(APhoneTb);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(AAddressTb);
            Controls.Add(label4);
            Controls.Add(APasswordTb);
            Controls.Add(label3);
            Controls.Add(ANameTb);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Agents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agents";
            ((System.ComponentModel.ISupportInitialize)AgentDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelBtn;
        private Button EditBtn;
        private Button SubmitBtn;
        private TextBox APhoneTb;
        private Label label7;
        private Label label5;
        private TextBox AAddressTb;
        private Label label4;
        private TextBox APasswordTb;
        private Label label3;
        private TextBox ANameTb;
        private Label label1;
        private Panel panel1;
        private DataGridView AgentDGV;
        private PictureBox pictureBox1;
        private Label label2;
    }
}