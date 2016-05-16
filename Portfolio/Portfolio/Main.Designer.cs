namespace Portfolio
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
            this.navibar1 = new Portfolio.Navibar();
            this.btnDetailsShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navibar1
            // 
            this.navibar1.Location = new System.Drawing.Point(13, 13);
            this.navibar1.Name = "navibar1";
            this.navibar1.Size = new System.Drawing.Size(207, 111);
            this.navibar1.TabIndex = 0;
            // 
            // btnDetailsShow
            // 
            this.btnDetailsShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetailsShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailsShow.Location = new System.Drawing.Point(13, 141);
            this.btnDetailsShow.Name = "btnDetailsShow";
            this.btnDetailsShow.Size = new System.Drawing.Size(145, 31);
            this.btnDetailsShow.TabIndex = 20;
            this.btnDetailsShow.Tag = "false";
            this.btnDetailsShow.Text = "Show Details ";
            this.btnDetailsShow.UseVisualStyleBackColor = true;
            this.btnDetailsShow.Click += new System.EventHandler(this.btnDetailsShow_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 674);
            this.Controls.Add(this.btnDetailsShow);
            this.Controls.Add(this.navibar1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Navibar navibar1;
        private System.Windows.Forms.Button btnDetailsShow;
    }
}