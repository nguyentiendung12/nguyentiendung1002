namespace ck
{
    partial class Ketqua
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
            labdachon = new Label();
            btnthoat = new Button();
            btntrangchu = new Button();
            label2 = new Label();
            label3 = new Label();
            txtykien = new TextBox();
            btngui = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(391, 31);
            label1.Name = "label1";
            label1.Size = new Size(188, 30);
            label1.TabIndex = 0;
            label1.Text = "Sản phẩm đã đặt";
            label1.Click += label1_Click;
            // 
            // labdachon
            // 
            labdachon.AutoSize = true;
            labdachon.Location = new Point(221, 155);
            labdachon.Name = "labdachon";
            labdachon.Size = new Size(38, 15);
            labdachon.TabIndex = 1;
            labdachon.Text = "label2";
            labdachon.Click += labdachon_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(918, 291);
            btnthoat.Margin = new Padding(3, 2, 3, 2);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(82, 36);
            btnthoat.TabIndex = 2;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // btntrangchu
            // 
            btntrangchu.Location = new Point(23, 291);
            btntrangchu.Name = "btntrangchu";
            btntrangchu.Size = new Size(75, 36);
            btntrangchu.TabIndex = 3;
            btntrangchu.Text = "Trang chủ";
            btntrangchu.UseVisualStyleBackColor = true;
            btntrangchu.Click += btntrangchu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(301, 291);
            label2.Name = "label2";
            label2.Size = new Size(380, 32);
            label2.TabIndex = 4;
            label2.Text = "Cảm ơn quý khách đã mua hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(23, 240);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 5;
            label3.Text = "Ý kiến đóng góp";
            // 
            // txtykien
            // 
            txtykien.Location = new Point(205, 245);
            txtykien.Name = "txtykien";
            txtykien.Size = new Size(653, 23);
            txtykien.TabIndex = 6;
            txtykien.TextChanged += txtykien_TextChanged;
            // 
            // btngui
            // 
            btngui.Location = new Point(918, 245);
            btngui.Name = "btngui";
            btngui.Size = new Size(75, 23);
            btngui.TabIndex = 7;
            btngui.Text = "Gửi";
            btngui.UseVisualStyleBackColor = true;
            btngui.Click += btngui_Click;
            // 
            // Ketqua
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 338);
            Controls.Add(btngui);
            Controls.Add(txtykien);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btntrangchu);
            Controls.Add(btnthoat);
            Controls.Add(labdachon);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ketqua";
            Text = "Ketqua";
            Load += Ketqua_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labdachon;
        private Button btnthoat;
        private Button btntrangchu;
        private Label label2;
        private Label label3;
        private TextBox txtykien;
        private Button btngui;
    }
}