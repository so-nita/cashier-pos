using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierPOS.UI.CustomStyles
{
    public class NotificationButton : HopeButton
    {
        private int _notificationCount = 0;

        // Property to set/get the notification count
        public int NotificationCount
        {
            get { return _notificationCount; }
            set
            {
                _notificationCount = value;
                Invalidate(); // Trigger the control to redraw
            }
        }

        // Override the OnPaint method to draw the notification badge
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Calculate the position for drawing the notification badge
            int badgeX = this.Width - 15; // Adjust the position as needed
            int badgeY = 0;

            // Draw the notification badge if the count is greater than 0
            if (_notificationCount > 0)
            {
                using (var brush = new SolidBrush(Color.Red))
                {
                    e.Graphics.FillEllipse(brush, badgeX, badgeY, 20, 20); // Adjust the size as needed
                }

                using (var font = new Font("Times New Roman", 9, FontStyle.Bold))
                {
                    // Adjust the position to center the text within the badge
                    float textX = badgeX + (20 - e.Graphics.MeasureString(_notificationCount.ToString(), font).Width) / 2;
                    float textY = badgeY + (20 - e.Graphics.MeasureString(_notificationCount.ToString(), font).Height) / 2;
                    e.Graphics.DrawString(_notificationCount.ToString(), font, Brushes.White, textX, textY);
                }
            }
        }

    }
}