namespace Portfolio
{
    partial class PortfolioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortfolioForm));
            this.navibar1 = new Portfolio.Navibar();
            this.btnDetailsShow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navibar1
            // 
            this.navibar1.BackColor = System.Drawing.Color.SteelBlue;
            this.navibar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("navibar1.BackgroundImage")));
            this.navibar1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navibar1.Location = new System.Drawing.Point(15, 13);
            this.navibar1.Name = "navibar1";
            this.navibar1.Size = new System.Drawing.Size(278, 107);
            this.navibar1.TabIndex = 0;
            // 
            // btnDetailsShow
            // 
            this.btnDetailsShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetailsShow.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDetailsShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDetailsShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailsShow.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailsShow.Image = ((System.Drawing.Image)(resources.GetObject("btnDetailsShow.Image")));
            this.btnDetailsShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailsShow.Location = new System.Drawing.Point(672, 12);
            this.btnDetailsShow.Name = "btnDetailsShow";
            this.btnDetailsShow.Size = new System.Drawing.Size(161, 46);
            this.btnDetailsShow.TabIndex = 21;
            this.btnDetailsShow.Tag = "false";
            this.btnDetailsShow.Text = "Show Details ";
            this.btnDetailsShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetailsShow.UseVisualStyleBackColor = false;
            this.btnDetailsShow.Click += new System.EventHandler(this.btnDetailsShow_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.objectListView1);
            this.panel1.Location = new System.Drawing.Point(12, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 414);
            this.panel1.TabIndex = 22;
            this.panel1.Visible = false;
            // 
            // objectListView1
            // 
            this.objectListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.objectListView1.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.objectListView1.Location = new System.Drawing.Point(3, 3);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(815, 408);
            this.objectListView1.TabIndex = 0;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // PortfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(845, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDetailsShow);
            this.Controls.Add(this.navibar1);
            this.Name = "PortfolioForm";
            this.Text = "Portfolio Control";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Navibar navibar1;
        private System.Windows.Forms.Button btnDetailsShow;
        private System.Windows.Forms.Panel panel1;
        private BrightIdeasSoftware.ObjectListView objectListView1;
    }
}