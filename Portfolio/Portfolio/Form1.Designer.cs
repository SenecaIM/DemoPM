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
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.detailsOLV = new BrightIdeasSoftware.ObjectListView();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioOLV)).BeginInit();
            this.optionsgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsOLV)).BeginInit();
            this.SuspendLayout();
            // 
            // portfolioOLV
            // 
            this.portfolioOLV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.portfolioOLV.CellEditUseWholeCell = false;
            this.portfolioOLV.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.portfolioOLV.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.portfolioOLV.Location = new System.Drawing.Point(12, 187);
            this.portfolioOLV.Name = "portfolioOLV";
            this.portfolioOLV.Size = new System.Drawing.Size(919, 459);
            this.portfolioOLV.TabIndex = 1;
            this.portfolioOLV.UseCompatibleStateImageBehavior = false;
            this.portfolioOLV.View = System.Windows.Forms.View.Details;
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
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(771, 12);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(160, 24);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "Show Old Records";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Location = new System.Drawing.Point(786, 110);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(145, 47);
            this.btnDetails.TabIndex = 8;
            this.btnDetails.Text = "Show/Hide Details ";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(247, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Range";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(247, 81);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // detailsOLV
            // 
            this.detailsOLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsOLV.CellEditUseWholeCell = false;
            this.detailsOLV.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.detailsOLV.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.detailsOLV.Location = new System.Drawing.Point(953, 31);
            this.detailsOLV.Name = "detailsOLV";
            this.detailsOLV.Size = new System.Drawing.Size(195, 615);
            this.detailsOLV.TabIndex = 13;
            this.detailsOLV.UseCompatibleStateImageBehavior = false;
            this.detailsOLV.View = System.Windows.Forms.View.Details;
            this.detailsOLV.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 658);
            this.Controls.Add(this.detailsOLV);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.optionsgroupBox);
            this.Controls.Add(this.portfolioOLV);
            this.Name = "Form1";
            this.Text = "Portfolio";
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
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private BrightIdeasSoftware.ObjectListView detailsOLV;
    }
}

