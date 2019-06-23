namespace TechShopWinForm
{
    partial class frmProductUsed
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
            this.tbProductCode = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbPricePI = new System.Windows.Forms.TextBox();
            this.tbStockQuantity = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCondition = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCondition = new System.Windows.Forms.TextBox();
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
            // tbProductCode
            // 
            this.tbProductCode.Location = new System.Drawing.Point(88, 38);
            this.tbProductCode.Name = "tbProductCode";
            this.tbProductCode.Size = new System.Drawing.Size(100, 20);
            this.tbProductCode.TabIndex = 6;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(88, 66);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(100, 20);
            this.tbProductName.TabIndex = 7;
            // 
            // tbPricePI
            // 
            this.tbPricePI.Location = new System.Drawing.Point(88, 92);
            this.tbPricePI.Name = "tbPricePI";
            this.tbPricePI.Size = new System.Drawing.Size(100, 20);
            this.tbPricePI.TabIndex = 8;
            // 
            // tbStockQuantity
            // 
            this.tbStockQuantity.Location = new System.Drawing.Point(88, 118);
            this.tbStockQuantity.Name = "tbStockQuantity";
            this.tbStockQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbStockQuantity.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(227, 38);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(12, 141);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(51, 13);
            this.lblCondition.TabIndex = 13;
            this.lblCondition.Text = "Condition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Brand";
            // 
            // tbCondition
            // 
            this.tbCondition.Location = new System.Drawing.Point(88, 141);
            this.tbCondition.Multiline = true;
            this.tbCondition.Name = "tbCondition";
            this.tbCondition.Size = new System.Drawing.Size(214, 46);
            this.tbCondition.TabIndex = 14;
            // 
            // frmProductUsed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 313);
            this.Controls.Add(this.tbCondition);
            this.Controls.Add(this.lblCondition);
            this.Name = "frmProductUsed";
            this.Text = "Used Product Form";
            this.Controls.SetChildIndex(this.lblCondition, 0);
            this.Controls.SetChildIndex(this.tbCondition, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPricePI;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox tbProductCode;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbPricePI;
        private System.Windows.Forms.TextBox tbStockQuantity;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCondition;
    }
}