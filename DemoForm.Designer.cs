namespace RichTextBoxExDemo
{
    partial class DemoForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.richTextBoxControl = new RichTextBoxExDemo.RichTextBoxControl();
            this.spinEditMaxLength = new DevExpress.XtraEditors.SpinEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemMaxLength = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemRichTextBox = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barMain = new DevExpress.XtraBars.Bar();
            this.barSubItemFile = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemFileExit = new DevExpress.XtraBars.BarButtonItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMaxLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMaxLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRichTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.richTextBoxControl);
            this.layoutControl.Controls.Add(this.spinEditMaxLength);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 22);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(484, 308);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // richTextBoxControl
            // 
            this.richTextBoxControl.DetectUrls = true;
            this.richTextBoxControl.Location = new System.Drawing.Point(75, 36);
            this.richTextBoxControl.MaxLength = 2147483647;
            this.richTextBoxControl.Name = "richTextBoxControl";
            this.richTextBoxControl.RtfText = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang4105{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}}\r\n" +
    "{\\colortbl ;\\red27\\green41\\blue62;}\r\n\\viewkind4\\uc1\\pard\\cf1\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxControl.Size = new System.Drawing.Size(397, 260);
            this.richTextBoxControl.TabIndex = 6;
            // 
            // spinEditMaxLength
            // 
            this.spinEditMaxLength.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEditMaxLength.Location = new System.Drawing.Point(75, 12);
            this.spinEditMaxLength.Name = "spinEditMaxLength";
            this.spinEditMaxLength.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditMaxLength.Properties.Mask.EditMask = "d";
            this.spinEditMaxLength.Properties.MaxValue = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.spinEditMaxLength.Size = new System.Drawing.Size(101, 20);
            this.spinEditMaxLength.StyleController = this.layoutControl;
            this.spinEditMaxLength.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemMaxLength,
            this.layoutControlItemRichTextBox,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(484, 308);
            this.Root.TextVisible = false;
            // 
            // layoutControlItemMaxLength
            // 
            this.layoutControlItemMaxLength.Control = this.spinEditMaxLength;
            this.layoutControlItemMaxLength.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemMaxLength.MaxSize = new System.Drawing.Size(168, 24);
            this.layoutControlItemMaxLength.MinSize = new System.Drawing.Size(168, 24);
            this.layoutControlItemMaxLength.Name = "layoutControlItemMaxLength";
            this.layoutControlItemMaxLength.Size = new System.Drawing.Size(168, 24);
            this.layoutControlItemMaxLength.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemMaxLength.Text = "MaxLength";
            this.layoutControlItemMaxLength.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItemRichTextBox
            // 
            this.layoutControlItemRichTextBox.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItemRichTextBox.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItemRichTextBox.Control = this.richTextBoxControl;
            this.layoutControlItemRichTextBox.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemRichTextBox.Name = "layoutControlItemRichTextBox";
            this.layoutControlItemRichTextBox.Size = new System.Drawing.Size(464, 264);
            this.layoutControlItemRichTextBox.Text = "RichTextBox";
            this.layoutControlItemRichTextBox.TextSize = new System.Drawing.Size(60, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(168, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(296, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // barManager
            // 
            this.barManager.AllowCustomization = false;
            this.barManager.AllowGlyphSkinning = true;
            this.barManager.AllowQuickCustomization = false;
            this.barManager.AllowShowToolbarsPopup = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMain,
            this.barStatus});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItemFile,
            this.barButtonItemFileExit,
            this.skinBarSubItem1});
            this.barManager.MainMenu = this.barMain;
            this.barManager.MaxItemId = 3;
            this.barManager.StatusBar = this.barStatus;
            // 
            // barMain
            // 
            this.barMain.BarName = "barMain";
            this.barMain.DockCol = 0;
            this.barMain.DockRow = 0;
            this.barMain.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMain.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1)});
            this.barMain.OptionsBar.DrawDragBorder = false;
            this.barMain.OptionsBar.MultiLine = true;
            this.barMain.OptionsBar.UseWholeRow = true;
            this.barMain.Text = "barMain";
            // 
            // barSubItemFile
            // 
            this.barSubItemFile.Caption = "&File";
            this.barSubItemFile.Id = 0;
            this.barSubItemFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemFileExit)});
            this.barSubItemFile.Name = "barSubItemFile";
            // 
            // barButtonItemFileExit
            // 
            this.barButtonItemFileExit.Caption = "&Exit";
            this.barButtonItemFileExit.Id = 1;
            this.barButtonItemFileExit.ImageOptions.SvgImage = global::RichTextBoxExDemo.Properties.Resources.close;
            this.barButtonItemFileExit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.barButtonItemFileExit.Name = "barButtonItemFileExit";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "&Theme";
            this.skinBarSubItem1.Id = 2;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barStatus
            // 
            this.barStatus.BarName = "barStatus";
            this.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barStatus.DockCol = 0;
            this.barStatus.DockRow = 0;
            this.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barStatus.OptionsBar.AllowQuickCustomization = false;
            this.barStatus.OptionsBar.DrawDragBorder = false;
            this.barStatus.OptionsBar.UseWholeRow = true;
            this.barStatus.Text = "barStatus";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(484, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 330);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(484, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 308);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(484, 22);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 308);
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(RichTextBoxExDemo.ViewModels.DemoFormViewModel);
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 352);
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "DemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RichTextBoxEx Demo";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMaxLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMaxLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRichTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SpinEdit spinEditMaxLength;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemMaxLength;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar barMain;
        private DevExpress.XtraBars.BarSubItem barSubItemFile;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFileExit;
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private RichTextBoxControl richTextBoxControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemRichTextBox;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
    }
}