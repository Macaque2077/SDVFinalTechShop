namespace SDVFINALPROJECT
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
            this.lstDeviceTypes = new System.Windows.Forms.ListBox();
            this.lblBrands = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDeviceTypes
            // 
            this.lstDeviceTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lstDeviceTypes.FormattingEnabled = true;
            this.lstDeviceTypes.ItemHeight = 25;
            this.lstDeviceTypes.Items.AddRange(new object[] {
            "Smart Phones",
            "Smart Watches",
            "Tablets"});
            this.lstDeviceTypes.Location = new System.Drawing.Point(12, 44);
            this.lstDeviceTypes.Name = "lstDeviceTypes";
            this.lstDeviceTypes.Size = new System.Drawing.Size(181, 304);
            this.lstDeviceTypes.TabIndex = 0;
            this.lstDeviceTypes.SelectedIndexChanged += new System.EventHandler(this.lstDeviceTypes_SelectedIndexChanged);
            // 
            // lblBrands
            // 
            this.lblBrands.AutoSize = true;
            this.lblBrands.Location = new System.Drawing.Point(12, 25);
            this.lblBrands.Name = "lblBrands";
            this.lblBrands.Size = new System.Drawing.Size(90, 13);
            this.lblBrands.TabIndex = 1;
            this.lblBrands.Text = "Types of Devices";
            this.lblBrands.Click += new System.EventHandler(this.lblBrands_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(286, 50);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(107, 53);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(286, 225);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(107, 53);
            this.btnOrders.TabIndex = 5;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(286, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 57);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(286, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 57);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblBrands);
            this.Controls.Add(this.lstDeviceTypes);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDeviceTypes;
        private System.Windows.Forms.Label lblBrands;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotValue;
    }
}

