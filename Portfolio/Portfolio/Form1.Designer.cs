namespace Portfolio
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
            this.portfolioOLV = new BrightIdeasSoftware.ObjectListView();
            this.IDColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InstrumentIDColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InstrumentDateColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ISINColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TickerColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Sedol1Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InstrumentNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PriceColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.optionsgroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.showOldCheck = new System.Windows.Forms.CheckBox();
            this.btnDetailsShow = new System.Windows.Forms.Button();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioOLV)).BeginInit();
            this.optionsgroupBox.SuspendLayout();
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
            this.portfolioOLV.AllColumns.Add(this.PriceColumn);
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
            this.PriceColumn});
            this.portfolioOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.portfolioOLV.FullRowSelect = true;
            this.portfolioOLV.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.portfolioOLV.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.portfolioOLV.Location = new System.Drawing.Point(12, 187);
            this.portfolioOLV.Name = "portfolioOLV";
            this.portfolioOLV.ShowGroups = false;
            this.portfolioOLV.Size = new System.Drawing.Size(1081, 459);
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
            this.InstrumentIDColumn.Width = 76;
            // 
            // InstrumentDateColumn
            // 
            this.InstrumentDateColumn.AspectName = "";
            this.InstrumentDateColumn.Text = "InstrumentDate";
            this.InstrumentDateColumn.Width = 87;
            // 
            // ISINColumn
            // 
            this.ISINColumn.AspectName = "";
            this.ISINColumn.Text = "ISIN";
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
            // 
            // InstrumentNameColumn
            // 
            this.InstrumentNameColumn.Text = "InstrumentName";
            this.InstrumentNameColumn.Width = 93;
            // 
            // PriceColumn
            // 
            this.PriceColumn.Text = "Price";
            this.PriceColumn.Width = 292;
            // 
            // optionsgroupBox
            // 
            this.optionsgroupBox.Controls.Add(this.radioButton4);
            this.optionsgroupBox.Controls.Add(this.radioButton3);
            this.optionsgroupBox.Controls.Add(this.radioButton2);
            this.optionsgroupBox.Controls.Add(this.radioButton1);
            this.optionsgroupBox.Location = new System.Drawing.Point(12, 12);
            this.optionsgroupBox.Name = "optionsgroupBox";
            this.optionsgroupBox.Size = new System.Drawing.Size(200, 120);
            this.optionsgroupBox.TabIndex = 6;
            this.optionsgroupBox.TabStop = false;
            this.optionsgroupBox.Text = "Portfolio Options";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 92);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 69);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Show Portfolio";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(114, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Show Client details";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // showOldCheck
            // 
            this.showOldCheck.AutoSize = true;
            this.showOldCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showOldCheck.Location = new System.Drawing.Point(250, 135);
            this.showOldCheck.Name = "showOldCheck";
            this.showOldCheck.Size = new System.Drawing.Size(160, 24);
            this.showOldCheck.TabIndex = 7;
            this.showOldCheck.Text = "Show Old Records";
            this.showOldCheck.UseVisualStyleBackColor = true;
            // 
            // btnDetailsShow
            // 
            this.btnDetailsShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetailsShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailsShow.Location = new System.Drawing.Point(749, 73);
            this.btnDetailsShow.Name = "btnDetailsShow";
            this.btnDetailsShow.Size = new System.Drawing.Size(145, 31);
            this.btnDetailsShow.TabIndex = 8;
            this.btnDetailsShow.Tag = "false";
            this.btnDetailsShow.Text = "Show Details ";
            this.btnDetailsShow.UseVisualStyleBackColor = true;
            this.btnDetailsShow.Click += new System.EventHandler(this.btnDetailsShow_Click);
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(247, 31);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDatePicker.TabIndex = 9;
            this.fromDatePicker.ValueChanged += new System.EventHandler(this.fromDatePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Maximum Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Minimum Date";
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(247, 81);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(200, 20);
            this.toDatePicker.TabIndex = 12;
            this.toDatePicker.ValueChanged += new System.EventHandler(this.toDatePicker_ValueChanged);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.Location = new System.Drawing.Point(908, 73);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(185, 573);
            this.propertyGrid1.TabIndex = 14;
            this.propertyGrid1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 658);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.btnDetailsShow);
            this.Controls.Add(this.showOldCheck);
            this.Controls.Add(this.optionsgroupBox);
            this.Controls.Add(this.portfolioOLV);
            this.Name = "Form1";
            this.Text = "Portfolio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portfolioOLV)).EndInit();
            this.optionsgroupBox.ResumeLayout(false);
            this.optionsgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BrightIdeasSoftware.ObjectListView portfolioOLV;
        private System.Windows.Forms.GroupBox optionsgroupBox;
        private System.Windows.Forms.CheckBox showOldCheck;
        private System.Windows.Forms.Button btnDetailsShow;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private BrightIdeasSoftware.OLVColumn IDColumn;
        private BrightIdeasSoftware.OLVColumn InstrumentIDColumn;
        private BrightIdeasSoftware.OLVColumn InstrumentDateColumn;
        private BrightIdeasSoftware.OLVColumn ISINColumn;
        private BrightIdeasSoftware.OLVColumn TickerColumn;
        private BrightIdeasSoftware.OLVColumn Sedol1Column;
        private BrightIdeasSoftware.OLVColumn InstrumentNameColumn;
        private BrightIdeasSoftware.OLVColumn PriceColumn;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}

