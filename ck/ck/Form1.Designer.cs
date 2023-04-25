namespace ck
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            raddanhsach = new Button();
            btndathang = new Button();
            groupBox1 = new GroupBox();
            cbElectric = new ComboBox();
            cbDiesel = new ComboBox();
            cbGasoline = new ComboBox();
            radElectric = new RadioButton();
            radDiesel = new RadioButton();
            radGasoline = new RadioButton();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            radWhite = new RadioButton();
            radBlack = new RadioButton();
            groupBox3 = new GroupBox();
            radAutomatic = new RadioButton();
            radManual = new RadioButton();
            groupBox4 = new GroupBox();
            radHatchback = new RadioButton();
            radSport = new RadioButton();
            radSUV = new RadioButton();
            radSedan = new RadioButton();
            groupBox5 = new GroupBox();
            radDTDModel03 = new RadioButton();
            radDTDModel02 = new RadioButton();
            radDTDModel01 = new RadioButton();
            btnthoat = new Button();
            btnthongbao = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // raddanhsach
            // 
            raddanhsach.BackColor = SystemColors.Desktop;
            raddanhsach.Location = new Point(151, 446);
            raddanhsach.Margin = new Padding(4);
            raddanhsach.Name = "raddanhsach";
            raddanhsach.Size = new Size(183, 59);
            raddanhsach.TabIndex = 0;
            raddanhsach.Text = "Danh sách sản phẩm";
            raddanhsach.UseVisualStyleBackColor = false;
            raddanhsach.Click += raddanhsach_Click;
            // 
            // btndathang
            // 
            btndathang.Location = new Point(14, 445);
            btndathang.Margin = new Padding(4);
            btndathang.Name = "btndathang";
            btndathang.Size = new Size(117, 60);
            btndathang.TabIndex = 1;
            btndathang.Text = "Đặt hàng";
            btndathang.UseVisualStyleBackColor = true;
            btndathang.Click += bF_Click_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Highlight;
            groupBox1.Controls.Add(cbElectric);
            groupBox1.Controls.Add(cbDiesel);
            groupBox1.Controls.Add(cbGasoline);
            groupBox1.Controls.Add(radElectric);
            groupBox1.Controls.Add(radDiesel);
            groupBox1.Controls.Add(radGasoline);
            groupBox1.Location = new Point(14, 51);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(313, 181);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "TypeCar";
            // 
            // cbElectric
            // 
            cbElectric.FormattingEnabled = true;
            cbElectric.Items.AddRange(new object[] { "EEngine01", "EEngine02" });
            cbElectric.Location = new Point(151, 139);
            cbElectric.Margin = new Padding(4);
            cbElectric.Name = "cbElectric";
            cbElectric.Size = new Size(153, 31);
            cbElectric.TabIndex = 5;
            cbElectric.Text = "Electric";
            cbElectric.SelectedIndexChanged += cbElectric_SelectedIndexChanged;
            // 
            // cbDiesel
            // 
            cbDiesel.FormattingEnabled = true;
            cbDiesel.Items.AddRange(new object[] { "DEngine01", "DEngine02" });
            cbDiesel.Location = new Point(151, 90);
            cbDiesel.Margin = new Padding(4);
            cbDiesel.Name = "cbDiesel";
            cbDiesel.Size = new Size(153, 31);
            cbDiesel.TabIndex = 4;
            cbDiesel.Text = "Diesel";
            // 
            // cbGasoline
            // 
            cbGasoline.FormattingEnabled = true;
            cbGasoline.Items.AddRange(new object[] { "GEngine01", "GEngine02" });
            cbGasoline.Location = new Point(151, 38);
            cbGasoline.Margin = new Padding(4);
            cbGasoline.Name = "cbGasoline";
            cbGasoline.Size = new Size(153, 31);
            cbGasoline.TabIndex = 3;
            cbGasoline.Text = "Gasoline";
            // 
            // radElectric
            // 
            radElectric.AutoSize = true;
            radElectric.Location = new Point(23, 138);
            radElectric.Margin = new Padding(4);
            radElectric.Name = "radElectric";
            radElectric.Size = new Size(89, 27);
            radElectric.TabIndex = 2;
            radElectric.TabStop = true;
            radElectric.Text = "Electric";
            radElectric.UseVisualStyleBackColor = true;
            radElectric.CheckedChanged += radElectric_CheckedChanged;
            // 
            // radDiesel
            // 
            radDiesel.AutoSize = true;
            radDiesel.Location = new Point(23, 88);
            radDiesel.Margin = new Padding(4);
            radDiesel.Name = "radDiesel";
            radDiesel.Size = new Size(79, 27);
            radDiesel.TabIndex = 1;
            radDiesel.TabStop = true;
            radDiesel.Text = "Diesel";
            radDiesel.UseVisualStyleBackColor = true;
            radDiesel.CheckedChanged += radDiesel_CheckedChanged;
            // 
            // radGasoline
            // 
            radGasoline.AutoSize = true;
            radGasoline.Location = new Point(23, 39);
            radGasoline.Margin = new Padding(4);
            radGasoline.Name = "radGasoline";
            radGasoline.Size = new Size(98, 27);
            radGasoline.TabIndex = 0;
            radGasoline.TabStop = true;
            radGasoline.Text = "Gasoline";
            radGasoline.UseVisualStyleBackColor = true;
            radGasoline.CheckedChanged += radGasoline_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(195, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(729, 38);
            label1.TabIndex = 3;
            label1.Text = "Chào mừng quý khách đã đến với cửa hàng chúng tôi";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Highlight;
            groupBox2.Controls.Add(radBlue);
            groupBox2.Controls.Add(radGreen);
            groupBox2.Controls.Add(radRed);
            groupBox2.Controls.Add(radWhite);
            groupBox2.Controls.Add(radBlack);
            groupBox2.Location = new Point(355, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(216, 181);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Color";
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Location = new Point(118, 85);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(66, 27);
            radBlue.TabIndex = 4;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Location = new Point(118, 37);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(78, 27);
            radGreen.TabIndex = 3;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Location = new Point(14, 134);
            radRed.Name = "radRed";
            radRed.Size = new Size(62, 27);
            radRed.TabIndex = 2;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            // 
            // radWhite
            // 
            radWhite.AutoSize = true;
            radWhite.Location = new Point(14, 82);
            radWhite.Name = "radWhite";
            radWhite.Size = new Size(79, 27);
            radWhite.TabIndex = 1;
            radWhite.TabStop = true;
            radWhite.Text = "White";
            radWhite.UseVisualStyleBackColor = true;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Location = new Point(14, 37);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(74, 27);
            radBlack.TabIndex = 0;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Highlight;
            groupBox3.Controls.Add(radAutomatic);
            groupBox3.Controls.Add(radManual);
            groupBox3.Location = new Point(609, 51);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(179, 181);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "GearBox";
            // 
            // radAutomatic
            // 
            radAutomatic.AutoSize = true;
            radAutomatic.Location = new Point(16, 79);
            radAutomatic.Name = "radAutomatic";
            radAutomatic.Size = new Size(115, 27);
            radAutomatic.TabIndex = 1;
            radAutomatic.TabStop = true;
            radAutomatic.Text = "Automatic";
            radAutomatic.UseVisualStyleBackColor = true;
            // 
            // radManual
            // 
            radManual.AutoSize = true;
            radManual.Location = new Point(16, 29);
            radManual.Name = "radManual";
            radManual.Size = new Size(90, 27);
            radManual.TabIndex = 0;
            radManual.TabStop = true;
            radManual.Text = "Manual";
            radManual.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Highlight;
            groupBox4.Controls.Add(radHatchback);
            groupBox4.Controls.Add(radSport);
            groupBox4.Controls.Add(radSUV);
            groupBox4.Controls.Add(radSedan);
            groupBox4.Location = new Point(834, 51);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 181);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Model Car";
            // 
            // radHatchback
            // 
            radHatchback.AutoSize = true;
            radHatchback.Location = new Point(113, 37);
            radHatchback.Name = "radHatchback";
            radHatchback.Size = new Size(116, 27);
            radHatchback.TabIndex = 3;
            radHatchback.TabStop = true;
            radHatchback.Text = "Hatchback";
            radHatchback.UseVisualStyleBackColor = true;
            // 
            // radSport
            // 
            radSport.AutoSize = true;
            radSport.Location = new Point(10, 132);
            radSport.Name = "radSport";
            radSport.Size = new Size(76, 27);
            radSport.TabIndex = 2;
            radSport.TabStop = true;
            radSport.Text = "Sport";
            radSport.UseVisualStyleBackColor = true;
            // 
            // radSUV
            // 
            radSUV.AutoSize = true;
            radSUV.Location = new Point(10, 84);
            radSUV.Name = "radSUV";
            radSUV.Size = new Size(64, 27);
            radSUV.TabIndex = 1;
            radSUV.TabStop = true;
            radSUV.Text = "SUV";
            radSUV.UseVisualStyleBackColor = true;
            // 
            // radSedan
            // 
            radSedan.AutoSize = true;
            radSedan.Location = new Point(10, 37);
            radSedan.Name = "radSedan";
            radSedan.Size = new Size(80, 27);
            radSedan.TabIndex = 0;
            radSedan.TabStop = true;
            radSedan.Text = "Sedan";
            radSedan.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.Highlight;
            groupBox5.Controls.Add(radDTDModel03);
            groupBox5.Controls.Add(radDTDModel02);
            groupBox5.Controls.Add(radDTDModel01);
            groupBox5.Location = new Point(12, 258);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(315, 160);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Wheel Type";
            // 
            // radDTDModel03
            // 
            radDTDModel03.AutoSize = true;
            radDTDModel03.Location = new Point(18, 127);
            radDTDModel03.Name = "radDTDModel03";
            radDTDModel03.Size = new Size(164, 27);
            radDTDModel03.TabIndex = 2;
            radDTDModel03.TabStop = true;
            radDTDModel03.Text = "DTDModel03_29";
            radDTDModel03.UseVisualStyleBackColor = true;
            // 
            // radDTDModel02
            // 
            radDTDModel02.AutoSize = true;
            radDTDModel02.Location = new Point(18, 78);
            radDTDModel02.Name = "radDTDModel02";
            radDTDModel02.Size = new Size(164, 27);
            radDTDModel02.TabIndex = 1;
            radDTDModel02.TabStop = true;
            radDTDModel02.Text = "DTDModel02_27";
            radDTDModel02.UseVisualStyleBackColor = true;
            // 
            // radDTDModel01
            // 
            radDTDModel01.AutoSize = true;
            radDTDModel01.Location = new Point(18, 29);
            radDTDModel01.Name = "radDTDModel01";
            radDTDModel01.Size = new Size(164, 27);
            radDTDModel01.TabIndex = 0;
            radDTDModel01.TabStop = true;
            radDTDModel01.Text = "DTDModel01_26";
            radDTDModel01.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(993, 446);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(91, 60);
            btnthoat.TabIndex = 8;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // btnthongbao
            // 
            btnthongbao.Location = new Point(874, 446);
            btnthongbao.Name = "btnthongbao";
            btnthongbao.Size = new Size(94, 59);
            btnthongbao.TabIndex = 9;
            btnthongbao.Text = "Thông báo";
            btnthongbao.UseVisualStyleBackColor = true;
            btnthongbao.Click += btnthongbao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 518);
            Controls.Add(btnthongbao);
            Controls.Add(btnthoat);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btndathang);
            Controls.Add(raddanhsach);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Phần mềm bán xe";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button raddanhsach;
        private Button btndathang;
        private GroupBox groupBox1;
        private ComboBox cbElectric;
        private ComboBox cbDiesel;
        private ComboBox cbGasoline;
        private RadioButton radElectric;
        private RadioButton radDiesel;
        private RadioButton radGasoline;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private RadioButton radWhite;
        private RadioButton radBlack;
        private GroupBox groupBox3;
        private RadioButton radAutomatic;
        private RadioButton radManual;
        private GroupBox groupBox4;
        private RadioButton radHatchback;
        private RadioButton radSport;
        private RadioButton radSUV;
        private RadioButton radSedan;
        private GroupBox groupBox5;
        private RadioButton radDTDModel03;
        private RadioButton radDTDModel02;
        private RadioButton radDTDModel01;
        private Button btnthoat;
        private Button btnthongbao;
    }
}