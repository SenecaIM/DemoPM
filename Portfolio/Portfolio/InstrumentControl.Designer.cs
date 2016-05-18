namespace Portfolio
{
    partial class InstrumentControl
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
            this.portfolioOLV = new BrightIdeasSoftware.ObjectListView();
            this.IDColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InstrumentIDColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InstrumentDateColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ISINColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TickerColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Sedol1Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InstrumentNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PriceDisplayColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DetailColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioOLV)).BeginInit();
            this.SuspendLayout();
            // 
            // portfolioOLV
            // 
            this.portfolioOLV.AllColumns.Add(this.IDColumn);
            this.portfolioOLV.AllColumns.Add(this.InstrumentIDColumn);
            this.portfolioOLV.AllColumns.Add(this.InstrumentDateColumn);
            this.portfolioOLV.AllColumns.Add(this.ISINColumn);
            this.portfolioOLV.AllColumns.Add(this.TickerColumn);
            this.portfolioOLV.AllColumns.Add(this.Sedol1Column);
            this.portfolioOLV.AllColumns.Add(this.InstrumentNameColumn);
            this.portfolioOLV.AllColumns.Add(this.PriceDisplayColumn);
            this.portfolioOLV.AllColumns.Add(this.DetailColumn);
            this.portfolioOLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portfolioOLV.CellEditUseWholeCell = false;
            this.portfolioOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDColumn,
            this.InstrumentIDColumn,
            this.InstrumentDateColumn,
            this.ISINColumn,
            this.TickerColumn,
            this.Sedol1Column,
            this.InstrumentNameColumn,
            this.PriceDisplayColumn,
            this.DetailColumn});
            this.portfolioOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.portfolioOLV.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portfolioOLV.FullRowSelect = true;
            this.portfolioOLV.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.portfolioOLV.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.portfolioOLV.Location = new System.Drawing.Point(0, 49);
            this.portfolioOLV.Name = "portfolioOLV";
            this.portfolioOLV.ShowGroups = false;
            this.portfolioOLV.Size = new System.Drawing.Size(1170, 468);
            this.portfolioOLV.TabIndex = 1;
            this.portfolioOLV.UseCompatibleStateImageBehavior = false;
            this.portfolioOLV.View = System.Windows.Forms.View.Details;
            this.portfolioOLV.SelectedIndexChanged += new System.EventHandler(this.portfolioOLV_SelectedIndexChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.AspectName = "";
            this.IDColumn.Text = "ID";
            // 
            // InstrumentIDColumn
            // 
            this.InstrumentIDColumn.AspectName = "";
            this.InstrumentIDColumn.Text = "InstrumentID";
            this.InstrumentIDColumn.Width = 89;
            // 
            // InstrumentDateColumn
            // 
            this.InstrumentDateColumn.AspectName = "";
            this.InstrumentDateColumn.Text = "InstrumentDate";
            this.InstrumentDateColumn.Width = 135;
            // 
            // ISINColumn
            // 
            this.ISINColumn.AspectName = "";
            this.ISINColumn.Text = "ISIN";
            this.ISINColumn.Width = 84;
            // 
            // TickerColumn
            // 
            this.TickerColumn.AspectName = "";
            this.TickerColumn.Text = "Ticker";
            // 
            // Sedol1Column
            // 
            this.Sedol1Column.AspectName = "";
            this.Sedol1Column.Text = "Sedol1";
            this.Sedol1Column.Width = 72;
            // 
            // InstrumentNameColumn
            // 
            this.InstrumentNameColumn.Text = "InstrumentName";
            this.InstrumentNameColumn.Width = 121;
            // 
            // PriceDisplayColumn
            // 
            this.PriceDisplayColumn.Text = "Price";
            this.PriceDisplayColumn.Width = 72;
            // 
            // DetailColumn
            // 
            this.DetailColumn.FillsFreeSpace = true;
            this.DetailColumn.Text = "Details";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDatePicker.Location = new System.Drawing.Point(0, 23);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(200, 21);
            this.fromDatePicker.TabIndex = 9;
            this.fromDatePicker.ValueChanged += new System.EventHandler(this.fromDatePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Maximum Date";
            // 
            // InstrumentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.portfolioOLV);
            this.Name = "InstrumentControl";
            this.Size = new System.Drawing.Size(920, 520);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portfolioOLV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BrightIdeasSoftware.ObjectListView portfolioOLV;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.OLVColumn IDColumn;
        private BrightIdeasSoftware.OLVColumn InstrumentIDColumn;
        private BrightIdeasSoftware.OLVColumn InstrumentDateColumn;
        private BrightIdeasSoftware.OLVColumn ISINColumn;
        private BrightIdeasSoftware.OLVColumn TickerColumn;
        private BrightIdeasSoftware.OLVColumn Sedol1Column;
        private BrightIdeasSoftware.OLVColumn InstrumentNameColumn;
        private BrightIdeasSoftware.OLVColumn PriceDisplayColumn;
        private BrightIdeasSoftware.OLVColumn DetailColumn;
    }
}

