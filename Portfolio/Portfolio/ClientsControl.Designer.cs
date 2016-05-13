namespace Portfolio
{
    partial class ClientsControl
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
            this.clientOLV = new BrightIdeasSoftware.ObjectListView();
            this.IDColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ClientNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.CurrencyID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AddressColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.clientOLV)).BeginInit();
            this.SuspendLayout();
            // 
            // clientOLV
            // 
            this.clientOLV.AllColumns.Add(this.IDColumn);
            this.clientOLV.AllColumns.Add(this.ClientNameColumn);
            this.clientOLV.AllColumns.Add(this.CurrencyID);
            this.clientOLV.AllColumns.Add(this.AddressColumn);
            this.clientOLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientOLV.CellEditUseWholeCell = false;
            this.clientOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDColumn,
            this.ClientNameColumn,
            this.CurrencyID,
            this.AddressColumn});
            this.clientOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.clientOLV.FullRowSelect = true;
            this.clientOLV.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.clientOLV.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.clientOLV.Location = new System.Drawing.Point(12, 183);
            this.clientOLV.Name = "clientOLV";
            this.clientOLV.ShowGroups = false;
            this.clientOLV.Size = new System.Drawing.Size(728, 459);
            this.clientOLV.TabIndex = 15;
            this.clientOLV.UseCompatibleStateImageBehavior = false;
            this.clientOLV.View = System.Windows.Forms.View.Details;
            this.clientOLV.SelectedIndexChanged += new System.EventHandler(this.clientOLV_SelectedIndexChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.AspectName = "";
            this.IDColumn.Text = "ID";
            // 
            // ClientNameColumn
            // 
            this.ClientNameColumn.AspectName = "";
            this.ClientNameColumn.Text = "ClientName";
            this.ClientNameColumn.Width = 96;
            // 
            // CurrencyID
            // 
            this.CurrencyID.Text = "CurrencyID";
            this.CurrencyID.Width = 106;
            // 
            // AddressColumn
            // 
            this.AddressColumn.Text = "Address";
            this.AddressColumn.Width = 274;
            // 
            // ClientsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clientOLV);
            this.Name = "ClientsControl";
            this.Size = new System.Drawing.Size(911, 827);
            this.Load += new System.EventHandler(this.ClientsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientOLV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private BrightIdeasSoftware.ObjectListView clientOLV;
        private BrightIdeasSoftware.OLVColumn IDColumn;
        private BrightIdeasSoftware.OLVColumn ClientNameColumn;
        private BrightIdeasSoftware.OLVColumn CurrencyID;
        private BrightIdeasSoftware.OLVColumn AddressColumn;
    }
}