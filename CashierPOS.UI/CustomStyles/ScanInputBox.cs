using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.UI.CustomStyles
{
    public class ScanInputBox : TextBox
    {
        public event EventHandler<string> TextSubmitted;
        public bool SubmitOnEnter { get; set; }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (SubmitOnEnter && e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.SuppressKeyPress = true;

                if (TextSubmitted != null)
                    TextSubmitted(this, this.Text);

                this.Clear();
            }
        }
    }
}
