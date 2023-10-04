namespace Bai2_MinhNhat
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdo_cong = new System.Windows.Forms.RadioButton();
            this.rdo_tru = new System.Windows.Forms.RadioButton();
            this.rdo_nhan = new System.Windows.Forms.RadioButton();
            this.rdo_chia = new System.Windows.Forms.RadioButton();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // rdo_cong
            // 
            this.rdo_cong.AutoSize = true;
            this.rdo_cong.Location = new System.Drawing.Point(24, 120);
            this.rdo_cong.Name = "rdo_cong";
            this.rdo_cong.Size = new System.Drawing.Size(31, 17);
            this.rdo_cong.TabIndex = 3;
            this.rdo_cong.TabStop = true;
            this.rdo_cong.Text = "+";
            this.rdo_cong.UseVisualStyleBackColor = true;
            // 
            // rdo_tru
            // 
            this.rdo_tru.AutoSize = true;
            this.rdo_tru.Location = new System.Drawing.Point(88, 120);
            this.rdo_tru.Name = "rdo_tru";
            this.rdo_tru.Size = new System.Drawing.Size(28, 17);
            this.rdo_tru.TabIndex = 4;
            this.rdo_tru.TabStop = true;
            this.rdo_tru.Text = "-";
            this.rdo_tru.UseVisualStyleBackColor = true;
            // 
            // rdo_nhan
            // 
            this.rdo_nhan.AutoSize = true;
            this.rdo_nhan.Location = new System.Drawing.Point(147, 120);
            this.rdo_nhan.Name = "rdo_nhan";
            this.rdo_nhan.Size = new System.Drawing.Size(30, 17);
            this.rdo_nhan.TabIndex = 5;
            this.rdo_nhan.TabStop = true;
            this.rdo_nhan.Text = "x";
            this.rdo_nhan.UseVisualStyleBackColor = true;
            // 
            // rdo_chia
            // 
            this.rdo_chia.AutoSize = true;
            this.rdo_chia.Location = new System.Drawing.Point(203, 120);
            this.rdo_chia.Name = "rdo_chia";
            this.rdo_chia.Size = new System.Drawing.Size(30, 17);
            this.rdo_chia.TabIndex = 6;
            this.rdo_chia.TabStop = true;
            this.rdo_chia.Text = "/";
            this.rdo_chia.UseVisualStyleBackColor = true;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(88, 143);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(62, 77);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(180, 20);
            this.txtKetQua.TabIndex = 8;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(179, 37);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(54, 20);
            this.txtB.TabIndex = 9;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(37, 37);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(60, 20);
            this.txtA.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 174);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.rdo_chia);
            this.Controls.Add(this.rdo_nhan);
            this.Controls.Add(this.rdo_tru);
            this.Controls.Add(this.rdo_cong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdo_cong;
        private System.Windows.Forms.RadioButton rdo_tru;
        private System.Windows.Forms.RadioButton rdo_nhan;
        private System.Windows.Forms.RadioButton rdo_chia;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
    }
}

