using System;
using System.Threading;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace UIDelaySimulator
{
    public partial class SettingsForm : Form
    {
        private readonly IKeyboardMouseEvents _globalhook;

        public SettingsForm()
        {
            InitializeComponent();
            _globalhook = Hook.GlobalEvents();

            _globalhook.MouseDownExt += GlobalHookMouseDownExt;
            _globalhook.KeyPress += GlobalHookKeyPress;

            labelCurrent.Text = trkDelayMilliseconds.Value + "ms";
        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            Thread.Sleep(trkDelayMilliseconds.Value);
        }

        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            Thread.Sleep(trkDelayMilliseconds.Value);
        }

        public void Unsubscribe()
        {
            _globalhook.MouseDownExt -= GlobalHookMouseDownExt;
            _globalhook.KeyPress -= GlobalHookKeyPress;
            _globalhook.Dispose();
        }

        private bool _closeByExit = false;
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unsubscribe();
            _closeByExit = true;
            Close();
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_closeByExit)
            {
                Hide();
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trkDelayMilliseconds_ValueChanged(object sender, EventArgs e)
        {
            labelCurrent.Text = trkDelayMilliseconds.Value + "ms";
        }
    }
}
