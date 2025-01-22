using System;
using System.Drawing;
using System.Windows.Forms;

namespace CashierPOS.UI.View_PopUp
{
    public partial class PopUp_Background : Form
    {
        private static Form _formBackground;
        public static Form Form;

        public PopUp_Background()
        {
            InitializeComponent();
        }

        public static void ShowPopUp()
        {
            _formBackground = Background();
            if (_formBackground != null)
            {
                _formBackground.StartPosition = FormStartPosition.Manual;
                _formBackground.FormBorderStyle = FormBorderStyle.None;
                _formBackground.Opacity = 0.70d;
                _formBackground.BackColor = Color.Black;
                _formBackground.WindowState = FormWindowState.Maximized;
                Form.TopMost = true;
                _formBackground.ShowInTaskbar = false;
                _formBackground.Show();
                Form.Owner = _formBackground;
                Form.ShowDialog();
            }
        }

        private static Form Background()
        {
            return (Form != null) ? new Form() : null!;
        }

        public static void ClosePopUp()
        {
            if (Form != null)
            {
                Form.Close();
            }

            if (_formBackground != null)
            {
                _formBackground.Hide();
                _formBackground = null!;
            }
        }
    }
}



