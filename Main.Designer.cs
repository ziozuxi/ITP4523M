namespace WindowsFormsApp5
{
    partial class Main
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
            this.Header = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserInformation = new System.Windows.Forms.Panel();
            this.txtJobTitle = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.Label();
            this.UserIcon = new System.Windows.Forms.PictureBox();
            this.CompanyInfo = new System.Windows.Forms.Panel();
            this.CompanyTitle1 = new System.Windows.Forms.Label();
            this.CompanyTitle0 = new System.Windows.Forms.Label();
            this.CompanyIcon = new System.Windows.Forms.PictureBox();
            this.Inventory = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.Accounting = new System.Windows.Forms.Button();
            this.UserBtn = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuContainer = new System.Windows.Forms.Panel();
            this.HomeContainer = new System.Windows.Forms.Panel();
            this.prodBtn = new System.Windows.Forms.Button();
            this.POSContainer = new System.Windows.Forms.Panel();
            this.InventoryContainer = new System.Windows.Forms.Panel();
            this.PurchaseContainer = new System.Windows.Forms.Panel();
            this.DeliveryBtn = new System.Windows.Forms.Button();
            this.WorkmanContainer = new System.Windows.Forms.Panel();
            this.UserContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            this.UserInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.CompanyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyIcon)).BeginInit();
            this.sidebar.SuspendLayout();
            this.MenuContainer.SuspendLayout();
            this.HomeContainer.SuspendLayout();
            this.POSContainer.SuspendLayout();
            this.InventoryContainer.SuspendLayout();
            this.PurchaseContainer.SuspendLayout();
            this.WorkmanContainer.SuspendLayout();
            this.UserContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Header.Controls.Add(this.panel2);
            this.Header.Controls.Add(this.panel1);
            this.Header.Controls.Add(this.UserInformation);
            this.Header.Controls.Add(this.CompanyInfo);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1735, 147);
            this.Header.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(342, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1344, 811);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(343, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 877);
            this.panel1.TabIndex = 1;
            // 
            // UserInformation
            // 
            this.UserInformation.Controls.Add(this.txtJobTitle);
            this.UserInformation.Controls.Add(this.txtUsername);
            this.UserInformation.Controls.Add(this.UserIcon);
            this.UserInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserInformation.Dock = System.Windows.Forms.DockStyle.Right;
            this.UserInformation.Location = new System.Drawing.Point(1389, 0);
            this.UserInformation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UserInformation.Name = "UserInformation";
            this.UserInformation.Size = new System.Drawing.Size(346, 147);
            this.UserInformation.TabIndex = 0;
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobTitle.ForeColor = System.Drawing.Color.White;
            this.txtJobTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtJobTitle.Location = new System.Drawing.Point(100, 75);
            this.txtJobTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(267, 38);
            this.txtJobTitle.TabIndex = 2;
            this.txtJobTitle.Text = "Admin";
            this.txtJobTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUsername.Location = new System.Drawing.Point(100, 38);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(267, 27);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "XXX XXX XXX";
            this.txtUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserIcon
            // 
            this.UserIcon.BackColor = System.Drawing.Color.White;
            this.UserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserIcon.Image = global::WindowsFormsApp5.Properties.Resources.user;
            this.UserIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserIcon.Location = new System.Drawing.Point(17, 38);
            this.UserIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(75, 75);
            this.UserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserIcon.TabIndex = 0;
            this.UserIcon.TabStop = false;
            // 
            // CompanyInfo
            // 
            this.CompanyInfo.Controls.Add(this.CompanyTitle1);
            this.CompanyInfo.Controls.Add(this.CompanyTitle0);
            this.CompanyInfo.Controls.Add(this.CompanyIcon);
            this.CompanyInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.CompanyInfo.Location = new System.Drawing.Point(0, 0);
            this.CompanyInfo.Margin = new System.Windows.Forms.Padding(0);
            this.CompanyInfo.Name = "CompanyInfo";
            this.CompanyInfo.Size = new System.Drawing.Size(340, 147);
            this.CompanyInfo.TabIndex = 0;
            // 
            // CompanyTitle1
            // 
            this.CompanyTitle1.AutoSize = true;
            this.CompanyTitle1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyTitle1.ForeColor = System.Drawing.Color.White;
            this.CompanyTitle1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CompanyTitle1.Location = new System.Drawing.Point(106, 75);
            this.CompanyTitle1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyTitle1.Name = "CompanyTitle1";
            this.CompanyTitle1.Size = new System.Drawing.Size(198, 38);
            this.CompanyTitle1.TabIndex = 3;
            this.CompanyTitle1.Text = "Toy Company";
            // 
            // CompanyTitle0
            // 
            this.CompanyTitle0.AutoSize = true;
            this.CompanyTitle0.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyTitle0.ForeColor = System.Drawing.Color.White;
            this.CompanyTitle0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CompanyTitle0.Location = new System.Drawing.Point(92, 27);
            this.CompanyTitle0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyTitle0.Name = "CompanyTitle0";
            this.CompanyTitle0.Size = new System.Drawing.Size(248, 38);
            this.CompanyTitle0.TabIndex = 2;
            this.CompanyTitle0.Text = "Smile && Sunshine";
            // 
            // CompanyIcon
            // 
            this.CompanyIcon.Image = global::WindowsFormsApp5.Properties.Resources.logo5;
            this.CompanyIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CompanyIcon.Location = new System.Drawing.Point(4, 17);
            this.CompanyIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CompanyIcon.Name = "CompanyIcon";
            this.CompanyIcon.Size = new System.Drawing.Size(106, 96);
            this.CompanyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CompanyIcon.TabIndex = 0;
            this.CompanyIcon.TabStop = false;
            // 
            // Inventory
            // 
            this.Inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Inventory.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Inventory.FlatAppearance.BorderSize = 0;
            this.Inventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Inventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Inventory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Inventory.Location = new System.Drawing.Point(0, 9);
            this.Inventory.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Inventory.Name = "Inventory";
            this.Inventory.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.Inventory.Size = new System.Drawing.Size(340, 75);
            this.Inventory.TabIndex = 2;
            this.Inventory.Text = "Inventory";
            this.Inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Inventory.UseVisualStyleBackColor = false;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.HomeBtn.Size = new System.Drawing.Size(340, 75);
            this.HomeBtn.TabIndex = 2;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // OrderBtn
            // 
            this.OrderBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OrderBtn.FlatAppearance.BorderSize = 0;
            this.OrderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.OrderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrderBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OrderBtn.Location = new System.Drawing.Point(0, 3);
            this.OrderBtn.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.OrderBtn.Size = new System.Drawing.Size(340, 75);
            this.OrderBtn.TabIndex = 2;
            this.OrderBtn.Text = "Order";
            this.OrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrderBtn.UseVisualStyleBackColor = true;
            // 
            // Accounting
            // 
            this.Accounting.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Accounting.FlatAppearance.BorderSize = 0;
            this.Accounting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Accounting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.Accounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accounting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accounting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Accounting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Accounting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Accounting.Location = new System.Drawing.Point(0, 9);
            this.Accounting.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Accounting.Name = "Accounting";
            this.Accounting.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.Accounting.Size = new System.Drawing.Size(340, 75);
            this.Accounting.TabIndex = 2;
            this.Accounting.Text = "Accounting";
            this.Accounting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Accounting.UseVisualStyleBackColor = true;
            // 
            // UserBtn
            // 
            this.UserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UserBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UserBtn.FlatAppearance.BorderSize = 0;
            this.UserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.UserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.UserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserBtn.Location = new System.Drawing.Point(0, 9);
            this.UserBtn.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.UserBtn.Size = new System.Drawing.Size(340, 75);
            this.UserBtn.TabIndex = 2;
            this.UserBtn.Text = "User";
            this.UserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserBtn.UseVisualStyleBackColor = false;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sidebar.Controls.Add(this.MenuContainer);
            this.sidebar.Controls.Add(this.HomeContainer);
            this.sidebar.Controls.Add(this.POSContainer);
            this.sidebar.Controls.Add(this.InventoryContainer);
            this.sidebar.Controls.Add(this.PurchaseContainer);
            this.sidebar.Controls.Add(this.WorkmanContainer);
            this.sidebar.Controls.Add(this.UserContainer);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 147);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sidebar.MaximumSize = new System.Drawing.Size(340, 0);
            this.sidebar.MinimumSize = new System.Drawing.Size(96, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(340, 1012);
            this.sidebar.TabIndex = 4;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MenuContainer.Controls.Add(this.HomeBtn);
            this.MenuContainer.Location = new System.Drawing.Point(0, 0);
            this.MenuContainer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(340, 87);
            this.MenuContainer.TabIndex = 0;
            // 
            // HomeContainer
            // 
            this.HomeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.HomeContainer.Controls.Add(this.prodBtn);
            this.HomeContainer.Location = new System.Drawing.Point(0, 93);
            this.HomeContainer.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.HomeContainer.Name = "HomeContainer";
            this.HomeContainer.Size = new System.Drawing.Size(340, 87);
            this.HomeContainer.TabIndex = 1;
            // 
            // prodBtn
            // 
            this.prodBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.prodBtn.FlatAppearance.BorderSize = 0;
            this.prodBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.prodBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.prodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodBtn.ForeColor = System.Drawing.Color.White;
            this.prodBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prodBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.prodBtn.Location = new System.Drawing.Point(0, 3);
            this.prodBtn.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.prodBtn.Name = "prodBtn";
            this.prodBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.prodBtn.Size = new System.Drawing.Size(340, 75);
            this.prodBtn.TabIndex = 5;
            this.prodBtn.Text = "Product";
            this.prodBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prodBtn.UseVisualStyleBackColor = false;
            this.prodBtn.Click += new System.EventHandler(this.prodBtn_Click);
            // 
            // POSContainer
            // 
            this.POSContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.POSContainer.Controls.Add(this.Inventory);
            this.POSContainer.Location = new System.Drawing.Point(0, 186);
            this.POSContainer.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.POSContainer.Name = "POSContainer";
            this.POSContainer.Size = new System.Drawing.Size(340, 87);
            this.POSContainer.TabIndex = 3;
            // 
            // InventoryContainer
            // 
            this.InventoryContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.InventoryContainer.Controls.Add(this.OrderBtn);
            this.InventoryContainer.Location = new System.Drawing.Point(0, 279);
            this.InventoryContainer.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.InventoryContainer.Name = "InventoryContainer";
            this.InventoryContainer.Size = new System.Drawing.Size(340, 87);
            this.InventoryContainer.TabIndex = 4;
            // 
            // PurchaseContainer
            // 
            this.PurchaseContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PurchaseContainer.Controls.Add(this.DeliveryBtn);
            this.PurchaseContainer.Location = new System.Drawing.Point(0, 372);
            this.PurchaseContainer.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.PurchaseContainer.Name = "PurchaseContainer";
            this.PurchaseContainer.Size = new System.Drawing.Size(340, 87);
            this.PurchaseContainer.TabIndex = 4;
            // 
            // DeliveryBtn
            // 
            this.DeliveryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeliveryBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DeliveryBtn.FlatAppearance.BorderSize = 0;
            this.DeliveryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeliveryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.DeliveryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveryBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeliveryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeliveryBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeliveryBtn.Location = new System.Drawing.Point(0, 3);
            this.DeliveryBtn.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.DeliveryBtn.Name = "DeliveryBtn";
            this.DeliveryBtn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.DeliveryBtn.Size = new System.Drawing.Size(340, 75);
            this.DeliveryBtn.TabIndex = 5;
            this.DeliveryBtn.Text = "Delivery";
            this.DeliveryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeliveryBtn.UseVisualStyleBackColor = false;
            this.DeliveryBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // WorkmanContainer
            // 
            this.WorkmanContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.WorkmanContainer.Controls.Add(this.Accounting);
            this.WorkmanContainer.Location = new System.Drawing.Point(0, 465);
            this.WorkmanContainer.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.WorkmanContainer.Name = "WorkmanContainer";
            this.WorkmanContainer.Size = new System.Drawing.Size(340, 87);
            this.WorkmanContainer.TabIndex = 5;
            // 
            // UserContainer
            // 
            this.UserContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UserContainer.Controls.Add(this.UserBtn);
            this.UserContainer.Location = new System.Drawing.Point(0, 558);
            this.UserContainer.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.UserContainer.Name = "UserContainer";
            this.UserContainer.Size = new System.Drawing.Size(340, 87);
            this.UserContainer.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(340, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1395, 1012);
            this.panel3.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1735, 1159);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.Header);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Header.ResumeLayout(false);
            this.UserInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            this.CompanyInfo.ResumeLayout(false);
            this.CompanyInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyIcon)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.MenuContainer.ResumeLayout(false);
            this.HomeContainer.ResumeLayout(false);
            this.POSContainer.ResumeLayout(false);
            this.InventoryContainer.ResumeLayout(false);
            this.PurchaseContainer.ResumeLayout(false);
            this.WorkmanContainer.ResumeLayout(false);
            this.UserContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel UserInformation;
        private System.Windows.Forms.Label txtJobTitle;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.PictureBox UserIcon;
        private System.Windows.Forms.Panel CompanyInfo;
        private System.Windows.Forms.Label CompanyTitle1;
        private System.Windows.Forms.Label CompanyTitle0;
        private System.Windows.Forms.PictureBox CompanyIcon;
        private System.Windows.Forms.Button Inventory;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Button Accounting;
        private System.Windows.Forms.Button UserBtn;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel MenuContainer;
        private System.Windows.Forms.Panel HomeContainer;
        private System.Windows.Forms.Panel POSContainer;
        private System.Windows.Forms.Panel InventoryContainer;
        private System.Windows.Forms.Panel PurchaseContainer;
        private System.Windows.Forms.Panel WorkmanContainer;
        private System.Windows.Forms.Panel UserContainer;
        private System.Windows.Forms.Button prodBtn;
        private System.Windows.Forms.Button DeliveryBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}