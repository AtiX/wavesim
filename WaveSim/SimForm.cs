using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaveSimLib.Code.Visualisation;
using WaveSimLib.Code.Wave;

namespace WaveSim
{
    public partial class SimForm : Form
    {
        private WaveEngine Engine;
        private DynamicColorVisualizer dcv;
        private int _resDiv = 4;

        private int _mouseX, _mouseY;
        private bool _mouseDown;
        private string _fileToLoad = "";

        public SimForm()
        {
            InitializeComponent();
        }

        public SimForm(string filename)
        {
            InitializeComponent();
            _fileToLoad = filename;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine = new WaveEngine();
            Engine.OnNewSimulationFrame += new WaveEngine.NewSimulationFrameHandler(Engine_OnNewSimulationFrame);
            Engine.Init(pb_image.Width / _resDiv, pb_image.Height / _resDiv);

            dcv = new DynamicColorVisualizer();
            p_colMax.BackColor = dcv.ColorMax;
            p_colNull.BackColor = dcv.ColorNull;
            p_colMin.BackColor = dcv.ColorMin;
            p_colWall.BackColor = dcv.ColorWall;
            p_colorMass.BackColor = dcv.ColorMass;

            txt_deltat.Text = Engine.Settings.DeltaT.ToString();
            txt_distanz.Text = Engine.Settings.TeilchenDistanz.ToString();
            txt_dkopplung.Text = Engine.Settings.FederkonstanteKopplung.ToString();
            txt_dteilchen.Text = Engine.Settings.FederkonstanteTeilchen.ToString();
            txt_energieerhaltung.Text = Engine.Settings.Energieerhaltung.ToString();
            txt_fps.Text = Engine.Settings.DesiredFPS.ToString();
            txt_masse.Text = Engine.Settings.Teilchenmasse.ToString();

            cb_mausaction.SelectedIndex = 0;
            cb_resDiv.SelectedIndex = 0;
            cb_wert.SelectedIndex = 9;
            cb_resDiv.SelectedIndex = 3;

            if (_fileToLoad != "")
            {
                WaveSettings set = Engine.Settings;

                bool result = set.LoadFromFile(_fileToLoad);

                if (!result)
                {
                    MessageBox.Show("An error occured whilst loading the file!", "Load");
                    return;
                }

                //Resize window
                Size windowS = new Size(set.Width * _resDiv + 242, set.Height * _resDiv + 83);
                this.Size = windowS;

                Engine.Settings = set;
                //MessageBox.Show("File loaded successfully!", "Load");
            }

            String PersonalFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.InitialDirectory = PersonalFolder + "\\WaveSim";
            openFileDialog.InitialDirectory = PersonalFolder + "\\WaveSim";

            Engine.Start();
        }

        void Engine_OnNewSimulationFrame(double[,] positionMap, bool[,] wallMap, bool[,] addonWallMap, double[,] massMap, double[,] addonMassMap, int fps)
        {
            Bitmap bmp = dcv.VisualizePositionMap(positionMap, wallMap, addonWallMap, massMap, addonMassMap, Engine.Width, Engine.Height);

            try
            {
                this.Invoke((Action) (() =>
                                          {
                                              pb_image.BackgroundImage = bmp;
                                              SetMouseInfoText(fps);
                                          }));
            }
            catch(Exception) {}
        }

        private void SaveSettings()
        {
            try
            {
                Engine.Settings.DeltaT = Convert.ToDouble(txt_deltat.Text);
                Engine.Settings.TeilchenDistanz = Convert.ToDouble(txt_distanz.Text);
                Engine.Settings.FederkonstanteKopplung = Convert.ToDouble(txt_dkopplung.Text);
                Engine.Settings.FederkonstanteTeilchen = Convert.ToDouble(txt_dteilchen.Text);
                Engine.Settings.Energieerhaltung = Convert.ToDouble(txt_energieerhaltung.Text);
                Engine.Settings.DesiredFPS = Convert.ToInt32(txt_fps.Text);
                Engine.Settings.Teilchenmasse = Convert.ToDouble(txt_masse.Text);
            }
            catch (Exception)
            {}
        }

        private void txt_dkopplung_KeyPress(object sender, KeyPressEventArgs e)
        {
            SaveSettings();
        }

        private void txt_distanz_KeyPress(object sender, KeyPressEventArgs e)
        {
            SaveSettings();
        }

