namespace WindowsFormsApp5.Delivery
{
    partial class Delivery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deliverynoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sstoydbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sstoy_dbDataSet = new WindowsFormsApp5.sstoy_dbDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.DeliveryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.deliverynoteTableAdapter = new WindowsFormsApp5.sstoy_dbDataSetTableAdapters.deliverynoteTableAdapter();
            this.deliverynoteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deliverynoteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliverynoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sstoydbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sstoy_dbDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliverynoteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliverynoteBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(11, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1156, 94);
            this.panel3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.button1.Location = new System.Drawing.Point(885, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "Received Goods";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(19, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Delivery";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(11, 188);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1156, 653);
            this.panel4.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliveryIDDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deliverynoteBindingSource2;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.Location = new System.Drawing.Point(26, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1097, 582);
            this.dataGridView1.TabIndex = 0;
            // 
            // deliverynoteBindingSource
            // 
            this.deliverynoteBindingSource.DataMember = "deliverynote";
            this.deliverynoteBindingSource.DataSource = this.sstoydbDataSetBindingSource;
            // 
            // sstoydbDataSetBindingSource
            // 
            this.sstoydbDataSetBindingSource.DataSource = this.sstoy_dbDataSet;
            this.sstoydbDataSetBindingSource.Position = 0;
            // 
            // sstoy_dbDataSet
            // 
            this.sstoy_dbDataSet.DataSetName = "sstoy_dbDataSet";
            this.sstoy_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.SearchBar);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.DeliveryDatePicker);
            this.panel1.Location = new System.Drawing.Point(11, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 84);
            this.panel1.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(682, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 35);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchBar.Location = new System.Drawing.Point(279, 20);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(398, 34);
            this.SearchBar.TabIndex = 13;
            this.SearchBar.Text = "Search by Delivery ID or Order ID";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(885, 16);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(237, 43);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Generate";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // DeliveryDatePicker
            // 
            this.DeliveryDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.DeliveryDatePicker.CalendarTitleBackColor = System.Drawing.Color.RoyalBlue;
            this.DeliveryDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeliveryDatePicker.Location = new System.Drawing.Point(26, 20);
            this.DeliveryDatePicker.Name = "DeliveryDatePicker";
            this.DeliveryDatePicker.Size = new System.Drawing.Size(236, 34);
            this.DeliveryDatePicker.TabIndex = 11;
            // 
            // deliverynoteTableAdapter
            // 
            this.deliverynoteTableAdapter.ClearBeforeFill = true;
            // 
            // deliverynoteBindingSource1
            // 
            this.deliverynoteBindingSource1.DataMember = "deliverynote";
            this.deliverynoteBindingSource1.DataSource = this.sstoydbDataSetBindingSource;
            // 
            // deliverynoteBindingSource2
            // 
            this.deliverynoteBindingSource2.DataMember = "deliverynote";
            this.deliverynoteBindingSource2.DataSource = this.sstoydbDataSetBindingSource;
            // 
            // deliveryIDDataGridViewTextBoxColumn
            // 
            this.deliveryIDDataGridViewTextBoxColumn.DataPropertyName = "deliveryID";
            this.deliveryIDDataGridViewTextBoxColumn.HeaderText = "deliveryID";
            this.deliveryIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryIDDataGridViewTextBoxColumn.Name = "deliveryIDDataGridViewTextBoxColumn";
            this.deliveryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "orderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "deliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "deliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 856);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Delivery";
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.Delivery_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliverynoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sstoydbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sstoy_dbDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliverynoteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliverynoteBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DateTimePicker DeliveryDatePicker;
        private System.Windows.Forms.BindingSource sstoydbDataSetBindingSource;
        private sstoy_dbDataSet sstoy_dbDataSet;
        private System.Windows.Forms.BindingSource deliverynoteBindingSource;
        private sstoy_dbDataSetTableAdapters.deliverynoteTableAdapter deliverynoteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource deliverynoteBindingSource2;
        private System.Windows.Forms.BindingSource deliverynoteBindingSource1;
    }
}