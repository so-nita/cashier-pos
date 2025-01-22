using CashierPOS.UI.View_PopUp;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierPOS.UI.View.View_PopUp.AddProductQty
{
    public partial class PopUp_AddQtyProduct : Form
    {
        public PopUp_AddQtyProduct()
        {
            InitializeComponent();
            InitializeEventHandeler();
            ActiveControl = txtProductQty;
        }
        private TextBox currentTextBox; // Maintain a reference to the currently selected textbox
        //method button for input number
        private void InputNumber(object sender, EventArgs e)
        {
            HopeButton button = (HopeButton)sender;

            if (currentTextBox != null)
            {
                button.Tag = button.Text;
                currentTextBox.Text += button.Tag;
                currentTextBox.SelectionStart = currentTextBox.Text.Length;
                currentTextBox.SelectionLength = 0;
            }
        }

        // Set the currentTextBox whenever a textbox is selected (e.g., when it gets focus)
        private void TextBoxSelected(object sender, EventArgs e)
        {
            currentTextBox = (TextBox)sender;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (currentTextBox != null && currentTextBox.Text.Length > 0)
            {
                int cursorPosition = currentTextBox.SelectionStart;
                if (cursorPosition > 0)
                {
                    currentTextBox.Text = currentTextBox.Text.Remove(cursorPosition - 1, 1);
                    currentTextBox.SelectionStart = cursorPosition - 1;
                    currentTextBox.SelectionLength = 0;
                }
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            PopUp_Background.ClosePopUp();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
