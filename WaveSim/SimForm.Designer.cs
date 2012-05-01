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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_set = new System.Windows.Forms.Button();
            this.txt_energieerhaltung = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_fps = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_deltat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dteilchen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_masse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_distanz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dkopplung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_reset = new System.Windows.Forms.Button();
            this.b_pause = new System.Windows.Forms.Button();
            this.b_step = new System.Windows.Forms.Button();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_mausaction = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.l_mouseinfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_wert = new System.Windows.Forms.ComboBox();
            this.cb_resDiv = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.b_resetElong = new System.Windows.Forms.Button();
            this.b_resetMass = new System.Windows.Forms.Button();
            this.b_resetSources = new System.Windows.Forms.Button();
            this.b_resetWalls = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_scale = new System.Windows.Forms.Button();
            this.p_colorMass = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.p_colWall = new System.Windows.Forms.Panel();
            this.p_colMin = new System.Windows.Forms.Panel();
            this.p_colNull = new System.Windows.Forms.Panel();
            this.p_colMax = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.b_save = new System.Windows.Forms.Button();
            this.b_load = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_set);
            this.groupBox1.Controls.Add(this.txt_energieerhaltung);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_fps);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_deltat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_dteilchen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_masse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_distanz);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_dkopplung);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulation Settings";
            // 
            // b_set
            // 
            this.b_set.Location = new System.Drawing.Point(106, 204);
            this.b_set.Name = "b_set";
            this.b_set.Size = new System.Drawing.Size(77, 25);
            this.b_set.TabIndex = 14;
            this.b_set.Text = "set";
            this.b_set.UseVisualStyleBackColor = true;
            this.b_set.Click += new System.EventHandler(this.b_set_Click);
            // 
            // txt_energieerhaltung
            // 
            this.txt_energieerhaltung.Location = new System.Drawing.Point(78, 178);
            this.txt_energieerhaltung.Name = "txt_energieerhaltung";
            this.txt_energieerhaltung.Size = new System.Drawing.Size(105, 20);
            this.txt_energieerhaltung.TabIndex = 13;
            this.txt_energieerhaltung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_energieerhaltung_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Energy %";
            // 
            // txt_fps
            // 
            this.txt_fps.Location = new System.Drawing.Point(78, 152);
            this.txt_fps.Name = "txt_fps";
            this.txt_fps.Size = new System.Drawing.Size(105, 20);
            this.txt_fps.TabIndex = 11;
            this.txt_fps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fps_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "desired FPS:";
            // 
            // txt_deltat
            // 
            this.txt_deltat.Location = new System.Drawing.Point(78, 126);
            this.txt_deltat.Name = "txt_deltat";
            this.txt_deltat.Size = new System.Drawing.Size(105, 20);
            this.txt_deltat.TabIndex = 9;
            this.txt_deltat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_deltat_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Delta T:";
            // 
            // txt_dteilchen
            // 
            this.txt_dteilchen.Location = new System.Drawing.Point(78, 100);
            this.txt_dteilchen.Name = "txt_dteilchen";
            this.txt_dteilchen.Size = new System.Drawing.Size(105, 20);
            this.txt_dteilchen.TabIndex = 7;
            this.txt_dteilchen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dteilchen_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "D Element:";
            // 
            // txt_masse
            // 
            this.txt_masse.Location = new System.Drawing.Point(78, 74);
            this.txt_masse.Name = "txt_masse";
            this.txt_masse.Size = new System.Drawing.Size(105, 20);
            this.txt_masse.TabIndex = 5;
            this.txt_masse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_masse_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mass:";
            // 
            // txt_distanz
            // 
            this.txt_distanz.Location = new System.Drawing.Point(78, 48);
            this.txt_distanz.Name = "txt_distanz";
            this.txt_distanz.Size = new System.Drawing.Size(105, 20);
            this.txt_distanz.TabIndex = 3;
            this.txt_distanz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_distanz_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Distance:";
            // 
            // txt_dkopplung
            // 
            this.txt_dkopplung.Location = new System.Drawing.Point(78, 22);
            this.txt_dkopplung.Name = "txt_dkopplung";
            this.txt_dkopplung.Size = new System.Drawing.Size(105, 20);
            this.txt_dkopplung.TabIndex = 1;
            this.txt_dkopplung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dkopplung_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "D Kopplung:";
            // 
            // b_reset
            // 
            this.b_reset.Location = new System.Drawing.Point(21, 256);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(174, 25);
            this.b_reset.TabIndex = 15;
            this.b_reset.Text = "Reset Simulation";
            this.b_reset.UseVisualStyleBackColor = true;
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // b_pause
            // 
            this.b_pause.Location = new System.Drawing.Point(21, 319);
            this.b_pause.Name = "b_pause";
            this.b_pause.Size = new System.Drawing.Size(174, 25);
            this.b_pause.TabIndex = 16;
            this.b_pause.Text = "Pause";
            this.b_pause.UseVisualStyleBackColor = true;
            this.b_pause.Click += new System.EventHandler(this.b_pause_Click);
            // 
            // b_step
            // 
            this.b_step.Location = new System.Drawing.Point(21, 350);
            this.b_step.Name = "b_step";
            this.b_step.Size = new System.Drawing.Size(174, 25);
            this.b_step.TabIndex = 17;
            this.b_step.Text = "Step";
            this.b_step.UseVisualStyleBackColor = true;
            this.b_step.Click += new System.EventHandler(this.b_step_Click);
            // 
            // pb_image
            // 
            this.pb_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_image.Location = new System.Drawing.Point(218, 12);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(691, 685);
            this.pb_image.TabIndex = 18;
            this.pb_image.TabStop = false;
            this.pb_image.Click += new System.EventHandler(this.pb_image_Click);
            this.pb_image.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_image_MouseClick);
            this.pb_image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_image_MouseDown);
            this.pb_image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_image_MouseMove);
            this.pb_image.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_image_MouseUp);
            this.pb_image.Resize += new System.EventHandler(this.pb_image_Resize);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mouse action:";
            // 
            // cb_mausaction
            // 
            this.cb_mausaction.FormattingEnabled = true;
            this.cb_mausaction.Items.AddRange(new object[] {
            "Poke (Amplitude)",
            "Set Wall",
            "Remove Wall",
            "Set Mass",
            "Clear Mass",
            "Create WaveSource"});
            this.cb_mausaction.Location = new System.Drawing.Point(21, 435);
            this.cb_mausaction.Name = "cb_mausaction";
            this.cb_mausaction.Size = new System.Drawing.Size(135, 21);
            this.cb_mausaction.TabIndex = 20;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.l_mouseinfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(917, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // l_mouseinfo
            // 
            this.l_mouseinfo.Name = "l_mouseinfo";
            this.l_mouseinfo.Size = new System.Drawing.Size(177, 17);
            this.l_mouseinfo.Text = "[0|0] Elongation: 0.0 Velocity: 0.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Value:";
            // 
            // cb_wert
            // 
            this.cb_wert.FormattingEnabled = true;
            this.cb_wert.Items.AddRange(new object[] {
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
            this.cb_wert.Location = new System.Drawing.Point(77, 462);
            this.cb_wert.Name = "cb_wert";
            this.cb_wert.Size = new System.Drawing.Size(77, 21);
            this.cb_wert.TabIndex = 23;
            // 
            // cb_resDiv
            // 
            this.cb_resDiv.FormattingEnabled = true;
            this.cb_resDiv.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cb_resDiv.Location = new System.Drawing.Point(119, 385);
            this.cb_resDiv.Name = "cb_resDiv";
            this.cb_resDiv.Size = new System.Drawing.Size(76, 21);
            this.cb_resDiv.TabIndex = 25;
            this.cb_resDiv.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Resolution Divisor:";
            // 
            // b_resetElong
            // 
            this.b_resetElong.Location = new System.Drawing.Point(22, 283);
            this.b_resetElong.Name = "b_resetElong";
            this.b_resetElong.Size = new System.Drawing.Size(45, 21);
            this.b_resetElong.TabIndex = 26;
            this.b_resetElong.Text = "Elong";
            this.b_resetElong.UseVisualStyleBackColor = true;
            this.b_resetElong.Click += new System.EventHandler(this.b_resetElong_Click);
            // 
            // b_resetMass
            // 
            this.b_resetMass.Location = new System.Drawing.Point(77, 283);
            this.b_resetMass.Name = "b_resetMass";
            this.b_resetMass.Size = new System.Drawing.Size(27, 21);
            this.b_resetMass.TabIndex = 27;
            this.b_resetMass.Text = "M";
            this.b_resetMass.UseVisualStyleBackColor = true;
            this.b_resetMass.Click += new System.EventHandler(this.b_resetMass_Click);
            // 
            // b_resetSources
            // 
            this.b_resetSources.Location = new System.Drawing.Point(118, 283);
            this.b_resetSources.Name = "b_resetSources";
            this.b_resetSources.Size = new System.Drawing.Size(36, 21);
            this.b_resetSources.TabIndex = 28;
            this.b_resetSources.Text = "Src";
            this.b_resetSources.UseVisualStyleBackColor = true;
            this.b_resetSources.Click += new System.EventHandler(this.b_resetSources_Click);
            // 
            // b_resetWalls
            // 
            this.b_resetWalls.Location = new System.Drawing.Point(171, 283);
            this.b_resetWalls.Name = "b_resetWalls";
            this.b_resetWalls.Size = new System.Drawing.Size(24, 21);
            this.b_resetWalls.TabIndex = 29;
            this.b_resetWalls.Text = "W";
            this.b_resetWalls.UseVisualStyleBackColor = true;
            this.b_resetWalls.Click += new System.EventHandler(this.b_resetWalls_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_scale);
            this.groupBox2.Controls.Add(this.p_colorMass);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.p_colWall);
            this.groupBox2.Controls.Add(this.p_colMin);
            this.groupBox2.Controls.Add(this.p_colNull);
            this.groupBox2.Controls.Add(this.p_colMax);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 499);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 171);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visualisation";
            // 
            // b_scale
            // 
            this.b_scale.Location = new System.Drawing.Point(9, 132);
            this.b_scale.Name = "b_scale";
            this.b_scale.Size = new System.Drawing.Size(185, 23);
            this.b_scale.TabIndex = 10;
            this.b_scale.Text = "Adjust Scale to Scene";
            this.b_scale.UseVisualStyleBackColor = true;
            this.b_scale.Click += new System.EventHandler(this.b_scale_Click);
            // 
            // p_colorMass
            // 
            this.p_colorMass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_colorMass.Location = new System.Drawing.Point(78, 113);
            this.p_colorMass.Name = "p_colorMass";
            this.p_colorMass.Size = new System.Drawing.Size(64, 13);
            this.p_colorMass.TabIndex = 9;
            this.p_colorMass.Click += new System.EventHandler(this.p_colorMass_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = " + Mass:";
            // 
            // p_colWall
            // 
            this.p_colWall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_colWall.Location = new System.Drawing.Point(78, 93);
            this.p_colWall.Name = "p_colWall";
            this.p_colWall.Size = new System.Drawing.Size(64, 13);
            this.p_colWall.TabIndex = 7;
            this.p_colWall.Click += new System.EventHandler(this.p_colWall_Click);
            // 
            // p_colMin
            // 
            this.p_colMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_colMin.Location = new System.Drawing.Point(78, 70);
            this.p_colMin.Name = "p_colMin";
            this.p_colMin.Size = new System.Drawing.Size(64, 13);
            this.p_colMin.TabIndex = 6;
            this.p_colMin.Click += new System.EventHandler(this.p_colMin_Click);
            // 
            // p_colNull
            // 
            this.p_colNull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_colNull.Location = new System.Drawing.Point(78, 48);
            this.p_colNull.Name = "p_colNull";
            this.p_colNull.Size = new System.Drawing.Size(64, 13);
            this.p_colNull.TabIndex = 5;
            this.p_colNull.Click += new System.EventHandler(this.p_colNull_Click);
            // 
            // p_colMax
            // 
            this.p_colMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_colMax.Location = new System.Drawing.Point(78, 26);
            this.p_colMax.Name = "p_colMax";
            this.p_colMax.Size = new System.Drawing.Size(64, 13);
            this.p_colMax.TabIndex = 4;
            this.p_colMax.Click += new System.EventHandler(this.p_colMax_Click);
            this.p_colMax.Paint += new System.Windows.Forms.PaintEventHandler(this.p_colMax_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Wall:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Null:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Minimum:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Maximum:";
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(12, 676);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(92, 23);
            this.b_save.TabIndex = 31;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_load
            // 
            this.b_load.Location = new System.Drawing.Point(118, 676);
            this.b_load.Name = "b_load";
            this.b_load.Size = new System.Drawing.Size(88, 23);
            this.b_load.TabIndex = 32;
            this.b_load.Text = "Load";
            this.b_load.UseVisualStyleBackColor = true;
            this.b_load.Click += new System.EventHandler(this.b_load_Click);
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
            // SimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 730);
            this.Controls.Add(this.b_load);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.b_resetWalls);
            this.Controls.Add(this.b_resetSources);
            this.Controls.Add(this.b_resetMass);
            this.Controls.Add(this.b_resetElong);
            this.Controls.Add(this.cb_resDiv);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_wert);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cb_mausaction);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.b_step);
            this.Controls.Add(this.b_pause);
            this.Controls.Add(this.b_reset);
            this.Controls.Add(this.groupBox1);
            this.Name = "SimForm";
            this.Text = "WaveSim 1.2.0 - (c) 2012 Arthur Silber";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.SimForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.SimForm_ResizeEnd);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_set;
        private System.Windows.Forms.TextBox txt_energieerhaltung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_fps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_deltat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_dteilchen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_masse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_distanz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dkopplung;
        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.Button b_pause;
        private System.Windows.Forms.Button b_step;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_mausaction;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel l_mouseinfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_wert;
        private System.Windows.Forms.ComboBox cb_resDiv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button b_resetElong;
        private System.Windows.Forms.Button b_resetMass;
        private System.Windows.Forms.Button b_resetSources;
        private System.Windows.Forms.Button b_resetWalls;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel p_colWall;
        private System.Windows.Forms.Panel p_colMin;
        private System.Windows.Forms.Panel p_colNull;
        private System.Windows.Forms.Panel p_colMax;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel p_colorMass;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button b_scale;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_load;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