        private void txt_masse_KeyPress(object sender, KeyPressEventArgs e)
        {
            SaveSettings();
        }

        private void txt_dteilchen_KeyPress(object sender, KeyPressEventArgs e)
        {
            SaveSettings();
        }

        private void txt_deltat_KeyPress(object sender, KeyPressEventArgs e)
        {
            SaveSettings();
        }

        private void txt_fps_KeyPress(object sender, KeyPressEventArgs e)
        {
            SaveSettings();
        }

        private void txt_energieerhaltung_KeyPress(object sender, KeyPressEventArgs e)
        {
            SaveSettings();
        }

        private void b_set_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void b_reset_Click(object sender, EventArgs e)
        {
            Engine.Init(pb_image.Width/_resDiv, pb_image.Height/_resDiv);
            Engine.Start();
        }

        private void b_pause_Click(object sender, EventArgs e)
        {
            if (Engine.SimulationRunning)
            {
                Engine.Stop();
                b_pause.Text = "Resume";
            }
            else
            {
                Engine.Start();
                b_pause.Text = "Pause";
            }
        }

        private void b_step_Click(object sender, EventArgs e)
        {
            Engine.ManualStep();
            b_pause.Text = "Resume";
        }

        private void pb_image_Click(object sender, EventArgs e)
        {
            
        }

        private void pb_image_MouseClick(object sender, MouseEventArgs e)
        {
            _mouseX = e.Location.X / _resDiv;
            _mouseY = e.Location.Y / _resDiv;

            DoMouseAction();
        }

        private void DoMouseAction()
        {
            int x = _mouseX;
            int y = _mouseY;

            double value = 0;
            if (cb_wert.SelectedIndex != -1)
                value = Convert.ToDouble(cb_wert.Items[cb_wert.SelectedIndex]);

            if (cb_mausaction.SelectedIndex == 0)
            {
                Engine.Poke(x, y, value, 0);
                Engine.Poke(x+1, y, value, 0);
                Engine.Poke(x, y+1, value, 0);
                Engine.Poke(x+1, y+1, value, 0);
            }
            else if (cb_mausaction.SelectedIndex == 1)
                Engine.SetWall(x, y);
            else if (cb_mausaction.SelectedIndex == 2)
            {
                Engine.SetWall(x, y, false);
                Engine.SetWall(x+1, y, false);
                Engine.SetWall(x, y+1, false);
                Engine.SetWall(x+1, y+1, false);
            }
            else if (cb_mausaction.SelectedIndex == 3)
            {
                Engine.SetMass(x, y, value);
                Engine.SetMass(x+1, y, value);
                Engine.SetMass(x, y+1, value);
                Engine.SetMass(x+1, y+1, value);
                Engine.SetMass(x, y + 2, value);
                Engine.SetMass(x + 2, y + 2, value);
            }
            else if (cb_mausaction.SelectedIndex == 4)
            {
                Engine.SetMass(x, y, 0);
                Engine.SetMass(x+1, y, 0);
                Engine.SetMass(x, y+1, 0);
                Engine.SetMass(x+1, y+1, 0);
                Engine.SetMass(x, y + +2, 0);
                Engine.SetMass(x + 2, y + 2, 0);
            }
            else if (cb_mausaction.SelectedIndex == 5)
            {
                SinusWaveSource sws = new SinusWaveSource();
                sws.X = x;
                sws.Y = y;
                sws.Frequency = value / 10.0;

                Engine.AddWaveSoucre(sws);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Engine.Stop();
        }

        private void pb_image_MouseMove(object sender, MouseEventArgs e)
        {
            _mouseX = e.Location.X / _resDiv;
            _mouseY = e.Location.Y / _resDiv;
            SetMouseInfoText(0);
            if (_mouseDown)
                DoMouseAction();
        }

        private void SetMouseInfoText(int fps)
        {
            try
            {
                double v = Engine.GetVelocity(_mouseX, _mouseY);
                double p = Engine.GetPosition(_mouseX, _mouseY);
                double w = Engine.GetEnergy(_mouseX, _mouseY);

                l_mouseinfo.Text = "[" + (_mouseX).ToString() + "|" + (_mouseY).ToString() + "] Elongation: " +
                                   p.ToString("##0.000") + " Velocity: " +
                                   v.ToString("##0.000" + " Energy: " + w.ToString("##0.000") + " FPS: " +
                                              fps.ToString());
            }
            catch (Exception e) {}
        }

        private void pb_image_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _mouseX = e.Location.X / _resDiv;
            _mouseY = e.Location.Y / _resDiv;
        }

