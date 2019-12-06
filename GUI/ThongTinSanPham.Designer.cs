namespace GUI
{
    partial class ThongTinSanPham
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.amountProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.codeProduct = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUnitProduct = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(280, 373);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 51;
            this.cancelButton.Text = "Hủy";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateButton2
            // 
            this.updateButton2.Location = new System.Drawing.Point(157, 373);
            this.updateButton2.Name = "updateButton2";
            this.updateButton2.Size = new System.Drawing.Size(75, 23);
            this.updateButton2.TabIndex = 50;
            this.updateButton2.Text = "Sửa";
            this.updateButton2.UseVisualStyleBackColor = true;
            this.updateButton2.Click += new System.EventHandler(this.updateButton2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Đơn vị tính";
            // 
            // amountProduct
            // 
            this.amountProduct.Location = new System.Drawing.Point(157, 257);
            this.amountProduct.Name = "amountProduct";
            this.amountProduct.Size = new System.Drawing.Size(198, 20);
            this.amountProduct.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Số Lượng";
            // 
            // priceProduct
            // 
            this.priceProduct.Location = new System.Drawing.Point(157, 190);
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.Size = new System.Drawing.Size(198, 20);
            this.priceProduct.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Giá Tiền";
            // 
            // nameProduct
            // 
            this.nameProduct.Location = new System.Drawing.Point(157, 131);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(198, 20);
            this.nameProduct.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tên sản phẩm";
            // 
            // codeProduct
            // 
            this.codeProduct.Enabled = false;
            this.codeProduct.Location = new System.Drawing.Point(157, 76);
            this.codeProduct.Name = "codeProduct";
            this.codeProduct.Size = new System.Drawing.Size(198, 20);
            this.codeProduct.TabIndex = 41;
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Location = new System.Drawing.Point(78, 79);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(73, 13);
            this.code.TabIndex = 40;
            this.code.Text = "Mã Sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Thông Tin Sản Phẩm";
            // 
            // cbUnitProduct
            // 
            this.cbUnitProduct.FormattingEnabled = true;
            this.cbUnitProduct.Location = new System.Drawing.Point(157, 321);
            this.cbUnitProduct.Name = "cbUnitProduct";
            this.cbUnitProduct.Size = new System.Drawing.Size(198, 21);
            this.cbUnitProduct.TabIndex = 52;
            // 
            // ThongTinSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.cbUnitProduct);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.amountProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priceProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codeProduct);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinSanPham";
            this.Text = "ThongTinSanPham";
            this.Load += new System.EventHandler(this.ThongTinSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox amountProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codeProduct;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUnitProduct;
    }
}