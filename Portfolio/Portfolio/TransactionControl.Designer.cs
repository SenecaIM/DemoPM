namespace Portfolio
{
    partial class TransactionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionControl));
            this.btnLog = new System.Windows.Forms.Button();
            this.transactionOLV = new BrightIdeasSoftware.ObjectListView();
            this.ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TransactionIDColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.QuantityColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.BookCostColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InstrumentIDColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TransactionDateColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label1 = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.transactionOLV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            this.btnLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLog.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(549, 534);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(109, 62);
            this.btnLog.TabIndex = 18;
            this.btnLog.Text = "Log in a new transaction";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // transactionOLV
            // 
            this.transactionOLV.AllColumns.Add(this.ID);
            this.transactionOLV.AllColumns.Add(this.TransactionIDColumn);
            this.transactionOLV.AllColumns.Add(this.QuantityColumn);
            this.transactionOLV.AllColumns.Add(this.BookCostColumn);
            this.transactionOLV.AllColumns.Add(this.InstrumentIDColumn);
            this.transactionOLV.AllColumns.Add(this.TransactionDateColumn);
            this.transactionOLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionOLV.CellEditUseWholeCell = false;
            this.transactionOLV.CheckBoxes = true;
            this.transactionOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.TransactionIDColumn,
            this.QuantityColumn,
            this.BookCostColumn,
            this.InstrumentIDColumn,
            this.TransactionDateColumn});
            this.transactionOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.transactionOLV.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionOLV.FullRowSelect = true;
            this.transactionOLV.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.transactionOLV.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.transactionOLV.Location = new System.Drawing.Point(0, 53);
            this.transactionOLV.Name = "transactionOLV";
            this.transactionOLV.ShowGroups = false;
            this.transactionOLV.Size = new System.Drawing.Size(655, 478);
            this.transactionOLV.TabIndex = 17;
            this.transactionOLV.UseCompatibleStateImageBehavior = false;
            this.transactionOLV.View = System.Windows.Forms.View.Details;
            this.transactionOLV.SelectedIndexChanged += new System.EventHandler(this.transactionOLV_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // TransactionIDColumn
            // 
            this.TransactionIDColumn.Text = "Transaction ID";
            this.TransactionIDColumn.Width = 121;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.Text = "Quantity";
            this.QuantityColumn.Width = 88;
            // 
            // BookCostColumn
            // 
            this.BookCostColumn.Text = "Book Cost";
            this.BookCostColumn.Width = 101;
            // 
            // InstrumentIDColumn
            // 
            this.InstrumentIDColumn.Text = "Instrument ID";
            this.InstrumentIDColumn.Width = 94;
            // 
            // TransactionDateColumn
            // 
            this.TransactionDateColumn.Text = "Transaction Date";
            this.TransactionDateColumn.Width = 132;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Maximum Date";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDatePicker.Location = new System.Drawing.Point(3, 26);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(200, 21);
            this.fromDatePicker.TabIndex = 19;
            this.fromDatePicker.ValueChanged += new System.EventHandler(this.fromDatePicker_ValueChanged);
            // 
            // TransactionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.transactionOLV);
            this.Name = "TransactionControl";
            this.Size = new System.Drawing.Size(658, 599);
            this.Load += new System.EventHandler(this.TransactionControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionOLV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private BrightIdeasSoftware.ObjectListView transactionOLV;
        private BrightIdeasSoftware.OLVColumn ID;
        private BrightIdeasSoftware.OLVColumn TransactionIDColumn;
        private BrightIdeasSoftware.OLVColumn QuantityColumn;
        private BrightIdeasSoftware.OLVColumn BookCostColumn;
        private BrightIdeasSoftware.OLVColumn InstrumentIDColumn;
        private BrightIdeasSoftware.OLVColumn TransactionDateColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
    }
}
