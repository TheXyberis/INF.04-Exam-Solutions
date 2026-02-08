using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_06_RGB_Color_Picker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void UpdateLivePreview()
        {
            int r = trackBarRed.Value;
            int g = trackBarGreen.Value;
            int b = trackBarBlue.Value;

            labelRedValue.Text = r.ToString();
            labelGreenValue.Text = g.ToString();
            labelBlueValue.Text = b.ToString();

            panelColorPreview.BackColor = Color.FromArgb(r, g, b);
        }

        private void buttonSaveColor_Click(object sender, EventArgs e)
        {
            Color currentRgb = panelColorPreview.BackColor;
            labelSavedResults.BackColor = currentRgb;
            //labelSavedResults.Text = $"{trackBarRed.Value}, {trackBarGreen.Value}, {trackBarBlue.Value}";
            labelSavedResults.Text = $"{currentRgb.R}, {currentRgb.G}, {currentRgb.B}";
        }

        private void OnSliderScroll(object sender, EventArgs e)
        {
            UpdateLivePreview();
        }
    }
}
