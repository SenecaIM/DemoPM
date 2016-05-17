namespace Portfolio
{
    partial class Navibar
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
            this.optionsgroupBox = new System.Windows.Forms.GroupBox();
            this.btnInstruments = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.optionsgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsgroupBox
            // 
            this.optionsgroupBox.Controls.Add(this.btnInstruments);
            this.optionsgroupBox.Controls.Add(this.btnClients);
            this.optionsgroupBox.Location = new System.Drawing.Point(4, 3);
            this.optionsgroupBox.Name = "optionsgroupBox";
            this.optionsgroupBox.Size = new System.Drawing.Size(200, 80);
            this.optionsgroupBox.TabIndex = 8;
            this.optionsgroupBox.TabStop = false;
            this.optionsgroupBox.Text = "Portfolio Options";
            this.optionsgroupBox.Enter += new System.EventHandler(this.optionsgroupBox_Enter);
            // 
            // btnInstruments
            // 
            this.btnInstruments.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInstruments.Location = new System.Drawing.Point(17, 50);
            this.btnInstruments.Name = "btnInstruments";
            this.btnInstruments.Size = new System.Drawing.Size(126, 23);
            this.btnInstruments.TabIndex = 1;
            this.btnInstruments.Text = "Show Instruments";
            this.btnInstruments.UseVisualStyleBackColor = false;
            this.btnInstruments.Click += new System.EventHandler(this.btnInstruments_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClients.Location = new System.Drawing.Point(17, 20);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(126, 23);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Show Clients";
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // Navibar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.optionsgroupBox);
            this.Name = "Navibar";
            this.Size = new System.Drawing.Size(207, 87);
            this.optionsgroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox optionsgroupBox;
        private System.Windows.Forms.Button btnInstruments;
        private System.Windows.Forms.Button btnClients;
    }
}
