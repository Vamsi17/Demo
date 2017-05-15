namespace AccessoriesStock
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessoriesManagerDataSet = new AccessoriesStock.AccessoriesManagerDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new AccessoriesStock.AccessoriesManagerDataSetTableAdapters.CategoryTableAdapter();
            this.tableAdapterManager = new AccessoriesStock.AccessoriesManagerDataSetTableAdapters.TableAdapterManager();
            this.fKItemCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new AccessoriesStock.AccessoriesManagerDataSetTableAdapters.ItemTableAdapter();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resultTable = new System.Windows.Forms.DataGridView();
            this.fKItemCategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddStock = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SellStock = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKItemCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKItemCategoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(691, 102);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(183, 23);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Model";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(339, 102);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(272, 22);
            this.Model.TabIndex = 2;
            // 
            // category
            // 
            this.category.DataSource = this.categoryBindingSource;
            this.category.DisplayMember = "CategoryName";
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(339, 39);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(230, 24);
            this.category.TabIndex = 3;
            this.category.ValueMember = "CategoryId";
            this.category.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.accessoriesManagerDataSet;
            // 
            // accessoriesManagerDataSet
            // 
            this.accessoriesManagerDataSet.DataSetName = "AccessoriesManagerDataSet";
            this.accessoriesManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Category";
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AccessoriesStock.AccessoriesManagerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fKItemCategoryBindingSource
            // 
            this.fKItemCategoryBindingSource.DataMember = "FK_Item_Category";
            this.fKItemCategoryBindingSource.DataSource = this.categoryBindingSource;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.accessoriesManagerDataSet;
            // 
            // resultTable
            // 
            this.resultTable.AllowUserToAddRows = false;
            this.resultTable.AllowUserToDeleteRows = false;
            this.resultTable.AllowUserToOrderColumns = true;
            this.resultTable.AutoGenerateColumns = false;
            this.resultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.CategoryId,
            this.ItemName,
            this.remainingQuantityDataGridViewTextBoxColumn,
            this.AddStock,
            this.SellStock});
            this.resultTable.DataSource = this.fKItemCategoryBindingSource1;
            this.resultTable.Location = new System.Drawing.Point(85, 190);
            this.resultTable.Name = "resultTable";
            this.resultTable.RowTemplate.Height = 24;
            this.resultTable.Size = new System.Drawing.Size(626, 187);
            this.resultTable.TabIndex = 5;
            this.resultTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fKItemCategoryBindingSource1
            // 
            this.fKItemCategoryBindingSource1.DataMember = "FK_Item_Category";
            this.fKItemCategoryBindingSource1.DataSource = this.categoryBindingSource;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Visible = false;
            // 
            // CategoryId
            // 
            this.CategoryId.DataPropertyName = "CategoryId";
            this.CategoryId.HeaderText = "CategoryId";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // remainingQuantityDataGridViewTextBoxColumn
            // 
            this.remainingQuantityDataGridViewTextBoxColumn.DataPropertyName = "RemainingQuantity";
            this.remainingQuantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.remainingQuantityDataGridViewTextBoxColumn.Name = "remainingQuantityDataGridViewTextBoxColumn";
            this.remainingQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AddStock
            // 
            this.AddStock.HeaderText = "AddStock";
            this.AddStock.Name = "AddStock";
            this.AddStock.Text = "AddStock";
            this.AddStock.ToolTipText = "Adding stock increases number of items";
            this.AddStock.UseColumnTextForButtonValue = true;
            // 
            // SellStock
            // 
            this.SellStock.HeaderText = "SellStock";
            this.SellStock.Name = "SellStock";
            this.SellStock.Text = "Sell";
            this.SellStock.ToolTipText = "Selling stock reduces one count in your stock balance";
            this.SellStock.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 409);
            this.Controls.Add(this.resultTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.category);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKItemCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKItemCategoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label2;
        private AccessoriesManagerDataSet accessoriesManagerDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private AccessoriesManagerDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private AccessoriesManagerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource fKItemCategoryBindingSource;
        private AccessoriesManagerDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.DataGridView resultTable;
        private System.Windows.Forms.BindingSource fKItemCategoryBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn AddStock;
        private System.Windows.Forms.DataGridViewButtonColumn SellStock;
    }
}

