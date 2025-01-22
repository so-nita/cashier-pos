using CashierPOS.UI.Constant;
using System.Drawing;
using System.Windows.Forms;

namespace CashierPOS.UI.Components;

public class CustomTouchScroll
{
    private Point mouseDownPoint;
    private FlowLayoutPanel parentPanel;
    private ScrollDirection scrollDirection;

    public CustomTouchScroll(FlowLayoutPanel panel, ScrollDirection direction)
    {
        parentPanel = panel;
        panel.HorizontalScroll.Visible = false;
        panel.HorizontalScroll.Enabled = false;
        panel.HorizontalScroll.Value = 0;
        scrollDirection = direction;
    }

    public void AssignScrollEvent(Control control)
    {
        control.MouseDown += MouseDown;
        control.MouseMove += MouseMove;

        foreach (Control item in control.Controls)
        {
            AssignScrollEvent(item);
        }
    }

    private void MouseMove(object? sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left)
            return;

        int diffX = scrollDirection == ScrollDirection.Horizontal ? Cursor.Position.X - mouseDownPoint.X : Cursor.Position.X + mouseDownPoint.X;
        int diffY = scrollDirection == ScrollDirection.Vertical ? Cursor.Position.Y - mouseDownPoint.Y : Cursor.Position.Y + mouseDownPoint.Y;

        Point pointDiff = new Point(diffX, diffY);

        if (mouseDownPoint.X == Cursor.Position.X && mouseDownPoint.Y == Cursor.Position.Y)
            return;

        Point currAuto = parentPanel.AutoScrollPosition;
        parentPanel.AutoScrollPosition = new Point(Math.Abs(currAuto.X) - pointDiff.X, Math.Abs(currAuto.Y) - pointDiff.Y);
        mouseDownPoint = Cursor.Position;
    }

    private void MouseDown(object? sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            mouseDownPoint = Cursor.Position;
        }
    }
}