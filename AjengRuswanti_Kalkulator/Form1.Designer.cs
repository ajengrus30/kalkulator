namespace AjengRuswanti_Kalkulator
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
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHasil = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilangan 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bilangan 2";
            // 
            // txtAngka1
            // 
            this.txtAngka1.Location = new System.Drawing.Point(128, 39);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(204, 20);
            this.txtAngka1.TabIndex = 2;
            // 
            // txtAngka2
            // 
            this.txtAngka2.Location = new System.Drawing.Point(128, 83);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(204, 20);
            this.txtAngka2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasil";
            // 
            // lblHasil
            // 
            this.lblHasil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHasil.Location = new System.Drawing.Point(128, 133);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(204, 25);
            this.lblHasil.TabIndex = 5;
            this.lblHasil.Text = "  ";
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(66, 177);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 54);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKurang.Location = new System.Drawing.Point(147, 177);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(75, 54);
            this.btnKurang.TabIndex = 7;
            this.btnKurang.Text = "-";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.BtnKurang_Click);
            // 
            // btnKali
            // 
            this.btnKali.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKali.Location = new System.Drawing.Point(66, 237);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(75, 54);
            this.btnKali.TabIndex = 8;
            this.btnKali.Text = "x";
            this.btnKali.UseVisualStyleBackColor = true;
            this.btnKali.Click += new System.EventHandler(this.BtnKali_Click);
            // 
            // btnBagi
            // 
            this.btnBagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBagi.Location = new System.Drawing.Point(147, 237);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(75, 54);
            this.btnBagi.TabIndex = 9;
            this.btnBagi.Text = "/";
            this.btnBagi.UseVisualStyleBackColor = true;
            this.btnBagi.Click += new System.EventHandler(this.BtnBagi_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(228, 177);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 114);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 327);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBagi);
            this.Controls.Add(this.btnKali);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator Sederhana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.Button btnBagi;
        private System.Windows.Forms.Button btnClear;
    }
}

