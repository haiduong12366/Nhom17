﻿namespace QLSV.Views
{
    partial class fGiaHan
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbtien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSoKy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(528, 212);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 36);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(401, 212);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 36);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Gia Hạn";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbtien);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(16, 98);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(611, 76);
            this.panel4.TabIndex = 12;
            // 
            // txbtien
            // 
            this.txbtien.Location = new System.Drawing.Point(303, 31);
            this.txbtien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbtien.Name = "txbtien";
            this.txbtien.ReadOnly = true;
            this.txbtien.Size = new System.Drawing.Size(268, 22);
            this.txbtien.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thành tiền:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSoKy);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(16, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(611, 76);
            this.panel3.TabIndex = 11;
            // 
            // txtSoKy
            // 
            this.txtSoKy.Location = new System.Drawing.Point(303, 31);
            this.txtSoKy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoKy.Name = "txtSoKy";
            this.txtSoKy.Size = new System.Drawing.Size(268, 22);
            this.txtSoKy.TabIndex = 1;
            this.txtSoKy.TextChanged += new System.EventHandler(this.txtSoKy_TextChanged);
            this.txtSoKy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPassWord_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số Kỳ:";
            // 
            // fGiaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 279);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fGiaHan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Gia Hạn";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSoKy;
        private System.Windows.Forms.Label label2;
    }
}