using System;
using System.Windows.Forms;

using LEWP.Core.Properties;

namespace LEWP.Core
{
    public partial class FormSettings : Form
    {
        private readonly int _difference;
        private readonly int _interval;
        private readonly int _imageNumber;
        private readonly int _satellite;

        public FormSettings()
        {
            InitializeComponent();
            _interval = Settings.Default.Interval;
            _difference = Settings.Default.Difference;
            _imageNumber = Settings.Default.ImageNumber;
            _satellite = Settings.Default.Source;
        }

        private void FormSettingsOnLoad(object sender, EventArgs e)
        {
            txtInterval.Value = _interval;
            txtDifference.Value = _difference;
            txtImageNumber.Value = _imageNumber;
            ComboSat.SelectedIndex = _satellite;
        }

        private void BtnCloseOnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSaveOnClick(object sender, EventArgs e)
        {
            Settings.Default.Interval = (int) txtInterval.Value;
            Settings.Default.Difference = (int)txtDifference.Value;
            Settings.Default.ImageNumber = (int)txtImageNumber.Value;
            Settings.Default.Source = ComboSat.SelectedIndex;
            Settings.Default.Save();
            BtnSave.Enabled = false;
        }

        private void OnChange(object sender, EventArgs e)
        {
            BtnSave.Enabled = txtInterval.Value != Settings.Default.Interval
                || txtDifference.Value != Settings.Default.Difference
                || ComboSat.SelectedIndex != Settings.Default.Source
                || txtImageNumber.Value != Settings.Default.ImageNumber;
        }
    }
}