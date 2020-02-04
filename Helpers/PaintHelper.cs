using DevExpress.LookAndFeel;
using DevExpress.Skins;

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RichTextBoxExDemo.Helpers
{
    internal static class PaintHelper
    {
        #region Constants
        private const int WM_SETREDRAW = 0x000B;
        #endregion

        #region Methods
        internal static void BeginUpdate(Control control)
        {
            var message = Message.Create(control.Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);

            var nativeWindow = NativeWindow.FromHandle(control.Handle);

            nativeWindow.DefWndProc(ref message);
        }

        internal static void EndUpdate(Control control)
        {
            var wparam = new IntPtr(1);
            var message = Message.Create(control.Handle, WM_SETREDRAW, wparam, IntPtr.Zero);

            var nativeWindow = NativeWindow.FromHandle(control.Handle);

            nativeWindow.DefWndProc(ref message);

            control.Invalidate();
        }

        internal static void PaintBorder(Rectangle rectangle, Graphics graphics)
        {
            graphics.PixelOffsetMode = PixelOffsetMode.Half;

            using (var pen = new Pen(ColorHelper.BorderColor))
            {
                graphics.DrawLine(pen, new Point(1, 0), new Point(1, rectangle.Height));
                graphics.DrawLine(pen, new Point(0, rectangle.Y + 1), new Point(rectangle.Width, rectangle.Y + 1));
                graphics.DrawLine(pen, new Point(rectangle.Width, 0), new Point(rectangle.Width, rectangle.Height));
                graphics.DrawLine(pen, new Point(0, rectangle.Height), new Point(rectangle.Width, rectangle.Height));
            }
        }

        internal static void PaintBottomBorder(Rectangle rectangle, Graphics graphics)
        {
            graphics.PixelOffsetMode = PixelOffsetMode.Half;
            using (var pen = new Pen(ColorHelper.BorderColor))
                graphics.DrawLine(pen, new Point(0, rectangle.Height), new Point(rectangle.Width, rectangle.Height));
        }

        internal static void PaintTopBorder(Rectangle rectangle, Graphics graphics)
        {
            graphics.PixelOffsetMode = PixelOffsetMode.Half;
            using (var pen = new Pen(ColorHelper.BorderColor))
                graphics.DrawLine(pen, new Point(0, rectangle.Y + 1), new Point(rectangle.Width, rectangle.Y + 1));
        }

        internal static void PaintLeftBorder(Rectangle rectangle, Graphics graphics)
        {
            graphics.PixelOffsetMode = PixelOffsetMode.Half;
            using (var pen = new Pen(ColorHelper.BorderColor))
                graphics.DrawLine(pen, new Point(1, 0), new Point(1, rectangle.Height));
        }

        internal static void PaintRightBorder(Rectangle rectangle, Graphics graphics)
        {
            graphics.PixelOffsetMode = PixelOffsetMode.Half;
            using (var pen = new Pen(ColorHelper.BorderColor))
                graphics.DrawLine(pen, new Point(rectangle.Width, 0), new Point(rectangle.Width, rectangle.Height));
        }

        internal static void PaintSizeGrip(Rectangle rectangle, Graphics graphics)
        {
            var skin = CommonSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel);
            var skinElement = skin[CommonSkins.SkinSizeGrip];
            var sizeGripImage = skinElement.Image.Image;

            var point = new Point();

            point.X = rectangle.Width - sizeGripImage.Width;
            point.Y = rectangle.Height - sizeGripImage.Height;

            graphics.DrawImageUnscaled(sizeGripImage, point);
        }
        #endregion
    }
}