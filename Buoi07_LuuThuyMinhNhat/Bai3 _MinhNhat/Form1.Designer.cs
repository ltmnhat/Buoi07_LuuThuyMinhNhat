namespace Bai3__MinhNhat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkRegular = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBoldnItalic = new System.Windows.Forms.CheckBox();
            this.rdo_autocolor = new System.Windows.Forms.RadioButton();
            this.rdo_red = new System.Windows.Forms.RadioButton();
            this.rdo_green = new System.Windows.Forms.RadioButton();
            this.rdo_blue = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trường Đại Học Công Thương Thành Phố Hồ Chí Minh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBoldnItalic);
            this.groupBox1.Controls.Add(this.chkItalic);
            this.groupBox1.Controls.Add(this.chkBold);
            this.groupBox1.Controls.Add(this.chkRegular);
            this.groupBox1.Location = new System.Drawing.Point(48, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font Style";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_blue);
            this.groupBox2.Controls.Add(this.rdo_green);
            this.groupBox2.Controls.Add(this.rdo_red);
            this.groupBox2.Controls.Add(this.rdo_autocolor);
            this.groupBox2.Location = new System.Drawing.Point(271, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 125);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(338, 293);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkRegular
            // 
            this.chkRegular.AutoSize = true;
            this.chkRegular.Location = new System.Drawing.Point(7, 20);
            this.chkRegular.Name = "chkRegular";
            this.chkRegular.Size = new System.Drawing.Size(63, 17);
            this.chkRegular.TabIndex = 0;
            this.chkRegular.Text = "Regular";
            this.chkRegular.UseVisualStyleBackColor = true;
            this.chkRegular.CheckedChanged += new System.EventHandler(this.chkRegular_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(7, 44);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(47, 17);
            this.chkBold.TabIndex = 1;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(7, 68);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(48, 17);
            this.chkItalic.TabIndex = 2;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkBoldnItalic
            // 
            this.chkBoldnItalic.AutoSize = true;
            this.chkBoldnItalic.Location = new System.Drawing.Point(7, 92);
            this.chkBoldnItalic.Name = "chkBoldnItalic";
            this.chkBoldnItalic.Size = new System.Drawing.Size(93, 17);
            this.chkBoldnItalic.TabIndex = 3;
            this.chkBoldnItalic.Text = "Bold and Italic";
            this.chkBoldnItalic.UseVisualStyleBackColor = true;
            this.chkBoldnItalic.CheckedChanged += new System.EventHandler(this.chkBoldnItalic_CheckedChanged);
            // 
            // rdo_autocolor
            // 
            this.rdo_autocolor.AutoSize = true;
            this.rdo_autocolor.Location = new System.Drawing.Point(7, 20);
            this.rdo_autocolor.Name = "rdo_autocolor";
            this.rdo_autocolor.Size = new System.Drawing.Size(70, 17);
            this.rdo_autocolor.TabIndex = 0;
            this.rdo_autocolor.TabStop = true;
            this.rdo_autocolor.Text = "Autocolor";
            this.rdo_autocolor.UseVisualStyleBackColor = true;
            this.rdo_autocolor.CheckedChanged += new System.EventHandler(this.rdo_autocolor_CheckedChanged);
            // 
            // rdo_red
            // 
            this.rdo_red.AutoSize = true;
            this.rdo_red.Location = new System.Drawing.Point(7, 44);
            this.rdo_red.Name = "rdo_red";
            this.rdo_red.Size = new System.Drawing.Size(45, 17);
            this.rdo_red.TabIndex = 1;
            this.rdo_red.TabStop = true;
            this.rdo_red.Text = "Red";
            this.rdo_red.UseVisualStyleBackColor = true;
            this.rdo_red.CheckedChanged += new System.EventHandler(this.rdo_red_CheckedChanged);
            // 
            // rdo_green
            // 
            this.rdo_green.AutoSize = true;
            this.rdo_green.Location = new System.Drawing.Point(7, 68);
            this.rdo_green.Name = "rdo_green";
            this.rdo_green.Size = new System.Drawing.Size(54, 17);
            this.rdo_green.TabIndex = 2;
            this.rdo_green.TabStop = true;
            this.rdo_green.Text = "Green";
            this.rdo_green.UseVisualStyleBackColor = true;
            this.rdo_green.CheckedChanged += new System.EventHandler(this.rdo_green_CheckedChanged);
            // 
            // rdo_blue
            // 
            this.rdo_blue.AutoSize = true;
            this.rdo_blue.Location = new System.Drawing.Point(7, 92);
            this.rdo_blue.Name = "rdo_blue";
            this.rdo_blue.Size = new System.Drawing.Size(46, 17);
            this.rdo_blue.TabIndex = 3;
            this.rdo_blue.TabStop = true;
            this.rdo_blue.Text = "Blue";
            this.rdo_blue.UseVisualStyleBackColor = true;
            this.rdo_blue.CheckedChanged += new System.EventHandler(this.rdo_blue_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 347);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBoldnItalic;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkRegular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_blue;
        private System.Windows.Forms.RadioButton rdo_green;
        private System.Windows.Forms.RadioButton rdo_red;
        private System.Windows.Forms.RadioButton rdo_autocolor;
        private System.Windows.Forms.Button btnExit;

    }
}

