namespace FlowDesigner
{
    partial class FlowChartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlowChartForm));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btn_arrow = new System.Windows.Forms.ToolStripButton();
            this.btn_sequence = new System.Windows.Forms.ToolStripButton();
            this.btn_loop = new System.Windows.Forms.ToolStripButton();
            this.btn_if = new System.Windows.Forms.ToolStripButton();
            this.btn_switch = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.graphControl = new Netron.GraphLib.UI.GraphControl();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStripContainer2.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(48, 398);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(48, 398);
            this.toolStripContainer.TabIndex = 1;
            this.toolStripContainer.Text = "toolStripContainer1";
            this.toolStripContainer.TopToolStripPanelVisible = false;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_arrow,
            this.btn_sequence,
            this.btn_loop,
            this.btn_if,
            this.btn_switch});
            this.toolStrip.Location = new System.Drawing.Point(0, 3);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(37, 206);
            this.toolStrip.TabIndex = 0;
            // 
            // btn_arrow
            // 
            this.btn_arrow.Checked = true;
            this.btn_arrow.CheckOnClick = true;
            this.btn_arrow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_arrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_arrow.Image = ((System.Drawing.Image)(resources.GetObject("btn_arrow.Image")));
            this.btn_arrow.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btn_arrow.Name = "btn_arrow";
            this.btn_arrow.Size = new System.Drawing.Size(35, 36);
            this.btn_arrow.Text = "toolStripButton1";
            this.btn_arrow.ToolTipText = "箭头工具";
            // 
            // btn_sequence
            // 
            this.btn_sequence.CheckOnClick = true;
            this.btn_sequence.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_sequence.Image = ((System.Drawing.Image)(resources.GetObject("btn_sequence.Image")));
            this.btn_sequence.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btn_sequence.Name = "btn_sequence";
            this.btn_sequence.Size = new System.Drawing.Size(35, 36);
            this.btn_sequence.Text = "toolStripButton2";
            this.btn_sequence.ToolTipText = "顺序结构";
            this.btn_sequence.Click += new System.EventHandler(this.btn_sequence_Click);
            // 
            // btn_loop
            // 
            this.btn_loop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_loop.Image = ((System.Drawing.Image)(resources.GetObject("btn_loop.Image")));
            this.btn_loop.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btn_loop.Name = "btn_loop";
            this.btn_loop.Size = new System.Drawing.Size(35, 36);
            this.btn_loop.ToolTipText = "循环结构";
            this.btn_loop.Click += new System.EventHandler(this.btn_loop_Click);
            // 
            // btn_if
            // 
            this.btn_if.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_if.Image = ((System.Drawing.Image)(resources.GetObject("btn_if.Image")));
            this.btn_if.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btn_if.Name = "btn_if";
            this.btn_if.Size = new System.Drawing.Size(35, 36);
            this.btn_if.ToolTipText = "判断结构";
            this.btn_if.Click += new System.EventHandler(this.btn_if_Click);
            // 
            // btn_switch
            // 
            this.btn_switch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_switch.Image = ((System.Drawing.Image)(resources.GetObject("btn_switch.Image")));
            this.btn_switch.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(35, 36);
            this.btn_switch.Text = "toolStripButton5";
            this.btn_switch.ToolTipText = "分支结构";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelX);
            this.panel1.Controls.Add(this.labelY);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(48, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 15);
            this.panel1.TabIndex = 3;
            // 
            // labelX
            // 
            this.labelX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX.Location = new System.Drawing.Point(226, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(80, 15);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X :";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelY
            // 
            this.labelY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelY.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelY.Location = new System.Drawing.Point(306, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(80, 15);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "Y :";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is a testThis is a testThis is a testThis is a testThis is a test";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // graphControl
            // 
            this.graphControl.AllowAddConnection = true;
            this.graphControl.AllowAddShape = true;
            this.graphControl.AllowDeleteShape = true;
            this.graphControl.AllowDrop = true;
            this.graphControl.AllowMoveShape = true;
            this.graphControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphControl.AutomataPulse = 10;
            this.graphControl.AutoScroll = true;
            this.graphControl.BackgroundColor = System.Drawing.Color.White;
            this.graphControl.BackgroundImagePath = null;
            this.graphControl.BackgroundType = Netron.GraphLib.CanvasBackgroundType.FlatColor;
            this.graphControl.DefaultConnectionEnd = Netron.GraphLib.ConnectionEnd.NoEnds;
            this.graphControl.DefaultConnectionPath = "Default";
            this.graphControl.DoTrack = false;
            this.graphControl.EnableContextMenu = true;
            this.graphControl.EnableLayout = false;
            this.graphControl.EnableToolTip = true;
            this.graphControl.FileName = null;
            this.graphControl.GradientBottom = System.Drawing.Color.White;
            this.graphControl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.graphControl.GradientTop = System.Drawing.Color.LightSteelBlue;
            this.graphControl.GraphLayoutAlgorithm = Netron.GraphLib.GraphLayoutAlgorithms.SpringEmbedder;
            this.graphControl.GridSize = 20;
            this.graphControl.Location = new System.Drawing.Point(40, 0);
            this.graphControl.Name = "graphControl";
            this.graphControl.RestrictToCanvas = true;
            this.graphControl.ShowAutomataController = false;
            this.graphControl.ShowGrid = false;
            this.graphControl.Size = new System.Drawing.Size(396, 362);
            this.graphControl.Snap = false;
            this.graphControl.TabIndex = 0;
            this.graphControl.Text = "graphControl1";
            this.graphControl.Zoom = 1F;
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(3, 373);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Left;
            // 
            // toolStripContainer2.LeftToolStripPanel
            // 
            this.toolStripContainer2.LeftToolStripPanel.Controls.Add(this.toolStrip);
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(40, 398);
            this.toolStripContainer2.TabIndex = 2;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // FlowChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 398);
            this.Controls.Add(this.toolStripContainer2);
            this.Controls.Add(this.graphControl);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FlowChartForm";
            this.Text = "流程图";
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolStripContainer2.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStripButton btn_arrow;
        private System.Windows.Forms.ToolStripButton btn_sequence;
        private System.Windows.Forms.ToolStripButton btn_loop;
        private System.Windows.Forms.ToolStripButton btn_if;
        private System.Windows.Forms.ToolStripButton btn_switch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX;
        private Netron.GraphLib.UI.GraphControl graphControl;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
    }
}