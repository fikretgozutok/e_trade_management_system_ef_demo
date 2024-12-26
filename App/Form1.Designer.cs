namespace App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpCategory = new GroupBox();
            cmbBoxCategory = new ComboBox();
            grpProductName = new GroupBox();
            txtSearch = new TextBox();
            dgw = new DataGridView();
            groupBox1 = new GroupBox();
            btnDeleteCategory = new Button();
            btnUpdateCategory = new Button();
            btnAddCategory = new Button();
            txtCategory = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnDeleteProduct = new Button();
            btnUpdateProduct = new Button();
            txtStock = new TextBox();
            btnAddProduct = new Button();
            label4 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            grpCategory.SuspendLayout();
            grpProductName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // grpCategory
            // 
            grpCategory.Controls.Add(cmbBoxCategory);
            grpCategory.Location = new Point(12, 12);
            grpCategory.Name = "grpCategory";
            grpCategory.Size = new Size(287, 61);
            grpCategory.TabIndex = 0;
            grpCategory.TabStop = false;
            grpCategory.Text = "By Category";
            // 
            // cmbBoxCategory
            // 
            cmbBoxCategory.FormattingEnabled = true;
            cmbBoxCategory.Location = new Point(6, 22);
            cmbBoxCategory.Name = "cmbBoxCategory";
            cmbBoxCategory.Size = new Size(262, 23);
            cmbBoxCategory.TabIndex = 0;
            cmbBoxCategory.SelectedIndexChanged += cmbBoxCategory_SelectedIndexChanged;
            // 
            // grpProductName
            // 
            grpProductName.Controls.Add(txtSearch);
            grpProductName.Location = new Point(305, 12);
            grpProductName.Name = "grpProductName";
            grpProductName.Size = new Size(287, 61);
            grpProductName.TabIndex = 1;
            grpProductName.TabStop = false;
            grpProductName.Text = "By Product Name";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(262, 23);
            txtSearch.TabIndex = 0;
            // 
            // dgw
            // 
            dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw.Location = new Point(12, 79);
            dgw.Name = "dgw";
            dgw.Size = new Size(580, 416);
            dgw.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeleteCategory);
            groupBox1.Controls.Add(btnUpdateCategory);
            groupBox1.Controls.Add(btnAddCategory);
            groupBox1.Controls.Add(txtCategory);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(598, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 83);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Category Management";
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(168, 52);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(75, 23);
            btnDeleteCategory.TabIndex = 4;
            btnDeleteCategory.Text = "Delete";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.Location = new Point(87, 52);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(75, 23);
            btnUpdateCategory.TabIndex = 3;
            btnUpdateCategory.Text = "Update";
            btnUpdateCategory.UseVisualStyleBackColor = true;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(6, 52);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(75, 23);
            btnAddCategory.TabIndex = 2;
            btnAddCategory.Text = "Add";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(101, 22);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(175, 23);
            txtCategory.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Category Name : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDeleteProduct);
            groupBox2.Controls.Add(btnUpdateProduct);
            groupBox2.Controls.Add(txtStock);
            groupBox2.Controls.Add(btnAddProduct);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtPrice);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtDescription);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtProductName);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(598, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(282, 181);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product Management";
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(168, 149);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(75, 23);
            btnDeleteProduct.TabIndex = 10;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(87, 149);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(75, 23);
            btnUpdateProduct.TabIndex = 5;
            btnUpdateProduct.Text = "Update";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(101, 114);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(175, 23);
            txtStock.TabIndex = 9;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(6, 149);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 23);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 117);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 8;
            label4.Text = "Units of Stock : ";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(101, 82);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(175, 23);
            txtPrice.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 85);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 6;
            label5.Text = "Price : ";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(101, 48);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(175, 23);
            txtDescription.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 51);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 4;
            label3.Text = "Description :";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(101, 16);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(175, 23);
            txtProductName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 2;
            label2.Text = "Product Name : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 507);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgw);
            Controls.Add(grpProductName);
            Controls.Add(grpCategory);
            Name = "Form1";
            Text = "Form1";
            grpCategory.ResumeLayout(false);
            grpProductName.ResumeLayout(false);
            grpProductName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCategory;
        private ComboBox cmbBoxCategory;
        private GroupBox grpProductName;
        private TextBox txtSearch;
        private DataGridView dgw;
        private GroupBox groupBox1;
        private Button btnUpdateCategory;
        private Button btnAddCategory;
        private TextBox txtCategory;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtStock;
        private Label label4;
        private TextBox txtPrice;
        private Label label5;
        private TextBox txtDescription;
        private Label label3;
        private TextBox txtProductName;
        private Label label2;
        private Button btnUpdateProduct;
        private Button btnAddProduct;
        private Button btnDeleteCategory;
        private Button btnDeleteProduct;
    }
}
