using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaveSimLib.Code.Wave;

namespace WaveSim
{
    public partial class SimSettingsForm : Form
    {
        public WaveSettings Settings;
 
        public SimSettingsForm()
        {
            InitializeComponent();
        }

        private void SimSettingsForm_Load(object sender, EventArgs e)
        {
            txt_deltat.Text = Settings.DeltaT.ToString();
            txt_distanz.Text = Settings.TeilchenDistanz.ToString();
            txt_dkopplung.Text = Settings.FederkonstanteKopplung.ToString();
            txt_dteilchen.Text = Settings.FederkonstanteTeilchen.ToString();
            txt_energieerhaltung.Text = Settings.Energieerhaltung.ToString();
            txt_fps.Text = Settings.DesiredFPS.ToString();
            txt_masse.Text = Settings.Teilchenmasse.ToString();
        }

        private void b_apply_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.DeltaT = Convert.ToDouble(txt_deltat.Text);
                Settings.TeilchenDistanz = Convert.ToDouble(txt_distanz.Text);
                Settings.FederkonstanteKopplung = Convert.ToDouble(txt_dkopplung.Text);
                Settings.FederkonstanteTeilchen = Convert.ToDouble(txt_dteilchen.Text);
                Settings.Energieerhaltung = Convert.ToDouble(txt_energieerhaltung.Text);
                Settings.DesiredFPS = Convert.ToInt32(txt_fps.Text);
                Settings.Teilchenmasse = Convert.ToDouble(txt_masse.Text);
            }
            catch (Exception)
            {
            }
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            Settings = null;
            this.Close();
        }
    }
}
