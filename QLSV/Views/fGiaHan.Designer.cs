namespace QLSV.Views
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
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(396, 172);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 29);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(301, 172);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 29);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbNewPass);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(12, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 62);
            this.panel4.TabIndex = 12;
            // 
            // txbNewPass
            // 
            this.txbNewPass.Location = new System.Drawing.Point(227, 25);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.ReadOnly = true;
            this.txbNewPass.Size = new System.Drawing.Size(202, 20);
            this.txbNewPass.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thành tiền:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbPassWord);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 62);
            this.panel3.TabIndex = 11;
            // 
            // txbPassWord
            // 
            this.txbPassWord.Location = new System.Drawing.Point(227, 25);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(202, 20);
            this.txbPassWord.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số Kỳ:";
            // 
            // fGiaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 227);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "fGiaHan";
            this.Text = "fGiaHan";
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
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Label label2;
    }
}