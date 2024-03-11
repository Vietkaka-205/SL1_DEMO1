namespace SL1_DEMO1
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.chkCShap = new System.Windows.Forms.CheckBox();
            this.chkJaVa = new System.Windows.Forms.CheckBox();
            this.chkSQL = new System.Windows.Forms.CheckBox();
            this.chkHTML = new System.Windows.Forms.CheckBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Sinh Viên";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(170, 75);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(52, 16);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(170, 122);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(30, 16);
            this.lblLop.TabIndex = 2;
            this.lblLop.Text = "Lớp";
            this.lblLop.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh Sách Môn Học Tự Chọn";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(258, 69);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(282, 22);
            this.txtHoTen.TabIndex = 4;
            this.txtHoTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(258, 122);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(282, 22);
            this.txtLop.TabIndex = 5;
            // 
            // chkCShap
            // 
            this.chkCShap.AutoSize = true;
            this.chkCShap.Location = new System.Drawing.Point(173, 241);
            this.chkCShap.Name = "chkCShap";
            this.chkCShap.Size = new System.Drawing.Size(70, 20);
            this.chkCShap.TabIndex = 6;
            this.chkCShap.Text = "CShap";
            this.chkCShap.UseVisualStyleBackColor = true;
            // 
            // chkJaVa
            // 
            this.chkJaVa.AutoSize = true;
            this.chkJaVa.Location = new System.Drawing.Point(173, 320);
            this.chkJaVa.Name = "chkJaVa";
            this.chkJaVa.Size = new System.Drawing.Size(61, 20);
            this.chkJaVa.TabIndex = 7;
            this.chkJaVa.Text = "JaVa";
            this.chkJaVa.UseVisualStyleBackColor = true;
            // 
            // chkSQL
            // 
            this.chkSQL.AutoSize = true;
            this.chkSQL.Location = new System.Drawing.Point(436, 241);
            this.chkSQL.Name = "chkSQL";
            this.chkSQL.Size = new System.Drawing.Size(55, 20);
            this.chkSQL.TabIndex = 8;
            this.chkSQL.Text = "SQL";
            this.chkSQL.UseVisualStyleBackColor = true;
            // 
            // chkHTML
            // 
            this.chkHTML.AutoSize = true;
            this.chkHTML.Location = new System.Drawing.Point(436, 320);
            this.chkHTML.Name = "chkHTML";
            this.chkHTML.Size = new System.Drawing.Size(66, 20);
            this.chkHTML.TabIndex = 9;
            this.chkHTML.Text = "HTML";
            this.chkHTML.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(197, 390);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(99, 23);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(406, 390);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.chkHTML);
            this.Controls.Add(this.chkSQL);
            this.Controls.Add(this.chkJaVa);
            this.Controls.Add(this.chkCShap);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.CheckBox chkCShap;
        private System.Windows.Forms.CheckBox chkJaVa;
        private System.Windows.Forms.CheckBox chkSQL;
        private System.Windows.Forms.CheckBox chkHTML;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
    }
}

