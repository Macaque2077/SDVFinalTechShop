namespace TechShopWinForm
{
    partial class frmOrdersView
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
            this.lblOrderInfo = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.lblPriceatPurchase = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTimeofOrder = new System.Windows.Forms.Label();
            this.lblCustDetails = new System.Windows.Forms.Label();
            this.tbProductCode = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbPriceAtTimeOfOrder = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbTimeOfOrder = new System.Windows.Forms.TextBox();
            this.tbCustomerDetails = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOrderInfo
            // 
            this.lblOrderInfo.AutoSize = true;
            this.lblOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblOrderInfo.Location = new System.Drawing.Point(13, 26);
            this.lblOrderInfo.Name = "lblOrderInfo";
            this.lblOrderInfo.Size = new System.Drawing.Size(181, 26);
            this.lblOrderInfo.TabIndex = 0;
            this.lblOrderInfo.Text = "Order information";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(27, 105);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblProductCode.TabIndex = 2;
            this.lblProductCode.Text = "Product Code";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(27, 140);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(75, 13);
            this.lblProdName.TabIndex = 3;
            this.lblProdName.Text = "Product Name";
            // 
            // lblPriceatPurchase
            // 
            this.lblPriceatPurchase.AutoSize = true;
            this.lblPriceatPurchase.Location = new System.Drawing.Point(27, 166);
            this.lblPriceatPurchase.Name = "lblPriceatPurchase";
            this.lblPriceatPurchase.Size = new System.Drawing.Size(91, 13);
            this.lblPriceatPurchase.TabIndex = 4;
            this.lblPriceatPurchase.Text = "Price at Purchase";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(27, 196);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblTimeofOrder
            // 
            this.lblTimeofOrder.AutoSize = true;
            this.lblTimeofOrder.Location = new System.Drawing.Point(27, 224);
            this.lblTimeofOrder.Name = "lblTimeofOrder";
            this.lblTimeofOrder.Size = new System.Drawing.Size(71, 13);
            this.lblTimeofOrder.TabIndex = 6;
            this.lblTimeofOrder.Text = "Time of Order";
            // 
            // lblCustDetails
            // 
            this.lblCustDetails.AutoSize = true;
            this.lblCustDetails.Location = new System.Drawing.Point(27, 256);
            this.lblCustDetails.Name = "lblCustDetails";
            this.lblCustDetails.Size = new System.Drawing.Size(86, 13);
            this.lblCustDetails.TabIndex = 7;
            this.lblCustDetails.Text = "Customer Details";
            // 
            // tbProductCode
            // 
            this.tbProductCode.Location = new System.Drawing.Point(129, 102);
            this.tbProductCode.Name = "tbProductCode";
            this.tbProductCode.ReadOnly = true;
            this.tbProductCode.Size = new System.Drawing.Size(196, 20);
            this.tbProductCode.TabIndex = 8;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(129, 133);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.ReadOnly = true;
            this.tbProductName.Size = new System.Drawing.Size(196, 20);
            this.tbProductName.TabIndex = 9;
            // 
            // tbPriceAtTimeOfOrder
            // 
            this.tbPriceAtTimeOfOrder.Location = new System.Drawing.Point(129, 163);
            this.tbPriceAtTimeOfOrder.Name = "tbPriceAtTimeOfOrder";
            this.tbPriceAtTimeOfOrder.ReadOnly = true;
            this.tbPriceAtTimeOfOrder.Size = new System.Drawing.Size(196, 20);
            this.tbPriceAtTimeOfOrder.TabIndex = 10;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(129, 189);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.ReadOnly = true;
            this.tbQuantity.Size = new System.Drawing.Size(196, 20);
            this.tbQuantity.TabIndex = 11;
            // 
            // tbTimeOfOrder
            // 
            this.tbTimeOfOrder.Location = new System.Drawing.Point(129, 224);
            this.tbTimeOfOrder.Name = "tbTimeOfOrder";
            this.tbTimeOfOrder.ReadOnly = true;
            this.tbTimeOfOrder.Size = new System.Drawing.Size(196, 20);
            this.tbTimeOfOrder.TabIndex = 12;
            // 
            // tbCustomerDetails
            // 
            this.tbCustomerDetails.Location = new System.Drawing.Point(30, 284);
            this.tbCustomerDetails.Multiline = true;
            this.tbCustomerDetails.Name = "tbCustomerDetails";
            this.tbCustomerDetails.ReadOnly = true;
            this.tbCustomerDetails.Size = new System.Drawing.Size(295, 160);
            this.tbCustomerDetails.TabIndex = 13;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(30, 68);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(44, 13);
            this.lblOrderID.TabIndex = 14;
            this.lblOrderID.Text = "OrderID";
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(129, 68);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.ReadOnly = true;
            this.tbOrderID.Size = new System.Drawing.Size(196, 20);
            this.tbOrderID.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(360, 284);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 65);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmOrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 456);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbOrderID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.tbCustomerDetails);
            this.Controls.Add(this.tbTimeOfOrder);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbPriceAtTimeOfOrder);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.tbProductCode);
            this.Controls.Add(this.lblCustDetails);
            this.Controls.Add(this.lblTimeofOrder);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPriceatPurchase);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.lblOrderInfo);
            this.Name = "frmOrdersView";
            this.Text = "OrdersView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderInfo;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Label lblPriceatPurchase;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTimeofOrder;
        private System.Windows.Forms.Label lblCustDetails;
        private System.Windows.Forms.TextBox tbProductCode;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbPriceAtTimeOfOrder;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbTimeOfOrder;
        private System.Windows.Forms.TextBox tbCustomerDetails;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Button btnClose;
    }
}