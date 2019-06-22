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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbProductCode = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbPriceAtTimeOfOrder = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbTimeOfOrder = new System.Windows.Forms.TextBox();
            this.tbCustomerDetails = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price at Purchase";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Time of Order";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Customer Details";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "OrderID";
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCustomerDetails);
            this.Controls.Add(this.tbTimeOfOrder);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbPriceAtTimeOfOrder);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.tbProductCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmOrdersView";
            this.Text = "OrdersView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbProductCode;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbPriceAtTimeOfOrder;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbTimeOfOrder;
        private System.Windows.Forms.TextBox tbCustomerDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Button btnClose;
    }
}