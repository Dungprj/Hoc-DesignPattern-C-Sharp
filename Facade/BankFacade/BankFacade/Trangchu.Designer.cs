namespace BankFacade
{
    partial class Trangchu
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
            this.txtCashAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNap = new System.Windows.Forms.Button();
            this.btnRut = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(878, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền hiện tại : ";
            // 
            // txtCashAmount
            // 
            this.txtCashAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashAmount.Location = new System.Drawing.Point(1074, 23);
            this.txtCashAmount.Name = "txtCashAmount";
            this.txtCashAmount.ReadOnly = true;
            this.txtCashAmount.Size = new System.Drawing.Size(153, 30);
            this.txtCashAmount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xin chào : ";
            // 
            // btnNap
            // 
            this.btnNap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNap.Location = new System.Drawing.Point(477, 236);
            this.btnNap.Name = "btnNap";
            this.btnNap.Size = new System.Drawing.Size(263, 69);
            this.btnNap.TabIndex = 4;
            this.btnNap.Text = "Nạp tiền";
            this.btnNap.UseVisualStyleBackColor = true;
            this.btnNap.Click += new System.EventHandler(this.btnNap_Click);
            // 
            // btnRut
            // 
            this.btnRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRut.Location = new System.Drawing.Point(477, 352);
            this.btnRut.Name = "btnRut";
            this.btnRut.Size = new System.Drawing.Size(263, 69);
            this.btnRut.TabIndex = 5;
            this.btnRut.Text = "Rút tiền";
            this.btnRut.UseVisualStyleBackColor = true;
            this.btnRut.Click += new System.EventHandler(this.btnRut_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(477, 141);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(263, 30);
            this.txtNhap.TabIndex = 6;
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(123, 23);
            this.txtN.Name = "txtN";
            this.txtN.ReadOnly = true;
            this.txtN.Size = new System.Drawing.Size(153, 30);
            this.txtN.TabIndex = 7;
            // 
            // Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 563);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.btnRut);
            this.Controls.Add(this.btnNap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCashAmount);
            this.Controls.Add(this.label1);
            this.Name = "Trangchu";
            this.Text = "Trangchu";
            this.Load += new System.EventHandler(this.Trangchu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCashAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNap;
        private System.Windows.Forms.Button btnRut;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtN;
    }
}