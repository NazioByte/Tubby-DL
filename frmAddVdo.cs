using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebVideoDownloader_2
{
    public partial class frmAddVdo : Form
    {
        public frmAddVdo()
        {
            InitializeComponent();

            this.btnOK.DialogResult = DialogResult.OK;
            this.btnClose.DialogResult = DialogResult.Cancel;

            vdo_panel.Visible = false;
            comboFormatType.Enabled = false;
            sound_panel.Enabled = false;
            vdo_panel.Enabled = false;

            comboFormatType.SelectedIndex = 0;
            comboBitrateSound.SelectedIndex = 0;
            comboSoundType.SelectedIndex = 0;
            comboHZSound.SelectedIndex = 0;

            comboResolution.SelectedIndex = 0;
            comboVdoBitrate.SelectedIndex = 0;
            comboFrameRate.SelectedIndex = 0;
            comboAspectRatio.SelectedIndex = 0;
            comboDelsound.SelectedIndex = 0;
            
        }

        private void frmAddVdo_Load(object sender, EventArgs e)
        {
            var _url = Clipboard.GetText();

            if (_url.IndexOf("www.youtube.com") != -1)
            {
                this.txtUrl.Text = string.Empty;
                this.txtUrl.Text = _url;
            }
            else
            {
                this.txtUrl.Text = string.Empty;
            }
        }

        private void vdo_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioVdoDefault_CheckedChanged(object sender, EventArgs e)
        {
            vdo_panel.Visible = false;
            comboFormatType.Enabled = false;
            sound_panel.Enabled = false;
            vdo_panel.Enabled = false;
        }

        private void radioVdoCustom_CheckedChanged(object sender, EventArgs e)
        {            
            comboFormatType.Enabled = true;
            sound_panel.Enabled = true;
            vdo_panel.Enabled = true;
            sound_panel.Visible = true;
            vdo_panel.Visible = false;
        }

        private void comboFormatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int panelIndex = comboFormatType.SelectedIndex;

            if (panelIndex <= 7)
            {
                switchToSoundPanel();
            }
            else if (panelIndex >= 8)
            {
                switchToVdoPanel();
            }
        }

        private void switchToVdoPanel()
        {
            sound_panel.Visible = false;
            vdo_panel.Visible = true;
            ICompound.Paneltype = "Video";
            
        }

        private void switchToSoundPanel()
        {
            vdo_panel.Visible = false;
            sound_panel.Visible = true;
            ICompound.Paneltype = "Sound";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboVdoBitrate_KeyUp(object sender, KeyEventArgs e)
        {
            int soda = 0;

            if (!Int32.TryParse(comboVdoBitrate.Text, out soda))
            {
                comboVdoBitrate.SelectedIndex = 0;
                e.Handled = true;
            }
        }

        private void comboFrameRate_KeyUp(object sender, KeyEventArgs e)
        {
            int soda = 0;

            if (!Int32.TryParse(comboFrameRate.Text, out soda))
            {
                comboFrameRate.SelectedIndex = 0;
                e.Handled = true;
            }
        }

        private void comboFrameRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBitrateSound_KeyUp(object sender, KeyEventArgs e)
        {
            int soda = 0;

            if (!Int32.TryParse(comboBitrateSound.Text, out soda))
            {
                comboBitrateSound.SelectedIndex = 0;
                e.Handled = true;
            }
        }

        private void comboHZSound_KeyUp(object sender, KeyEventArgs e)
        {
            int soda = 0;

            if (!Int32.TryParse(comboHZSound.Text, out soda))
            {
                comboHZSound.SelectedIndex = 0;
                e.Handled = true;
            }
        }

    }
}
