namespace CustomersRegistry
{
    partial class MainForm
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
            this.GridPanel = new System.Windows.Forms.Panel();
            this.OperationsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainDataGrid = new System.Windows.Forms.DataGridView();
            this.CustomerPanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.JoinDatePicker = new System.Windows.Forms.DateTimePicker();
            this.JoinDateLbl = new System.Windows.Forms.Label();
            this.AddressTbx = new System.Windows.Forms.TextBox();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.LastNameTbx = new System.Windows.Forms.TextBox();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.FirstNameTbx = new System.Windows.Forms.TextBox();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.SearchCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridPanel.SuspendLayout();
            this.OperationsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).BeginInit();
            this.CustomerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridPanel
            // 
            this.GridPanel.ContextMenuStrip = this.OperationsMenu;
            this.GridPanel.Controls.Add(this.MainDataGrid);
            this.GridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPanel.Location = new System.Drawing.Point(0, 0);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(1008, 729);
            this.GridPanel.TabIndex = 0;
            // 
            // OperationsMenu
            // 
            this.OperationsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCustomerToolStripMenuItem,
            this.EditCustomerToolStripMenuItem,
            this.DeleteCustomerToolStripMenuItem,
            this.SearchCustomerToolStripMenuItem});
            this.OperationsMenu.Name = "OperationsMenu";
            this.OperationsMenu.Size = new System.Drawing.Size(163, 114);
            // 
            // AddCustomerToolStripMenuItem
            // 
            this.AddCustomerToolStripMenuItem.Name = "AddCustomerToolStripMenuItem";
            this.AddCustomerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.AddCustomerToolStripMenuItem.Text = "Add customer";
            this.AddCustomerToolStripMenuItem.Click += new System.EventHandler(this.AddCustomerToolStripMenuItem_Click);
            // 
            // EditCustomerToolStripMenuItem
            // 
            this.EditCustomerToolStripMenuItem.Name = "EditCustomerToolStripMenuItem";
            this.EditCustomerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.EditCustomerToolStripMenuItem.Text = "Edit customer";
            this.EditCustomerToolStripMenuItem.Click += new System.EventHandler(this.EditCustomerToolStripMenuItem_Click);
            // 
            // DeleteCustomerToolStripMenuItem
            // 
            this.DeleteCustomerToolStripMenuItem.Name = "DeleteCustomerToolStripMenuItem";
            this.DeleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.DeleteCustomerToolStripMenuItem.Text = "Delete customer";
            this.DeleteCustomerToolStripMenuItem.Click += new System.EventHandler(this.DeleteCustomerToolStripMenuItem_Click);
            // 
            // MainDataGrid
            // 
            this.MainDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDataGrid.Location = new System.Drawing.Point(0, 0);
            this.MainDataGrid.MultiSelect = false;
            this.MainDataGrid.Name = "MainDataGrid";
            this.MainDataGrid.ReadOnly = true;
            this.MainDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainDataGrid.Size = new System.Drawing.Size(1008, 729);
            this.MainDataGrid.TabIndex = 0;
            this.MainDataGrid.SelectionChanged += new System.EventHandler(this.MainDataGrid_SelectionChanged);
            // 
            // CustomerPanel
            // 
            this.CustomerPanel.Controls.Add(this.SearchButton);
            this.CustomerPanel.Controls.Add(this.CancelBtn);
            this.CustomerPanel.Controls.Add(this.SaveBtn);
            this.CustomerPanel.Controls.Add(this.JoinDatePicker);
            this.CustomerPanel.Controls.Add(this.JoinDateLbl);
            this.CustomerPanel.Controls.Add(this.AddressTbx);
            this.CustomerPanel.Controls.Add(this.AddressLbl);
            this.CustomerPanel.Controls.Add(this.LastNameTbx);
            this.CustomerPanel.Controls.Add(this.LastNameLbl);
            this.CustomerPanel.Controls.Add(this.FirstNameTbx);
            this.CustomerPanel.Controls.Add(this.FirstNameLbl);
            this.CustomerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.Size = new System.Drawing.Size(1008, 729);
            this.CustomerPanel.TabIndex = 1;
            this.CustomerPanel.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(15, 264);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(200, 23);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(262, 215);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(200, 23);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(15, 215);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(200, 23);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // JoinDatePicker
            // 
            this.JoinDatePicker.Location = new System.Drawing.Point(15, 171);
            this.JoinDatePicker.Name = "JoinDatePicker";
            this.JoinDatePicker.Size = new System.Drawing.Size(200, 20);
            this.JoinDatePicker.TabIndex = 7;
            // 
            // JoinDateLbl
            // 
            this.JoinDateLbl.AutoSize = true;
            this.JoinDateLbl.Location = new System.Drawing.Point(12, 155);
            this.JoinDateLbl.Name = "JoinDateLbl";
            this.JoinDateLbl.Size = new System.Drawing.Size(94, 13);
            this.JoinDateLbl.TabIndex = 6;
            this.JoinDateLbl.Text = "Data przystąpienia";
            // 
            // AddressTbx
            // 
            this.AddressTbx.Location = new System.Drawing.Point(15, 122);
            this.AddressTbx.Name = "AddressTbx";
            this.AddressTbx.Size = new System.Drawing.Size(447, 20);
            this.AddressTbx.TabIndex = 5;
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(12, 106);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(45, 13);
            this.AddressLbl.TabIndex = 4;
            this.AddressLbl.Text = "Address";
            // 
            // LastNameTbx
            // 
            this.LastNameTbx.Location = new System.Drawing.Point(15, 74);
            this.LastNameTbx.Name = "LastNameTbx";
            this.LastNameTbx.Size = new System.Drawing.Size(447, 20);
            this.LastNameTbx.TabIndex = 3;
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Location = new System.Drawing.Point(12, 58);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(49, 13);
            this.LastNameLbl.TabIndex = 2;
            this.LastNameLbl.Text = "Surname";
            // 
            // FirstNameTbx
            // 
            this.FirstNameTbx.Location = new System.Drawing.Point(15, 25);
            this.FirstNameTbx.Name = "FirstNameTbx";
            this.FirstNameTbx.Size = new System.Drawing.Size(447, 20);
            this.FirstNameTbx.TabIndex = 1;
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(12, 9);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(55, 13);
            this.FirstNameLbl.TabIndex = 0;
            this.FirstNameLbl.Text = "First name";
            // 
            // SearchCustomerToolStripMenuItem
            // 
            this.SearchCustomerToolStripMenuItem.Name = "SearchCustomerToolStripMenuItem";
            this.SearchCustomerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.SearchCustomerToolStripMenuItem.Text = "Search customer";
            this.SearchCustomerToolStripMenuItem.Click += new System.EventHandler(this.SearchCustomerToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.ContextMenuStrip = this.OperationsMenu;
            this.Controls.Add(this.CustomerPanel);
            this.Controls.Add(this.GridPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.GridPanel.ResumeLayout(false);
            this.OperationsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).EndInit();
            this.CustomerPanel.ResumeLayout(false);
            this.CustomerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.Panel CustomerPanel;
        private System.Windows.Forms.DateTimePicker JoinDatePicker;
        private System.Windows.Forms.Label JoinDateLbl;
        private System.Windows.Forms.TextBox AddressTbx;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.TextBox LastNameTbx;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.TextBox FirstNameTbx;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DataGridView MainDataGrid;
        private System.Windows.Forms.ContextMenuStrip OperationsMenu;
        private System.Windows.Forms.ToolStripMenuItem AddCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditCustomerToolStripMenuItem;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ToolStripMenuItem SearchCustomerToolStripMenuItem;
    }
}

