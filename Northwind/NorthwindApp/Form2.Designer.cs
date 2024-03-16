namespace NorthwindApp
{
    partial class Form2
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
            this.btnShow = new System.Windows.Forms.Button();
            this.lstView = new System.Windows.Forms.ListBox();
            this.radioBtnOrder = new System.Windows.Forms.RadioButton();
            this.radioBtnEmployees = new System.Windows.Forms.RadioButton();
            this.panelRadioProvider = new System.Windows.Forms.GroupBox();
            this.radioBtnCustomers = new System.Windows.Forms.RadioButton();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblContactName = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.panelRadioProvider.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(66, 207);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(91, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lstView
            // 
            this.lstView.FormattingEnabled = true;
            this.lstView.ItemHeight = 16;
            this.lstView.Location = new System.Drawing.Point(228, 12);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(630, 388);
            this.lstView.TabIndex = 1;
            // 
            // radioBtnOrder
            // 
            this.radioBtnOrder.AutoSize = true;
            this.radioBtnOrder.Location = new System.Drawing.Point(6, 21);
            this.radioBtnOrder.Name = "radioBtnOrder";
            this.radioBtnOrder.Size = new System.Drawing.Size(69, 20);
            this.radioBtnOrder.TabIndex = 4;
            this.radioBtnOrder.TabStop = true;
            this.radioBtnOrder.Text = "Orders";
            this.radioBtnOrder.UseVisualStyleBackColor = true;
            // 
            // radioBtnEmployees
            // 
            this.radioBtnEmployees.AutoSize = true;
            this.radioBtnEmployees.Location = new System.Drawing.Point(6, 47);
            this.radioBtnEmployees.Name = "radioBtnEmployees";
            this.radioBtnEmployees.Size = new System.Drawing.Size(97, 20);
            this.radioBtnEmployees.TabIndex = 5;
            this.radioBtnEmployees.TabStop = true;
            this.radioBtnEmployees.Text = "Employees";
            this.radioBtnEmployees.UseVisualStyleBackColor = true;
            // 
            // panelRadioProvider
            // 
            this.panelRadioProvider.Controls.Add(this.radioBtnCustomers);
            this.panelRadioProvider.Controls.Add(this.radioBtnOrder);
            this.panelRadioProvider.Controls.Add(this.radioBtnEmployees);
            this.panelRadioProvider.Location = new System.Drawing.Point(16, 92);
            this.panelRadioProvider.Name = "panelRadioProvider";
            this.panelRadioProvider.Size = new System.Drawing.Size(200, 109);
            this.panelRadioProvider.TabIndex = 7;
            this.panelRadioProvider.TabStop = false;
            this.panelRadioProvider.Text = "Сhoose";
            // 
            // radioBtnCustomers
            // 
            this.radioBtnCustomers.AutoSize = true;
            this.radioBtnCustomers.Location = new System.Drawing.Point(7, 74);
            this.radioBtnCustomers.Name = "radioBtnCustomers";
            this.radioBtnCustomers.Size = new System.Drawing.Size(92, 20);
            this.radioBtnCustomers.TabIndex = 6;
            this.radioBtnCustomers.TabStop = true;
            this.radioBtnCustomers.Text = "Customers";
            this.radioBtnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(730, 504);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(128, 23);
            this.btnAddCustomer.TabIndex = 8;
            this.btnAddCustomer.Text = "Add a customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(16, 426);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(77, 16);
            this.lblCustomerID.TabIndex = 9;
            this.lblCustomerID.Text = "CustomerID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(19, 461);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerID.TabIndex = 10;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(120, 426);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(102, 16);
            this.lblCompanyName.TabIndex = 9;
            this.lblCompanyName.Text = "CompanyName";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(123, 461);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 22);
            this.txtCompanyName.TabIndex = 10;
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(225, 426);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(89, 16);
            this.lblContactName.TabIndex = 9;
            this.lblContactName.Text = "ContactName";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(228, 461);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(100, 22);
            this.txtContactName.TabIndex = 10;
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.AutoSize = true;
            this.lblContactTitle.Location = new System.Drawing.Point(331, 426);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(78, 16);
            this.lblContactTitle.TabIndex = 9;
            this.lblContactTitle.Text = "ContactTitle";
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Location = new System.Drawing.Point(334, 461);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(100, 22);
            this.txtContactTitle.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(437, 426);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(440, 461);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 10;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(543, 426);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 16);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(546, 461);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 10;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(649, 426);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(51, 16);
            this.lblRegion.TabIndex = 9;
            this.lblRegion.Text = "Region";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(652, 461);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(100, 22);
            this.txtRegion.TabIndex = 10;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(755, 426);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(78, 16);
            this.lblPostalCode.TabIndex = 9;
            this.lblPostalCode.Text = "PostalCode";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(758, 461);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 22);
            this.txtPostalCode.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 553);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.txtContactTitle);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblContactTitle);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.panelRadioProvider);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.btnShow);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelRadioProvider.ResumeLayout(false);
            this.panelRadioProvider.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox lstView;
        private System.Windows.Forms.RadioButton radioBtnOrder;
        private System.Windows.Forms.RadioButton radioBtnEmployees;
        private System.Windows.Forms.GroupBox panelRadioProvider;
        private System.Windows.Forms.RadioButton radioBtnCustomers;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtPostalCode;
    }
}