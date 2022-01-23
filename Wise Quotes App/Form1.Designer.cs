namespace Wise_Quotes_App
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
            this.components = new System.ComponentModel.Container();
            this.lblquotes = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trsnsparentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.secToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.setWallpaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qoutes_timer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblquotes
            // 
            this.lblquotes.BackColor = System.Drawing.Color.Black;
            this.lblquotes.ContextMenuStrip = this.contextMenuStrip;
            this.lblquotes.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquotes.ForeColor = System.Drawing.Color.White;
            this.lblquotes.Location = new System.Drawing.Point(17, 64);
            this.lblquotes.Name = "lblquotes";
            this.lblquotes.Size = new System.Drawing.Size(255, 88);
            this.lblquotes.TabIndex = 1;
            this.lblquotes.Text = "Jesus Christ is lord";
            this.lblquotes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblquotes_MouseDown);
            this.lblquotes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblquotes_MouseMove);
            this.lblquotes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblquotes_MouseUp);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colourToolStripMenuItem,
            this.trsnsparentToolStripMenuItem,
            this.timerToolStripMenuItem,
            this.setWallpaperToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(159, 180);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.colourToolStripMenuItem.Text = "Colour";
            // 
            // trsnsparentToolStripMenuItem
            // 
            this.trsnsparentToolStripMenuItem.Name = "trsnsparentToolStripMenuItem";
            this.trsnsparentToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.trsnsparentToolStripMenuItem.Text = "Trsnsparent";
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.offToolStripMenuItem,
            this.secToolStripMenuItem,
            this.secToolStripMenuItem1,
            this.secToolStripMenuItem2,
            this.minToolStripMenuItem,
            this.minToolStripMenuItem1,
            this.minToolStripMenuItem2});
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.timerToolStripMenuItem.Text = "Timer";
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.offToolStripMenuItem.Text = "Off";
            // 
            // secToolStripMenuItem
            // 
            this.secToolStripMenuItem.Name = "secToolStripMenuItem";
            this.secToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.secToolStripMenuItem.Text = "5 sec";
            // 
            // secToolStripMenuItem1
            // 
            this.secToolStripMenuItem1.Name = "secToolStripMenuItem1";
            this.secToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.secToolStripMenuItem1.Text = "15 Sec";
            // 
            // secToolStripMenuItem2
            // 
            this.secToolStripMenuItem2.Name = "secToolStripMenuItem2";
            this.secToolStripMenuItem2.Size = new System.Drawing.Size(115, 22);
            this.secToolStripMenuItem2.Text = "30 Sec";
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.minToolStripMenuItem.Text = "1 min";
            // 
            // minToolStripMenuItem1
            // 
            this.minToolStripMenuItem1.Name = "minToolStripMenuItem1";
            this.minToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.minToolStripMenuItem1.Text = "5 min";
            // 
            // minToolStripMenuItem2
            // 
            this.minToolStripMenuItem2.Name = "minToolStripMenuItem2";
            this.minToolStripMenuItem2.Size = new System.Drawing.Size(115, 22);
            this.minToolStripMenuItem2.Text = "15 min";
            // 
            // setWallpaperToolStripMenuItem
            // 
            this.setWallpaperToolStripMenuItem.Name = "setWallpaperToolStripMenuItem";
            this.setWallpaperToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.setWallpaperToolStripMenuItem.Text = "Set Wallpaper";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // qoutes_timer
            // 
            this.qoutes_timer.Enabled = true;
            this.qoutes_timer.Interval = 1500;
            this.qoutes_timer.Tick += new System.EventHandler(this.qoutes_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.lblquotes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblquotes;
        private System.Windows.Forms.Timer qoutes_timer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trsnsparentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setWallpaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem secToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem2;
    }
}

