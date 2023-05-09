using System.Runtime.InteropServices;

namespace ZX_WareHouse.Forms
{
    public partial class LoginForm : Form
    {
        // Variables
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public LoginForm() =>
            InitializeComponent();

        private void CloseFormButton_Click(object sender, EventArgs e) =>
            Close();

        private void MinimizeFormButton_Click(object sender, EventArgs e) =>
            WindowState = FormWindowState.Minimized;

        private void WindowPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
