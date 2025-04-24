using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sufler.Properts
{
    /// <summary>
    /// Класс отрисовки элементов
    /// </summary>
    public static class Drawer
    {
        //Скругление формы
        public static void RoundForm(Form form, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = new Rectangle(0, 0, form.Width, form.Height);
            int diameter = radius * 2;

            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90); // Вверх-лево
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90); // Вверх-право
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90); // Низ-право
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90); // Низ-лево

            path.CloseFigure();

            form.Region = new Region(path);
        }

        //Скругление фигур
        public static GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        //Скругление аватарки
        public static void MakeControlRound(Control control, int v)
        {
            if (control == null) return;

            int diameter = Math.Min(control.Width, control.Height);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, diameter, diameter);
            control.Region = new Region(path);
        }

    }
}

