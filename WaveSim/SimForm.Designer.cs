namespace WaveSim
{
    partial class SimForm
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
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.l_mouseinfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetElongationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetMassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationResolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCbSimResolution = new System.Windows.Forms.ToolStripComboBox();
            this.mouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCbMouseAction = new System.Windows.Forms.ToolStripComboBox();
            this.valueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCbMouseValue = new System.Windows.Forms.ToolStripComboBox();
            this.editSimulationParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_image
            // 
            this.pb_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_image.Location = new System.Drawing.Point(12, 27);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(924, 528);
            this.pb_image.TabIndex = 18;
            this.pb_image.TabStop = false;
            this.pb_image.Click += new System.EventHandler(this.pb_image_Click);
            this.pb_image.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_image_MouseClick);
            this.pb_image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_image_MouseDown);
            this.pb_image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_image_MouseMove);
            this.pb_image.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_image_MouseUp);
            this.pb_image.Resize += new System.EventHandler(this.pb_image_Resize);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.l_mouseinfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 558);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(948, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // l_mouseinfo
            // 
            this.l_mouseinfo.Name = "l_mouseinfo";
            this.l_mouseinfo.Size = new System.Drawing.Size(177, 17);
            this.l_mouseinfo.Text = "[0|0] Elongation: 0.0 Velocity: 0.0";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "NewSimulation.was";
            this.saveFileDialog.Filter = "WaveSimulation|*.was|All files|*.*";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "WaveSimulation|*.was|All files|*.*";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.simulationToolStripMenuItem,
            this.visualisationToolStripMenuItem,
            this.mouseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stepToolStripMenuItem,
            this.editSimulationParametersToolStripMenuItem});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetAllToolStripMenuItem,
            this.resetElongationToolStripMenuItem,
            this.resetMassToolStripMenuItem,
            this.resetSourcesToolStripMenuItem,
            this.resetWallsToolStripMenuItem});
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.resetAllToolStripMenuItem.Text = "Reset all";
            this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.resetAllToolStripMenuItem_Click);
            // 
            // resetElongationToolStripMenuItem
            // 
            this.resetElongationToolStripMenuItem.Name = "resetElongationToolStripMenuItem";
            this.resetElongationToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.resetElongationToolStripMenuItem.Text = "Reset Elongation";
            this.resetElongationToolStripMenuItem.Click += new System.EventHandler(this.resetElongationToolStripMenuItem_Click);
            // 
            // resetMassToolStripMenuItem
            // 
            this.resetMassToolStripMenuItem.Name = "resetMassToolStripMenuItem";
            this.resetMassToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.resetMassToolStripMenuItem.Text = "Reset Mass";
            this.resetMassToolStripMenuItem.Click += new System.EventHandler(this.resetMassToolStripMenuItem_Click);
            // 
            // resetSourcesToolStripMenuItem
            // 
            this.resetSourcesToolStripMenuItem.Name = "resetSourcesToolStripMenuItem";
            this.resetSourcesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.resetSourcesToolStripMenuItem.Text = "Reset Sources";
            this.resetSourcesToolStripMenuItem.Click += new System.EventHandler(this.resetSourcesToolStripMenuItem_Click);
            // 
            // resetWallsToolStripMenuItem
            // 
            this.resetWallsToolStripMenuItem.Name = "resetWallsToolStripMenuItem";
            this.resetWallsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.resetWallsToolStripMenuItem.Text = "Reset Walls";
            this.resetWallsToolStripMenuItem.Click += new System.EventHandler(this.resetWallsToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // stepToolStripMenuItem
            // 
            this.stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            this.stepToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.stepToolStripMenuItem.Text = "Step";
            this.stepToolStripMenuItem.Click += new System.EventHandler(this.stepToolStripMenuItem_Click);
            // 
            // visualisationToolStripMenuItem
            // 
            this.visualisationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulationResolutionToolStripMenuItem,
            this.editColorsToolStripMenuItem});
            this.visualisationToolStripMenuItem.Name = "visualisationToolStripMenuItem";
            this.visualisationToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.visualisationToolStripMenuItem.Text = "Visualisation";
            // 
            // simulationResolutionToolStripMenuItem
            // 
            this.simulationResolutionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCbSimResolution});
            this.simulationResolutionToolStripMenuItem.Name = "simulationResolutionToolStripMenuItem";
            this.simulationResolutionToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.simulationResolutionToolStripMenuItem.Text = "Simulation Resolution";
            // 
            // tsCbSimResolution
            // 
            this.tsCbSimResolution.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.tsCbSimResolution.Name = "tsCbSimResolution";
            this.tsCbSimResolution.Size = new System.Drawing.Size(121, 23);
            this.tsCbSimResolution.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // mouseToolStripMenuItem
            // 
            this.mouseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionTypeToolStripMenuItem,
            this.valueToolStripMenuItem});
            this.mouseToolStripMenuItem.Name = "mouseToolStripMenuItem";
            this.mouseToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.mouseToolStripMenuItem.Text = "Mouse";
            // 
            // actionTypeToolStripMenuItem
            // 
            this.actionTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCbMouseAction});
            this.actionTypeToolStripMenuItem.Name = "actionTypeToolStripMenuItem";
            this.actionTypeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.actionTypeToolStripMenuItem.Text = "Action Type";
            // 
            // tsCbMouseAction
            // 
            this.tsCbMouseAction.Items.AddRange(new object[] {
            "Poke (Amplitude)",
            "Set Wall",
            "Remove Wall",
            "Set Mass",
            "Clear Mass",
            "Create WaveSource"});
            this.tsCbMouseAction.Name = "tsCbMouseAction";
            this.tsCbMouseAction.Size = new System.Drawing.Size(121, 23);
            // 
            // valueToolStripMenuItem
            // 
            this.valueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCbMouseValue});
            this.valueToolStripMenuItem.Name = "valueToolStripMenuItem";
            this.valueToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.valueToolStripMenuItem.Text = "Value";
            // 
            // tsCbMouseValue
            // 
            this.tsCbMouseValue.Items.AddRange(new object[] {
            "0",
            "0.25",
            "0.5",
            "0.75",
            "1",
            "1.25",
            "1.5",
            "1.75",
            "2",
            "2.5",
            "3",
            "5",
            "10"});
            this.tsCbMouseValue.Name = "tsCbMouseValue";
            this.tsCbMouseValue.Size = new System.Drawing.Size(121, 23);
            // 
            // editSimulationParametersToolStripMenuItem
            // 
            this.editSimulationParametersToolStripMenuItem.Name = "editSimulationParametersToolStripMenuItem";
            this.editSimulationParametersToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.editSimulationParametersToolStripMenuItem.Text = "Edit Simulation Parameters";
            this.editSimulationParametersToolStripMenuItem.Click += new System.EventHandler(this.editSimulationParametersToolStripMenuItem_Click);
            // 
            // editColorsToolStripMenuItem
            // 
            this.editColorsToolStripMenuItem.Name = "editColorsToolStripMenuItem";
            this.editColorsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.editColorsToolStripMenuItem.Text = "Edit Colors";
            this.editColorsToolStripMenuItem.Click += new System.EventHandler(this.editColorsToolStripMenuItem_Click);
            // 
            // SimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 580);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pb_image);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SimForm";
            this.Text = "WaveSim 1.2.0 - (c) 2012 Arthur Silber";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.SimForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.SimForm_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel l_mouseinfo;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetElongationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetMassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetWallsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualisationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationResolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tsCbSimResolution;
        private System.Windows.Forms.ToolStripMenuItem mouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tsCbMouseAction;
        private System.Windows.Forms.ToolStripMenuItem valueToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tsCbMouseValue;
        private System.Windows.Forms.ToolStripMenuItem editSimulationParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editColorsToolStripMenuItem;
    }
}

