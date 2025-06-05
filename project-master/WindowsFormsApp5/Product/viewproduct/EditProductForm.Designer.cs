namespace WindowsFormsApp5.Product
{
    partial class EditProductForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblProductIDText = new System.Windows.Forms.Label();
            this.lblProductNameText = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblPriceText = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblTargetText = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();

            this.lblProductIDText.AutoSize = true;
            this.lblProductIDText.Location = new System.Drawing.Point(72, 56);
            this.lblProductIDText.Name = "lblProductIDText";
            this.lblProductIDText.Size = new System.Drawing.Size(59, 12);
            this.lblProductIDText.TabIndex = 0;
            this.lblProductIDText.Text = "Product ID:";

            this.lblProductNameText.AutoSize = true;
            this.lblProductNameText.Location = new System.Drawing.Point(57, 147);
            this.lblProductNameText.Name = "lblProductNameText";
            this.lblProductNameText.Size = new System.Drawing.Size(74, 12);
            this.lblProductNameText.TabIndex = 1;
            this.lblProductNameText.Text = "Product Name:";

            this.txtProductID.Location = new System.Drawing.Point(137, 46);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(100, 22);
            this.txtProductID.TabIndex = 2;

            this.txtProductName.Location = new System.Drawing.Point(137, 144);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 22);
            this.txtProductName.TabIndex = 3;

            this.lblPriceText.AutoSize = true;
            this.lblPriceText.Location = new System.Drawing.Point(100, 225);
            this.lblPriceText.Name = "lblPriceText";
            this.lblPriceText.Size = new System.Drawing.Size(31, 12);
            this.lblPriceText.TabIndex = 4;
            this.lblPriceText.Text = "Price:";

            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(137, 215);
            this.numPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 22);
            this.numPrice.TabIndex = 5;

            this.lblTargetText.AutoSize = true;
            this.lblTargetText.Location = new System.Drawing.Point(100, 304);
            this.lblTargetText.Name = "lblTargetText";
            this.lblTargetText.Size = new System.Drawing.Size(38, 12);
            this.lblTargetText.TabIndex = 6;
            this.lblTargetText.Text = "Target:";

            this.txtTarget.Location = new System.Drawing.Point(137, 301);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(100, 22);
            this.txtTarget.TabIndex = 7;

            this.btnSave.Location = new System.Drawing.Point(587, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(694, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.lblTargetText);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.lblPriceText);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductNameText);
            this.Controls.Add(this.lblProductIDText);
            this.Name = "EditProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Product";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductIDText;
        private System.Windows.Forms.Label lblProductNameText;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblPriceText;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblTargetText;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}