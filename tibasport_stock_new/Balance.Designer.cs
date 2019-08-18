namespace tibasport_stock_new
{
    partial class Balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balance));
            this.dgViewBalance = new System.Windows.Forms.DataGridView();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tibasport_dbDataSet = new tibasport_stock_new.tibasport_dbDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.balanceTableAdapter = new tibasport_stock_new.tibasport_dbDataSetTableAdapters.balanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tibasport_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewBalance
            // 
            this.dgViewBalance.AllowUserToAddRows = false;
            this.dgViewBalance.AllowUserToDeleteRows = false;
            this.dgViewBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgViewBalance.AutoGenerateColumns = false;
            this.dgViewBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yearDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.itemdescDataGridViewTextBoxColumn,
            this.storeDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.avgDataGridViewTextBoxColumn});
            this.dgViewBalance.DataSource = this.balanceBindingSource;
            this.dgViewBalance.Location = new System.Drawing.Point(14, 68);
            this.dgViewBalance.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgViewBalance.Name = "dgViewBalance";
            this.dgViewBalance.ReadOnly = true;
            this.dgViewBalance.Size = new System.Drawing.Size(731, 335);
            this.dgViewBalance.TabIndex = 0;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "السنة";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "الكود";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemdescDataGridViewTextBoxColumn
            // 
            this.itemdescDataGridViewTextBoxColumn.DataPropertyName = "item_desc";
            this.itemdescDataGridViewTextBoxColumn.HeaderText = "الوصف";
            this.itemdescDataGridViewTextBoxColumn.Name = "itemdescDataGridViewTextBoxColumn";
            this.itemdescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storeDataGridViewTextBoxColumn
            // 
            this.storeDataGridViewTextBoxColumn.DataPropertyName = "store";
            this.storeDataGridViewTextBoxColumn.HeaderText = "المخزن";
            this.storeDataGridViewTextBoxColumn.Name = "storeDataGridViewTextBoxColumn";
            this.storeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "الكمية";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // avgDataGridViewTextBoxColumn
            // 
            this.avgDataGridViewTextBoxColumn.DataPropertyName = "avg";
            this.avgDataGridViewTextBoxColumn.HeaderText = "المتوسط";
            this.avgDataGridViewTextBoxColumn.Name = "avgDataGridViewTextBoxColumn";
            this.avgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceBindingSource
            // 
            this.balanceBindingSource.DataMember = "balance";
            this.balanceBindingSource.DataSource = this.tibasport_dbDataSet;
            // 
            // tibasport_dbDataSet
            // 
            this.tibasport_dbDataSet.DataSetName = "tibasport_dbDataSet";
            this.tibasport_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(620, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // balanceTableAdapter
            // 
            this.balanceTableAdapter.ClearBeforeFill = true;
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgViewBalance);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Balance";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الارصدة";
            this.Load += new System.EventHandler(this.Balance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tibasport_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewBalance;
        private System.Windows.Forms.Button button1;
        private tibasport_dbDataSet tibasport_dbDataSet;
        private System.Windows.Forms.BindingSource balanceBindingSource;
        private tibasport_dbDataSetTableAdapters.balanceTableAdapter balanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgDataGridViewTextBoxColumn;
    }
}