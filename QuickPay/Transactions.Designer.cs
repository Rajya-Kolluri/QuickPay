namespace QuickPay
{
    partial class Transactions
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
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ResetBtn = new Button();
            CheckBalTb = new TextBox();
            BalanceLbl = new Label();
            CheckBalBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            WdAmtTb = new TextBox();
            label4 = new Label();
            WdAccountTb = new TextBox();
            WdBtn = new Button();
            label13 = new Label();
            panel5 = new Panel();
            label9 = new Label();
            DepAmtTb = new TextBox();
            label10 = new Label();
            DepAccTb = new TextBox();
            DepBtn = new Button();
            label11 = new Label();
            panel4 = new Panel();
            button6 = new Button();
            button1 = new Button();
            BalanceLabel = new Label();
            TransferAmt = new TextBox();
            label12 = new Label();
            ToTb = new TextBox();
            label8 = new Label();
            label7 = new Label();
            FromTb = new TextBox();
            TransferBtn = new Button();
            label6 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.CadetBlue;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(948, 906);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(150, 62);
            button3.TabIndex = 40;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.CadetBlue;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(551, 906);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(150, 62);
            button2.TabIndex = 39;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(350, -74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(576, 68);
            label1.TabIndex = 25;
            label1.Text = "New Account Form";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.DarkCyan;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(66, 884);
            panel1.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(CheckBalTb);
            panel2.Controls.Add(BalanceLbl);
            panel2.Controls.Add(CheckBalBtn);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(269, 121);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1211, 172);
            panel2.TabIndex = 43;
            panel2.Paint += panel2_Paint;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = SystemColors.Control;
            ResetBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ResetBtn.Location = new Point(934, 80);
            ResetBtn.Margin = new Padding(4);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(109, 39);
            ResetBtn.TabIndex = 50;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            // 
            // CheckBalTb
            // 
            CheckBalTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CheckBalTb.Location = new Point(38, 80);
            CheckBalTb.Margin = new Padding(4);
            CheckBalTb.Name = "CheckBalTb";
            CheckBalTb.Size = new Size(220, 35);
            CheckBalTb.TabIndex = 49;
            // 
            // BalanceLbl
            // 
            BalanceLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BalanceLbl.AutoSize = true;
            BalanceLbl.BackColor = Color.Transparent;
            BalanceLbl.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BalanceLbl.ForeColor = Color.CadetBlue;
            BalanceLbl.Location = new Point(899, 26);
            BalanceLbl.Margin = new Padding(4, 0, 4, 0);
            BalanceLbl.Name = "BalanceLbl";
            BalanceLbl.Size = new Size(176, 32);
            BalanceLbl.TabIndex = 48;
            BalanceLbl.Text = "Your Balance";
            // 
            // CheckBalBtn
            // 
            CheckBalBtn.BackColor = Color.CadetBlue;
            CheckBalBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CheckBalBtn.Location = new Point(412, 55);
            CheckBalBtn.Margin = new Padding(4);
            CheckBalBtn.Name = "CheckBalBtn";
            CheckBalBtn.Size = new Size(255, 62);
            CheckBalBtn.TabIndex = 47;
            CheckBalBtn.Text = "Check";
            CheckBalBtn.UseVisualStyleBackColor = false;
            CheckBalBtn.Click += CheckBalBtn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.CadetBlue;
            label3.Location = new Point(38, 26);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(254, 32);
            label3.TabIndex = 40;
            label3.Text = "Check your Balance";
            label3.Click += label3_Click_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(621, 29);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(439, 68);
            label2.TabIndex = 44;
            label2.Text = "Transactions";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(WdAmtTb);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(WdAccountTb);
            panel3.Controls.Add(WdBtn);
            panel3.Controls.Add(label13);
            panel3.Location = new Point(126, 320);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(670, 211);
            panel3.TabIndex = 48;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.CadetBlue;
            label5.Location = new Point(4, 146);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 50;
            label5.Text = "Amount";
            // 
            // WdAmtTb
            // 
            WdAmtTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WdAmtTb.Location = new Point(242, 144);
            WdAmtTb.Margin = new Padding(4);
            WdAmtTb.Name = "WdAmtTb";
            WdAmtTb.Size = new Size(220, 35);
            WdAmtTb.TabIndex = 49;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.CadetBlue;
            label4.Location = new Point(4, 71);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(218, 32);
            label4.TabIndex = 48;
            label4.Text = "Account Number";
            // 
            // WdAccountTb
            // 
            WdAccountTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WdAccountTb.Location = new Point(242, 69);
            WdAccountTb.Margin = new Padding(4);
            WdAccountTb.Name = "WdAccountTb";
            WdAccountTb.Size = new Size(220, 35);
            WdAccountTb.TabIndex = 39;
            // 
            // WdBtn
            // 
            WdBtn.BackColor = Color.CadetBlue;
            WdBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            WdBtn.Location = new Point(494, 84);
            WdBtn.Margin = new Padding(4);
            WdBtn.Name = "WdBtn";
            WdBtn.Size = new Size(160, 62);
            WdBtn.TabIndex = 47;
            WdBtn.Text = "Withdraw";
            WdBtn.UseVisualStyleBackColor = false;
            WdBtn.Click += WdBtn_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(242, 12);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(143, 32);
            label13.TabIndex = 40;
            label13.Text = "Withdrawl";
            label13.Click += label13_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label9);
            panel5.Controls.Add(DepAmtTb);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(DepAccTb);
            panel5.Controls.Add(DepBtn);
            panel5.Controls.Add(label11);
            panel5.Location = new Point(858, 320);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(670, 211);
            panel5.TabIndex = 51;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.CadetBlue;
            label9.Location = new Point(4, 146);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(111, 32);
            label9.TabIndex = 50;
            label9.Text = "Amount";
            // 
            // DepAmtTb
            // 
            DepAmtTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DepAmtTb.Location = new Point(242, 144);
            DepAmtTb.Margin = new Padding(4);
            DepAmtTb.Name = "DepAmtTb";
            DepAmtTb.Size = new Size(220, 35);
            DepAmtTb.TabIndex = 49;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.CadetBlue;
            label10.Location = new Point(4, 71);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(218, 32);
            label10.TabIndex = 48;
            label10.Text = "Account Number";
            // 
            // DepAccTb
            // 
            DepAccTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DepAccTb.Location = new Point(242, 69);
            DepAccTb.Margin = new Padding(4);
            DepAccTb.Name = "DepAccTb";
            DepAccTb.Size = new Size(220, 35);
            DepAccTb.TabIndex = 39;
            // 
            // DepBtn
            // 
            DepBtn.BackColor = Color.CadetBlue;
            DepBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DepBtn.Location = new Point(494, 84);
            DepBtn.Margin = new Padding(4);
            DepBtn.Name = "DepBtn";
            DepBtn.Size = new Size(160, 62);
            DepBtn.TabIndex = 47;
            DepBtn.Text = "Deposit";
            DepBtn.UseVisualStyleBackColor = false;
            DepBtn.Click += DepBtn_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkSlateGray;
            label11.Location = new Point(254, 12);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(104, 32);
            label11.TabIndex = 40;
            label11.Text = "Deposit";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button6);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(BalanceLabel);
            panel4.Controls.Add(TransferAmt);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(ToTb);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(FromTb);
            panel4.Controls.Add(TransferBtn);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(218, 570);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1262, 260);
            panel4.TabIndex = 48;
            // 
            // button6
            // 
            button6.BackColor = Color.MintCream;
            button6.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(363, 176);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(50, 35);
            button6.TabIndex = 58;
            button6.Text = "Go";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MintCream;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(363, 104);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(50, 35);
            button1.TabIndex = 51;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BalanceLabel
            // 
            BalanceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BalanceLabel.AutoSize = true;
            BalanceLabel.BackColor = Color.Transparent;
            BalanceLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BalanceLabel.ForeColor = Color.CadetBlue;
            BalanceLabel.Location = new Point(447, 105);
            BalanceLabel.Margin = new Padding(4, 0, 4, 0);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(111, 32);
            BalanceLabel.TabIndex = 56;
            BalanceLabel.Text = "Amount";
            // 
            // TransferAmt
            // 
            TransferAmt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TransferAmt.Location = new Point(881, 140);
            TransferAmt.Margin = new Padding(4);
            TransferAmt.Name = "TransferAmt";
            TransferAmt.Size = new Size(173, 35);
            TransferAmt.TabIndex = 54;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.CadetBlue;
            label12.Location = new Point(751, 140);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(111, 32);
            label12.TabIndex = 55;
            label12.Text = "Amount";
            // 
            // ToTb
            // 
            ToTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ToTb.Location = new Point(171, 178);
            ToTb.Margin = new Padding(4);
            ToTb.Name = "ToTb";
            ToTb.Size = new Size(183, 35);
            ToTb.TabIndex = 52;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.CadetBlue;
            label8.Location = new Point(58, 176);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(43, 32);
            label8.TabIndex = 53;
            label8.Text = "To";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(519, 20);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(116, 32);
            label7.TabIndex = 51;
            label7.Text = "Transfer";
            // 
            // FromTb
            // 
            FromTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FromTb.Location = new Point(172, 107);
            FromTb.Margin = new Padding(4);
            FromTb.Name = "FromTb";
            FromTb.Size = new Size(183, 35);
            FromTb.TabIndex = 39;
            FromTb.TextChanged += textBox3_TextChanged;
            // 
            // TransferBtn
            // 
            TransferBtn.BackColor = Color.CadetBlue;
            TransferBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TransferBtn.Location = new Point(1081, 127);
            TransferBtn.Margin = new Padding(4);
            TransferBtn.Name = "TransferBtn";
            TransferBtn.Size = new Size(154, 62);
            TransferBtn.TabIndex = 47;
            TransferBtn.Text = "Transfer";
            TransferBtn.UseVisualStyleBackColor = false;
            TransferBtn.Click += button5_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.CadetBlue;
            label6.Location = new Point(58, 107);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 32);
            label6.TabIndex = 40;
            label6.Text = "From";
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1618, 884);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Transactions";
            Text = "Transactions";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button CheckBalBtn;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private TextBox WdAccountTb;
        private Button WdBtn;
        private Label label13;
        private Label label5;
        private TextBox WdAmtTb;
        private Label label4;
        private Panel panel5;
        private Label label9;
        private TextBox DepAmtTb;
        private Label label10;
        private TextBox DepAccTb;
        private Button DepBtn;
        private Label label11;
        private Panel panel4;
        private Label label7;
        private TextBox FromTb;
        private Button TransferBtn;
        private Label label6;
        private TextBox TransferAmt;
        private Label label12;
        private TextBox ToTb;
        private Label label8;
        private Label BalanceLbl;
        private TextBox CheckBalTb;
        private Button ResetBtn;
        private Label BalanceLabel;
        private Button button6;
        private Button button1;
    }
}