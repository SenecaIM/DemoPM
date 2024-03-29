﻿namespace Portfolio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsControl));
            this.clientOLV = new BrightIdeasSoftware.ObjectListView();
            this.IDColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ClientNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.CurrencyID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AddressColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
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
            this.clientOLV.CheckBoxes = true;
            this.clientOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDColumn,
            this.ClientNameColumn,
            this.CurrencyID,
            this.AddressColumn});
            this.clientOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.clientOLV.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientOLV.FullRowSelect = true;
            this.clientOLV.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.clientOLV.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.clientOLV.Location = new System.Drawing.Point(0, 0);
            this.clientOLV.Name = "clientOLV";
            this.clientOLV.ShowGroups = false;
            this.clientOLV.Size = new System.Drawing.Size(711, 525);
            this.clientOLV.TabIndex = 15;
            this.clientOLV.UseCompatibleStateImageBehavior = false;
            this.clientOLV.View = System.Windows.Forms.View.Details;
            this.clientOLV.SelectedIndexChanged += new System.EventHandler(this.clientOLV_SelectedIndexChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.AspectName = "";
            this.IDColumn.HeaderCheckBox = true;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(599, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 62);
            this.button1.TabIndex = 16;
            this.button1.Text = "Display client\'s portfolio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClient.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(470, 531);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(109, 62);
            this.btnAddClient.TabIndex = 17;
            this.btnAddClient.Text = "Add or edit a client";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // ClientsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientOLV);
            this.Name = "ClientsControl";
            this.Size = new System.Drawing.Size(711, 596);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddClient;
    }
}