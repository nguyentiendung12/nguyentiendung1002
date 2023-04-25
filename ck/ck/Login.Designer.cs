namespace ck
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            btndangnhap = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(228, 32);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 123);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên người dùng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 186);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(194, 125);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(134, 23);
            txtuser.TabIndex = 3;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(194, 182);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(134, 23);
            txtpass.TabIndex = 4;
            // 
            // btndangnhap
            // 
            btndangnhap.Location = new Point(531, 163);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(75, 54);
            btndangnhap.TabIndex = 5;
            btndangnhap.Text = "Đăng nhập";
            btndangnhap.UseVisualStyleBackColor = true;
            btndangnhap.Click += btndangnhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(419, 163);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 54);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 248);
            Controls.Add(btnThoat);
            Controls.Add(btndangnhap);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtuser;
        private TextBox txtpass;
        private Button btndangnhap;
        private Button btnThoat;
    }
}