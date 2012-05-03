using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaveSimLib.Code.Visualisation;

namespace WaveSim
{
    public partial class SimVisForm : Form
    {
        private DynamicColorVisualizer _dvis;
        private ColorDialog _colorDialog;

        public SimVisForm(DynamicColorVisualizer visualizer)
        {
            InitializeComponent();
            _dvis = visualizer;
            _colorDialog = new ColorDialog();

            p_colMax.BackColor = _dvis.ColorMax;
            p_colNull.BackColor = _dvis.ColorNull;
            p_colMin.BackColor = _dvis.ColorMin;
            p_colWall.BackColor = _dvis.ColorWall;
            p_colorMass.BackColor = _dvis.ColorMass;
        }

        private void p_colMax_Click(object sender, EventArgs e)
        {
            DialogResult res = _colorDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                p_colMax.BackColor = _dvis.ColorMax = _colorDialog.Color;
                _dvis.UpdateColorMapping(false);
            }
        }

        private void p_colNull_Click(object sender, EventArgs e)
        {
            DialogResult res = _colorDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                p_colNull.BackColor = _dvis.ColorNull = _colorDialog.Color;
                _dvis.UpdateColorMapping(false);
            }
        }

        private void p_colMin_Click(object sender, EventArgs e)
        {
            DialogResult res = _colorDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                p_colMin.BackColor = _dvis.ColorMin = _colorDialog.Color;
                _dvis.UpdateColorMapping(false);
            }
        }

        private void p_colWall_Click(object sender, EventArgs e)
        {
            DialogResult res = _colorDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                p_colWall.BackColor = _dvis.ColorWall = _colorDialog.Color;
                _dvis.UpdateColorMapping(false);
            }
        }

        private void p_colorMass_Click(object sender, EventArgs e)
        {
            DialogResult res = _colorDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                p_colorMass.BackColor = _dvis.ColorMass = _colorDialog.Color;
                _dvis.UpdateColorMapping(false);
            }
        }

        private void b_scale_Click(object sender, EventArgs e)
        {
            _dvis.UpdateColorMapping(true);

            p_colorMass.BackColor = _dvis.ColorMass;
            p_colWall.BackColor = _dvis.ColorWall;
            p_colMin.BackColor = _dvis.ColorMin;
            p_colNull.BackColor = _dvis.ColorNull;
            p_colMax.BackColor = _dvis.ColorMax;
        }
    }
}
