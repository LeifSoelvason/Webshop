namespace MinWebShop
{
    partial class MenuForm
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
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_address = new System.Windows.Forms.Button();
            this.btn_account = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_customer
            // 
            this.btn_customer.Location = new System.Drawing.Point(48, 32);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(75, 23);
            this.btn_customer.TabIndex = 0;
            this.btn_customer.Text = "Customer";
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_address
            // 
            this.btn_address.Location = new System.Drawing.Point(48, 95);
            this.btn_address.Name = "btn_address";
            this.btn_address.Size = new System.Drawing.Size(75, 23);
            this.btn_address.TabIndex = 1;
            this.btn_address.Text = "Address";
            this.btn_address.UseVisualStyleBackColor = true;
            this.btn_address.Click += new System.EventHandler(this.btn_address_Click);
            // 
            // btn_account
            // 
            this.btn_account.Location = new System.Drawing.Point(48, 158);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(75, 23);
            this.btn_account.TabIndex = 2;
            this.btn_account.Text = "Account";
            this.btn_account.UseVisualStyleBackColor = true;
            this.btn_account.Click += new System.EventHandler(this.btn_account_Click);
            // 
            // btn_product
            // 
            this.btn_product.Location = new System.Drawing.Point(48, 221);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(75, 23);
            this.btn_product.TabIndex = 3;
            this.btn_product.Text = "Product";
            this.btn_product.UseVisualStyleBackColor = true;
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(48, 284);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(75, 23);
            this.btn_order.TabIndex = 4;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(675, 383);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_product);
            this.Controls.Add(this.btn_account);
            this.Controls.Add(this.btn_address);
            this.Controls.Add(this.btn_customer);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button btn_address;
        private System.Windows.Forms.Button btn_account;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_close;
    }
}