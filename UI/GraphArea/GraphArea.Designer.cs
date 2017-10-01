namespace UI.GraphArea
{
    partial class GraphArea
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphArea));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.drawingArea = new System.Windows.Forms.Panel();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.constPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caTiFiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apTiFiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuTiFiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcGenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcGenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clockGenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.drawingArea.SuspendLayout();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(853, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // drawingArea
            // 
            this.drawingArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("drawingArea.BackgroundImage")));
            this.drawingArea.ContextMenuStrip = this.ctxMenu;
            this.drawingArea.Controls.Add(this.vScrollBar);
            this.drawingArea.Controls.Add(this.hScrollBar);
            this.drawingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingArea.Location = new System.Drawing.Point(0, 0);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(853, 557);
            this.drawingArea.TabIndex = 1;
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOperationToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(151, 48);
            // 
            // addOperationToolStripMenuItem
            // 
            this.addOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberGeneratorToolStripMenuItem,
            this.patternToolStripMenuItem,
            this.timeFiltersToolStripMenuItem,
            this.functionToolStripMenuItem,
            this.clocksToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.addOperationToolStripMenuItem.Name = "addOperationToolStripMenuItem";
            this.addOperationToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addOperationToolStripMenuItem.Text = "Add operation";
            // 
            // numberGeneratorToolStripMenuItem
            // 
            this.numberGeneratorToolStripMenuItem.Name = "numberGeneratorToolStripMenuItem";
            this.numberGeneratorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.numberGeneratorToolStripMenuItem.Text = "Number generator";
            this.numberGeneratorToolStripMenuItem.Click += new System.EventHandler(this.AddOperationClick);
            // 
            // patternToolStripMenuItem
            // 
            this.patternToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.constPatternToolStripMenuItem,
            this.randomToolStripMenuItem});
            this.patternToolStripMenuItem.Name = "patternToolStripMenuItem";
            this.patternToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.patternToolStripMenuItem.Text = "Pattern";
            // 
            // constPatternToolStripMenuItem
            // 
            this.constPatternToolStripMenuItem.Name = "constPatternToolStripMenuItem";
            this.constPatternToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.constPatternToolStripMenuItem.Text = "Const";
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.randomToolStripMenuItem.Text = "Random";
            // 
            // timeFiltersToolStripMenuItem
            // 
            this.timeFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caTiFiToolStripMenuItem,
            this.apTiFiToolStripMenuItem,
            this.cuTiFiToolStripMenuItem});
            this.timeFiltersToolStripMenuItem.Name = "timeFiltersToolStripMenuItem";
            this.timeFiltersToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.timeFiltersToolStripMenuItem.Text = "Time Filters";
            // 
            // caTiFiToolStripMenuItem
            // 
            this.caTiFiToolStripMenuItem.Name = "caTiFiToolStripMenuItem";
            this.caTiFiToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.caTiFiToolStripMenuItem.Text = "CaTiFi";
            // 
            // apTiFiToolStripMenuItem
            // 
            this.apTiFiToolStripMenuItem.Name = "apTiFiToolStripMenuItem";
            this.apTiFiToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.apTiFiToolStripMenuItem.Text = "ApTiFi";
            // 
            // cuTiFiToolStripMenuItem
            // 
            this.cuTiFiToolStripMenuItem.Name = "cuTiFiToolStripMenuItem";
            this.cuTiFiToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.cuTiFiToolStripMenuItem.Text = "CuTiFi";
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcGenToolStripMenuItem,
            this.funcGenToolStripMenuItem1});
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.functionToolStripMenuItem.Text = "Function";
            // 
            // funcGenToolStripMenuItem
            // 
            this.funcGenToolStripMenuItem.Name = "funcGenToolStripMenuItem";
            this.funcGenToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.funcGenToolStripMenuItem.Text = "Func";
            // 
            // funcGenToolStripMenuItem1
            // 
            this.funcGenToolStripMenuItem1.Name = "funcGenToolStripMenuItem1";
            this.funcGenToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.funcGenToolStripMenuItem1.Text = "FuncGen";
            // 
            // clocksToolStripMenuItem
            // 
            this.clocksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clockToolStripMenuItem,
            this.clockGenToolStripMenuItem});
            this.clocksToolStripMenuItem.Name = "clocksToolStripMenuItem";
            this.clocksToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.clocksToolStripMenuItem.Text = "Clocks";
            // 
            // clockToolStripMenuItem
            // 
            this.clockToolStripMenuItem.Name = "clockToolStripMenuItem";
            this.clockToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.clockToolStripMenuItem.Text = "Clock";
            // 
            // clockGenToolStripMenuItem
            // 
            this.clockGenToolStripMenuItem.Name = "clockGenToolStripMenuItem";
            this.clockGenToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.clockGenToolStripMenuItem.Text = "ClockGen";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // vScrollBar
            // 
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar.Location = new System.Drawing.Point(836, 0);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(17, 540);
            this.vScrollBar.TabIndex = 1;
            this.vScrollBar.Value = 45;
            // 
            // hScrollBar
            // 
            this.hScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar.Location = new System.Drawing.Point(0, 540);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(853, 17);
            this.hScrollBar.TabIndex = 0;
            this.hScrollBar.Value = 45;
            // 
            // GraphArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drawingArea);
            this.Controls.Add(this.statusStrip1);
            this.Name = "GraphArea";
            this.Size = new System.Drawing.Size(853, 579);
            this.drawingArea.ResumeLayout(false);
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel drawingArea;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem addOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem constPatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caTiFiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apTiFiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuTiFiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcGenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcGenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clockGenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
