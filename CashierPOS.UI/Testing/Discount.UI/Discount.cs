using CashierPOS.Model.Models.Product;
using CashierPOS.UI.Service;
using ReaLTaiizor.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierPOS.UI.Testing
{
    public partial class Discount : Form
    {
        public List<ProductResponse> Products = new List<ProductResponse>();
        public Discount()
        {
            InitializeComponent();
        }
        private void InitailizeLoad_Component(object sender, EventArgs e)
        {
            InitializeEventHandeler();
            InitListProduct();
        }

        private int checkedProductCount = 0;
        private void CheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is FoxCheckBoxEdit checkbox)
            {
                if(checkbox.Tag.ToString() == "0")
                {
                    foreach (FoxCheckBoxEdit _checkbox in panel_listitem.Controls.OfType<FoxCheckBoxEdit>())
                    {
                        if (_checkbox.Tag.ToString() != "0")
                        {
                            _checkbox.Checked = checkbox.Checked;
                        }
                    }
                }
                else
                {
                    if (checkbox.Checked)
                    {
                        checkedProductCount++;
                    }
                    else
                    {
                        checkedProductCount++;
                    }
                    ((FoxCheckBoxEdit)panel_listitem.Controls[0]).Checked = (checkedProductCount == Products.Count);
                }
            }

        }

        private async void InitListProduct()
        {
            var service = new ProductService();
            Products = await service.GetAllAsync();

            var allCheck = CreateCheckbox(new ProductResponse() { Id = "0", Name = "All" });
            allCheck.CheckedChanged += CheckAll_CheckedChanged;
            panel_listitem.Controls.Add(allCheck);

            foreach (var item in Products)
            {
                var checkBox = CreateCheckbox(item);
                checkBox.CheckedChanged += CheckAll_CheckedChanged;
                panel_listitem.Controls.Add(checkBox);
            }
        }
        private FoxCheckBoxEdit CreateCheckbox(ProductResponse product)
        {
            return new FoxCheckBoxEdit()
            {
                BorderColor = Color.FromArgb(200, 200, 200),
                Checked = false,
                DisabledBorderColor = Color.FromArgb(230, 230, 230),
                DisabledTextColor = Color.FromArgb(128, 255, 128),
                EnabledCalc = true,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = Color.FromArgb(66, 78, 90),
                HoverBorderColor = Color.FromArgb(44, 156, 218),
                Size = new Size(280, 23),
                Text = product.Name,
                Tag = product.Id,
            };
        }
    }
}
