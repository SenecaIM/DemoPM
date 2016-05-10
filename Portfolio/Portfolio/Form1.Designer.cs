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
            this.detailsOLV = new BrightIdeasSoftware.ObjectListView();
            this.ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InstrumentID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InstrumentDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ISIN = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Ticker = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Sedol1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Exchange = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InstrumentName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InstrumentType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PriceMid = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PriceBid = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PriceAsk = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PriceLast = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PriceNAV = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PriceCurrencyID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PriceFactor = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DivGross = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DivCurrencyID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DivFactor = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FixedParAmount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FixedParValue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FixedCoupon = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FixedAccuredInterest = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.portfolioOLV)).BeginInit();
            this.optionsgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsOLV)).BeginInit();
            this.SuspendLayout();
            // 
            // portfolioOLV
            // 
            this.portfolioOLV.AllColumns.Add(this.ID);
            this.portfolioOLV.AllColumns.Add(this.InstrumentID);
            this.portfolioOLV.AllColumns.Add(this.InstrumentDate);
            this.portfolioOLV.AllColumns.Add(this.ISIN);
            this.portfolioOLV.AllColumns.Add(this.Ticker);
            this.portfolioOLV.AllColumns.Add(this.Sedol1);
            this.portfolioOLV.AllColumns.Add(this.Exchange);
            this.portfolioOLV.AllColumns.Add(this.InstrumentName);
            this.portfolioOLV.AllColumns.Add(this.InstrumentType);
            this.portfolioOLV.AllColumns.Add(this.PriceMid);
            this.portfolioOLV.AllColumns.Add(this.PriceBid);
            this.portfolioOLV.AllColumns.Add(this.PriceAsk);
            this.portfolioOLV.AllColumns.Add(this.PriceLast);
            this.portfolioOLV.AllColumns.Add(this.PriceNAV);
            this.portfolioOLV.AllColumns.Add(this.PriceCurrencyID);
            this.portfolioOLV.AllColumns.Add(this.PriceFactor);
            this.portfolioOLV.AllColumns.Add(this.DivGross);
            this.portfolioOLV.AllColumns.Add(this.DivCurrencyID);
            this.portfolioOLV.AllColumns.Add(this.DivFactor);
            this.portfolioOLV.AllColumns.Add(this.FixedParAmount);
            this.portfolioOLV.AllColumns.Add(this.FixedParValue);
            this.portfolioOLV.AllColumns.Add(this.FixedCoupon);
            this.portfolioOLV.AllColumns.Add(this.FixedAccuredInterest);
            this.portfolioOLV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.portfolioOLV.CellEditUseWholeCell = false;
            this.portfolioOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.InstrumentID,
            this.InstrumentDate,
            this.ISIN,
            this.Ticker,
            this.Sedol1,
            this.Exchange,
            this.InstrumentName,
            this.InstrumentType,
            this.PriceMid,
            this.PriceBid,
            this.PriceAsk,
            this.PriceLast,
            this.PriceNAV,
            this.PriceCurrencyID,
            this.PriceFactor,
            this.DivGross,
            this.DivCurrencyID,
            this.DivFactor,
            this.FixedParAmount,
            this.FixedParValue,
            this.FixedCoupon,
            this.FixedAccuredInterest});
            this.portfolioOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.portfolioOLV.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.portfolioOLV.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.portfolioOLV.Location = new System.Drawing.Point(12, 187);
            this.portfolioOLV.Name = "portfolioOLV";
            this.portfolioOLV.Size = new System.Drawing.Size(919, 459);
            this.portfolioOLV.TabIndex = 1;
            this.portfolioOLV.UseCompatibleStateImageBehavior = false;
            this.portfolioOLV.View = System.Windows.Forms.View.Details;
            this.portfolioOLV.SelectedIndexChanged += new System.EventHandler(this.portfolioOLV_SelectedIndexChanged);
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
            this.showOldCheck.Location = new System.Drawing.Point(771, 12);
            this.showOldCheck.Name = "showOldCheck";
            this.showOldCheck.Size = new System.Drawing.Size(160, 24);
            this.showOldCheck.TabIndex = 7;
            this.showOldCheck.Text = "Show Old Records";
            this.showOldCheck.UseVisualStyleBackColor = true;
            // 
            // btnDetailsShow
            // 
            this.btnDetailsShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailsShow.Location = new System.Drawing.Point(802, 73);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date Picker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Range";
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(247, 81);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(200, 20);
            this.toDatePicker.TabIndex = 12;
            // 
            // detailsOLV
            // 
            this.detailsOLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsOLV.CellEditUseWholeCell = false;
            this.detailsOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.detailsOLV.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.detailsOLV.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.detailsOLV.Location = new System.Drawing.Point(953, 31);
            this.detailsOLV.Name = "detailsOLV";
            this.detailsOLV.Size = new System.Drawing.Size(0, 615);
            this.detailsOLV.TabIndex = 13;
            this.detailsOLV.UseCompatibleStateImageBehavior = false;
            this.detailsOLV.View = System.Windows.Forms.View.Details;
            this.detailsOLV.Visible = false;
            // 
            // ID
            // 
            this.ID.AspectName = "";
            this.ID.Text = "ID";
            // 
            // InstrumentID
            // 
            this.InstrumentID.AspectName = "";
            this.InstrumentID.Text = "InstrumentID";
            this.InstrumentID.Width = 76;
            // 
            // InstrumentDate
            // 
            this.InstrumentDate.AspectName = "";
            this.InstrumentDate.Text = "InstrumentDate";
            this.InstrumentDate.Width = 87;
            // 
            // ISIN
            // 
            this.ISIN.AspectName = "";
            this.ISIN.Text = "ISIN";
            // 
            // Ticker
            // 
            this.Ticker.AspectName = "";
            this.Ticker.Text = "Ticker";
            // 
            // Sedol1
            // 
            this.Sedol1.AspectName = "";
            this.Sedol1.Text = "Sedol1";
            // 
            // Exchange
            // 
            this.Exchange.AspectName = "";
            this.Exchange.Text = "Exchange";
            // 
            // InstrumentName
            // 
            this.InstrumentName.Text = "InstrumentName";
            this.InstrumentName.Width = 93;
            // 
            // InstrumentType
            // 
            this.InstrumentType.Text = "InstrumentType";
            this.InstrumentType.Width = 90;
            // 
            // PriceMid
            // 
            this.PriceMid.Text = "PriceMid";
            // 
            // PriceBid
            // 
            this.PriceBid.Text = "PriceBid";
            // 
            // PriceAsk
            // 
            this.PriceAsk.Text = "PriceAsk";
            // 
            // PriceLast
            // 
            this.PriceLast.Text = "PriceLast";
            // 
            // PriceNAV
            // 
            this.PriceNAV.Text = "PriceNAV";
            // 
            // PriceCurrencyID
            // 
            this.PriceCurrencyID.Text = "PriceCurrencyID";
            // 
            // PriceFactor
            // 
            this.PriceFactor.Text = "PriceFactor";
            // 
            // DivGross
            // 
            this.DivGross.Text = "DivGross";
            // 
            // DivCurrencyID
            // 
            this.DivCurrencyID.Text = "DivCurrencyID";
            // 
            // DivFactor
            // 
            this.DivFactor.Text = "DivFactor";
            // 
            // FixedParAmount
            // 
            this.FixedParAmount.Text = "FixedParAmount";
            // 
            // FixedParValue
            // 
            this.FixedParValue.Text = "FixedParValue";
            // 
            // FixedCoupon
            // 
            this.FixedCoupon.Text = "FixedCoupon";
            // 
            // FixedAccuredInterest
            // 
            this.FixedAccuredInterest.Text = "FixedAccuredInterest";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 658);
            this.Controls.Add(this.detailsOLV);
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
            ((System.ComponentModel.ISupportInitialize)(this.detailsOLV)).EndInit();
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
        private BrightIdeasSoftware.ObjectListView detailsOLV;
        private BrightIdeasSoftware.OLVColumn ID;
        private BrightIdeasSoftware.OLVColumn InstrumentID;
        private BrightIdeasSoftware.OLVColumn InstrumentDate;
        private BrightIdeasSoftware.OLVColumn ISIN;
        private BrightIdeasSoftware.OLVColumn Ticker;
        private BrightIdeasSoftware.OLVColumn Sedol1;
        private BrightIdeasSoftware.OLVColumn Exchange;
        private BrightIdeasSoftware.OLVColumn InstrumentName;
        private BrightIdeasSoftware.OLVColumn InstrumentType;
        private BrightIdeasSoftware.OLVColumn PriceMid;
        private BrightIdeasSoftware.OLVColumn PriceBid;
        private BrightIdeasSoftware.OLVColumn PriceAsk;
        private BrightIdeasSoftware.OLVColumn PriceLast;
        private BrightIdeasSoftware.OLVColumn PriceNAV;
        private BrightIdeasSoftware.OLVColumn PriceCurrencyID;
        private BrightIdeasSoftware.OLVColumn PriceFactor;
        private BrightIdeasSoftware.OLVColumn DivGross;
        private BrightIdeasSoftware.OLVColumn DivCurrencyID;
        private BrightIdeasSoftware.OLVColumn DivFactor;
        private BrightIdeasSoftware.OLVColumn FixedParAmount;
        private BrightIdeasSoftware.OLVColumn FixedParValue;
        private BrightIdeasSoftware.OLVColumn FixedCoupon;
        private BrightIdeasSoftware.OLVColumn FixedAccuredInterest;
    }
}

