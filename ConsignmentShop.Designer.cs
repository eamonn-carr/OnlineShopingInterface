namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            this.headertext = new System.Windows.Forms.Label();
            this.Itemlistbox = new System.Windows.Forms.ListBox();
            this.ItemListBoxlabel = new System.Windows.Forms.Label();
            this.AddToCart = new System.Windows.Forms.Button();
            this.shoppingCartListBoxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headertext
            // 
            this.headertext.AutoSize = true;
            this.headertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headertext.Location = new System.Drawing.Point(50, 38);
            this.headertext.Name = "headertext";
            this.headertext.Size = new System.Drawing.Size(366, 37);
            this.headertext.TabIndex = 0;
            this.headertext.Text = "CosingmentShopDemo";
            // 
            // Itemlistbox
            // 
            this.Itemlistbox.FormattingEnabled = true;
            this.Itemlistbox.ItemHeight = 20;
            this.Itemlistbox.Location = new System.Drawing.Point(12, 129);
            this.Itemlistbox.Name = "Itemlistbox";
            this.Itemlistbox.Size = new System.Drawing.Size(256, 184);
            this.Itemlistbox.TabIndex = 1;
            // 
            // ItemListBoxlabel
            // 
            this.ItemListBoxlabel.AutoSize = true;
            this.ItemListBoxlabel.Location = new System.Drawing.Point(12, 89);
            this.ItemListBoxlabel.Name = "ItemListBoxlabel";
            this.ItemListBoxlabel.Size = new System.Drawing.Size(92, 20);
            this.ItemListBoxlabel.TabIndex = 2;
            this.ItemListBoxlabel.Text = "Store Items";
            // 
            // AddToCart
            // 
            this.AddToCart.Location = new System.Drawing.Point(274, 139);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(126, 29);
            this.AddToCart.TabIndex = 3;
            this.AddToCart.Text = "Add to cart";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // shoppingCartListBoxLabel
            // 
            this.shoppingCartListBoxLabel.AutoSize = true;
            this.shoppingCartListBoxLabel.Location = new System.Drawing.Point(403, 89);
            this.shoppingCartListBoxLabel.Name = "shoppingCartListBoxLabel";
            this.shoppingCartListBoxLabel.Size = new System.Drawing.Size(111, 20);
            this.shoppingCartListBoxLabel.TabIndex = 5;
            this.shoppingCartListBoxLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 20;
            this.shoppingCartListBox.Location = new System.Drawing.Point(407, 129);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(256, 184);
            this.shoppingCartListBox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(544, 319);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(108, 29);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 394);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartListBoxLabel);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.ItemListBoxlabel);
            this.Controls.Add(this.Itemlistbox);
            this.Controls.Add(this.headertext);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop Design";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headertext;
        private System.Windows.Forms.ListBox Itemlistbox;
        private System.Windows.Forms.Label ItemListBoxlabel;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.Label shoppingCartListBoxLabel;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Button makePurchase;
    }
}