        private void pb_image_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_resDiv.SelectedIndex != -1)
            {
                _resDiv = cb_resDiv.SelectedIndex + 1;
                Engine.Init(pb_image.Width / _resDiv, pb_image.Height / _resDiv);
            }

        }

        private void b_resetElong_Click(object sender, EventArgs e)
        {
            Engine.ResetElongation();
        }

        private void b_resetMass_Click(object sender, EventArgs e)
        {
            Engine.ResetMass();
        }

        private void b_resetSources_Click(object sender, EventArgs e)
        {
            Engine.ResetSources();
        }

        private void b_resetWalls_Click(object sender, EventArgs e)
        {
            Engine.ResetWalls();
        }

        private void pb_image_Resize(object sender, EventArgs e)
        {
            //Re-init
            Engine.Stop();
            //Restart is done by Form - resize end
            //Engine.Init(pb_image.Width / _resDiv, pb_image.Height / _resDiv);
        }

        private void p_colMax_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p_colMax_Click(object sender, EventArgs e)
        {
            DialogResult res = colorDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                p_colMax.BackColor = dcv.ColorMax = colorDialog.Color;
                dcv.UpdateColorMapping(false);
            }
        }

        private void p_colNull_Click(object sender, EventArgs e)
        {
            DialogResult res = colorDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                p_colNull.BackColor = dcv.ColorNull = colorDialog.Color;
                dcv.UpdateColorMapping(false);
            }
        }

        private void p_colMin_Click(object sender, EventArgs e)
        {
            DialogResult res = colorDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                p_colMin.BackColor = dcv.ColorMin = colorDialog.Color;
                dcv.UpdateColorMapping(false);
            }
        }

        private void p_colWall_Click(object sender, EventArgs e)
        {
            DialogResult res = colorDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                p_colWall.BackColor = dcv.ColorWall = colorDialog.Color;
                dcv.UpdateColorMapping(false);
            }
        }

        private void p_colorMass_Click(object sender, EventArgs e)
        {
            DialogResult res = colorDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                p_colorMass.BackColor = dcv.ColorMass = colorDialog.Color;
                dcv.UpdateColorMapping(false);
            }
        }

        private void b_scale_Click(object sender, EventArgs e)
        {
            dcv.UpdateColorMapping(true);

            p_colorMass.BackColor = dcv.ColorMass;
            p_colWall.BackColor = dcv.ColorWall;
            p_colMin.BackColor = dcv.ColorMin;
            p_colNull.BackColor = dcv.ColorNull;
            p_colMax.BackColor = dcv.ColorMax;
        }

        private Size _oldsize;

        private void SimForm_ResizeBegin(object sender, EventArgs e)
        {
            Engine.Stop();
            _oldsize = this.Size;
        }

        private void SimForm_ResizeEnd(object sender, EventArgs e)
        {  
            if(!this.Size.Equals(_oldsize))
            Engine.Init(pb_image.Width / _resDiv, pb_image.Height / _resDiv);

            Engine.Start();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            Engine.Stop();
            WaveSettings set = Engine.Settings;

            DialogResult res = saveFileDialog.ShowDialog();

            if (res != System.Windows.Forms.DialogResult.Cancel)
            {
                bool result = set.SaveToFile(saveFileDialog.FileName);
                if (result)
                {
                    MessageBox.Show("File successfully saved!", "Save");
                }
                else
                {
                    MessageBox.Show("Error whilst saving the file!", "Save");
                }
            }

            Engine.Start();
        }

        private void b_load_Click(object sender, EventArgs e)
        {
            Engine.Stop();
            WaveSettings set = Engine.Settings;

            DialogResult res = openFileDialog.ShowDialog();

            if (res != System.Windows.Forms.DialogResult.Cancel)
            {
                bool result = set.LoadFromFile(openFileDialog.FileName);

                if (!result)
                {
                    MessageBox.Show("An error occured whilst loading the file!", "Load");
                    Engine.Start();
                    return;
                }

                //Resize window
                Size windowS = new Size(set.Width * _resDiv + 242, set.Height * _resDiv + 83);
                this.Size = windowS;

                Engine.Settings = set;
                MessageBox.Show("File loaded successfully!", "Load");
                Engine.Start();
            }
        }
    }
}
