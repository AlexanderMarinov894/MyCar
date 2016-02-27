namespace MyCar.Forms
{
    partial class BaseForm
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
            this.BaseMenu = new System.Windows.Forms.MenuStrip();
            this.myCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseMenu
            // 
            this.BaseMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myCarToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.BaseMenu.Location = new System.Drawing.Point(0, 0);
            this.BaseMenu.Name = "BaseMenu";
            this.BaseMenu.Size = new System.Drawing.Size(284, 24);
            this.BaseMenu.TabIndex = 0;
            this.BaseMenu.Text = "BaseMenu";
            // 
            // myCarToolStripMenuItem
            // 
            this.myCarToolStripMenuItem.Name = "myCarToolStripMenuItem";
            this.myCarToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.myCarToolStripMenuItem.Text = "Open";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BaseMenu);
            this.MainMenuStrip = this.BaseMenu;
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.BaseMenu.ResumeLayout(false);
            this.BaseMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BaseMenu;
        private System.Windows.Forms.ToolStripMenuItem myCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}