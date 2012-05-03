namespace WaveSim
{
    partial class SimVisForm
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
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 171);
            this.groupBox2.TabIndex = 31;
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
            // SimVisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 189);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SimVisForm";
            this.Text = "Visualisation Colors";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_scale;
        private System.Windows.Forms.Panel p_colorMass;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel p_colWall;
        private System.Windows.Forms.Panel p_colMin;
        private System.Windows.Forms.Panel p_colNull;
        private System.Windows.Forms.Panel p_colMax;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}