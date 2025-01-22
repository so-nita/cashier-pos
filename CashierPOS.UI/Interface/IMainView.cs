using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.UI.Interface
{
    public interface IMainView
    {
        Action<string> SearchItem { get; set; }

        void LoadData();
        void CloseView();
        void AddController(Form form);
    }
}
