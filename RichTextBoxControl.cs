using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSpellChecker;

using RichTextBoxExDemo.Helpers;

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RichTextBoxExDemo
{
    public partial class RichTextBoxControl : XtraUserControl
    {
        #region Properties
        [DefaultValue(false)]
        public bool DetectUrls
        {
            get { return richTextBox.DetectUrls; }
            set { richTextBox.DetectUrls = value; }
        }

        public int MaxLength
        {
            get { return richTextBox.MaxLength; }
            set { richTextBox.MaxLength = value; }
        }

        [DefaultValue(false)]
        public bool ReadOnly
        {
            get { return richTextBox.ReadOnly; }
            set { richTextBox.ReadOnly = value; }
        }

        public string RtfText
        {
            get { return richTextBox.Rtf; }
            set
            {
                richTextBox.Rtf = value;
                SetThemeStyle();
            }
        }
        #endregion

        #region Constructors
        public RichTextBoxControl()
        {
            InitializeComponent();

            LookAndFeel.StyleChanged += lookAndFeel_StyleChanged;

            barManager.SetPopupContextMenu(richTextBox, popupMenu);

            SetThemeStyle();

            spellChecker.SetCanCheckText(richTextBox, true);
            spellChecker.SpellCheckMode = SpellCheckMode.AsYouType;
            spellChecker.SpellingFormType = SpellingFormType.Word;
            spellChecker.ParentContainer = richTextBox;
        }
        #endregion

        #region Methods
        private void SetThemeStyle()
        {
            panelControl.BackColor = ColorHelper.WindowColor;

            richTextBox.BackColor = ColorHelper.WindowColor;
            richTextBox.ForeColor = ColorHelper.WindowTextColor;
        }

        private void UpdateCommandState()
        {
            barButtonItemUndo.Enabled = richTextBox.CanUndo;

            barButtonItemCut.Enabled = richTextBox.SelectedText != string.Empty;
            barButtonItemCopy.Enabled = richTextBox.SelectionLength > 0;
            barButtonItemPaste.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.Text);
            barButtonItemDelete.Enabled = richTextBox.SelectionLength > 0;

            barButtonItemSelectAll.Enabled = richTextBox.TextLength > 0;

            if (richTextBox.SelectionFont != null)
            {
                barCheckItemBold.Checked = richTextBox.SelectionFont.Bold;
                barCheckItemItalic.Checked = richTextBox.SelectionFont.Italic;
                barCheckItemUnderline.Checked = richTextBox.SelectionFont.Underline;
            }
        }
        #endregion

        #region Events
        private void barButtonItemCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            richTextBox.Copy();
        }

        private void barButtonItemCut_ItemClick(object sender, ItemClickEventArgs e)
        {
            richTextBox.Cut();
        }

        private void barButtonItemDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            richTextBox.SelectedText = string.Empty;
        }

        private void barButtonItemPaste_ItemClick(object sender, ItemClickEventArgs e)
        {
            richTextBox.Paste();
        }

        private void barButtonItemSelectAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void barButtonItemSpellCheck_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                PaintHelper.BeginUpdate(richTextBox);

                spellChecker.Check(richTextBox);
            }
            finally
            {
                PaintHelper.EndUpdate(richTextBox);
            }
        }

        private void barCheckItemBold_ItemClick(object sender, ItemClickEventArgs e)
        {
            richTextBox.ToggleBold();
        }

        private void barCheckItemItalic_ItemClick(object sender, ItemClickEventArgs e)
        {
            richTextBox.ToggleItalic();
        }

        private void barCheckItemUnderline_ItemClick(object sender, ItemClickEventArgs e)
        {
            richTextBox.ToggleUnderline();
        }

        private void barButtonItemUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            richTextBox.Undo();
        }

        private void barManager_QueryShowPopupMenu(object sender, QueryShowPopupMenuEventArgs e)
        {
            var point = e.Control.PointToClient(e.Position);
            var spellCheckErrorBase = spellChecker.CalcError(point);
            //////e.Cancel = spellCheckErrorBase == null;

            var spellCheckerCommandList = spellChecker.GetCommandsByError(spellCheckErrorBase);
            if (spellCheckerCommandList != null)
            {
                foreach (var spellCheckerCommand in spellCheckerCommandList)
                {
            ////        var barButtonItem = new BarButtonItem(barManager, spellCheckerCommand.Caption);
            ////        barButtonItem.Enabled = spellCheckerCommand.Enabled;
            ////        barButtonItem.Tag = spellCheckerCommand;
            ////        barButtonItem.ItemClick += new ItemClickEventHandler(OnPopupMenuItemClick);
            ////        popupMenu.ItemLinks.Add(barButtonItem);
                }
                //var barButtonItem = new BarButtonItem(barManager, "Show Spelling Form");
                ////itemShowSpellingForm.ItemClick += OnPopupMenuShowSpellingForm_ItemClick;
                //popupMenu.ItemLinks.Add(barButtonItem);
            }
        }

        private void panelControl_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            PaintHelper.PaintBorder(e.ClipRectangle, e.Graphics);
        }

        private void richTextBox_CommandStateChanged(object sender, EventArgs e)
        {
            UpdateCommandState();
        }

        private void richTextBox_SelectionChanged(object sender, EventArgs e)
        {
            UpdateCommandState();
        }

        private void lookAndFeel_StyleChanged(object sender, EventArgs e)
        {
            SetThemeStyle();
        }
        #endregion
    }
}