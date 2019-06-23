namespace TechShopWinForm
{
    partial class frmHome
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
            this.lstbxDeviceTypes = new System.Windows.Forms.ListBox();
            this.lblDeviceTypes = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxDeviceTypes
            // 
            this.lstbxDeviceTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lstbxDeviceTypes.FormattingEnabled = true;
            this.lstbxDeviceTypes.ItemHeight = 25;
            this.lstbxDeviceTypes.Location = new System.Drawing.Point(12, 44);
            this.lstbxDeviceTypes.Name = "lstbxDeviceTypes";
            this.lstbxDeviceTypes.Size = new System.Drawing.Size(181, 304);
            this.lstbxDeviceTypes.TabIndex = 0;
            this.lstbxDeviceTypes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstbxDeviceTypes_MouseDoubleClick);
            // 
            // lblDeviceTypes
            // 
            this.lblDeviceTypes.AutoSize = true;
            this.lblDeviceTypes.Location = new System.Drawing.Point(12, 25);
            this.lblDeviceTypes.Name = "lblDeviceTypes";
            this.lblDeviceTypes.Size = new System.Drawing.Size(90, 13);
            this.lblDeviceTypes.TabIndex = 1;
            this.lblDeviceTypes.Text = "Types of Devices";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(286, 50);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(107, 53);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(286, 225);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(107, 53);
            this.btnOrders.TabIndex = 5;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(286, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 57);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotValue
            // 
            this.lblTotValue.AutoSize = true;
            this.lblTotValue.Location = new System.Drawing.Point(15, 409);
            this.lblTotValue.Name = "lblTotValue";
            this.lblTotValue.Size = new System.Drawing.Size(61, 13);
            this.lblTotValue.TabIndex = 10;
            this.lblTotValue.Text = "Total Value";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.lblTotValue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblDeviceTypes);
            this.Controls.Add(this.lstbxDeviceTypes);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDeviceTypes;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotValue;
        internal System.Windows.Forms.ListBox lstbxDeviceTypes;
    }
}

