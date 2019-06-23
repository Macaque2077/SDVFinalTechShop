namespace TechShopWinForm
{
    partial class frmProduct
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
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPricePI = new System.Windows.Forms.Label();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbPricePI = new System.Windows.Forms.TextBox();
            this.tbStockQuantity = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.tbProductCode = new System.Windows.Forms.TextBox();
            this.tbLastModified = new System.Windows.Forms.TextBox();
            this.lblLastModified = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(12, 15);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(69, 13);
            this.lblProductCode.TabIndex = 0;
            this.lblProductCode.Text = "ProductCode";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(13, 66);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // lblPricePI
            // 
            this.lblPricePI.AutoSize = true;
            this.lblPricePI.Location = new System.Drawing.Point(13, 92);
            this.lblPricePI.Name = "lblPricePI";
            this.lblPricePI.Size = new System.Drawing.Size(73, 13);
            this.lblPricePI.TabIndex = 2;
            this.lblPricePI.Text = "Price Per Item";
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Location = new System.Drawing.Point(13, 118);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(80, 13);
            this.lblStockQuantity.TabIndex = 3;
            this.lblStockQuantity.Text = "Stock Quantity ";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(13, 221);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Description";
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(88, 37);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(100, 20);
            this.tbBrand.TabIndex = 6;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(88, 63);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(100, 20);
            this.tbProductName.TabIndex = 7;
            // 
            // tbPricePI
            // 
            this.tbPricePI.Location = new System.Drawing.Point(88, 89);
            this.tbPricePI.Name = "tbPricePI";
            this.tbPricePI.Size = new System.Drawing.Size(100, 20);
            this.tbPricePI.TabIndex = 8;
            // 
            // tbStockQuantity
            // 
            this.tbStockQuantity.Location = new System.Drawing.Point(88, 115);
            this.tbStockQuantity.Name = "tbStockQuantity";
            this.tbStockQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbStockQuantity.TabIndex = 9;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(12, 237);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(323, 64);
            this.tbDescription.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(231, 15);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(13, 41);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(35, 13);
            this.lblBrand.TabIndex = 15;
            this.lblBrand.Text = "Brand";
            // 
            // tbProductCode
            // 
            this.tbProductCode.Location = new System.Drawing.Point(88, 8);
            this.tbProductCode.Name = "tbProductCode";
            this.tbProductCode.Size = new System.Drawing.Size(100, 20);
            this.tbProductCode.TabIndex = 16;
            // 
            // tbLastModified
            // 
            this.tbLastModified.Location = new System.Drawing.Point(88, 196);
            this.tbLastModified.Name = "tbLastModified";
            this.tbLastModified.ReadOnly = true;
            this.tbLastModified.Size = new System.Drawing.Size(100, 20);
            this.tbLastModified.TabIndex = 17;
            // 
            // lblLastModified
            // 
            this.lblLastModified.AutoSize = true;
            this.lblLastModified.Location = new System.Drawing.Point(12, 196);
            this.lblLastModified.Name = "lblLastModified";
            this.lblLastModified.Size = new System.Drawing.Size(70, 13);
            this.lblLastModified.TabIndex = 18;
            this.lblLastModified.Text = "Last Modified";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 313);
            this.Controls.Add(this.lblLastModified);
            this.Controls.Add(this.tbLastModified);
            this.Controls.Add(this.tbProductCode);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbStockQuantity);
            this.Controls.Add(this.tbPricePI);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblStockQuantity);
            this.Controls.Add(this.lblPricePI);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductCode);
            this.Name = "frmProduct";
            this.Text = "Product Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPricePI;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbPricePI;
        private System.Windows.Forms.TextBox tbStockQuantity;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox tbProductCode;
        private System.Windows.Forms.TextBox tbLastModified;
        private System.Windows.Forms.Label lblLastModified;
    }
}