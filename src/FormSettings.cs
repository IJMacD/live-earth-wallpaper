using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using LEWP.Common;
using LEWP.Core.Properties;

namespace LEWP.Core
{
    public partial class FormSettings : Form
    {
        private readonly int _interval;
        private readonly int _imageNumber;
        private readonly int _satellite;
        private readonly int _wallpaperStyle;

        private readonly Orchestrator _orchestrator;

        public FormSettings()
        {
            InitializeComponent();
            _interval = Settings.Default.Interval;
            _imageNumber = Settings.Default.ImageNumber;
            _satellite = Settings.Default.Source;
            _wallpaperStyle = Settings.Default.WallpaperStyle;
            _orchestrator = new Orchestrator();
        }

        private void FormSettingsOnLoad(object sender, EventArgs e)
        {
            txtInterval.Value = _interval;
            txtImageNumber.Value = _imageNumber;
            ComboSat.SelectedIndex = _satellite;
            ComboStyle.SelectedIndex = _wallpaperStyle;
        }

        private void BtnCloseOnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSaveOnClick(object sender, EventArgs e)
        {
            var needsRefresh = (int)ComboStyle.SelectedIndex != Settings.Default.WallpaperStyle ||
                ComboSat.SelectedIndex != Settings.Default.Source ||
                (int)txtImageNumber.Value != Settings.Default.ImageNumber;

            Settings.Default.WallpaperStyle = ComboStyle.SelectedIndex;
            Settings.Default.Interval = (int)txtInterval.Value;
            Settings.Default.ImageNumber = (int)txtImageNumber.Value;
            Settings.Default.Source = ComboSat.SelectedIndex;
            Settings.Default.Save();
            BtnSave.Enabled = false;

            if (needsRefresh)
            {
                var _cts = new CancellationTokenSource();
                var _service = Task.Run(() => _orchestrator.RunOnce(_cts.Token), _cts.Token);
            }
        }

        private void OnChange(object sender, EventArgs e)
        {
            BtnSave.Enabled = txtInterval.Value != Settings.Default.Interval
                || ComboStyle.SelectedIndex != Settings.Default.WallpaperStyle
                || ComboSat.SelectedIndex != Settings.Default.Source
                || txtImageNumber.Value != Settings.Default.ImageNumber;

            tabControl1.Visible = ComboSat.SelectedIndex == (int)ImageSources.DSCOVR;
        }
    }
}