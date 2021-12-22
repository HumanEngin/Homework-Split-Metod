
namespace SPLIT_OLMADAN_SPLIT
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
            this.btn1 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtBx1 = new System.Windows.Forms.TextBox();
            this.lstBx1 = new System.Windows.Forms.ListBox();
            this.txtBx2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(290, 97);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(103, 63);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Ayır ve Sırala";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(109, 32);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(186, 25);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Ayıracağınız Kelimeler:";
            // 
            // txtBx1
            // 
            this.txtBx1.Location = new System.Drawing.Point(12, 60);
            this.txtBx1.Name = "txtBx1";
            this.txtBx1.Size = new System.Drawing.Size(381, 31);
            this.txtBx1.TabIndex = 2;
            // 
            // lstBx1
            // 
            this.lstBx1.FormattingEnabled = true;
            this.lstBx1.ItemHeight = 25;
            this.lstBx1.Location = new System.Drawing.Point(12, 179);
            this.lstBx1.Name = "lstBx1";
            this.lstBx1.Size = new System.Drawing.Size(381, 204);
            this.lstBx1.TabIndex = 3;
            // 
            // txtBx2
            // 
            this.txtBx2.Location = new System.Drawing.Point(134, 100);
            this.txtBx2.Name = "txtBx2";
            this.txtBx2.Size = new System.Drawing.Size(150, 31);
            this.txtBx2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ayırıcı Karakter:";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(13, 139);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(154, 34);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "ListBox\'u Temizle";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 395);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBx2);
            this.Controls.Add(this.lstBx1);
            this.Controls.Add(this.txtBx1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtBx1;
        private System.Windows.Forms.ListBox lstBx1;
        private System.Windows.Forms.TextBox txtBx2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn2;
    }
}

