namespace RichTextBoxExDemo
{
    partial class RichTextBoxControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox = new RichTextBoxExDemo.RichTextBoxEx(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItemUndo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCut = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCopy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPaste = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSelectAll = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItemBold = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemItalic = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemUnderline = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItemSpellCheck = new DevExpress.XtraBars.BarButtonItem();
            this.barToolbar = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.spellChecker = new DevExpress.XtraSpellChecker.SpellChecker(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(2, 2);
            this.richTextBox.Name = "richTextBox";
            this.barManager.SetPopupContextMenu(this.richTextBox, this.popupMenu);
            this.richTextBox.Size = new System.Drawing.Size(350, 156);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.CommandStateChanged += new System.EventHandler(this.richTextBox_CommandStateChanged);
            this.richTextBox.SelectionChanged += new System.EventHandler(this.richTextBox_SelectionChanged);
            // 
            // barManager
            // 
            this.barManager.AllowCustomization = false;
            this.barManager.AllowQuickCustomization = false;
            this.barManager.AllowShowToolbarsPopup = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barToolbar});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barCheckItemBold,
            this.barCheckItemItalic,
            this.barCheckItemUnderline,
            this.barButtonItemSpellCheck,
            this.barButtonItemUndo,
            this.barButtonItemCut,
            this.barButtonItemCopy,
            this.barButtonItemPaste,
            this.barButtonItemDelete,
            this.barButtonItemSelectAll});
            this.barManager.MaxItemId = 10;
            this.barManager.QueryShowPopupMenu += new DevExpress.XtraBars.QueryShowPopupMenuEventHandler(this.barManager_QueryShowPopupMenu);
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemCut, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemCopy),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemPaste),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSelectAll, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItemBold, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItemItalic),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItemUnderline),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSpellCheck, true)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            // 
            // barButtonItemUndo
            // 
            this.barButtonItemUndo.Caption = "Undo";
            this.barButtonItemUndo.Id = 4;
            this.barButtonItemUndo.ImageOptions.SvgImage = global::RichTextBoxExDemo.Properties.Resources.undo;
            this.barButtonItemUndo.Name = "barButtonItemUndo";
            this.barButtonItemUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemUndo_ItemClick);
            // 
            // barButtonItemCut
            // 
            this.barButtonItemCut.Caption = "Cut";
            this.barButtonItemCut.Id = 5;
            this.barButtonItemCut.ImageOptions.SvgImage = global::RichTextBoxExDemo.Properties.Resources.cut;
            this.barButtonItemCut.Name = "barButtonItemCut";
            this.barButtonItemCut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCut_ItemClick);
            // 
            // barButtonItemCopy
            // 
            this.barButtonItemCopy.Caption = "Copy";
            this.barButtonItemCopy.Id = 6;
            this.barButtonItemCopy.ImageOptions.SvgImage = global::RichTextBoxExDemo.Properties.Resources.copy;
            this.barButtonItemCopy.Name = "barButtonItemCopy";
            this.barButtonItemCopy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCopy_ItemClick);
            // 
            // barButtonItemPaste
            // 
            this.barButtonItemPaste.Caption = "Paste";
            this.barButtonItemPaste.Id = 7;
            this.barButtonItemPaste.ImageOptions.SvgImage = global::RichTextBoxExDemo.Properties.Resources.paste;
            this.barButtonItemPaste.Name = "barButtonItemPaste";
            this.barButtonItemPaste.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPaste_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Delete";
            this.barButtonItemDelete.Id = 8;
            this.barButtonItemDelete.ImageOptions.SvgImage = global::RichTextBoxExDemo.Properties.Resources.delete;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // barButtonItemSelectAll
            // 
            this.barButtonItemSelectAll.Caption = "Select All";
            this.barButtonItemSelectAll.Id = 9;
            this.barButtonItemSelectAll.ImageOptions.SvgImage = global::RichTextBoxExDemo.Properties.Resources.selectall;
            this.barButtonItemSelectAll.Name = "barButtonItemSelectAll";
            this.barButtonItemSelectAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSelectAll_ItemClick);
            // 
            // barCheckItemBold
            // 
            this.barCheckItemBold.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barCheckItemBold.Caption = "Bold";
            this.barCheckItemBold.Id = 0;
            this.barCheckItemBold.ImageOptions.SvgImage = global::RichTextBoxExDemo.Properties.Resources.bold;
            this.barCheckItemBold.Name = "barCheckItemBold";
            this.barCheckItemBold.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemBold_ItemClick);
            // 
            // barCheckItemItalic
            // 
            this.barCheckItemItalic.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barCheckItemItalic.Caption = "Italic";
            this.barCheckItemItalic.Id = 1;
            this.barCheckItemItalic.ImageOptions.SvgImage = global::RichTextBoxExDemo.Properties.Resources.italic;
            this.barCheckItemItalic.Name = "barCheckItemItalic";
            this.barCheckItemItalic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemItalic_ItemClick);
            // 
            // barCheckItemUnderline
            // 
            this.barCheckItemUnderline.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barCheckItemUnderline.Caption = "Underline";
            this.barCheckItemUnderline.Id = 2;
            this.barCheckItemUnderline.ImageOptions.SvgImage = global::RichTextBoxExDemo.Properties.Resources.underline;
            this.barCheckItemUnderline.Name = "barCheckItemUnderline";
            this.barCheckItemUnderline.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemUnderline_ItemClick);
            // 
            // barButtonItemSpellCheck
            // 
            this.barButtonItemSpellCheck.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemSpellCheck.Caption = "SpellCheck";
            this.barButtonItemSpellCheck.Id = 3;
            this.barButtonItemSpellCheck.ImageOptions.SvgImage = global::RichTextBoxExDemo.Properties.Resources.spellcheck;
            this.barButtonItemSpellCheck.Name = "barButtonItemSpellCheck";
            this.barButtonItemSpellCheck.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSpellCheck_ItemClick);
            // 
            // barToolbar
            // 
            this.barToolbar.BarName = "barToolbar";
            this.barToolbar.DockCol = 0;
            this.barToolbar.DockRow = 0;
            this.barToolbar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barToolbar.FloatLocation = new System.Drawing.Point(520, 236);
            this.barToolbar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItemBold),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItemItalic),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItemUnderline),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSpellCheck, true)});
            this.barToolbar.OptionsBar.DrawBorder = false;
            this.barToolbar.OptionsBar.DrawDragBorder = false;
            this.barToolbar.OptionsBar.UseWholeRow = true;
            this.barToolbar.Text = "barToolbar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(354, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 160);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(354, 28);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 160);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(354, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 160);
            // 
            // panelControl
            // 
            this.panelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl.Controls.Add(this.richTextBox);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Padding = new System.Windows.Forms.Padding(2);
            this.panelControl.Size = new System.Drawing.Size(354, 160);
            this.panelControl.TabIndex = 6;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // spellChecker
            // 
            this.spellChecker.CheckAsYouTypeOptions.CheckControlsInParentContainer = true;
            this.spellChecker.Culture = new System.Globalization.CultureInfo("en-CA");
            this.spellChecker.ParentContainer = null;
            // 
            // RichTextBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "RichTextBoxControl";
            this.Size = new System.Drawing.Size(354, 188);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBoxEx richTextBox;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar barToolbar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarCheckItem barCheckItemBold;
        private DevExpress.XtraBars.BarCheckItem barCheckItemItalic;
        private DevExpress.XtraBars.BarCheckItem barCheckItemUnderline;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSpellCheck;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUndo;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCut;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCopy;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPaste;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSelectAll;
        private DevExpress.XtraSpellChecker.SpellChecker spellChecker;
    }
}
