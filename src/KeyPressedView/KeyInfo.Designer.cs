
namespace KeyPressedView
{
    partial class KeyInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyInfo));
            this.notifyIconM = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItem_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSetStart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCancelStart = new System.Windows.Forms.ToolStripMenuItem();
            this.label = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconM
            // 
            this.notifyIconM.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconM.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconM.Icon")));
            this.notifyIconM.Text = "喵~";
            this.notifyIconM.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Quit,
            this.menuItemSetStart,
            this.menuItemCancelStart});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 70);
            // 
            // menuItem_Quit
            // 
            this.menuItem_Quit.Name = "menuItem_Quit";
            this.menuItem_Quit.Size = new System.Drawing.Size(148, 22);
            this.menuItem_Quit.Text = "退出";
            this.menuItem_Quit.Click += new System.EventHandler(this.menuItem_Quit_Click);
            // 
            // menuItemSetStart
            // 
            this.menuItemSetStart.Name = "menuItemSetStart";
            this.menuItemSetStart.Size = new System.Drawing.Size(148, 22);
            this.menuItemSetStart.Text = "打开开机自启";
            this.menuItemSetStart.Click += new System.EventHandler(this.menuItemSetStart_Click);
            // 
            // menuItemCancelStart
            // 
            this.menuItemCancelStart.Name = "menuItemCancelStart";
            this.menuItemCancelStart.Size = new System.Drawing.Size(148, 22);
            this.menuItemCancelStart.Text = "取消开机自启";
            this.menuItemCancelStart.Click += new System.EventHandler(this.menuItemCancelStart_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Margin = new System.Windows.Forms.Padding(0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(91, 46);
            this.label.TabIndex = 0;
            this.label.Text = "Text";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KeyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 60);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeyInfo";
            this.Opacity = 0.5D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconM;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Quit;
        private System.Windows.Forms.ToolStripMenuItem menuItemSetStart;
        private System.Windows.Forms.ToolStripMenuItem menuItemCancelStart;
    }
}
