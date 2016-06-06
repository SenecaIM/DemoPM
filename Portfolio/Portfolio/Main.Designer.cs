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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnDetailsShow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.navibar1 = new Portfolio.Navibar();
            this.SuspendLayout();
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
            this.btnDetailsShow.Location = new System.Drawing.Point(990, 12);
            this.btnDetailsShow.Name = "btnDetailsShow";
            this.btnDetailsShow.Size = new System.Drawing.Size(161, 46);
            this.btnDetailsShow.TabIndex = 20;
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
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 483);
            this.panel1.TabIndex = 21;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.BackColor = System.Drawing.Color.DeepPink;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(990, 77);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(161, 46);
            this.btnHelp.TabIndex = 23;
            this.btnHelp.Tag = "false";
            this.btnHelp.Text = "I need help";
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // navibar1
            // 
            this.navibar1.BackColor = System.Drawing.Color.SteelBlue;
            this.navibar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("navibar1.BackgroundImage")));
            this.navibar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navibar1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navibar1.Location = new System.Drawing.Point(12, 12);
            this.navibar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navibar1.Name = "navibar1";
            this.navibar1.Size = new System.Drawing.Size(277, 152);
            this.navibar1.TabIndex = 22;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1163, 674);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.navibar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDetailsShow);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDetailsShow;
        private System.Windows.Forms.Panel panel1;
        private Navibar navibar1;
        private System.Windows.Forms.Button btnHelp;
    }
}