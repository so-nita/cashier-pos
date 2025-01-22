using CashierPOS.UI.Interface;
using CashierPOS.UI.Service;
using CashierPOS.UI.View_PopUp;
using Microsoft.VisualBasic.Devices;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierPOS.UI.View.View_PopUp
{
    public partial class PopUp_alert : Form
    {
        private bool _click { get; set; } = false;

        public PopUp_alert()
        {
            InitializeComponent();
        }

        private void ChangeColorButton(HopeButton btn)
        {
            if (_click)
            {
                btn.PrimaryColor = Color.SteelBlue;
            }
            else
            {
                btn.PrimaryColor = Color.SeaGreen;
            }
        }

        public event EventHandler<string> IsClicked;
        private void btnCash_Click(object sender, EventArgs e)
        {
            if(sender is HopeButton btn)
            {
                ChangeColorButton(btn);
                _ = PaymentAsync(sender, "PT-0001");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopUp_Background.ClosePopUp();
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            _ = PaymentAsync(sender, "");
        }

        private async Task PaymentAsync(object sender ,string paymenCode)
        {
            // paymet then print receipt 
            if (sender != null)
            {
                this.Close();
                PopUp_Background.ClosePopUp();

                IsClicked?.Invoke(sender, paymenCode);
            }
        }
    }
}
