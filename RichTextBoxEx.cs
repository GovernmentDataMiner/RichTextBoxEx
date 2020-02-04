using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RichTextBoxExDemo
{
    [ToolboxItem(false)]
    public partial class RichTextBoxEx : RichTextBox
    {
        //#region Imports
        //[DllImport("user32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        //#endregion

        #region Event Handlers
        public event EventHandler CommandStateChanged;
        #endregion

        #region Constants
        private const int MK_CONTROL = 0x0008;
        private const int WM_MOUSEWHEEL = 0x020A;
        private const int WM_PASTE = 0x302;
        //private const int WM_SETREDRAW = 11;
        #endregion

        #region Constructors
        public RichTextBoxEx()
        {
            InitializeComponent();
        }

        public RichTextBoxEx(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion

        #region Methods
        //public static void ResumeDrawing(Control parent)
        //{
        //    SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
        //    parent.Refresh();
        //}

        //public static void SuspendDrawing(Control parent)
        //{
        //    SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
        //}

        public void ToggleBold()
        {
            var selectionFont = SelectionFont;
            if (selectionFont != null)
                SelectionFont = new Font(selectionFont.FontFamily, selectionFont.Size, SelectionFont.Style ^ FontStyle.Bold);

            UpdateCommandState();
        }

        public void ToggleItalic()
        {
            var selectionFont = SelectionFont;
            if (selectionFont != null)
                SelectionFont = new Font(selectionFont.FontFamily, selectionFont.Size, SelectionFont.Style ^ FontStyle.Italic);

            UpdateCommandState();
        }

        public void ToggleUnderline()
        {
            var selectionFont = SelectionFont;
            if (selectionFont != null)
                SelectionFont = new Font(selectionFont.FontFamily, selectionFont.Size, SelectionFont.Style ^ FontStyle.Underline);

            UpdateCommandState();
        }

        protected override bool ProcessCmdKey(ref Message m, Keys keyData)
        {
            if (ReadOnly)
                return base.ProcessCmdKey(ref m, keyData);

            if ((keyData & Keys.Control) > 0 && (keyData & Keys.KeyCode) == Keys.B)
            {
                ToggleBold();
                return true;
            }
            if ((keyData & Keys.Control) > 0 && (keyData & Keys.KeyCode) == Keys.I)
            {
                ToggleItalic();
                return true;
            }
            if ((keyData & Keys.Control) > 0 && (keyData & Keys.KeyCode) == Keys.U)
            {
                ToggleUnderline();
                return true;
            }

            if ((keyData & Keys.Control) > 0 && (keyData & Keys.KeyCode) == Keys.E || (keyData & Keys.KeyCode) == Keys.R)
                return true;

            return base.ProcessCmdKey(ref m, keyData);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_PASTE:
                    {
                        Paste(DataFormats.GetFormat(DataFormats.Text));
                        return;
                    }
                case WM_MOUSEWHEEL:
                    if (((int)m.WParam & MK_CONTROL) == MK_CONTROL)
                    {
                        m.WParam = IntPtr.Zero;
                        m.Result = IntPtr.Zero;
                    }
                    break;
                default:
                    break;
            }

            base.WndProc(ref m);
        }

        private void UpdateCommandState()
        {
            CommandStateChanged?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region Events
        private void richTextBoxEx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Paste();
                e.Handled = true;
            }
        }
        #endregion
    }
}