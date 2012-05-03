namespace WaveSim
{
    partial class SimSettingsForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.b_apply = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_energieerhaltung
            // 
            this.txt_energieerhaltung.Location = new System.Drawing.Point(142, 165);
            this.txt_energieerhaltung.Name = "txt_energieerhaltung";
            this.txt_energieerhaltung.Size = new System.Drawing.Size(105, 20);
            this.txt_energieerhaltung.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Energy %";
            // 
            // txt_fps
            // 
            this.txt_fps.Location = new System.Drawing.Point(142, 139);
            this.txt_fps.Name = "txt_fps";
            this.txt_fps.Size = new System.Drawing.Size(105, 20);
            this.txt_fps.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "desired FPS:";
            // 
            // txt_deltat
            // 
            this.txt_deltat.Location = new System.Drawing.Point(142, 113);
            this.txt_deltat.Name = "txt_deltat";
            this.txt_deltat.Size = new System.Drawing.Size(105, 20);
            this.txt_deltat.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Delta t:";
            // 
            // txt_dteilchen
            // 
            this.txt_dteilchen.Location = new System.Drawing.Point(142, 87);
            this.txt_dteilchen.Name = "txt_dteilchen";
            this.txt_dteilchen.Size = new System.Drawing.Size(105, 20);
            this.txt_dteilchen.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Node spring constant:";
            // 
            // txt_masse
            // 
            this.txt_masse.Location = new System.Drawing.Point(142, 61);
            this.txt_masse.Name = "txt_masse";
            this.txt_masse.Size = new System.Drawing.Size(105, 20);
            this.txt_masse.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mass:";
            // 
            // txt_distanz
            // 
            this.txt_distanz.Location = new System.Drawing.Point(142, 33);
            this.txt_distanz.Name = "txt_distanz";
            this.txt_distanz.Size = new System.Drawing.Size(105, 20);
            this.txt_distanz.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Distance:";
            // 
            // txt_dkopplung
            // 
            this.txt_dkopplung.Location = new System.Drawing.Point(142, 6);
            this.txt_dkopplung.Name = "txt_dkopplung";
            this.txt_dkopplung.Size = new System.Drawing.Size(105, 20);
            this.txt_dkopplung.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Coupling spring constant:";
            // 
            // b_apply
            // 
            this.b_apply.Location = new System.Drawing.Point(179, 202);
            this.b_apply.Name = "b_apply";
            this.b_apply.Size = new System.Drawing.Size(75, 23);
            this.b_apply.TabIndex = 28;
            this.b_apply.Text = "Apply";
            this.b_apply.UseVisualStyleBackColor = true;
            this.b_apply.Click += new System.EventHandler(this.b_apply_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(98, 202);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 29;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // SimSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 237);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_apply);
            this.Controls.Add(this.txt_energieerhaltung);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_fps);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_deltat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_dteilchen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_masse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_distanz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_dkopplung);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SimSettingsForm";
            this.Text = "Simulation Parameters";
            this.Load += new System.EventHandler(this.SimSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button b_apply;
        private System.Windows.Forms.Button b_cancel;

    }
}