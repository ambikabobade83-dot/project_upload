namespace HRMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMINSTRATORLOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLOYEELOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.aDMINSTRATORLOGINToolStripMenuItem,
            this.eMPLOYEELOGINToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.aboutUsToolStripMenuItem.Text = "ABOUT US";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // aDMINSTRATORLOGINToolStripMenuItem
            // 
            this.aDMINSTRATORLOGINToolStripMenuItem.Name = "aDMINSTRATORLOGINToolStripMenuItem";
            this.aDMINSTRATORLOGINToolStripMenuItem.Size = new System.Drawing.Size(166, 21);
            this.aDMINSTRATORLOGINToolStripMenuItem.Text = "ADMINSTRATOR LOGIN";
            this.aDMINSTRATORLOGINToolStripMenuItem.Click += new System.EventHandler(this.aDMINSTRATORLOGINToolStripMenuItem_Click);
            // 
            // eMPLOYEELOGINToolStripMenuItem
            // 
            this.eMPLOYEELOGINToolStripMenuItem.Name = "eMPLOYEELOGINToolStripMenuItem";
            this.eMPLOYEELOGINToolStripMenuItem.Size = new System.Drawing.Size(130, 21);
            this.eMPLOYEELOGINToolStripMenuItem.Text = "EMPLOYEE LOGIN";
            this.eMPLOYEELOGINToolStripMenuItem.Click += new System.EventHandler(this.eMPLOYEELOGINToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 368);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMINSTRATORLOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLOYEELOGINToolStripMenuItem;
    }
}

